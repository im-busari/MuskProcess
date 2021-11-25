using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MuskProcessServices
{
    class Intervention
    {
        private int _interventionId { get; set; }
        private int _siteInspectionId { get; set; }
        private int _subHeaderId { get; set; }
        private int _count { get; set; }
        private string _comment { get; set; }
        private bool _completed { get; set; }
        private string _actionTaken { get; set; }

        private DateTime? _updatedAt { get; set; }
        private DateTime? _createdAt { get; set; }

        public Intervention() {}

        public Intervention(int subHeaderId, int count, string comment, bool completed, string actionTaken) {
            _siteInspectionId = 3;
            _subHeaderId = 2;
            _count = count;
            _comment = comment;
            _completed = completed;
            _actionTaken = actionTaken;
        }

        public static void SaveToDB(string sqlQuery, Intervention item)
        {
            using (SqlConnection connToDB = new SqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                // Open connection
                connToDB.Open();

                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connToDB);

                // Set the sqlCommand's properties
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.Parameters.Add(new SqlParameter("SiteInspectionID", item.SiteInspectionID));
                sqlCommand.Parameters.Add(new SqlParameter("SubHeaderID", item.SubHeaderID));
                sqlCommand.Parameters.Add(new SqlParameter("Count", item.Count));
                sqlCommand.Parameters.Add(new SqlParameter("Comment", item.Comment));
                sqlCommand.Parameters.Add(new SqlParameter("Completed", item.Completed));
                sqlCommand.Parameters.Add(new SqlParameter("ActionTaken", item.ActionTaken));

                // execute the command
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Welcome back!");
                MessageBox.Show(item.Count.ToString());
            }
        }

        public int InterventionID
        {
            get { return _interventionId; }
            set { _interventionId = value; }
        }
        public int SiteInspectionID
        {
            get { return _siteInspectionId; }
            set { _siteInspectionId = value; }
        }
        public int SubHeaderID
        {
            get { return _subHeaderId; }
            set { _subHeaderId = value; }
        }
        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        public bool Completed
        {
            get { return _completed; }
            set { _completed = value; }
        }
        public string ActionTaken
        {
            get { return _actionTaken; }
            set { _actionTaken = value; }
        }

    }
}
