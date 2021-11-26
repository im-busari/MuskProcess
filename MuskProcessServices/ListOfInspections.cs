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

            string queryExpression = String.Format("SELECT SiteInspections.CreatedAt, Sites.Name, SiteInspections.WorkArea, users1.Firstname as Inspector, users2.Firstname as CompletedBy, COUNT(Interventions.InterventionID) as Interventions " +
                "FROM SiteInspections INNER JOIN Sites ON SiteInspections.SiteID=Sites.SiteID " +
                "INNER JOIN Users AS users1 ON SiteInspections.Inspector=users1.UserID " +
                "INNER JOIN Users AS users2 ON SiteInspections.CompletedBy=users2.UserID " +
                "LEFT JOIN Interventions as interventions on interventions.SiteInspectionID=SiteInspections.SiteInspectionID " +
                "GROUP BY SiteInspections.SiteInspectionID, SiteInspections.CreatedAt, Sites.Name, SiteInspections.WorkArea, users1.Firstname, users2.Firstname " +
                "ORDER BY SiteInspections.SiteInspectionID");

            DataTable result = queryExpression.getDataSetFromDB().Tables[0];
            dgvListOfInspections.DataSource = result;
        }

        private void ListOfInspections_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'siteInspectionsDS.SiteInspections' table. You can move, or remove it, as needed.
            this.siteInspectionsTableAdapter.Fill(this.siteInspectionsDS.SiteInspections);

        }
    }
}
