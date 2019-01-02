using DropfleetDatabaseEditor.Datastore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropfleetDatabaseEditor.Controllers
{
    
    class TonnageController
    {
        MySqlConnection connection;
        DatabaseControl dBControl = new DatabaseControl();

        public List<TonnageClass> GetTonnageClasses()
        {
            List<TonnageClass> tonnageClassList = new List<TonnageClass>();

            connection = dBControl.GetConnection();
            connection.Open();
            MySqlDataReader dataReader;

            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM TonnageClass", connection))
            {
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    TonnageClass newClass = new TonnageClass
                    {
                        ClassID = dataReader.GetInt16(0),
                        ClassName = dataReader.GetString(1)
                    };

                    tonnageClassList.Add(newClass);
                }
            }

            connection.Close();

            return tonnageClassList;
        }

        public string GetClassName(int classID)
        {
            string className = "";

            connection = dBControl.GetConnection();
            connection.Open();
            MySqlDataReader dataReader;

            using (MySqlCommand cmd = new MySqlCommand("SELECT class FROM TonnageClass WHERE classID = @classID", connection))
            {

                cmd.Parameters.AddWithValue("@classID", classID);
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    className = dataReader.GetString(0);
                }
            }

            connection.Close();
            return className;
        }

        public void InsertTonnage(Tonnage tonnage)
        {
            connection = dBControl.GetConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Tonnage (tonnage, value, class) VALUES (@tonnage, @value, @class)", connection))
            {
                cmd.Parameters.AddWithValue("@tonnage", tonnage.TonnageName);
                cmd.Parameters.AddWithValue("@value", tonnage.Value);
                cmd.Parameters.AddWithValue("@class", tonnage.TonnageClass.ClassID);

                int rows = cmd.ExecuteNonQuery();
            }
            connection.Close();
        }

        public List<Tonnage> GetAllTonnages()
        {
            List<Tonnage> tonnageList = new List<Tonnage>();
            connection = dBControl.GetConnection();
            connection.Open();
            MySqlDataReader dataReader;

            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Tonnage", connection))
            {
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Tonnage newTonnage = new Tonnage
                    {
                        TonnageID = dataReader.GetInt16(0),
                        TonnageName = dataReader.GetString(1),
                        Value = dataReader.GetUInt16(2),
                        TonnageClass = new TonnageClass
                        {
                            ClassID = dataReader.GetUInt16(3)
                        }
                    };
                    newTonnage.TonnageClass.ClassName = GetClassName(newTonnage.TonnageClass.ClassID);
                    tonnageList.Add(newTonnage);
                }
            }
            connection.Close();            

            return tonnageList;
        }

        public void UpdateTonnage(Tonnage tonnage)
        {
            connection = dBControl.GetConnection();
            connection.Open();
            
            using (MySqlCommand cmd = new MySqlCommand("UPDATE Tonnage SET tonnage = @tonnage, value = @value, class = @classID WHERE" +
                " tonnageID = @tonnageID", connection))
            {
                cmd.Parameters.AddWithValue("@tonnage", tonnage.TonnageName);
                cmd.Parameters.AddWithValue("@value", tonnage.Value);
                cmd.Parameters.AddWithValue("@classID", tonnage.TonnageClass.ClassID);
                cmd.Parameters.AddWithValue("@tonnageID", tonnage.TonnageID);

                int rows = cmd.ExecuteNonQuery();
            }

            connection.Close();
        }


    }
}
