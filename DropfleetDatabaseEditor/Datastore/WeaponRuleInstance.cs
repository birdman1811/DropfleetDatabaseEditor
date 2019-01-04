using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Datastore
{
    public class WeaponRuleInstance : WeaponRule
    {
        private int amount;

        public WeaponRuleInstance()
        {
        }

        public WeaponRuleInstance(int amount)
        {
            Amount = amount;
            
        }
        public int Amount { get => amount; set => amount = value; }

        public string FullString
        {
            get
            {
                if (this.Amount > 0)
                {
                    return Rule + " (" + Amount + ")";
                }
                else
                {
                    return Rule;
                }
            }

            
        }
    }
}
