using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Generation_Tool
{
    using System.Data.SQLite;
    using System.Data;
    internal class Databases
    {
        public static int GetAmount(string name)
        {
            string connectionString = "Data Source=DM.db";
            SQLiteConnection connection = new(connectionString);
            int count = 0;
            connection.Open();

            string selectQuery = "SELECT * FROM " + name;
            using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    count = dataTable.Rows.Count;
                }
            }

            connection.Close();
            return count;
        }
        private static void CreateShopTables()
        {
            string connectionString = "Data Source=DM.db";
            SQLiteConnection connection = new(connectionString);

            connection.Open();

            string createDbQuery = "CREATE DATABASE IF NOT EXISTS DMGen";
            string createTableQuery = "CREATE TABLE IF NOT EXISTS Shop (ID INTEGER PRIMARY KEY, ItemName TEXT, " +
                "ItemDescription TEXT, ItemPrice TEXT, ItemTheme TEXT, ShopType1 TEXT, ShopType2 TEXT, " +
                "ShopType3 TEXT, ItemType TEXT)";

            using (SQLiteCommand command = new(createDbQuery, connection))
            {
                command.ExecuteNonQuery();
            }
            using (SQLiteCommand command = new(createTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }

            connection.Close();
        }

        public static void AddShopItem(int ID, string Name, string Des, string Price, string Theme, string Type1,
            string Type2, string Type3, string Type4)
        {
            CreateShopTables();
            string connectionString = "Data Source=DM.db";
            SQLiteConnection connection = new(connectionString);

            connection.Open();

            string insertQuery = "INSERT INTO Shop (ID, ItemName, ItemDescription, ItemPrice" +
                "ItemTheme, ShopType1, ShopType2, ShopType3, ItemType) VALUES ('" + ID + "'" +
                "'" + Name + "'" + "'" + Des + "'" + "'" + Price + "'" + "'" + Theme + "'" +
                "'" + Type1 + "'" + "'" + Type2 + "'" + "'" + Type3 + "'" + "'" + Type4 + "')";
            using (SQLiteCommand command = new(insertQuery, connection))
            {
                command.ExecuteNonQuery();
            }

            connection.Close();
        }
        public static int Generate(int Mod)
        {
            Random ran = new();
            return ran.Next(Mod);
        }
    }
}
