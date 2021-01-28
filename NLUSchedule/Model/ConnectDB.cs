using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace appTKB
{
    public class ConnectDB
    {


        public static void insertDataFromDatabase(string query)
        {
            string connectionString = "Server=tcp:tkbwinfomapp.database.windows.net,1433;Initial Catalog=TKBwinformApp;Persist Security Info=False;User ID=tkbwinfomapp;Password=baobebong123@#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            connection.Close();
            adapter.Fill(table);

        }

        public static DataTable loadDataFromDatabase(string query)
        {
            string connectionString = "Server=tcp:tkbwinfomapp.database.windows.net,1433;Initial Catalog=TKBwinformApp;Persist Security Info=False;User ID=tkbwinfomapp;Password=baobebong123@#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            connection.Close();
            return table;

        }
        public static string printDataTableToString(DataTable Table)
        {
            string result = "";
            foreach (DataRow dataRow in Table.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    result += item.ToString();
                }
                result += "@\n";
            }
            return result;
        }



        public static bool checkExist(string MS, string tenCot, string tenBang)
        {
            string queryString = "SELECT * FROM " + tenBang + " WHERE " + tenCot + " = " + MS;
            if (loadDataFromDatabase(queryString).Rows.Count != 0)
            {
                return true;
            }

            return false;
        }


        public static bool checkExistForDSSVTable(string maMH, int Thu, int TietBD, int TH)
        {
            string queryString = "SELECT * FROM DSSV WHERE MaMH = '" + maMH + "' AND Thu = " + TH + " AND TietBD = " + TietBD + " AND TH =" + TH;
            if (loadDataFromDatabase(queryString).Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

    }
}

