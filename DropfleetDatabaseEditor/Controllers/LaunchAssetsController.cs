using DropfleetDatabaseEditor.Datastore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Controllers
{
    class LaunchAssetsController
    {
        MySqlConnection connection;
        DatabaseControl dBControl = new DatabaseControl();

        public List<LaunchAsset> GetAllLaunchAssets()
        {
            List<LaunchAsset> launchAssets = new List<LaunchAsset>();
            connection = dBControl.GetConnection();
            connection.Open();
            MySqlDataReader dataReader;

            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM LaunchAssets", connection))
            {
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    LaunchAsset newAsset = new LaunchAsset
                    {
                        AssetID = dataReader.GetInt16(0),
                        Asset = dataReader.GetString(1)
                    };

                    launchAssets.Add(newAsset);
                }
            }

            connection.Close();

            return launchAssets;
        }

        public void InsertLaunchAssetInstance(LaunchAsset asset, int shipID)
        {
            connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO AssetInstance (asset, ship, value) VALUES (@assetID, @shipID. @value)", connection))
            {
                cmd.Parameters.AddWithValue("@assetID", asset.AssetID);
                cmd.Parameters.AddWithValue("@shipID", shipID);
                cmd.Parameters.AddWithValue("@@value", asset.Amount);

                int rows = cmd.ExecuteNonQuery();
            }

            connection.Close();
        }

        public void UpdateLaunchAssetInstance(LaunchAsset asset, int shipID)
        {
            connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("UPDATE AssetInstance SET value = @value WHERE " +
                "asset = @assetID AND ship = @shipID", connection))
            {
                cmd.Parameters.AddWithValue("@assetID", asset.AssetID);
                cmd.Parameters.AddWithValue("@shipID", shipID);
                cmd.Parameters.AddWithValue("@@value", asset.Amount);

                int rows = cmd.ExecuteNonQuery();
            }

            connection.Close();
        }

        public void DeleteLaunchAssetInstance(LaunchAsset asset, int shipID)
        {
            connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM AssetInstance WHERE asset = @assetID AND ship = @shipID AND value = @value", connection))
            {
                cmd.Parameters.AddWithValue("@assetID", asset.AssetID);
                cmd.Parameters.AddWithValue("@shipID", shipID);
                cmd.Parameters.AddWithValue("@@value", asset.Amount);

                int rows = cmd.ExecuteNonQuery();
            }

            connection.Close();
        }
    }
}
