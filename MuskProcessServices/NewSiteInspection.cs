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

            // block right side fields until user fills out the site inspection information (left)

            // once filled out block the left side of the screen 
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
            interventions.Add(new Intervention(sectionField.SelectedIndex,
                Int32.Parse(countField.Text),
                commentField.Text,
                completedCheckBox.Checked,
                actionTakenField.Text)
                );

            // Clear out the form for new interventions to be added
            sectionField.SelectedIndex = 0;
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
            sectionField.SelectedIndex = 0;

            // get selected item id, defined for testing purposes
            sectionField.SelectedValue = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void section_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SubHeader obj = sectionField.SelectedItem as SubHeader;
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
    }
}
