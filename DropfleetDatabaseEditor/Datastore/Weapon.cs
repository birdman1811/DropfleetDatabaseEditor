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
        private int lockValue;
        private int attack;
        private int damage;
        private List<WeaponRule> rules;

        public Weapon()
        {
        }

        public Weapon(int weaponID, Faction faction, int lockValue, int attack, int damage, List<WeaponRule> rules )
        {
            this.WeaponID = weaponID;
            this.Faction = faction;
            this.LockValue = lockValue;
            this.Attack = attack;
            this.Damage = damage;
            this.Rules = rules;
        }

        public int WeaponID { get => weaponID; set => weaponID = value; }
        public int LockValue { get => lockValue; set => lockValue = value; }
        public int Attack { get => attack; set => attack = value; }
        public int Damage { get => damage; set => damage = value; }
        internal Faction Faction { get => faction; set => faction = value; }
        internal List<WeaponRule> Rules { get => rules; set => rules = value; }
    }
}
