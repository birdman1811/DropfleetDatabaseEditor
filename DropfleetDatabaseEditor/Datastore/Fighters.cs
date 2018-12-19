using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Datastore
{
    class Fighters
    {
        private int fighterID;
        private Faction Faction;
        private int thrust;
        private int pdBonus;

        public Fighters()
        {
        }

        public Fighters(int fighterID, Faction faction, int thrust, int pdBonus)
        {
            this.FighterID = fighterID;
            Faction1 = faction;
            this.Thrust = thrust;
            this.PdBonus = pdBonus;
        }

        public int FighterID { get => fighterID; set => fighterID = value; }
        public int Thrust { get => thrust; set => thrust = value; }
        public int PdBonus { get => pdBonus; set => pdBonus = value; }
        internal Faction Faction1 { get => Faction; set => Faction = value; }
    }
}
