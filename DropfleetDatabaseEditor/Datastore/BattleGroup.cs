using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Datastore
{
    class BattleGroup
    {
        private int groupID;
        private string groupName;
        private string groupImage;
        private int max;
        private int minLight;
        private int maxLight;
        private int minMedium;
        private int maxMedium;
        private int minHeavy;
        private int maxHeavy;
        private int minSuperheavy;
        private int maxSuperheavy;
        private int minSuperheavy2;
        private int maxSuperheavy2;

        public BattleGroup()
        {
        }

        public BattleGroup(int groupID, string groupName, string groupImage, int max, int minLight, int maxLight, int minMedium, int maxMedium, int minHeavy, int maxHeavy, 
            int minSuperheavy, int maxSuperheavy, int minSuperheavy2, int maxSuperheavy2)
        {
            this.GroupID = groupID;
            this.GroupName = groupName;
            this.GroupImage = groupImage;
            this.Max = max;
            this.MinLight = minLight;
            this.MaxLight = maxLight;
            this.MinMedium = minMedium;
            this.MaxMedium = maxMedium;
            this.MinHeavy = minHeavy;
            this.MaxHeavy = maxHeavy;
            this.MinSuperheavy = minSuperheavy;
            this.MaxSuperheavy = maxSuperheavy;
            this.MinSuperheavy2 = minSuperheavy2;
            this.MaxSuperheavy2 = maxSuperheavy2;
        }

        public int GroupID { get => groupID; set => groupID = value; }
        public string GroupName { get => groupName; set => groupName = value; }
        public string GroupImage { get => groupImage; set => groupImage = value; }
        public int Max { get => max; set => max = value; }
        public int MinLight { get => minLight; set => minLight = value; }
        public int MaxLight { get => maxLight; set => maxLight = value; }
        public int MinMedium { get => minMedium; set => minMedium = value; }
        public int MaxMedium { get => maxMedium; set => maxMedium = value; }
        public int MinHeavy { get => minHeavy; set => minHeavy = value; }
        public int MaxHeavy { get => maxHeavy; set => maxHeavy = value; }
        public int MinSuperheavy { get => minSuperheavy; set => minSuperheavy = value; }
        public int MaxSuperheavy { get => maxSuperheavy; set => maxSuperheavy = value; }
        public int MinSuperheavy2 { get => minSuperheavy2; set => minSuperheavy2 = value; }
        public int MaxSuperheavy2 { get => maxSuperheavy2; set => maxSuperheavy2 = value; }
    }
}
