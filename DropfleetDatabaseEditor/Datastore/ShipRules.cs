using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Datastore
{
    class ShipRules
    {
        private int ruleID;
        private string rule;
        private int amount;

        public ShipRules()
        {
        }

        public ShipRules(int ruleID, string rule, int amount)
        {
            this.RuleID = ruleID;
            this.Rule = rule;
            this.Amount = amount;
        }

        public int RuleID { get => ruleID; set => ruleID = value; }
        public string Rule { get => rule; set => rule = value; }
        public int Amount { get => amount; set => amount = value; }
    }
}
