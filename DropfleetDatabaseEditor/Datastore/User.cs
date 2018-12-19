using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Datastore
{
    class User
    {
        private int userID;
        private string email;
        private string password;
        private string salt;
        private string hash;
        private AccountType accountType;

        public User()
        {
        }

        public User(int userID, string email, string password, string salt, string hash, AccountType accountType)
        {
            this.UserID = userID;
            this.Email = email;
            this.Password = password;
            this.Salt = salt;
            this.Hash = hash;
            this.AccountType = accountType;
        }

        public int UserID { get => userID; set => userID = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Salt { get => salt; set => salt = value; }
        public string Hash { get => hash; set => hash = value; }
        internal AccountType AccountType { get => accountType; set => accountType = value; }
    }
}
