using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Datastore
{
    public class WeaponFacing
    {
        private Weapon weapon;
        private List<Facings> facings;
        private int listNumber;

        public WeaponFacing()
        {
            facings = new List<Facings>();
            weapon = new Weapon();
        }

        public WeaponFacing(Weapon weapon, List<Facings> facings, int listNumber)
        {
            this.Weapon = weapon;
            this.Facings = facings;
            this.ListNumber = listNumber;
        }

        public int ListNumber { get => listNumber; set => listNumber = value; }
        internal Weapon Weapon { get => weapon; set => weapon = value; }
        internal List<Facings> Facings { get => facings; set => facings = value; }

        private string CreateFaceString()
        {
            string faceString = "";

            foreach (Facings face in facings)
            {
                string thisFace = face.Facing;
                faceString = string.Concat( faceString, "/", thisFace);
            }

            return faceString;
        }

        public string FullString
        {
            get
            {
                string faceString = CreateFaceString();
                return weapon.Name + faceString;                
            }
        }

        public void AddFacing(Facings facing)
        {
            facings.Add(facing);
        }

        public void RemoveFacing(Facings facing)
        {
            facings.Remove(facing);
        }

        public void SetFacings(List<Facings> facingsList)
        {
            facings = facingsList;
        }
    }
}
