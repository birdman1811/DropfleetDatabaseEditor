using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Datastore
{
    class WeaponFacing
    {
        private Weapon weapon;
        private List<Facings> facings;

        public WeaponFacing()
        {
        }

        public WeaponFacing(Weapon weapon, List<Facings> facings)
        {
            this.Weapon = weapon;
            this.Facings = facings;
        }

        internal Weapon Weapon { get => weapon; set => weapon = value; }
        internal List<Facings> Facings { get => facings; set => facings = value; }
    }
}
