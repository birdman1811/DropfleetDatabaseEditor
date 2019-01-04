using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DropfleetDatabaseEditor.Datastore;
using MySql.Data.MySqlClient;

namespace DropfleetDatabaseEditor.Controllers
{
    class FactionController
    {

        MySqlConnection connection;        
        DatabaseControl dBControl = new DatabaseControl();

        public List<Faction> GetAllFactions()
        {
            List<Faction> factionList = new List<Faction>();

            connection = dBControl.GetConnection();
            MySqlDataReader dataReader;
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Factions", connection))
            {
                
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Faction newFaction = new Faction
                    {
                        FactionID = dataReader.GetInt16(0),
                        Name = dataReader.GetString(1),
                        Icon = dataReader.GetString(2),
                        Lore = dataReader.GetString(3),
                        Gameplay = dataReader.GetString(4)
                    };

                    factionList.Add(newFaction);
                }
            }
            connection.Close();

            return factionList;
        }

        public void UpdateFaction(Faction factionToUpdate)
        {
            connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("UPDATE Factions SET factionName = @name, factionIcon = @icon, factionLore = @lore, " +
                "factionGameplay = @gameplay WHERE factionID = @id", connection))
            {
                cmd.Parameters.AddWithValue("@name", factionToUpdate.Name);
                cmd.Parameters.AddWithValue("@icon", factionToUpdate.Icon);
                cmd.Parameters.AddWithValue("@lore", factionToUpdate.Lore);
                cmd.Parameters.AddWithValue("@gameplay", factionToUpdate.Gameplay);
                cmd.Parameters.AddWithValue("@id", factionToUpdate.FactionID);

                int rows = cmd.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void AddFaction(Faction newFaction)
        {
            connection = dBControl.GetConnection();            
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Factions (factionName, factionIcon, factionLore, factionGameplay) VALUES" +
                "(@name, @icon, @lore, @gameplay)", connection))
            {
                cmd.Parameters.AddWithValue("@name", newFaction.Name);
                cmd.Parameters.AddWithValue("@icon", newFaction.Icon);
                cmd.Parameters.AddWithValue("@lore", newFaction.Lore);
                cmd.Parameters.AddWithValue("@gameplay", newFaction.Gameplay);

                int rows = cmd.ExecuteNonQuery();
                
            }
            connection.Close();
        }

        public Faction GetFactionByID(int factionID)
        {
            connection = dBControl.GetConnection();
            MySqlDataReader dataReader;
            connection.Open();
            Faction faction = new Faction();

            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Factions WHERE factionID = @factionID", connection))
            {
                cmd.Parameters.AddWithValue("@factionID", factionID);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    faction.FactionID = dataReader.GetInt16(0);
                    faction.Name = dataReader.GetString(1);
                    faction.Icon = dataReader.GetString(2);
                    faction.Lore = dataReader.GetString(3);
                    faction.Gameplay = dataReader.GetString(4);
                }

                
            }
            connection.Close();

            return faction;
        }
    }
}
