using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MuskProcessServices
{
    // Shared methods to use across the application.
    public static class SharedMethods
    {
        public static User _currentUser { get; set; }

        /**
         * Access data related to the currently logged in user. 
         */
        public static User CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; }
        }

        /**
         * A shared metod to use whenever getting data from the Database using SQL string.
         */
        public static DataSet getDataSetFromDB(this String queryExpression)
        {
            DBConnection dbConnection = DBConnection.getInstanceOfDBConnection();
            DataSet dataset = dbConnection.getDataSet(queryExpression);
            return dataset;
        }

        public static void SaveSiteInspectionToDB(string sqlQuery, SiteInspection item)
        {
            using (SqlConnection connToDB = new SqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                // Open connection
                connToDB.Open();

                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connToDB);

                // Set the sqlCommand's properties
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.Parameters.Add(new SqlParameter("SiteID", item.SiteId));
                sqlCommand.Parameters.Add(new SqlParameter("CompletedBy", item.CompletedBy));
                sqlCommand.Parameters.Add(new SqlParameter("Supervisor", item.Supervisor));
                sqlCommand.Parameters.Add(new SqlParameter("Inspector", item.Inspector));
                sqlCommand.Parameters.Add(new SqlParameter("WorkArea", item.WorkArea));
                sqlCommand.Parameters.Add(new SqlParameter("JobDescription", item.JobDescription));
                sqlCommand.Parameters.Add(new SqlParameter("Type", item.Type));
                sqlCommand.Parameters.Add(new SqlParameter("Status", item.Status));

                MessageBox.Show(item.SiteId.ToString());

                // execute the command
                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
