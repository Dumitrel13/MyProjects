using Hangman_Game.ViewModel;
using System;
using System.Data.SqlClient;
using System.Windows;

namespace Hangman_Game.Utilities
{
    class DatabaseConnection
    {
        private SqlConnection sqlConnection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DatabaseConnection()
        {
            server = "localhost";
            database = "HangmanGame";
            uid = "admin";
            password = "admin13";

            string connString;

            connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            sqlConnection = new SqlConnection(connString);
        }

        public bool Login(string user, string password)
        {
            String query = $"SELECT COUNT(1) FROM [User]" +
                $" WHERE Username='{user}' AND Password='{password}'";

            try
            {
                if (OpenConnection())
                {
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.CommandType = System.Data.CommandType.Text;

                    int count = Convert.ToInt32(sqlCommand.ExecuteScalar());

                    if (count == 1)
                    {
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        sqlConnection.Close();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is incorrect!");
                        sqlConnection.Close();
                        return false;
                    }
                }
                else
                {
                    sqlConnection.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                return false;
            }
        }
        public bool Register(string user, string password, string avatar)
        {
            if (user == "" || password == "")
            {
                MessageBox.Show("Username or Password is missing!");
                return false;
            }
            string query = $"INSERT INTO [User] (Username, Password, Avatar) VALUES" +
                        $" ('{user}', '{password}', '{avatar.Remove(0, 53)}');";

            try
            {
                if (OpenConnection())
                {
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    try
                    {
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Registration complete!");
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
                else
                {
                    sqlConnection.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                return false;
            }

            return true;
        }
        private bool OpenConnection()
        {
            try
            {
                sqlConnection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Connection to server failed!");
                        break;

                    case 1045:
                        MessageBox.Show("Server username of password is incorrect!");
                        break;
                }
                return false;
            }
        }
    }
}
