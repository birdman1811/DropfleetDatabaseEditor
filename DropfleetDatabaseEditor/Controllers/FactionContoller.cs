using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DropfleetDatabaseEditor.Datastore;
using MySql.Data.MySqlClient;

namespace DropfleetDatabaseEditor.Controllers
{
    class FactionContoller
    {

        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader dataReader;
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
                    Faction newFaction = new Faction();
                    newFaction.FactionID = dataReader.GetInt16(0);
                    newFaction.Name = dataReader.GetString(1);
                    newFaction.Icon = dataReader.GetString(2);
                    newFaction.Lore = dataReader.GetString(3);
                    newFaction.Gameplay = dataReader.GetString(4);

                    factionList.Add(newFaction);
                }
            }
            connection.Close();

            return factionList;
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
    }
}
