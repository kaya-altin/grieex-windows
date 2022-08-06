using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;

namespace GrieeX.GrieeXBase
{
    public class Zip
    {

        public static void Compress(List<string> FileNames, string ZipFileName)
        {
            FileStream fsOut = File.Create(ZipFileName);
            ZipOutputStream zipStream = new ZipOutputStream(fsOut);

            zipStream.SetLevel(3); // 0-9, 9 being the highest level of compression

            //zipStream.Password = password;    // optional

            foreach (string filename in FileNames)
            {
                string entryName = StrippedFilename(filename);
                if (entryName.Contains("Casts\\") | entryName.Contains("Posters\\") )
                {
                    entryName = "Images\\" + entryName;
                }
                //if (entryName.Contains("GrieeX.db"))
                //{
                //    entryName = entryName.Replace("GrieeX.db", "GrieeX.tmp");
                //}

                ZipEntry newEntry = new ZipEntry(entryName);

                newEntry.DateTime = DateTime.Now;

                // Use Off to permit the zip to be unpacked by XP's built-in extractor and other older
                // code. Use On or Dynamic if the file will be bigger than 4GB.
                //zipStream.UseZip64 = UseZip64.Off;

                zipStream.PutNextEntry(newEntry);

                // unzip file in buffered chunks
                // the "using" will close the stream even if an exception occurs
                byte[] buffer = new byte[4096];

                using (FileStream streamReader = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    StreamUtils.Copy(streamReader, zipStream, buffer);
                }


                zipStream.CloseEntry();
            }
            zipStream.IsStreamOwner = true;    // Makes the Close also Close the underlying stream
            zipStream.Close();

        }

        public static void Compress2(List<string> FileNames, string ZipFileName)
        {
            FileStream fsOut = File.Create(ZipFileName);
            ZipOutputStream zipStream = new ZipOutputStream(fsOut);

            zipStream.SetLevel(3); // 0-9, 9 being the highest level of compression

            //zipStream.Password = password;    // optional

            foreach (string filename in FileNames)
            {
                string entryName = Path.GetFileName(filename);
                ZipEntry newEntry = new ZipEntry(entryName);
                newEntry.DateTime = DateTime.Now;

                // Use Off to permit the zip to be unpacked by XP's built-in extractor and other older
                // code. Use On or Dynamic if the file will be bigger than 4GB.
                zipStream.UseZip64 = UseZip64.Off;

                zipStream.PutNextEntry(newEntry);

                // unzip file in buffered chunks
                // the "using" will close the stream even if an exception occurs
                byte[] buffer = new byte[4096];

                using (FileStream streamReader = File.OpenRead(filename))
                {
                    StreamUtils.Copy(streamReader, zipStream, buffer);
                }
                zipStream.CloseEntry();
            }
            zipStream.IsStreamOwner = true;    // Makes the Close also Close the underlying stream
            zipStream.Close();

        }

        private static string StrippedFilename(string filename)
        {
            DirectoryInfo directories = new DirectoryInfo(filename);
            string pathlessName = directories.Parent.Name + "\\" + Path.GetFileName(filename);

            return pathlessName;
        }




        public static void Extract(string from, string to)
        {
            FileStream fs = File.OpenRead(from);
            ZipInputStream zs = new ZipInputStream(fs);
            zs.IsStreamOwner = false;

            while (true)
            {
                ZipEntry zipEntry = zs.GetNextEntry();
                if (zipEntry == null)
                    break;
                String entryFileName = zipEntry.Name;

                byte[] buffer = new byte[4096];
                String fullZipToPath = Path.Combine(to, entryFileName);
                // unzip file in small chunks
                using (FileStream streamWriter = File.Create(fullZipToPath))
                {
                    while (true)
                    {
                        int nBytes = zs.Read(buffer, 0, buffer.Length);
                        if (nBytes <= 0)
                            break;
                        streamWriter.Write(buffer, 0, nBytes);
                    }
                }

            }
        }



    }
}
