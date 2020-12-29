using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace ass5webappdesk
{
    public class fillTable
    {
        public static string getWhileLoopData()
        {
            string connectionString = "Server=tcp:ass5bilgi.database.windows.net,1433;Initial Catalog=dbass5bilgi;Persist Security Info=False;User ID=KristynAdmin;Password=xxx;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string htmlStr = "";
            SqlConnection thisConnection = new SqlConnection(connectionString);
            SqlCommand thisCommand = thisConnection.CreateCommand();
            thisCommand.CommandText = "select top 10 CustomerID, Title, FirstName, LastName, EmailAddress from [SalesLT].[Customer]";
            thisConnection.Open();
            SqlDataReader reader = thisCommand.ExecuteReader();

            while (reader.Read())
            {
                int ID = reader.GetInt32(0);
                string Title = reader.GetString(1);
                string FirstName = reader.GetString(2);
                string LastName = reader.GetString(3);
                string EmailAddress = reader.GetString(4);

                htmlStr += "<tr><td>" + ID + "</td><td>" + Title + "</td><td>" + FirstName + "</td><td>" + LastName + "</td><td>" + EmailAddress + "</td></tr>";
            }

            thisConnection.Close();
            return htmlStr;
        }
    }
}
