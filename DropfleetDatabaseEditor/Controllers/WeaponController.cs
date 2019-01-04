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
    class WeaponController
    {
        MySqlConnection connection;
        DatabaseControl dBControl = new DatabaseControl();

        public List<Weapon> GetWeaponsByFaction(Faction faction)
        {
            List<Weapon> weaponList = new List<Weapon>();

            connection = dBControl.GetConnection();
            MySqlDataReader dataReader;
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("SELECT * from Weapons where faction = @faction", connection))
            {
                cmd.Parameters.AddWithValue("@faction", faction.FactionID);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Weapon newWeapon = new Weapon
                    {
                        WeaponID = dataReader.GetInt16(0),
                        Faction = faction,
                        Name = dataReader.GetString(2),
                        LockValue = dataReader.GetInt16(3),
                        Attack = dataReader.GetString(4),
                        Damage = dataReader.GetInt16(5)
                        
                    };

                    Thread rulesThread = new Thread(() => newWeapon.SetRules(GetRulesForWeapon(newWeapon.WeaponID)))
                    {
                        IsBackground = true,
                        Name = "WeaponRulesThread"
                    };
                    rulesThread.Start();
                    weaponList.Add(newWeapon);
                }
            }

            connection.Close();
            return weaponList;
        }

        public void AddWeapon (Weapon weapon)
        {
            connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Weapons (faction, name, lockValue, attack, damage) VALUES (@faction, @name, @lockValue, " +
                 "@attack, @damage)", connection))
            {
                Console.WriteLine("Faction is " + weapon.Faction.Name + " ID is " + weapon.Faction.FactionID);               
                cmd.Parameters.AddWithValue("@faction", weapon.Faction.FactionID);
                cmd.Parameters.AddWithValue("@name", weapon.Name);
                cmd.Parameters.AddWithValue("@lockValue", weapon.LockValue);
                cmd.Parameters.AddWithValue("@attack", weapon.Attack);
                cmd.Parameters.AddWithValue("@damage", weapon.Damage);

                int rows = cmd.ExecuteNonQuery();
            }
            

            weapon.WeaponID = GetWeaponID(weapon);
            connection.Close();

            foreach (WeaponRuleInstance rule in weapon.Rules)
            {
                Thread insertRuleInstanceThread = new Thread(() => InsertWeaponRuleInstance(weapon.WeaponID, rule));
                insertRuleInstanceThread.Start();

              
            }            
        }

        public void UpdateWeapon(Weapon weapon)
        {
            connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("UPDATE Weapons SET faction = @faction, name = @name, lockValue = @lockValue, attack = @attack, " +
                "damage = @damage WHERE weaponID = @weaponID ", connection))
            {
                cmd.Parameters.AddWithValue("@faction", weapon.Faction.FactionID);
                cmd.Parameters.AddWithValue("@name", weapon.Name);
                cmd.Parameters.AddWithValue("@lockValue", weapon.LockValue);
                cmd.Parameters.AddWithValue("@attack", weapon.Attack);
                cmd.Parameters.AddWithValue("@damage", weapon.Damage);
                cmd.Parameters.AddWithValue("@weaponID", weapon.WeaponID);

                int rows = cmd.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void InsertWeaponRuleInstance(int weaponID, WeaponRuleInstance rule)
        {
            MySqlConnection connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO WeaponSpecialRuleInstance (weapon, rule, amount)" +
                " VALUES(@weapon, @rule, @amount)", connection))
            {
                cmd.Parameters.AddWithValue("@weapon", weaponID);
                cmd.Parameters.AddWithValue("@rule", rule.RuleID);
                cmd.Parameters.AddWithValue("@amount", rule.Amount);

                int rows = cmd.ExecuteNonQuery();
            }

            connection.Close();
        }

        public List<Facings> GetAllFacings()
        {
            List<Facings> facingsList = new List<Facings>();
            connection = dBControl.GetConnection();
            connection.Open();
            MySqlDataReader dataReader;

            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Facings", connection))
            {
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Facings newFacing = new Facings
                    {
                        FaceID = dataReader.GetInt16(0),
                        Facing = dataReader.GetString(1)
                    };

                    facingsList.Add(newFacing);
                }
            }

            connection.Close();
            return facingsList;
        }

        public void InsertFacingInstance( Facings facing, int listNumber)
        {
            connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO FacingInstance (listNumber, facing) VALUES (@weaponInstance, @facingID)", connection))
            {
                cmd.Parameters.AddWithValue("@weaponInstance", listNumber);
                cmd.Parameters.AddWithValue("@facingID", facing.FaceID);

                int rows = cmd.ExecuteNonQuery();
            }

            connection.Close();
        }

        public void DeleteFacingInstance(int listNumber, Facings facing)
        {
            connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM FacingInstance WHERE listNumber= @weaponInstance AND facing = @facingID", connection))
            {
                cmd.Parameters.AddWithValue("@weaponInstance", listNumber);
                cmd.Parameters.AddWithValue("@facingID", facing.FaceID);

                int rows = cmd.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void InsertWeaponInstance(WeaponFacing weaponFacing, int shipID)
        {
            connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO WeaponInstance (weapon, ship, listNumber) VALUES " +
                "(@weapon, @ship, @listNumber)", connection))
            {
                cmd.Parameters.AddWithValue("@weapon", weaponFacing.Weapon.WeaponID);
                cmd.Parameters.AddWithValue("@ship", shipID);
                cmd.Parameters.AddWithValue("@listNumber", weaponFacing.ListNumber);

                int rows = cmd.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void DeleteWeaponInstance(WeaponFacing weaponFacing)
        {
            connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM WeaponInstance WHERE listNumber = @listNumber", connection))
            {
                cmd.Parameters.AddWithValue("@listNumber", weaponFacing.ListNumber);

                int rows = cmd.ExecuteNonQuery();
            }
            connection.Close();
        }

        public List<int> GetListNumbers()
        {
            List<int> listNumbers = new List<int>();
            connection = dBControl.GetConnection();
            MySqlDataReader dataReader;
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM WeaponInstance", connection))
            {
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int listNumber = dataReader.GetInt16(3);
                    listNumbers.Add(listNumber);
                }
            }
            connection.Close();

            return listNumbers;
        }

        public List<WeaponFacing> GetWeaponsByShip(int shipID)
        {
            List<WeaponFacing> weaponsList = new List<WeaponFacing>();
            connection = dBControl.GetConnection();
            MySqlDataReader dataReader;
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM WeaponInstance WHERE ship = @shipid", connection))
            {
                cmd.Parameters.AddWithValue("@shipid", shipID);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    WeaponFacing newWeaponFacing = new WeaponFacing
                    {
                        ListNumber = dataReader.GetInt16(3)
                    };
                    int weaponID = dataReader.GetInt16(1);
                    newWeaponFacing.Weapon = GetWeaponByID(weaponID);

                    weaponsList.Add(newWeaponFacing);
                }
            }

            connection.Close();

            return weaponsList;
        }

        public Weapon GetWeaponByID(int weaponID)
        {
            Weapon weapon = new Weapon();
            connection = dBControl.GetConnection();
            MySqlDataReader dataReader;
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Weapons WHERE weaponID = @weaponID", connection))
            {
                cmd.Parameters.AddWithValue("@weaponID", weaponID);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    weapon.Name = dataReader.GetString(2);
                    weapon.LockValue = dataReader.GetInt16(3);
                    weapon.Attack = dataReader.GetString(4);
                    weapon.Damage = dataReader.GetInt16(5);
                    int factionID = dataReader.GetInt16(1);
                    FactionController factionController = new FactionController();
                    weapon.Faction = factionController.GetFactionByID(factionID);

                }
            }

            connection.Close();
            return weapon;
        }

        public void DeleteWeaponRuleInstance(WeaponRuleInstance rule, int weaponID)
        {
            connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM WeaponSpecialRuleInstance WHERE weapon = @weapon AND rule = @rule AND " +
                "amount = @amount ", connection))
            {
                cmd.Parameters.AddWithValue("@weapon", weaponID);
                cmd.Parameters.AddWithValue("@rule", rule.RuleID);
                cmd.Parameters.AddWithValue("@amount", rule.Amount);

                int rows = cmd.ExecuteNonQuery();

            }
            connection.Close();
        }

        public void UpdateWeaponRuleInstance(WeaponRuleInstance rule, int weaponID)
        {
            connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("UPDATE WeaponSpecialRuleInstance SET amount = @amount WHERE weapon = @weaponID AND " +
                "rule = @ruleID", connection))
            {
                cmd.Parameters.AddWithValue("@amount", rule.Amount);
                cmd.Parameters.AddWithValue("@weaponID", weaponID);
                cmd.Parameters.AddWithValue("@ruleID", rule.RuleID);

                int rows = cmd.ExecuteNonQuery();
            }

            connection.Close();
        }

        public int GetWeaponID(Weapon weapon)
        {
            int weaponId = 0;
            MySqlConnection connection1 = dBControl.GetConnection();
            connection1.Open();
            MySqlDataReader dataReader;

            using (MySqlCommand cmd = new MySqlCommand("SELECT weaponID FROM Weapons where name = @name", connection1))
            {
                cmd.Parameters.AddWithValue("@name", weapon.Name);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    weaponId = dataReader.GetInt16(0);
                }
            }
            connection1.Close();
            return weaponId;
            
        } 

        public List<WeaponRuleInstance> GetRulesForWeapon(int weaponID)
        {
            List<WeaponRuleInstance> weaponRules = new List<WeaponRuleInstance>();

            MySqlConnection connection1 = dBControl.GetConnection();
            MySqlDataReader dataReader1;

            connection1.Open();

            using (MySqlCommand cmd = new MySqlCommand("SELECT i.rule, r.rule, i.amount FROM WeaponSpecialRuleInstance AS i, WeaponSpecialRules AS r " +
                "WHERE i.weapon = @weaponID AND r.ruleid = i.rule", connection1))
            {
                cmd.Parameters.AddWithValue("@weaponID", weaponID);

                dataReader1 = cmd.ExecuteReader();

                while (dataReader1.Read())
                {
                    WeaponRuleInstance newRuleInstance = new WeaponRuleInstance
                    {
                        RuleID = dataReader1.GetInt16(0),
                        Rule = dataReader1.GetString(1),
                        Amount = dataReader1.GetInt16(2)
                    };

                    weaponRules.Add(newRuleInstance);
                }
            }

            connection1.Close();
            return weaponRules;
        }

        public void InsertWeaponRule(WeaponRule rule)
        {
            connection = dBControl.GetConnection();
            
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO WeaponSpecialRules (rule) VALUES (@rule)", connection))
            {
                cmd.Parameters.AddWithValue("@rule", rule.Rule);

                int rows = cmd.ExecuteNonQuery();
            }

            connection.Close();
        }

        public List<WeaponRule> GetWeaponRules()
        {
            List<WeaponRule> weaponRules = new List<WeaponRule>();
            connection = dBControl.GetConnection();
            MySqlDataReader dataReader;
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM WeaponSpecialRules", connection))
            {
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    WeaponRule newRule = new WeaponRule
                    {
                        RuleID = dataReader.GetInt16(0),
                        Rule = dataReader.GetString(1)
                    };
                    weaponRules.Add(newRule);
                }
            }
            connection.Close();
            return weaponRules;

        }

        public void UpdateRule (WeaponRule ruleToUpdate)
        {
            connection = dBControl.GetConnection();            
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("UPDATE WeaponSpecialRules SET rule = @rule WHERE ruleid = @id" ,connection))
            {
                cmd.Parameters.AddWithValue("@rule", ruleToUpdate.Rule);
                cmd.Parameters.AddWithValue("@id", ruleToUpdate.RuleID);

                int rows = cmd.ExecuteNonQuery();
            }

            connection.Close();
        }
    }
}
