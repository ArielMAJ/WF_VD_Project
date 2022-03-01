using System;
using System.Data;
using System.Data.SQLite;


namespace WF_VD_Project.DataBase
{
    class DB
    {
        private static SQLiteConnection connection;

        private static SQLiteConnection DBConnection()
        {

            connection = new SQLiteConnection("Data Source=..\\..\\..\\DataBase\\data.db");
            connection.Open();
            return connection;

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

        public static DataTable GetClients()
        {
            return consult("SELECT IDCLIENT, T_NAME, T_CPF, T_JOBTITLE FROM CLIENTS");
        }
        public static DataTable GetEquipments()
        {
            return consult("SELECT IDEQUIPMENT, ID_CLIENT, T_EQUIPMENTDESCRIPTION FROM EQUIPMENTS");
        }
        public static DataTable GetEquipments(string condition)
        {
            return consult($"SELECT IDEQUIPMENT, ID_CLIENT, T_EQUIPMENTDESCRIPTION FROM EQUIPMENTS WHERE {condition}");
        }
    }
}