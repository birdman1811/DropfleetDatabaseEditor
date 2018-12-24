using DropfleetDatabaseEditor.Datastore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Controllers
{
    class UserAccessController
    {
        UserController userController = new UserController();
        public UserAccessController()
        {
        }        

        public Boolean GrantAccess (User userToVerify, string passwordEntered)
        {
            bool verified = true;

            string savedPasswordHash = userToVerify.Hash.ToString();
            byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            var pbkdf2 = new Rfc2898DeriveBytes(passwordEntered, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                {
                    verified = false; 
                }
            }

            return verified;
        }

        public void CreateUser(string email, string password)
        {
            /* Create Salt*/
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            /* hash and salt password*/
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);

            /* Convert to string*/
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashbytes = new byte[36];

            Array.Copy(salt, 0, hashbytes, 0, 16);
            Array.Copy(hash, 0, hashbytes, 16, 20);

            string savedPasswordHash = Convert.ToBase64String(hashbytes);

            User newUser = new User();
            newUser.Email = email;
            newUser.Hash = savedPasswordHash;
            AccountType accountType = new AccountType();
            accountType.AccountTypeID = 1;
            accountType.AccountTypeName = "TTCombatStaff";
            newUser.AccountType = accountType;        

            userController.InsertUser(newUser);
        }

        public void EditUser(User userToEdit, string password)
        {
            /* Create Salt*/
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            /* hash and salt password*/
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);

            /* Convert to string*/
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashbytes = new byte[36];

            Array.Copy(salt, 0, hashbytes, 0, 16);
            Array.Copy(hash, 0, hashbytes, 16, 20);

            string savedPasswordHash = Convert.ToBase64String(hashbytes);

            userToEdit.Hash = savedPasswordHash;

            userController.UpdateUser(userToEdit.UserID, userToEdit);
        }
    }
}
