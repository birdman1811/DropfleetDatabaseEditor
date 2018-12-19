using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Datastore
{
    class LaunchAsset
    {
        private int assetID;
        private string asset;

        public LaunchAsset()
        {
        }

        public LaunchAsset(int assetID, string asset)
        {
            this.AssetID = assetID;
            this.Asset = asset;
        }

        public int AssetID { get => assetID; set => assetID = value; }
        public string Asset { get => asset; set => asset = value; }
    }
}
