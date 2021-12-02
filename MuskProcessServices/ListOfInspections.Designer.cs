
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
            this.siteDropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enteredByDropdown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.monthDropdown = new System.Windows.Forms.ComboBox();
            this.yearDropdown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.dgvListOfInspections = new System.Windows.Forms.DataGridView();
            this.siteInspectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewPdfBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfInspections)).BeginInit();
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
            // siteDropdown
            // 
            this.siteDropdown.FormattingEnabled = true;
            this.siteDropdown.Location = new System.Drawing.Point(76, 237);
            this.siteDropdown.Name = "siteDropdown";
            this.siteDropdown.Size = new System.Drawing.Size(193, 24);
            this.siteDropdown.TabIndex = 6;
            this.siteDropdown.SelectedIndexChanged += new System.EventHandler(this.siteDropdown_SelectedIndexChanged);
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
            // enteredByDropdown
            // 
            this.enteredByDropdown.FormattingEnabled = true;
            this.enteredByDropdown.Location = new System.Drawing.Point(335, 237);
            this.enteredByDropdown.Name = "enteredByDropdown";
            this.enteredByDropdown.Size = new System.Drawing.Size(193, 24);
            this.enteredByDropdown.TabIndex = 8;
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
            // monthDropdown
            // 
            this.monthDropdown.FormattingEnabled = true;
            this.monthDropdown.Location = new System.Drawing.Point(591, 237);
            this.monthDropdown.Name = "monthDropdown";
            this.monthDropdown.Size = new System.Drawing.Size(112, 24);
            this.monthDropdown.TabIndex = 10;
            // 
            // yearDropdown
            // 
            this.yearDropdown.FormattingEnabled = true;
            this.yearDropdown.Location = new System.Drawing.Point(733, 237);
            this.yearDropdown.Name = "yearDropdown";
            this.yearDropdown.Size = new System.Drawing.Size(72, 24);
            this.yearDropdown.TabIndex = 12;
            this.yearDropdown.SelectedIndexChanged += new System.EventHandler(this.yearDropdown_SelectedIndexChanged);
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
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
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
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
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
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // dgvListOfInspections
            // 
            this.dgvListOfInspections.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvListOfInspections.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListOfInspections.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListOfInspections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListOfInspections.Location = new System.Drawing.Point(81, 335);
            this.dgvListOfInspections.Name = "dgvListOfInspections";
            this.dgvListOfInspections.RowHeadersWidth = 51;
            this.dgvListOfInspections.RowTemplate.Height = 24;
            this.dgvListOfInspections.Size = new System.Drawing.Size(1042, 150);
            this.dgvListOfInspections.TabIndex = 41;
            // 
            // viewPdfBtn
            // 
            this.viewPdfBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.viewPdfBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.viewPdfBtn.Location = new System.Drawing.Point(1154, 352);
            this.viewPdfBtn.Name = "viewPdfBtn";
            this.viewPdfBtn.Size = new System.Drawing.Size(108, 34);
            this.viewPdfBtn.TabIndex = 42;
            this.viewPdfBtn.Text = "View PDF";
            this.viewPdfBtn.UseVisualStyleBackColor = false;
            this.viewPdfBtn.Click += new System.EventHandler(this.viewPdfBtn_Click);
            // 
            // ListOfInspections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 746);
            this.Controls.Add(this.viewPdfBtn);
            this.Controls.Add(this.dgvListOfInspections);
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yearDropdown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthDropdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enteredByDropdown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siteDropdown);
            this.Controls.Add(this.welcomeText);
            this.Name = "ListOfInspections";
            this.Text = "ListOfInspections";
            this.Load += new System.EventHandler(this.ListOfInspections_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfInspections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteInspectionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.ComboBox siteDropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox enteredByDropdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox monthDropdown;
        private System.Windows.Forms.ComboBox yearDropdown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.DataGridView dgvListOfInspections;
        private System.Windows.Forms.BindingSource siteInspectionsBindingSource;
        private System.Windows.Forms.Button viewPdfBtn;
    }
}