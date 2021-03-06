using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using MuskProcessServices.Models;

namespace MuskProcessServices
{
    public partial class ListOfInspections : Form
    {
        public ListOfInspections()
        {
            InitializeComponent();

        }

        private void ListOfInspections_Load(object sender, EventArgs e)
        {
            GetSiteInspectionsFromDB();
            dgvListOfInspections.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PopulateFilterOptionFields();
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            // Fetch data from DB
            GetSiteInspectionsFromDB();
        }
        
        // User must select a row and then click on the "View PDF" button to generate PDF

        private void viewPdfBtn_Click(object sender, EventArgs e)
        {
            // pass siteInspectionID
            PDFReport.generatePDF(1);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void GetSiteInspectionsFromDB(string sqlCondition = null)
        {
            string finalQuery = String.Format("");

            string initialQueryExpression = String.Format(
                "SELECT SiteInspections.SiteInspectionID as ID, SiteInspections.CreatedAt, Sites.Name as Site, SiteInspections.WorkArea, CONCAT(users1.Firstname, ' ', users1.Surname) as Inspector, CONCAT(users2.Firstname, ' ', users2.Surname) as CompletedBy, COUNT(Interventions.InterventionID) as Interventions " +
                "FROM SiteInspections INNER JOIN Sites ON SiteInspections.SiteID=Sites.SiteID " +
                "INNER JOIN Users AS users1 ON SiteInspections.Inspector=users1.UserID " +
                "INNER JOIN Users AS users2 ON SiteInspections.CompletedBy=users2.UserID " +
                "LEFT JOIN Interventions as interventions on interventions.SiteInspectionID=SiteInspections.SiteInspectionID");

            string endOfQuery = String.Format(
                "GROUP BY SiteInspections.SiteInspectionID, SiteInspections.CreatedAt, Sites.Name, SiteInspections.WorkArea, users1.Firstname, users1.Surname, users2.Firstname, users2.Surname " +
                "ORDER BY SiteInspections.SiteInspectionID"
                );





            if (sqlCondition != null)
            {
                finalQuery = String.Join(" ", initialQueryExpression, sqlCondition, endOfQuery);
                
            } else
            {
                finalQuery = String.Join(" ", initialQueryExpression, endOfQuery);
            }

            DataTable result = finalQuery.getDataSetFromDB().Tables[0];
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
        private void PopulateFilterOptionFields()
        {
            // Sites dropdown items
            siteDropdown.DataSource = MuskSite.getAllSites().Tables[0];
            siteDropdown.ValueMember = "SiteID";
            siteDropdown.DisplayMember = "Name";
            siteDropdown.SelectedItem = null;
            siteDropdown.SelectedText = "-- Select --";

            // EnteredBy dropdown items
            enteredByDropdown.DataSource = User.getAllUsers().Tables[0];
            enteredByDropdown.ValueMember = "UserID";
            enteredByDropdown.DisplayMember = "Fullname";
            enteredByDropdown.SelectedItem = null;
            enteredByDropdown.SelectedText = "-- Select --";

            // Months dropdown
            string[] monthNames = DateTimeFormatInfo.CurrentInfo.MonthNames;
            monthNames = monthNames.Where((item, index) => index != monthNames.Length - 1).ToArray();
            monthDropdown.DataSource = monthNames;
            monthDropdown.SelectedItem = null;
            monthDropdown.SelectedText = "-- Select --";
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string sqlCondition = "WHERE";
            List<string> fieldsValues = new List<string>();

            if(siteDropdown.SelectedValue != null)
            {
                fieldsValues.Add($"SiteInspections.SiteID={Convert.ToInt32(siteDropdown.SelectedValue)}");

            }
            if (enteredByDropdown.SelectedValue != null)
            {
                fieldsValues.Add($"SiteInspections.CompletedBy={Convert.ToInt32(enteredByDropdown.SelectedValue)}");

            }

            if (fieldsValues.Count > 0)
            {
                MessageBox.Show(fieldsValues.Count.ToString());
                string combineConditions = String.Join(" AND ", fieldsValues.ToArray());
                sqlCondition = String.Join(" ", sqlCondition, combineConditions);
                GetSiteInspectionsFromDB(sqlCondition);
            } else
            {
                MessageBox.Show("No conditions");
            }
        }
    }
}
