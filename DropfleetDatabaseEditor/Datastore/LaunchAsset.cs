using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Datastore
{
    public class LaunchAsset
    {
        private int assetID;
        private string asset;
        private int amount;

        public LaunchAsset()
        {
        }

        public LaunchAsset(int assetID, string asset, int amount)
        {
            this.AssetID = assetID;
            this.Asset = asset;
            this.amount = amount;
        }

        public int AssetID { get => assetID; set => assetID = value; }
        public string Asset { get => asset; set => asset = value; }
        public int Amount { get => amount; set => amount = value; }
    }
}
