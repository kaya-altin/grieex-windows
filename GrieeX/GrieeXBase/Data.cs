using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GrieeX.GrieeXBase
{
    public class Data
    {
        public enum ReturnType { None, Dataset, Datatable, Scalar, ID }

        public static object Execute(string Query)
        {
            return OleDb._RunQuery(Query, CommandType.Text, ReturnType.None);
        }

        public static object Execute(string Query, ReturnType rt)
        {
            return OleDb._RunQuery(Query, CommandType.Text, rt);
        }


        internal class OleDb
        {

            private static OleDbConnection con;
            private static OleDbCommand dc;

            public static void Connect()
            {
                try
                {
                    con = new OleDbConnection();
                    con.ConnectionString = string.Format("PROVIDER=Microsoft.Jet.OLEDB.4.0;DATA SOURCE={0}\\Database\\dbGrieeX.mdb", Application.StartupPath);
                    con.Open();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }

            public static void Disconnect()
            {
                con.Close();
                con.Dispose();
            }

            public static System.Data.ConnectionState ConnectionState()
            {
                return con.State;
            }

            public static object _RunQuery(String Query, System.Data.CommandType dcType, ReturnType rt)
            {
                object ReturnValue = null;
                Query = Query.Replace("'", "’");
                Query = Query.Replace("@#", "'");
                Query = Query.Replace("''", "NULL");
                //try
                //{
                dc = new System.Data.OleDb.OleDbCommand(Query, con);
                dc.CommandType = dcType;

                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(dc);
                switch (rt)
                {
                    case ReturnType.Dataset:
                        da.Fill(ds);

                        ReturnValue = ds;

                        ds.Dispose();
                        ds = null;
                        da = null;
                        break;
                    case ReturnType.Datatable:
                        da.Fill(ds);

                        ReturnValue = ds.Tables[0];

                        ds = null;
                        da = null;
                        break;
                    case ReturnType.Scalar:
                        ReturnValue = dc.ExecuteScalar();
                        break;
                    case ReturnType.ID:
                        dc.ExecuteNonQuery();

                        dc.CommandText = "SELECT @@IDENTITY";
                        ReturnValue = dc.ExecuteScalar();
                        break;
                    case ReturnType.None:
                        dc.ExecuteNonQuery();
                        break;
                    default:
                        dc.ExecuteNonQuery();
                        break;
                }
                //}

                //catch (Exception ex)
                //{
                //    XtraMessageBox.Show(ex.Message);
                //}
                return ReturnValue;
            }
        }



        public static void EmitGrid(String Query, DevExpress.XtraGrid.GridControl dg)
        {
            try
            {
                dg.DataSource = Execute(Query, ReturnType.Datatable);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        public static void EmitGrid(String Query, DataGridView dg)
        {
            try
            {
                dg.DataSource = Execute(Query, ReturnType.Datatable);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        //public static void EmitCombo(String Query, Components.dComboBox cb)
        //{
        //    try
        //    {
        //        cb.DisplayMember = "STR";
        //        cb.ValueMember = "ID";
        //        cb.DataSource = Execute(Query, ReturnType.Datatable);
        //        cb.Text = "";
        //        cb.SelectedValue = -1;
        //    }
        //    catch (Exception ex)
        //    {
        //        XtraMessageBox.Show(ex.Message);
        //    }
        //}

        public static void EmitCombo(String Query, DevExpress.XtraEditors.LookUpEdit cb, bool bFirstEmptyRow)
        {
            try
            {
                DataTable table = new DataTable("Table");
                DataRow newRow;

                table.Columns.Add("ID");
                table.Columns.Add("STR");

                if (bFirstEmptyRow == true)
                {
                    newRow = table.NewRow();

                    newRow["ID"] = "";
                    newRow["STR"] = "";

                    table.Rows.Add(newRow);
                }


                DataRow[] drs = ((DataTable)Execute(Query, ReturnType.Datatable)).Select();

                foreach (DataRow item in drs)
                {
                    newRow = table.NewRow();
                    newRow["ID"] = item[0];
                    newRow["STR"] = item[1];

                    table.Rows.Add(newRow);
                }

                cb.Properties.DisplayMember = "STR";
                cb.Properties.ValueMember = "ID";
                cb.Properties.DataSource = table;
                //cb.ItemIndex = 0;
                cb.EditValue = table.Rows[0][0];

                cb.Properties.ForceInitialize();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        public static void EmitCombo(String Query, DevExpress.XtraEditors.LookUpEdit cb, bool bFirstEmptyRow, string LanguageKey)
        {
            try
            {
                DataTable table = new DataTable("Table");
                DataRow newRow;

                table.Columns.Add("ID");
                table.Columns.Add("STR");

                if (bFirstEmptyRow == true)
                {
                    newRow = table.NewRow();

                    newRow["ID"] = "";
                    newRow["STR"] = "";

                    table.Rows.Add(newRow);
                }


                DataRow[] drs = ((DataTable)Execute(Query, ReturnType.Datatable)).Select();

                foreach (DataRow item in drs)
                {
                    newRow = table.NewRow();
                    newRow["ID"] = item[0];
                    try
                    {
                        newRow["STR"] = Language.FindKey(LanguageKey, item[1].ToString()).Value;
                    }
                    catch (Exception)
                    {
                        newRow["STR"] = item[1].ToString();
                    }
                    table.Rows.Add(newRow);
                }

                cb.Properties.DisplayMember = "STR";
                cb.Properties.ValueMember = "ID";
                cb.Properties.DataSource = table;
                //cb.ItemIndex = 0;
                cb.EditValue = table.Rows[0][0];

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        public static void EmitComboList(String Query, System.Windows.Forms.ComboBox cb)
        {
            try
            {
                cb.DisplayMember = "STR";
                cb.ValueMember = "ID";
                cb.DataSource = Execute(Query, ReturnType.Datatable);
                cb.SelectedValue = 1;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

    }
}
