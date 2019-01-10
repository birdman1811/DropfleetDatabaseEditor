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
                while (dataReader1.Read())
                {
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

        public List<WeaponFacing> GetShipWeapons(int shipID)
        {
            List<WeaponFacing> weaponList = new List<WeaponFacing>();
            connection = dBControl.GetConnection();
            connection.Open();
            MySqlDataReader dataReader;

            using (MySqlCommand cmd = new MySqlCommand("SELECT i.weapon, i.listNumber, w.name FROM WeaponInstance AS i, Weapons AS w " +
                "WHERE i.ship = @ship AND w.weaponID = i.weapon", connection))
            {
                cmd.Parameters.AddWithValue("@ship", shipID);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    WeaponFacing newWeapon = new WeaponFacing();
                    newWeapon.Weapon.WeaponID = dataReader.GetInt16(0);
                    newWeapon.ListNumber = dataReader.GetInt32(1);
                    newWeapon.Weapon.Name = dataReader.GetString(2);

                    weaponList.Add(newWeapon);

                }
            }

            connection.Close();

            foreach (WeaponFacing w in weaponList)
            {
                Thread facingsThread = new Thread(() => w.SetFacings(GetWeaponsFacings(w.ListNumber)))
                {
                    IsBackground = true,
                    Name = "FacingsThread"
                };
                facingsThread.Start();
            }

            return weaponList;
        }

        private List<Facings> GetWeaponsFacings(int listNumber)
        {
            List<Facings> facingList = new List<Facings>();
            MySqlConnection connection2 = dBControl.GetConnection();
            connection2.Open();
            MySqlDataReader dataReader2;

            using (MySqlCommand cmd = new MySqlCommand("SELECT i.facing, f.facing FROM FacingInstance AS i, Facings as f " +
                "WHERE i.listNumber = @listNumber AND f.faceID = i.facing ", connection2))
            {
                cmd.Parameters.AddWithValue("@listNumber", listNumber);

                dataReader2 = cmd.ExecuteReader();

                while (dataReader2.Read())
                {
                    Facings newFacing = new Facings();
                    newFacing.FaceID = dataReader2.GetInt16(0);
                    newFacing.Facing = dataReader2.GetString(1);

                    facingList.Add(newFacing);
                    Console.WriteLine("Facing " + newFacing.Facing + " To Weapon");
                }
            }
            connection2.Close();
            return facingList;
        }

        public List<LaunchAsset> GetShipsLaunchAssets(int shipID)
        {
            List<LaunchAsset> assetList = new List<LaunchAsset>();
            connection = dBControl.GetConnection();
            connection.Open();
            MySqlDataReader dataReader;

            using (MySqlCommand cmd = new MySqlCommand("SELECT i.asset, l.asset, i.value FROM AssetInstance as i, LaunchAssets as l " +
                "WHERE i.ship = @shipID AND l.assetID = i.asset'", connection))
            {
                cmd.Parameters.AddWithValue("@shipID", shipID);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    LaunchAsset newAsset = new LaunchAsset();
                    newAsset.AssetID = dataReader.GetInt16(0);
                    newAsset.Asset = dataReader.GetString(1);
                    newAsset.Amount = dataReader.GetInt16(2);

                    assetList.Add(newAsset);
                }
                foreach (LaunchAsset l in assetList)
                {
                    Thread assetThread = new Thread(() => l.SetRules(GetAssetRules(l, shipID)))
                    {
                        IsBackground = true,
                        Name = "Asset Thread"
                    };
                    assetThread.Start();
                }
            }
            connection.Close();
            return assetList;
        }

        private List<WeaponRuleInstance> GetAssetRules(LaunchAsset asset, int shipID)
        {
            List<WeaponRuleInstance> rulesList = new List<WeaponRuleInstance>();
            MySqlConnection connection2 = dBControl.GetConnection();
            connection2.Open();
            MySqlDataReader dataReader2;

            using (MySqlCommand cmd = new MySqlCommand("SELECT i.rule, i.amount, r.rule FROM AssetSpecialRuleInstance AS i, WeaponSpecialRules AS r " +
                "WHERE  i.asset = @assetID AND i.ship = @shipID AND r.ruleid = i.rule", connection2))
            {
                cmd.Parameters.AddWithValue("@assetID", asset.AssetID);
                cmd.Parameters.AddWithValue("@shipID", shipID);

                dataReader2 = cmd.ExecuteReader();

                while (dataReader2.Read())
                {
                    WeaponRuleInstance rule = new WeaponRuleInstance();
                    rule.RuleID = dataReader2.GetInt16(0);
                    rule.Rule = dataReader2.GetString(2);
                    rule.Amount = dataReader2.GetInt16(1);

                    rulesList.Add(rule);
                }
            }
            connection2.Close();
            return rulesList;
        }
    }
}
