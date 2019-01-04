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
    }
}
