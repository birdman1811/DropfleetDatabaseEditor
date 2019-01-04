using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Datastore
{
    public class Tonnage
    {
        private int tonnageID;
        private string tonnageName;
        private int value;
        private TonnageClass tonnageClass;

        public Tonnage()
        {
        }

        public Tonnage(int tonnageID, string tonnage, int value, TonnageClass tonnageClass)
        {
            this.TonnageID = tonnageID;
            this.TonnageName = tonnage;
            this.Value = value;
            this.TonnageClass = tonnageClass;
        }

        public int TonnageID { get => tonnageID; set => tonnageID = value; }
        public string TonnageName { get => tonnageName; set => tonnageName = value; }
        public int Value { get => value; set => this.value = value; }
        internal TonnageClass TonnageClass { get => tonnageClass; set => tonnageClass = value; }
    }
}
