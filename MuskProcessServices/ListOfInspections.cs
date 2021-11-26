using System;
using System.Data;
using System.Windows.Forms;

namespace MuskProcessServices
{
    public partial class ListOfInspections : Form
    {
        public ListOfInspections()
        {
            InitializeComponent();

        }
        private void GetSiteInspectionsFromDB()
        {
            string queryExpression = String.Format(
                "SELECT SiteInspections.SiteInspectionID as ID, SiteInspections.CreatedAt, Sites.Name as Site, SiteInspections.WorkArea, CONCAT(users1.Firstname, ' ', users1.Surname) as Inspector, CONCAT(users2.Firstname, ' ', users2.Surname) as CompletedBy, COUNT(Interventions.InterventionID) as Interventions " +
                "FROM SiteInspections INNER JOIN Sites ON SiteInspections.SiteID=Sites.SiteID " +
                "INNER JOIN Users AS users1 ON SiteInspections.Inspector=users1.UserID " +
                "INNER JOIN Users AS users2 ON SiteInspections.CompletedBy=users2.UserID " +
                "LEFT JOIN Interventions as interventions on interventions.SiteInspectionID=SiteInspections.SiteInspectionID " +
                "GROUP BY SiteInspections.SiteInspectionID, SiteInspections.CreatedAt, Sites.Name, SiteInspections.WorkArea, users1.Firstname, users1.Surname, users2.Firstname, users2.Surname " +
                "ORDER BY SiteInspections.SiteInspectionID");

            DataTable result = queryExpression.getDataSetFromDB().Tables[0];
            dgvListOfInspections.DataSource = result;

            // Set sizes of columns
            dgvListOfInspections.Columns[0].Width = 30;
            dgvListOfInspections.Columns[1].Width = 90;
            dgvListOfInspections.Columns[2].Width = 150;
            dgvListOfInspections.Columns[3].Width = 150;
            dgvListOfInspections.Columns[4].Width = 110;
            dgvListOfInspections.Columns[5].Width = 110;
            dgvListOfInspections.Columns[6].Width = 90;
        }

        private void ListOfInspections_Load(object sender, EventArgs e)
        {
            GetSiteInspectionsFromDB();
            dgvListOfInspections.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            // Fetch data from DB
            GetSiteInspectionsFromDB();
        }
        
        // User must select a row and then click on the button to generate PDF

        private void dgvListOfInspections_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show(dgvListOfInspections.CurrentCell.Value.ToString());
        }

        private void viewPdfBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvListOfInspections.SelectedRows)
            {
                MessageBox.Show(row.Cells[1].Value.ToString());
            }
        }
    }
}
