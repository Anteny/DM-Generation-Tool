﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace DM_Generation_Tool
{

    internal class Databases
    {
        public static string ShowItems(int mod)
        {
            int count = 0;
            Random ran = new();
            string items = string.Empty;
            string connectionString = "Data Source=DM.db";
            SQLiteConnection connection = new(connectionString);

            connection.Open();
            string stm = "SELECT COUNT(id) FROM Shop";
            using var cmd = new SQLiteCommand(stm, connection);
            using SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                count = int.Parse($"{rdr.GetInt32(0)}");
            }
            for (int inc = 0; inc < mod; ++inc)
            {
                int pull = ran.Next(count);
                int i = 0;
                while (rdr.Read())
                {
                    if (i == pull)
                    {
                        items += $"{rdr.GetInt32(0)} {rdr.GetString(1)} {rdr.GetString(2)} {rdr.GetString(3)} {rdr.GetString(4)} {rdr.GetString(5)}" +
                            $" {rdr.GetString(6)} {rdr.GetString(7)} {rdr.GetString(8)}" + "\n";
                    }
                    ++i;
                }
            }
            connection.Close();
            return items;
        }

        public static string ShowAllItems()
        {
            string items = string.Empty;

            string connectionString = "Data Source=DM.db";
            SQLiteConnection connection = new(connectionString);

            connection.Open();


            string stm = "SELECT * FROM Shop";


            using var cmd = new SQLiteCommand(stm, connection);
            using SQLiteDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                items += $"{rdr.GetInt32(0)} {rdr.GetString(1)} {rdr.GetString(2)} {rdr.GetString(3)} {rdr.GetString(4)} {rdr.GetString(5)}" +
                    $" {rdr.GetString(6)} {rdr.GetString(7)} {rdr.GetString(8)}" + "\n";
            }

            connection.Close();

            return items;
        }
        public static void DropShopTables()
        {
            string connectionString = "Data Source=DM.db";
            SQLiteConnection connection = new(connectionString);

            connection.Open();


            string createTableQuery = "DROP TABLE Shop";

            using (SQLiteCommand command = new(createTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }

            connection.Close();
        }

        public static int GetAmount(string name)
        {
            string connectionString = "Data Source=DM.db";
            SQLiteConnection connection = new(connectionString);
            int count = 0;
            connection.Open();

            string selectQuery = "SELECT * FROM " + name;
            using (SQLiteCommand command = new(selectQuery, connection))
            {
                using SQLiteDataAdapter adapter = new(command);
                DataTable dataTable = new();
                adapter.Fill(dataTable);
                count = dataTable.Rows.Count;
            }

            connection.Close();
            return count;
        }
        public static void CreateShopTables()
        {
            string connectionString = "Data Source=DM.db";
            SQLiteConnection connection = new(connectionString);

            connection.Open();

 
            string createTableQuery = "CREATE TABLE Shop (ID INTEGER PRIMARY KEY, ItemName TEXT, " +
                "ItemDescription TEXT, ItemPrice TEXT, ItemTheme TEXT, ShopType1 TEXT, ShopType2 TEXT, " +
                "ShopType3 TEXT, ItemType TEXT)";

            using (SQLiteCommand command = new(createTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }

            connection.Close();
        }

        public static void AddShopItem(int ID, string Name, string Des, string Price, string Theme, string Type1,
            string Type2, string Type3, string Type4)
        {
            string connectionString = "Data Source=DM.db";
            SQLiteConnection connection = new(connectionString);

            connection.Open();

            string insertQuery = "INSERT INTO Shop (ID, ItemName, ItemDescription, ItemPrice, " +
                "ItemTheme, ShopType1, ShopType2, ShopType3, ItemType) VALUES ('" + ID + "', " +
                "'" + Name + "', " + "'" + Des + "', " + "'" + Price + "', " + "'" + Theme + "', " +
                "'" + Type1 + "', " + "'" + Type2 + "', " + "'" + Type3 + "', " + "'" + Type4 + "')";
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
