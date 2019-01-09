using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DropfleetDatabaseEditor.Datastore;
using MySql.Data.MySqlClient;

namespace DropfleetDatabaseEditor.Controllers
{
    class BattlegroupController
    {
        MySqlConnection connection;
        DatabaseControl dBControl = new DatabaseControl();

        public void InsertBattlegroup(BattleGroup group)
        {
            connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Battlegroups (groupName, image, max, minLight, maxLight, minMedium, maxMedium, " +
                "minHeavy, maxHeavy, minSuperheavy, maxSuperheavy, minDreadnought, maxDreadnought) VALUES (@groupName, @image, @max, " +
                "@minLight, @maxLight, @minMedium, @maxMedium, @minHeavy, @maxHeavy, @minSuperheavy, @maxSuperheavy, @minDreadnought, @maxDreadnought)"
                , connection))
            {
                cmd.Parameters.AddWithValue("@groupName", group.GroupName);
                cmd.Parameters.AddWithValue("@image", group.GroupImage);
                cmd.Parameters.AddWithValue("@max", group.Max);
                cmd.Parameters.AddWithValue("@minLight", group.MinLight);
                cmd.Parameters.AddWithValue("@maxLight", group.MaxLight);
                cmd.Parameters.AddWithValue("@minMedium", group.MinMedium);
                cmd.Parameters.AddWithValue("@maxMedium", group.MaxMedium);
                cmd.Parameters.AddWithValue("@minHeavy", group.MinHeavy);
                cmd.Parameters.AddWithValue("@maxHeavy", group.MaxHeavy);
                cmd.Parameters.AddWithValue("@minSuperheavy", group.MinSuperheavy);
                cmd.Parameters.AddWithValue("@maxSuperheavy", group.MaxSuperheavy);
                cmd.Parameters.AddWithValue("@minDreadnought", group.MinDreadnought);
                cmd.Parameters.AddWithValue("@maxDreadnought", group.MaxDreadnought);

                int rows = cmd.ExecuteNonQuery();
            }

            connection.Close();
        }
    }

}
