using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DropfleetDatabaseEditor.Controllers
{
    class DatabaseControl
    {
        public MySqlConnection GetConnection()
        {
            string server = "31.132.4.108";
            string database = "dropfleet_fleetbuilder";
            string uid = "dropfleet_appadmin";
            string password = "hnX)ZWQWtt-v";


            string connectionString;
            MySqlConnection connection;
            connectionString = "SERVER =" + server + ";" + "DATABASE=" + database + ";" +
                "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
            return connection;
        }
    }
}
