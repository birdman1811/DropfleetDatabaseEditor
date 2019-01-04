using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Datastore
{
    public class TonnageClass
    {
        private int classID;
        private string className;

        public TonnageClass()
        {
        }

        public TonnageClass(int classID, string className)
        {
            this.ClassID = classID;
            this.ClassName = className;
        }

        public int ClassID { get => classID; set => classID = value; }
        public string ClassName { get => className; set => className = value; }
    }
}
