using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuskProcessServices
{
    public class DBConnection
    {
        private static DBConnection _instance;

        // The connection string that is set in settings for this project
        private string connectionString;

        private DBConnection()
        {
            connectionString = Properties.Settings.Default.DBConnectionString;
        }

        public static DBConnection getInstanceOfDBConnection()
        {
            if (_instance == null) _instance = new DBConnection();
            return _instance;
        }

        // Generic method to add items to DB, KeyValuePair<string, string> values
        /*public void SaveToDB(string sqlQuery, List<Intervention> interventions)
        {
            using (SqlConnection connToDB = new SqlConnection(connectionString))
            {
                // Open connection
                connToDB.Open();

                foreach(Intervention item in interventions)
                {
                    SqlCommand sqlCommand = new SqlCommand(sqlQuery, connToDB);

                    // Set the sqlCommand's properties
                    sqlCommand.CommandType = CommandType.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("SiteInspectionID", item.SiteInspectionID));
                    sqlCommand.Parameters.Add(new SqlParameter("SubHeaderID", item.SubHeaderID));
                    sqlCommand.Parameters.Add(new SqlParameter("Count", item.Count));
                    sqlCommand.Parameters.Add(new SqlParameter("Comment", item.Comment));
                    sqlCommand.Parameters.Add(new SqlParameter("Completed", item.Completed));
                    sqlCommand.Parameters.Add(new SqlParameter("ActionTaken", item.ActionTaken));
                    sqlCommand.Parameters.Add(new SqlParameter("CreatedAt", new DateTime()));
                    sqlCommand.Parameters.Add(new SqlParameter("UpdatedAt", new DateTime()));

                    // execute the command
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }*/
        public DataSet getDataSet(string sqlQuery)
        {
            DataSet dataSet = new DataSet();

            using (SqlConnection connToDB = new SqlConnection(connectionString))
            {
                connToDB.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connToDB);

                adapter.Fill(dataSet);
            }

            return dataSet;
        }

    }
}
