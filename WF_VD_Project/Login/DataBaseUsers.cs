using System;
using System.Data;
using System.Data.SQLite;
using WF_VD_Project.Entities;

namespace WF_VD_Project.DataBase
{
    class DBU
    {
        private static SQLiteConnection connection;

        private static SQLiteConnection DBConnection()
        {

            connection = new SQLiteConnection("Data Source=..\\..\\..\\DataBase\\database.db");
            connection.Open();
            return connection;

        }

        public static DataTable getAllUsers()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DBConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM TB_USERS";
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

        public static void NewUser(User u)
        {
            if (UsernameExists(u))
            {
                MessageBox.Show("Username já existe.");
                return;
            }
            try
            {
                var cmd = DBConnection().CreateCommand();
                cmd.CommandText = 
                    "INSERT INTO TB_USERS(" +
                    "T_NAME, " +
                    "T_USERNAME, " +
                    "T_PASSWORD, " +
                    "T_USERSTATUS, " +
                    "N_USERLEVEL" +
                    ") " +
                    "VALUES(@name,@username,@password,@userstatus,@userlevel)";
                cmd.Parameters.AddWithValue("@name", u.name);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@userstatus", u.status);
                cmd.Parameters.AddWithValue("@userlevel", u.userLevel);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo usuário inserido.");
                DBConnection().Close();
            }
            catch( Exception ex)
            {
                MessageBox.Show("Erro ao gravar novo usuário.");
                DBConnection().Close();
            }
        }
        
        public static bool UsernameExists(User u)
        {
            bool exists;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = DBConnection().CreateCommand();
            cmd.CommandText = "SELECT T_USERNAME " +
                              "FROM TB_USERS " +
                             $"WHERE T_USERNAME='{u.username}'";
            da = new SQLiteDataAdapter(cmd.CommandText, DBConnection());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                exists = true;
            else
                exists = false;
            return exists;
        }

    }
}