using System;
using System.Windows.Forms;

namespace MuskProcessServices
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            // Display username of current user
            //MessageBox.Show(AuthState.CurrentUser.Username);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void addNewInspectionBtn_Click(object sender, EventArgs e)
        {
            (new NewSiteInspection()).Show();
        }
        private void viewInspectionBtn_Click(object sender, EventArgs e)
        {
            (new ListOfInspections()).Show();
        }
        private void viewMonthlyReportBtn_Click(object sender, EventArgs e)
        {
            (new Monthly_Inspection_Report()).Show();
        }
    }
}
