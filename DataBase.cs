using System;
using System.Data;
using System.Data.SQLite;


namespace WF_VD_Project
{
    class DB
    {
        private static SQLiteConnection connection;

        private static SQLiteConnection DBConnection()
        {

            connection = new SQLiteConnection("Data Source=..\\..\\..\\DB\\data.db");
            connection.Open();
            return connection;

        }

        public static DataTable getAllUsers(string table)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DBConnection().CreateCommand())
                {
                    cmd.CommandText = $"SELECT * FROM {table}";
                    da = new SQLiteDataAdapter(cmd.CommandText, DBConnection());
                    da.Fill(dt);
                    DBConnection().Close();
                    return dt;
                }
            }
            catch (Exception)
            {

                DBConnection().Close();
                throw;
            }
        }

        public static DataTable consult(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DBConnection().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, DBConnection());
                    da.Fill(dt);
                    DBConnection().Close();
                    return dt;
                }
            }
            catch (Exception)
            {
                DBConnection().Close();
                throw;
            }
        }
    }
}