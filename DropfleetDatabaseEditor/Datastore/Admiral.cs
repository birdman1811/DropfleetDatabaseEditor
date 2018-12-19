using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Datastore
{
    class Admiral
    {
        private int admiralID;
        private Faction faction;
        private string admiralName;
        private int av;
        private int cost;

        public Admiral()
        {
        }

        public Admiral(int admiralID, Faction faction, string admiralName, int av, int cost)
        {
            this.AdmiralID = admiralID;
            this.Faction = faction;
            this.AdmiralName = admiralName;
            this.Av = av;
            this.Cost = cost;
        }

        public int AdmiralID { get => admiralID; set => admiralID = value; }
        public string AdmiralName { get => admiralName; set => admiralName = value; }
        public int Av { get => av; set => av = value; }
        public int Cost { get => cost; set => cost = value; }
        internal Faction Faction { get => faction; set => faction = value; }
    }
}
