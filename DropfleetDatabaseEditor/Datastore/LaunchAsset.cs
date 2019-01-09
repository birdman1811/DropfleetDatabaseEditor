using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Datastore
{
    public class LaunchAsset
    {
        private int assetID;
        private string asset;
        private int amount;
        List<WeaponRuleInstance> rules;

        public LaunchAsset()
        {
            rules = new List<WeaponRuleInstance>();
        }

        public LaunchAsset(int assetID, string asset, int amount, List<WeaponRuleInstance> rules)
        {
            this.assetID = assetID;
            this.asset = asset;
            this.amount = amount;
            this.rules = rules;
        }

        public int AssetID { get => assetID; set => assetID = value; }
        public string Asset { get => asset; set => asset = value; }
        public int Amount { get => amount; set => amount = value; }
        public List<WeaponRuleInstance> Rules { get => rules; set => rules = value; }

        public string FullString
        {
            get
            {
                if (this.Amount > 0)
                {
                    return Asset + " (" + Amount + ")";
                }
                else
                {
                    return Asset;
                }
            }


        }

        public void AddRuleInstance(WeaponRuleInstance rule)
        {
            Rules.Add(rule);
        }


        public void RemoveRuleInstance(WeaponRuleInstance rule)
        {
            Rules.Remove(rule);
        }
        
    }
}
