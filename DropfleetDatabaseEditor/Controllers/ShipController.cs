﻿using DropfleetDatabaseEditor.Datastore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Controllers
{
    class ShipController
    {
        MySqlConnection connection;
        DatabaseControl dBControl = new DatabaseControl();

        public void InsertShip(Ship ship)
        {
            connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Ships " +
                "(name, faction, scan, sigMin, sigMax, thrust, hull, aMin, aMax, pd, gMin, gMax, launch, tonnage, points) VALUES " +
                "(@name, @faction, @scan, @sigMin, @sigMax, @thrust, @hull, @aMin, @aMax, @pd, @gMIn, @gMax, @launch, @tonnage, @points)", connection))
            {
                cmd.Parameters.AddWithValue("@name", ship.Name);
                cmd.Parameters.AddWithValue("@faction", ship.Faction.FactionID);
                cmd.Parameters.AddWithValue("@scan", ship.Scan);
                cmd.Parameters.AddWithValue("@sigMin", ship.SigMin);
                cmd.Parameters.AddWithValue("@sigMax", ship.SigMax);
                cmd.Parameters.AddWithValue("@thrust", ship.Thrust);
                cmd.Parameters.AddWithValue("@hull", ship.Hull);
                cmd.Parameters.AddWithValue("@aMin", ship.AMin);
                cmd.Parameters.AddWithValue("@aMax", ship.AMax);
                cmd.Parameters.AddWithValue("@pd", ship.Pd);
                cmd.Parameters.AddWithValue("@gMin", ship.GMin);
                cmd.Parameters.AddWithValue("@gMax", ship.GMax);
                cmd.Parameters.AddWithValue("@launch", ship.Launch);
                cmd.Parameters.AddWithValue("@tonnage", ship.Tonnage.TonnageID);
                cmd.Parameters.AddWithValue("@points", ship.Points);

                int rows = cmd.ExecuteNonQuery();
            }

            connection.Close();
            
        }

        public int GetShipID(string shipName, int shipPoints)
        {
            connection = dBControl.GetConnection();
            connection.Open();
            MySqlDataReader dataReader;
            int shipID = 0;

            using (MySqlCommand cmd = new MySqlCommand("SELECT shipID FROM Ships WHERE name = @name AND points = @points", connection))
            {
                cmd.Parameters.AddWithValue("@name", shipName);
                cmd.Parameters.AddWithValue("@points", shipPoints);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    shipID = dataReader.GetInt16(0);
                }
            }

            connection.Close();
            return shipID;
        }
    }
}
