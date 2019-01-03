using DropfleetDatabaseEditor.Datastore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Controllers
{
    class ShipRulesController
    {
        MySqlConnection connection;
        DatabaseControl dBControl = new DatabaseControl();

        public void InsertRule(ShipRule rule)
        {
            connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO ShipSpecialRules (rule) VALUES (@rule)", connection))
            {
                cmd.Parameters.AddWithValue("@rule", rule.Rule);

                int rows = cmd.ExecuteNonQuery();
            }

            connection.Close();
        }

        public void InsertRuleInstance(ShipRule rule, int shipID)
        {
            connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO ShipSpecialRulesInstances (ship, rule, amount) VALUES (@ship, @rule," +
                " @amount)", connection))
            {
                cmd.Parameters.AddWithValue("@ship", shipID);
                cmd.Parameters.AddWithValue("@rule", rule.RuleID);
                cmd.Parameters.AddWithValue("@amount", rule.Amount);

                int rows = cmd.ExecuteNonQuery();
            }

            connection.Close();
        }

        public void UpdateRuleInstance(ShipRule rule, int shipID)
        {
            connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("UPDATE ShipSpecialRulesInstances SET amount = @amount WHERE " +
                "ship = @shipID AND rule = @ruleID", connection))
            {
                cmd.Parameters.AddWithValue("@ship", shipID);
                cmd.Parameters.AddWithValue("@rule", rule.RuleID);
                cmd.Parameters.AddWithValue("@amount", rule.Amount);

                int rows = cmd.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void DeleteRuleInstance(ShipRule rule, int shipID)
        {
            connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM ShipSpecialRulesInstances WHERE amount = @amount" +
                "ship = @shipID AND rule = @ruleID ", connection))
            {
                cmd.Parameters.AddWithValue("@ship", shipID);
                cmd.Parameters.AddWithValue("@rule", rule.RuleID);
                cmd.Parameters.AddWithValue("@amount", rule.Amount);

                int rows = cmd.ExecuteNonQuery();
            }
            connection.Close();
        }

        public List<ShipRule> GetAllRules()
        {
            connection = dBControl.GetConnection();
            connection.Open();
            MySqlDataReader dataReader;

            List<ShipRule> shipRules = new List<ShipRule>();

            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM ShipSpecialRules", connection))
            {
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    ShipRule newRule = new ShipRule
                    {
                        RuleID = dataReader.GetInt16(0),
                        Rule = dataReader.GetString(1)
                    };

                    shipRules.Add(newRule);
                }
            }

            connection.Close();

            return shipRules;
        }

        public void UpdateRule(ShipRule rule)
        {
            connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("UPDATE ShipSpecialRules SET rule = @rule WHERE ruleID = @ruleID", connection))
            {
                cmd.Parameters.AddWithValue("@rule", rule.Rule);
                cmd.Parameters.AddWithValue("@ruleID", rule.RuleID);

                int rows = cmd.ExecuteNonQuery();
            }

            connection.Close();
        }
        
    }
}
