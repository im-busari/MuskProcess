using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuskProcessServices
{
    public partial class NewSiteInspection : Form
    {
        private List<Intervention> interventions = new List<Intervention>(); 
        public NewSiteInspection()
        {
            InitializeComponent();

            // Disable intervention details part from the form, until user creates a site inspection.
            sectionDropdown.Enabled = false;
            countField.Enabled = false;
            commentField.Enabled = false;
            completedCheckBox.Enabled = false;
            actionTakenField.Enabled = false;
            addNewBtn.Enabled = false;
            uploadBtn.Enabled = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            // Get value from form and add them to List<Interventions>
            interventions.Add(new Intervention(sectionDropdown.SelectedIndex,
                Int32.Parse(countField.Text),
                commentField.Text,
                completedCheckBox.Checked,
                actionTakenField.Text)
                );

            // Clear out the form for new interventions to be added
            sectionDropdown.SelectedIndex = 0;
            countField.Text = "";
            commentField.Text = "";
            completedCheckBox.Checked = false;
            actionTakenField.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sectionDropdown.SelectedIndex = 0;

            // get selected item id, defined for testing purposes
            sectionDropdown.SelectedValue = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void section_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SubHeader obj = sectionDropdown.SelectedItem as SubHeader;
            if (obj != null)
                MessageBox.Show(string.Format(".{0} - {1} selected", obj._subHeaderID, obj._subTitle, MessageBoxButtons.OK, MessageBoxIcon.Information));

        }

        private void countField_TextChanged(object sender, EventArgs e)
        {

        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            // add interventions to DB
            // dbConn.saveToDB("INSERT INTO Interventions (SiteInspectionID, SubHeaderID, Count, Comment, Completed, ActionTaken) VALUES (@SiteInspectionID...)", siteInspectionId
            Intervention item = interventions[0];
            
            Intervention.SaveToDB("INSERT INTO Interventions(SiteInspectionID, SubHeaderID, Count, Comment, Completed, ActionTaken) VALUES(@SiteInspectionID, @SubHeaderID, @Count, @Comment, @Completed, @ActionTaken)", item);
            
        }

        private void createSiteInspectionBtn_Click(object sender, EventArgs e)
        {
            // Enable Intervention details part of the form
            sectionDropdown.Enabled = true;
            countField.Enabled = true;
            commentField.Enabled = true;
            completedCheckBox.Enabled = true;
            actionTakenField.Enabled = true;
            addNewBtn.Enabled = true;
            uploadBtn.Enabled = true;

            // Disable Site Inspection details form
            siteDropdown.Enabled = false;
            workAreaField.Enabled = false;
            supervisorDropdown.Enabled = false;
            jobDescriptionField.Enabled = false;
            inspectorDropdown.Enabled = false;
            typeField.Enabled = false;
        }
    }
}
