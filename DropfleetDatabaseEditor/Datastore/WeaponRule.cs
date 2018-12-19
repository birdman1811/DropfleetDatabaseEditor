using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Datastore
{
    class WeaponRule
    {
        private int ruleID;
        private string rule;

        public WeaponRule()
        {
        }

        public WeaponRule(int ruleID, string rule)
        {
            this.RuleID = ruleID;
            this.Rule = rule;
        }

        public int RuleID { get => ruleID; set => ruleID = value; }
        public string Rule { get => rule; set => rule = value; }
    }
}
