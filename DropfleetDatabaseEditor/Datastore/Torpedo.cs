using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Datastore
{
    class Torpedo
    {
        private int torpedoID;
        private Faction faction;
        private int thrust;
        private int attack;
        private int damage;
        private List<WeaponRule> rules;

        public Torpedo()
        {
        }

        public Torpedo(int torpedoID, Faction faction, int thrust, int attack, int damage, List<WeaponRule> rules)
        {
            this.TorpedoID = torpedoID;
            this.Faction = faction;
            this.Thrust = thrust;
            this.Attack = attack;
            this.Damage = damage;
            this.Rules = rules;
        }

        public int TorpedoID { get => torpedoID; set => torpedoID = value; }
        public int Thrust { get => thrust; set => thrust = value; }
        public int Attack { get => attack; set => attack = value; }
        public int Damage { get => damage; set => damage = value; }
        internal Faction Faction { get => faction; set => faction = value; }
        internal List<WeaponRule> Rules { get => rules; set => rules = value; }
    }
}
