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

            using (MySqlCommand cmd = new MySqlCommand("SELECT * from Weapons where faction = @faction"))
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
                        Attack = dataReader.GetInt16(4),
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


        public List<WeaponRuleInstance> GetRulesForWeapon(int weaponID)
        {
            List<WeaponRuleInstance> weaponRules = new List<WeaponRuleInstance>();

            connection = dBControl.GetConnection();
            MySqlDataReader dataReader;

            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("SELECT i.rule, r.rule, i.amount FROM WeaponSpecialRuleInstance AS i, WeaponSpecialRules AS r " +
                "WHERE i.weapon = @weaponID",connection))
            {
                cmd.Parameters.AddWithValue("@weaponID", weaponID);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    WeaponRuleInstance newRuleInstance = new WeaponRuleInstance
                    {
                        RuleID = dataReader.GetInt16(0),
                        Rule = dataReader.GetString(1),
                        Amount = dataReader.GetInt16(2)
                    };

                    weaponRules.Add(newRuleInstance);
                }
            }

            connection.Close();
            return weaponRules;
        }

        public void InsertWeaponRule(WeaponRule rule)
        {
            connection = dBControl.GetConnection();
            
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO WeaponSpecialRules (rule) VALUES (@rule)", connection))
            {
                cmd.Parameters.AddWithValue("@rule", rule);

                int rows = cmd.ExecuteNonQuery();
            }

            connection.Close();
        }
    }
}
