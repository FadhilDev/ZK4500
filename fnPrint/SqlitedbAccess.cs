using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace fingerPrint
{
    public class SqliteDbAccess
    {
        public static SQLiteConnection ConStr=new SQLiteConnection($"Data Source={Application.StartupPath}\\db\\fingerPrintDB.db;Version=3 ;UTF8Encoding=True;");
    
        public static DataTable ReturnDataTable(string sqlStr, SQLiteParameter[] parm)
        {
            var dt = new DataTable();
            try
            {
                if (ConStr.State == ConnectionState.Closed) { ConStr.Open(); }

                var cmd = new SQLiteCommand
                {
                    CommandText = sqlStr,
                    Connection = ConStr
                };

                if (parm != null)
                {
                    cmd.Parameters.AddRange(parm);
                }

                var da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }

            finally
            {
                if (ConStr.State == ConnectionState.Open)
                { ConStr.Close(); }
            }
            return dt;
        }


        static SQLiteDataReader _dr;
        public static SQLiteDataReader ReturnDataRow(string sqlStr, SQLiteParameter[] parm)
        {
            try
            {
                if (ConStr.State == ConnectionState.Closed) { ConStr.Open(); }
                var cmd = new SQLiteCommand
                {
                    CommandText = sqlStr,
                    Connection = ConStr
                };
                if (parm != null)
                {
                    cmd.Parameters.AddRange(parm);
                }
                _dr = cmd.ExecuteReader();
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }

            finally
            {
                if (ConStr.State == ConnectionState.Open)
                { ConStr.Close(); }
            }
            return _dr;
        }

        public static DataSet ReturnDataSet(string sqlStr, SQLiteParameter[] parm, int TypeComm)
        {
            var ds = new DataSet();
            try
            {
                if (ConStr.State == ConnectionState.Closed) { ConStr.Open(); }

                var cmd = new SQLiteCommand
                {
                    CommandText = sqlStr,
                    Connection = ConStr
                };

                if (parm != null)
                {
                    cmd.Parameters.AddRange(parm);
                }

                var da = new SQLiteDataAdapter(cmd);
                da.Fill(ds);
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }

            finally
            {
                if (ConStr.State == ConnectionState.Open)
                { ConStr.Close(); }
            }
            return ds;
        }

        public static void ExcuteData(string sqlStr, SQLiteParameter[] parm)
        {
            try
            {
                if (ConStr.State == ConnectionState.Closed) { ConStr.Open(); }

                var cmd = new SQLiteCommand
                {
                    CommandText = sqlStr,
                    Connection = ConStr
                };

                if (parm != null)
                {
                    cmd.Parameters.AddRange(parm);
                }

                cmd.ExecuteNonQuery();
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }

            finally
            {
                if (ConStr.State == ConnectionState.Open)
                { ConStr.Close(); }
            }
        }

        public int GetLastId(string tableName)
        {
            var dt = new DataTable();
            var id = 0;
            try
            {
                if (ConStr.State == ConnectionState.Closed) { ConStr.Open(); }

                var da = new SQLiteDataAdapter("SELECT IDENT_CURRENT('" + tableName + "')", ConStr);
                da.Fill(dt);
                id = Convert.ToInt32(dt.Rows[0][0].ToString());
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }

            finally
            {
                if (ConStr.State == ConnectionState.Open)
                { ConStr.Close(); }
            }
            return id;
        }

        public void DbBackup(string notes, string dbName)
        {

            //try
            //{
            //    if (!Directory.Exists(Application.StartupPath + "\\Backup\\"))
            //    {
            //        Directory.CreateDirectory(Application.StartupPath + "\\Backup\\");
            //    }

            //    if (conStr1.State == ConnectionState.Closed) { conStr1.Open(); }

            //    System.Globalization.DateTimeFormatInfo GregorianDTF = (new System.Globalization.CultureInfo("Ar-Sy", true)).DateTimeFormat;
            //    GregorianDTF.Calendar = new System.Globalization.GregorianCalendar();
            //    string DToday = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss-tt", GregorianDTF) + ".bak"; // Name Of DB Buckup With Date And Time

            //    string cmd = "BACKUP DATABASE  " + "  DbName  " + "  TO DISK =   N'" + Application.StartupPath + "\\Backup\\" + DToday + "' WITH  DESCRIPTION =  N'" + Notes.ToString() + "', NOFORMAT, NOINIT,  NAME = N'Mechanisms', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            //    SQLiteCommand SqlCom = new SQLiteCommand(cmd, conStr1);
            //    SqlCom.ExecuteNonsqlStr();
            //    MessageBox.Show("تمت عملية النسخ الإحتياطي بنجاح");
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }

            //finally
            //{
            //    if (conStr1.State == ConnectionState.Open)
            //    { conStr1.Close(); }
            //}

        }


        public void CheckNo(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

    }
}


