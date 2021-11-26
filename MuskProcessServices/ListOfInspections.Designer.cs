
namespace MuskProcessServices
{
    partial class ListOfInspections
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.welcomeText = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.dgvListOfInspections = new System.Windows.Forms.DataGridView();
            this.siteInspectionsDS = new MuskProcessServices.SiteInspectionsDS();
            this.siteInspectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siteInspectionsTableAdapter = new MuskProcessServices.SiteInspectionsDSTableAdapters.SiteInspectionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfInspections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteInspectionsDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteInspectionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.Location = new System.Drawing.Point(73, 152);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(135, 17);
            this.welcomeText.TabIndex = 5;
            this.welcomeText.Text = "Welcome, John Doe";
            this.welcomeText.UseMnemonic = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(76, 237);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(78, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Site:";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(337, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Entered by:";
            this.label2.UseMnemonic = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(335, 237);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(193, 24);
            this.comboBox2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(593, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Month:";
            this.label3.UseMnemonic = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(591, 237);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(112, 24);
            this.comboBox3.TabIndex = 10;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(733, 237);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(72, 24);
            this.comboBox4.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(730, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Year:";
            this.label4.UseMnemonic = false;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.searchBtn.Location = new System.Drawing.Point(1154, 227);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(108, 34);
            this.searchBtn.TabIndex = 14;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Coral;
            this.logoutBtn.Location = new System.Drawing.Point(1187, 61);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 34);
            this.logoutBtn.TabIndex = 38;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.backBtn.Location = new System.Drawing.Point(73, 61);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(90, 34);
            this.backBtn.TabIndex = 37;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(540, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(323, 32);
            this.label9.TabIndex = 39;
            this.label9.Text = "List of Site Inspections";
            // 
            // reloadBtn
            // 
            this.reloadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.reloadBtn.Location = new System.Drawing.Point(1154, 291);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(108, 34);
            this.reloadBtn.TabIndex = 40;
            this.reloadBtn.Text = "Reload Data";
            this.reloadBtn.UseVisualStyleBackColor = true;
            // 
            // dgvListOfInspections
            // 
            this.dgvListOfInspections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListOfInspections.Location = new System.Drawing.Point(81, 335);
            this.dgvListOfInspections.Name = "dgvListOfInspections";
            this.dgvListOfInspections.RowHeadersWidth = 51;
            this.dgvListOfInspections.RowTemplate.Height = 24;
            this.dgvListOfInspections.Size = new System.Drawing.Size(240, 150);
            this.dgvListOfInspections.TabIndex = 41;
            // 
            // siteInspectionsDS
            // 
            this.siteInspectionsDS.DataSetName = "SiteInspectionsDS";
            this.siteInspectionsDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siteInspectionsBindingSource
            // 
            this.siteInspectionsBindingSource.DataMember = "SiteInspections";
            this.siteInspectionsBindingSource.DataSource = this.siteInspectionsDS;
            // 
            // siteInspectionsTableAdapter
            // 
            this.siteInspectionsTableAdapter.ClearBeforeFill = true;
            // 
            // ListOfInspections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 746);
            this.Controls.Add(this.dgvListOfInspections);
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.welcomeText);
            this.Name = "ListOfInspections";
            this.Text = "ListOfInspections";
            this.Load += new System.EventHandler(this.ListOfInspections_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfInspections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteInspectionsDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteInspectionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.DataGridView dgvListOfInspections;
        private SiteInspectionsDS siteInspectionsDS;
        private System.Windows.Forms.BindingSource siteInspectionsBindingSource;
        private SiteInspectionsDSTableAdapters.SiteInspectionsTableAdapter siteInspectionsTableAdapter;
    }
}