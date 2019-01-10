using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Datastore
{
    public class Ship
    {
        private int shipID;
        private string name;
        private Faction faction;
        private int scan;
        private int sigMin;
        private int sigMax;
        private int thrust;
        private int hull;
        private int aMin;
        private int aMax;
        private int pd;
        private int gMin;
        private int gMax;
        private bool launch;
        private Tonnage tonnage;
        private List<WeaponFacing> weapons;
        private List<ShipRule> special;
        private int points;
        private List<LaunchAsset> launchAssets;

        public Ship()
        {
            Special = new List<ShipRule>();
            weapons = new List<WeaponFacing>();
            launchAssets = new List<LaunchAsset>();
            tonnage = new Tonnage();
        }

        public Ship(int shipID, string name, Faction faction, int scan, int sigMin, int sigMax, int thrust, int hull, int aMin, int aMax, int pd, int gMin, int gMax, bool launch,
            Tonnage tonnage, List<WeaponFacing> weapons, List<ShipRule> special, int points, List<LaunchAsset> launchAssets)
        {
            ShipID = shipID;
            Name = name;
            Faction = faction;
            Scan = scan;
            SigMin = sigMin;
            SigMax = sigMax;
            Thrust = thrust;
            Hull = hull;
            AMin = aMin;
            AMax = aMax;
            Pd = pd;
            GMin = gMin;
            GMax = gMax;
            Launch = launch;
            Tonnage = tonnage;
            Weapons = weapons;
            Special = special;
            Points = points;
            LaunchAssets = launchAssets;
            ShipID = shipID;
            Name = name;
            Scan = scan;
            SigMin = sigMin;
            SigMax = sigMax;
            Thrust = thrust;
            Hull = hull;
            AMin = aMin;
            AMax = aMax;
            Pd = pd;
            GMin = gMin;
            GMax = gMax;
            Launch = launch;
            Points = points;
            Faction = faction;
            Tonnage = tonnage;
            Weapons = weapons;
            Special = special;
            LaunchAssets = launchAssets;
        }

        public int ShipID { get => shipID; set => shipID = value; }
        public string Name { get => name; set => name = value; }
        public int Scan { get => scan; set => scan = value; }
        public int SigMin { get => sigMin; set => sigMin = value; }
        public int SigMax { get => sigMax; set => sigMax = value; }
        public int Thrust { get => thrust; set => thrust = value; }
        public int Hull { get => hull; set => hull = value; }
        public int AMin { get => aMin; set => aMin = value; }
        public int AMax { get => aMax; set => aMax = value; }
        public int Pd { get => pd; set => pd = value; }
        public int GMin { get => gMin; set => gMin = value; }
        public int GMax { get => gMax; set => gMax = value; }
        public bool Launch { get => launch; set => launch = value; }
        public int Points { get => points; set => points = value; }
        internal Faction Faction { get => faction; set => faction = value; }
        internal Tonnage Tonnage { get => tonnage; set => tonnage = value; }
        internal List<WeaponFacing> Weapons { get => weapons; set => weapons = value; }
        internal List<ShipRule> Special { get => special; set => special = value; }
        internal List<LaunchAsset> LaunchAssets { get => launchAssets; set => launchAssets = value; }

        public void AddRule(ShipRule rule)
        {
            Special.Add(rule);
        }

        public void RemoveRule(ShipRule rule)
        {
            Special.Remove(rule);
        }

        public void SetRules(List<ShipRule> rules)
        {
            Special = rules;
        }

        public void AddWeapon(WeaponFacing weapon)
        {
            Weapons.Add(weapon);
        }

        public void RemoveWeapon(WeaponFacing weapon)
        {
            Weapons.Remove(weapon);
        }

        public void AddAsset(LaunchAsset asset)
        {
            LaunchAssets.Add(asset);
        }

        public void DeleteAsset(LaunchAsset asset)
        {
            LaunchAssets.Remove(asset);
        }
    }
}
