using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Data;
using System.Data.Common;

namespace Cursed
{
    class Database
    {

        private static string DataPath = @"UsersDatabase.db";
        SQLiteConnection DataConnect = new SQLiteConnection(string.Format("DataSource ={0};", DataPath));

        public Database()
        {
            if (File.Exists(DataPath) == false)
            {
                CreateDB();
            }
        }

        private void CreateDB()
        {
            try
            {
                File.Create(DataPath).Close();
                DataConnect.Open();
                SQLiteCommand DatabaseCommand = new SQLiteCommand("DROP TABLE IF EXISTS UsersDatabase;"
                                                          + "CREATE TABLE UsersDatabase("
                                                          + "id INTEGER PRIMARY KEY AUTOINCREMENT,"
                                                          + "Username TEXT,"
                                                          + "Password TEXT);",
                                                          DataConnect);
                DatabaseCommand.ExecuteNonQuery();
                DataConnect.Close();
            }
            catch
            {
                MessageBox.Show("Программа не может создать БД на этом компьютере.");
            }
        }

        public bool Autorisation(string username, string password)
        {
            DataConnect.Open();
            SQLiteCommand DatabaseCMD = new SQLiteCommand("SELECT * FROM UsersDatabase;", DataConnect);
            SQLiteDataReader UsersList = DatabaseCMD.ExecuteReader();

            foreach (DbDataRecord UserLine in UsersList)
            {
                string UsernameTrue = UserLine["Username"].ToString();
                string PasswordTrue = UserLine["Password"].ToString();
                if (username == UsernameTrue && password == PasswordTrue)
                {
                    DataConnect.Close();
                    return true;
                }
            }
            DataConnect.Close();
            return false;
        }

        public bool UsernameCheck(string username)
        {
            DataConnect.Open();
            SQLiteCommand DatabaseCMD = new SQLiteCommand("SELECT * FROM UsersDatabase;", DataConnect);
            SQLiteDataReader UsersList = DatabaseCMD.ExecuteReader();

            foreach (DbDataRecord UserLine in UsersList)
            {
                string UsernameTrue = UserLine["Username"].ToString();
                if (username == UsernameTrue)
                {
                    DataConnect.Close();
                    return false;
                }
            }
            DataConnect.Close();
            return true;
        }
        public void CreateUser(string username, string password)
        {
            DataConnect.Open();
            SQLiteCommand DatabaseCommand = new SQLiteCommand("INSERT INTO 'UsersDatabase' ('Username', 'Password') VALUES(@Username, @Password); ", DataConnect);
            DatabaseCommand.Parameters.Add("@Username", DbType.String).Value = username;
            DatabaseCommand.Parameters.Add("@Password", DbType.String).Value = password;
            DatabaseCommand.ExecuteNonQuery();
            DataConnect.Close();
        }
    }
}
