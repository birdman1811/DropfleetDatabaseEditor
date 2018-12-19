using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Datastore
{
    class AccountType
    {
        private int accountTypeID;
        private string accountTypeName;

        public AccountType()
        {
        }

        public AccountType(int accountTypeID, string accountType)
        {
            this.accountTypeID = accountTypeID;
            this.accountTypeName = accountType;
        }

        public int AccountTypeID { get => accountTypeID; set => accountTypeID = value; }
        public string AccountTypeName { get => accountTypeName; set => accountTypeName = value; }
    }
}
