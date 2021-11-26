namespace MuskProcessServices
{
    partial class Menu
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addNewInspectionBtn = new System.Windows.Forms.Button();
            this.viewInspectionBtn = new System.Windows.Forms.Button();
            this.viewMonthlyReportBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(523, 197);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(48, 17);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "MENU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MuskProcessServices.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(396, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // addNewInspectionBtn
            // 
            this.addNewInspectionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewInspectionBtn.Location = new System.Drawing.Point(332, 233);
            this.addNewInspectionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addNewInspectionBtn.Name = "addNewInspectionBtn";
            this.addNewInspectionBtn.Size = new System.Drawing.Size(425, 59);
            this.addNewInspectionBtn.TabIndex = 2;
            this.addNewInspectionBtn.Text = "Add a New Site Inspection Report";
            this.addNewInspectionBtn.UseVisualStyleBackColor = true;
            this.addNewInspectionBtn.Click += new System.EventHandler(this.addNewInspectionBtn_Click);
            // 
            // viewInspectionBtn
            // 
            this.viewInspectionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewInspectionBtn.Location = new System.Drawing.Point(332, 314);
            this.viewInspectionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewInspectionBtn.Name = "viewInspectionBtn";
            this.viewInspectionBtn.Size = new System.Drawing.Size(425, 59);
            this.viewInspectionBtn.TabIndex = 3;
            this.viewInspectionBtn.Text = "View Site Inspection Reports";
            this.viewInspectionBtn.UseVisualStyleBackColor = true;
            this.viewInspectionBtn.Click += new System.EventHandler(this.viewInspectionBtn_Click);
            // 
            // viewMonthlyReportBtn
            // 
            this.viewMonthlyReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMonthlyReportBtn.Location = new System.Drawing.Point(332, 395);
            this.viewMonthlyReportBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewMonthlyReportBtn.Name = "viewMonthlyReportBtn";
            this.viewMonthlyReportBtn.Size = new System.Drawing.Size(425, 59);
            this.viewMonthlyReportBtn.TabIndex = 4;
            this.viewMonthlyReportBtn.Text = "View Monthly Report";
            this.viewMonthlyReportBtn.UseVisualStyleBackColor = true;
            this.viewMonthlyReportBtn.Click += new System.EventHandler(this.viewMonthlyReportBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.viewMonthlyReportBtn);
            this.Controls.Add(this.viewInspectionBtn);
            this.Controls.Add(this.addNewInspectionBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addNewInspectionBtn;
        private System.Windows.Forms.Button viewInspectionBtn;
        private System.Windows.Forms.Button viewMonthlyReportBtn;
    }
}