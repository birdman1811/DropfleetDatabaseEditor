using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Datastore
{
    class Facings
    {
        private int faceID;
        private string facing;

        public Facings()
        {
        }

        public Facings(int faceID, string facing)
        {
            this.FaceID = faceID;
            this.Facing = facing;
        }

        public int FaceID { get => faceID; set => faceID = value; }
        public string Facing { get => facing; set => facing = value; }
    }
}
