using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace GrieeX.GrieeXBase
{
    #region "Class INIFile"
    public class Language
    {    
        //#region "Constructor"
        //public INIFile()
        //    : base()
        //{
        //}

        //public INIFile(string FileName)
        //    : base()
        //{
        //    LoadFile(FileName);
        //}
        //#endregion

        #region "Properties"
        private const string SectionOpenChar = "[";
        private const string SectionCloseChar = "]";
        private const string NameValueDelimChar = "=";
        private const string CommentChar = ";";
        //private FileInfo File;
        #endregion
        public static List<Section> Sections = new List<Section>();

        #region "Methods"
        #region "File Operations"
        #region "LoadFile"
        public static void LoadFile(string FileName)
        {
            Contents = System.IO.File.ReadAllText(FileName, Encoding.GetEncoding("Windows-1254"));
        }
        #endregion

        #endregion

        #region "Searching"
        #region "FindSection"
        public static Section FindSection(string SectionName)
        {

            Section oSection = null;

            foreach (Section oSection_loopVariable in Sections)
            {
                oSection = oSection_loopVariable;
                if (oSection.Name == null)
                {
                    if (SectionName == null)
                        return oSection;
                }
                else
                {
                    if (oSection.Name.ToLower() == SectionName.ToLower())
                        return oSection;
                }
            }

            throw new SectionNotFoundException(SectionName);
        }

        #endregion

        #region "FindKey"
        public static Key FindKey(string SectionName, string KeyName)
        {
            try
            {
                Section oSection = FindSection(SectionName);

                if (oSection != null)
                {
                    return oSection.FindKey(KeyName);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return new Key("","");
            }

        }
        #endregion
        #endregion

        #region "Simple Editing"
        #region "GetValue"
        public string GetValue(string SectionName, string KeyName)
        {
            Key oKey = FindKey(SectionName, KeyName);

            if (oKey != null)
            {
                return oKey.Value;
            }
            else
            {
                return null;
            }
        }
        //public static string GetValue(string SectionName, string KeyName, string FileName)
        //{
        //    INIFile INI = new INIFile(FileName);

        //    return INI.GetValue(SectionName, KeyName);
        //}
        #endregion

        #endregion

        #region "Contents"
        private static string Contents
        {
            get
            {
                System.Text.StringBuilder sbBuffer = new System.Text.StringBuilder();

                Section oSection = null;
                Key oKey = null;

                foreach (Section oSection_loopVariable in Sections)
                {
                    oSection = oSection_loopVariable;
                    if (oSection.Name != null)
                    {
                        sbBuffer.AppendLine(SectionOpenChar + oSection.Name + SectionCloseChar);
                    }

                    foreach (Key oKey_loopVariable in oSection.Keys)
                    {
                        oKey = oKey_loopVariable;
                        if (oKey.IsComment)
                        {
                            sbBuffer.AppendLine(CommentChar + oKey.Value);
                        }
                        else
                        {
                            sbBuffer.AppendLine(oKey.Name + NameValueDelimChar + oKey.Value);
                        }
                    }
                    sbBuffer.AppendLine();
                }
                return sbBuffer.ToString();
            }
            set
            {
                //clear out all the sections first
                Sections.Clear();

                if (string.IsNullOrEmpty(value))
                    return;

                using (System.IO.StringReader srBuffer = new System.IO.StringReader(value))
                {
                    string sLine = srBuffer.ReadLine().Trim();
                    string sTrimmedLine = sLine.Trim();

                    Section oCurrentSection = null;

                    do
                    {
                        sTrimmedLine = sLine.Trim();

                        if (sTrimmedLine.Length > 0)
                        {
                            switch (sTrimmedLine.Substring(0, 1))
                            {
                                case SectionOpenChar:
                                    if (sTrimmedLine.Contains(SectionCloseChar))
                                    {
                                        oCurrentSection = new Section(sTrimmedLine.Substring(1, sTrimmedLine.IndexOf(SectionCloseChar) - 1));
                                    }
                                    else
                                    {
                                        oCurrentSection = new Section(sTrimmedLine.Substring(1, sTrimmedLine.Length - 1));
                                    }
                                    Sections.Add(oCurrentSection);
                                    break;
                                case CommentChar:
                                    if (oCurrentSection == null)
                                    {
                                        oCurrentSection = new Section();
                                        Sections.Add(oCurrentSection);
                                    }

                                    oCurrentSection.Keys.Add(new Key(sTrimmedLine.Substring(1)));
                                    break;
                                default:
                                    string sKeyName = null;
                                    string sKeyValue = null;

                                    if (sTrimmedLine.Contains(NameValueDelimChar))
                                    {
                                        sKeyName = sTrimmedLine.Substring(0, sTrimmedLine.IndexOf(NameValueDelimChar));
                                        sKeyValue = sTrimmedLine.Substring(sKeyName.Length + 1);
                                    }
                                    else
                                    {
                                        sKeyName = sTrimmedLine;
                                        sKeyValue = null;
                                    }

                                    if (oCurrentSection == null)
                                    {
                                        oCurrentSection = new Section(null);
                                        Sections.Add(oCurrentSection);
                                    }

                                    oCurrentSection.Keys.Add(new Key(sKeyName, sKeyValue));
                                    break;
                            }
                        }

                        sLine = srBuffer.ReadLine();
                    } while (!(sLine == null));

                    srBuffer.Close();
                }
            }
        }

        #endregion
        #endregion

    }
    #endregion

    #region "Class Section"

    public class Section
    {

        #region "Constructor"
        public Section()
            : base()
        {
        }
        public Section(string SectionName)
            : base()
        {
            this.Name = SectionName;
        }
        #endregion
        public List<Key> Keys = new List<Key>();

        public string Name;
        #region "FindKey"
        public Key FindKey(string KeyName)
        {
            //we're lazy (still)... return only the first matching key
            Key oKey = null;

            foreach (Key oKey_loopVariable in Keys)
            {
                oKey = oKey_loopVariable;
                if (oKey.Name != null)
                {
                    if (oKey.Name.ToLower() == KeyName.ToLower())
                        return oKey;
                }
            }

            throw new KeyNotFoundException(KeyName);
        }
        #endregion
    }
    #endregion

    #region "Class Key"
    public class Key
    {

        #region "Constructor"
        public Key(string KeyName, string Value)
            : base()
        {

            this.Name = KeyName;
            this.Value = Value;
            IsComment = false;
        }

        public Key(string Comment)
            : base()
        {

            Value = Comment;
            IsComment = true;
        }
        public Key()
            : base()
        {
        }
        #endregion
        public string Name;
        public string Value;

        public bool IsComment;

    }
    #endregion

    #region "Class FileNotSpecifiedException"
    public class FileNotSpecifiedException : Exception
    {
        public FileNotSpecifiedException()
            : base("A file was not specified for reading or writing. The field 'File' is set to 'Nothing'.")
        {
        }
    }
    #endregion

    #region "Class SectionNotFoundException"
    class SectionNotFoundException : Exception
    {
        public SectionNotFoundException(string SectionName)
            : base("The section '" + SectionName + "' was not found.")
        {
        }
    }
    #endregion

    #region "Class KeyNotFoundException"
    class KeyNotFoundException : Exception
    {
        public KeyNotFoundException(string KeyName)
            : base("The key '" + KeyName + "' was not found.")
        {
        }
    }
    #endregion
}