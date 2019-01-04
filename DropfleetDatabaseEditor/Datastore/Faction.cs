using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Datastore
{
    public class Faction
    {
        private int factionID;
        private string name;
        private string icon;
        private string lore;
        private string gameplay;

        public Faction()
        {
        }

        public Faction(int factionID, string name, string icon, string lore, string gameplay)
        {
            this.factionID = factionID;
            this.name = name;
            this.icon = icon;
            this.lore = lore;
            this.gameplay = gameplay;
        }

        public int FactionID { get => factionID; set => factionID = value; }
        public string Name { get => name; set => name = value; }
        public string Icon { get => icon; set => icon = value; }
        public string Lore { get => lore; set => lore = value; }
        public string Gameplay { get => gameplay; set => gameplay = value; }
    }
}
