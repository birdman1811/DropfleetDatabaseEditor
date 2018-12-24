using DropfleetDatabaseEditor.Datastore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Controllers
{
    class UserController
    {
        MySqlConnection connection;
        private User user = new User();              
        DatabaseControl dBControl = new DatabaseControl();

        public User GetUser (string email)
        {
            connection = dBControl.GetConnection();
            MySqlDataReader dataReader;
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Users WHERE email = @email", connection))
            {
                cmd.Parameters.AddWithValue("@email", email);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    user.UserID = dataReader.GetInt16(0);
                    user.Hash = dataReader.GetString(2);
                    AccountType accountType = new AccountType
                    {
                        AccountTypeID = dataReader.GetInt16(3)
                    };

                }
            }
            connection.Close();
                return user;
        }

        public void InsertUser (User newUser)
        {
            connection = dBControl.GetConnection();            
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Users (email, passHash, accountType) VALUES(@email, @hash, @account)", connection))
            {
                cmd.Parameters.AddWithValue("@email", newUser.Email);
                cmd.Parameters.AddWithValue("@hash", newUser.Hash);
                cmd.Parameters.AddWithValue("@account", 1);

                int rows = cmd.ExecuteNonQuery();
            }
            connection.Close();
        }

        public bool CheckUserName ( string email)
        {
            bool valid = false;


            connection = dBControl.GetConnection();
            MySqlDataReader dataReader;
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Users WHERE email = @email", connection))
            {
                cmd.Parameters.AddWithValue("@email", email);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    valid = true;
                }
            }
            connection.Close();
            return valid;
        }

        public void UpdateUser(int userID, User newUserDetails)
        {
            connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("UPDATE Users SET email = @email, passHash = @passHash, accountType = @accountType " +
                "WHERE accountID = @UserID", connection))
            {
                cmd.Parameters.AddWithValue("@email", newUserDetails.Email);
                cmd.Parameters.AddWithValue("@passHash", newUserDetails.Hash);
                cmd.Parameters.AddWithValue("@accountType", 1);
                cmd.Parameters.AddWithValue("@UserID", userID);

                int rows = cmd.ExecuteNonQuery();
            }
            connection.Close();
        }
       
    }
}
