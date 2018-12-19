using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Datastore
{
    class Bombers
    {
        private int bomberID;
        private Faction faction;
        private int thrust;
        private int lockValue;
        private int damage;
        private List<WeaponRule> rules;


        public Bombers()
        {
        }

        public Bombers(int bomberID, Faction faction, int thrust, int lockValue, int damage, List<WeaponRule> rules)
        {
            this.BomberID = bomberID;
            this.Faction = faction;
            this.Thrust = thrust;
            this.LockValue = lockValue;
            this.Damage = damage;
            this.Rules = rules;
        }

        public int BomberID { get => bomberID; set => bomberID = value; }
        public int Thrust { get => thrust; set => thrust = value; }
        public int LockValue { get => lockValue; set => lockValue = value; }
        public int Damage { get => damage; set => damage = value; }
        internal Faction Faction { get => faction; set => faction = value; }
        internal List<WeaponRule> Rules { get => rules; set => rules = value; }
    }
}
