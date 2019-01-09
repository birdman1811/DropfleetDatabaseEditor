using DropfleetDatabaseEditor.Datastore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Controllers
{
    class ShipController
    {
        MySqlConnection connection;
        DatabaseControl dBControl = new DatabaseControl();
        TonnageController tonnageControl = new TonnageController();

        public void InsertShip(Ship ship)
        {
            connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Ships " +
                "(name, faction, scan, sigMin, sigMax, thrust, hull, aMin, aMax, pd, gMin, gMax, launch, tonnage, points) VALUES " +
                "(@name, @faction, @scan, @sigMin, @sigMax, @thrust, @hull, @aMin, @aMax, @pd, @gMIn, @gMax, @launch, @tonnage, @points)", connection))
            {
                cmd.Parameters.AddWithValue("@name", ship.Name);
                cmd.Parameters.AddWithValue("@faction", ship.Faction.FactionID);
                cmd.Parameters.AddWithValue("@scan", ship.Scan);
                cmd.Parameters.AddWithValue("@sigMin", ship.SigMin);
                cmd.Parameters.AddWithValue("@sigMax", ship.SigMax);
                cmd.Parameters.AddWithValue("@thrust", ship.Thrust);
                cmd.Parameters.AddWithValue("@hull", ship.Hull);
                cmd.Parameters.AddWithValue("@aMin", ship.AMin);
                cmd.Parameters.AddWithValue("@aMax", ship.AMax);
                cmd.Parameters.AddWithValue("@pd", ship.Pd);
                cmd.Parameters.AddWithValue("@gMin", ship.GMin);
                cmd.Parameters.AddWithValue("@gMax", ship.GMax);
                cmd.Parameters.AddWithValue("@launch", ship.Launch);
                cmd.Parameters.AddWithValue("@tonnage", ship.Tonnage.TonnageID);
                cmd.Parameters.AddWithValue("@points", ship.Points);

                int rows = cmd.ExecuteNonQuery();
            }

            connection.Close();

            ship.ShipID = GetShipID(ship.Name, ship.Points, ship.Faction.FactionID);

            foreach (ShipRule rule in ship.Special)
            {
                AddSpecialRuleInstance(ship.ShipID, rule);
            }
            
        }

        public int GetShipID(string shipName, int shipPoints, int factionID)
        {
            connection = dBControl.GetConnection();
            connection.Open();
            MySqlDataReader dataReader;
            int shipID = 0;

            using (MySqlCommand cmd = new MySqlCommand("SELECT shipID FROM Ships WHERE name = @name AND points = @points AND faction = @faction", connection))
            {
                cmd.Parameters.AddWithValue("@name", shipName);
                cmd.Parameters.AddWithValue("@points", shipPoints);
                cmd.Parameters.AddWithValue("@faction", factionID);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    shipID = dataReader.GetInt16(0);
                }
            }

            connection.Close();
            return shipID;
        }

        

        public void AddSpecialRuleInstance(int shipID, ShipRule rule)
        {
            connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO ShipSpecialRulesInstances (ship, rule, amount) VALUES " +
                "(@ship, @rule, @amount)", connection))
            {
                cmd.Parameters.AddWithValue("@ship", shipID);
                cmd.Parameters.AddWithValue("@rule", rule.RuleID);
                cmd.Parameters.AddWithValue("@amount", rule.Amount);

                int rows = cmd.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void DeleteSpecialRuleInstance(int shipID, ShipRule rule)
        {
            connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM ShipSpecialRulesInstances WHERE ship = @ship AND rule = @rule AND amount = @amount",
                connection))
            {
                cmd.Parameters.AddWithValue("@ship", shipID);
                cmd.Parameters.AddWithValue("@rule", rule.RuleID);
                cmd.Parameters.AddWithValue("@amount", rule.Amount);

                int rows = cmd.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void UpdateShip(Ship ship)
        {
            connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("UPDATE Ships SET name = @name. faction = @faction, scan = @scan, sigMin = @sigMin, sigMax = @sigMax, " +
                "thrust = @thrust, hull = @hull, aMin = @aMin, aMax = @aMax, pd = @pd, gMin = @gMin, gMax = gMax, launch = @launch, tonnage = @tonnage, " +
                "points = @points", connection))
            {
                cmd.Parameters.AddWithValue("@name", ship.Name);
                cmd.Parameters.AddWithValue("@faction", ship.Faction.FactionID);
                cmd.Parameters.AddWithValue("@scan", ship.Scan);
                cmd.Parameters.AddWithValue("@sigMin", ship.SigMin);
                cmd.Parameters.AddWithValue("@sigMax", ship.SigMax);
                cmd.Parameters.AddWithValue("@thrust", ship.Thrust);
                cmd.Parameters.AddWithValue("@hull", ship.Hull);
                cmd.Parameters.AddWithValue("@aMin", ship.AMin);
                cmd.Parameters.AddWithValue("@aMax", ship.AMax);
                cmd.Parameters.AddWithValue("@pd", ship.Pd);
                cmd.Parameters.AddWithValue("@gMin", ship.GMin);
                cmd.Parameters.AddWithValue("@gMax", ship.GMax);
                cmd.Parameters.AddWithValue("@launch", ship.Launch);
                cmd.Parameters.AddWithValue("@tonnage", ship.Tonnage.TonnageID);
                cmd.Parameters.AddWithValue("@points", ship.Points);

                int rows = cmd.ExecuteNonQuery();
            }
            connection.Close();
        }

        public List<Ship> GetAllShipsOfFaction(Faction faction)
        {
            List<Ship> shipList = new List<Ship>();
            connection = dBControl.GetConnection();
            connection.Open();
            MySqlDataReader dataReader;

            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Ships WHERE faction = @factionID", connection))
            {
                cmd.Parameters.AddWithValue("@factionID", faction.FactionID);

                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Ship newShip = new Ship
                    {
                        ShipID = dataReader.GetInt16(0),
                        Name = dataReader.GetString(1),
                        Faction = faction,
                        Scan = dataReader.GetInt16(3),
                        SigMin = dataReader.GetInt16(4),
                        SigMax = dataReader.GetInt16(5),
                        Thrust = dataReader.GetInt16(6),
                        Hull = dataReader.GetInt16(7),
                        AMin = dataReader.GetInt16(8),
                        AMax = dataReader.GetInt16(9),
                        Pd = dataReader.GetInt16(10),
                        GMin = dataReader.GetInt16(11),
                        GMax = dataReader.GetInt16(12),
                        Launch = dataReader.GetBoolean(13),
                        Points = dataReader.GetInt16(15),                        
                    };
                    newShip.Tonnage.TonnageID = dataReader.GetInt16(14);
                    newShip.Tonnage = tonnageControl.GetTonnageByID(newShip.Tonnage.TonnageID);
                    Thread specialRulesThread = new Thread(() => newShip.SetRules(GetSpecialRules(newShip.ShipID)))
                    {
                        IsBackground = true,
                        Name = "SpecialThread"
                    };
                    specialRulesThread.Start();
                    shipList.Add(newShip);
                }
            }
            connection.Close();                     
            return shipList;
        }

        private List<ShipRule> GetSpecialRules(int shipID)
        {
            List<ShipRule> shipRules = new List<ShipRule>();
            MySqlConnection connection1 = dBControl.GetConnection();
            connection1.Open();
            MySqlDataReader dataReader1;

            using (MySqlCommand cmd = new MySqlCommand("SELECT i.rule, r.rule, i.amount FROM ShipSpecialRulesInstances AS i, ShipSpecialRules AS r " +
                "WHERE i.ship = @ship AND r.ruleID = i.rule", connection1))
            {
                cmd.Parameters.AddWithValue("@ship", shipID);

                dataReader1 = cmd.ExecuteReader();
                while (dataReader1.Read()){
                    ShipRule newRule = new ShipRule
                    {
                        RuleID = dataReader1.GetInt16(0),
                        Rule = dataReader1.GetString(1),
                        Amount = dataReader1.GetInt16(2)
                    };

                    shipRules.Add(newRule);
                    
                }

               
            }
            connection1.Close();
            return shipRules;
        }       
    }
}
