using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Datastore
{
    class Weapon
    {
        private int weaponID;
        private Faction faction;
        private string name;
        private int lockValue;
        private int attack;
        private int damage;
        private List<WeaponRuleInstance> rules;

        public Weapon()
        {
        }

        public Weapon(int weaponID, Faction faction, string name, int lockValue, int attack, int damage, List<WeaponRuleInstance> rules )
        {
            this.WeaponID = weaponID;
            this.Faction = faction;
            this.Name = name;
            this.LockValue = lockValue;
            this.Attack = attack;
            this.Damage = damage;
            this.Rules = rules;
        }

        public int WeaponID { get => weaponID; set => weaponID = value; }
        public int LockValue { get => lockValue; set => lockValue = value; }
        public int Attack { get => attack; set => attack = value; }
        public int Damage { get => damage; set => damage = value; }
        public string Name { get => name; set => name = value; }
        internal Faction Faction { get => faction; set => faction = value; }       
        internal List<WeaponRuleInstance> Rules { get => rules; set => rules = value; }

        public void SetRules(List<WeaponRuleInstance> rules)
        {
            this.Rules = rules;
        }
    }
}
