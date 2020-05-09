namespace HRMS
{
    partial class EmployeeDashForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEmpLoad = new MetroFramework.Controls.MetroPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lnlLogOut = new System.Windows.Forms.LinkLabel();
            this.lblLoginInfo = new MetroFramework.Controls.MetroLabel();
            this.pnlProfile = new MetroFramework.Controls.MetroPanel();
            this.btnOwnPayslips = new MetroFramework.Controls.MetroButton();
            this.btnInformation = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pnlEmpLoad, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1237, 553);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlEmpLoad
            // 
            this.pnlEmpLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmpLoad.HorizontalScrollbarBarColor = true;
            this.pnlEmpLoad.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlEmpLoad.HorizontalScrollbarSize = 10;
            this.pnlEmpLoad.Location = new System.Drawing.Point(3, 103);
            this.pnlEmpLoad.Name = "pnlEmpLoad";
            this.pnlEmpLoad.Size = new System.Drawing.Size(1231, 447);
            this.pnlEmpLoad.TabIndex = 1;
            this.pnlEmpLoad.VerticalScrollbarBarColor = true;
            this.pnlEmpLoad.VerticalScrollbarHighlightOnWheel = false;
            this.pnlEmpLoad.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroPanel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1231, 94);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 88);
            this.panel2.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(24, 32);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(147, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Employee Panel";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.pnlProfile);
            this.metroPanel1.Controls.Add(this.lnlLogOut);
            this.metroPanel1.Controls.Add(this.lblLoginInfo);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(203, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1025, 88);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lnlLogOut
            // 
            this.lnlLogOut.AutoSize = true;
            this.lnlLogOut.Location = new System.Drawing.Point(936, 51);
            this.lnlLogOut.Name = "lnlLogOut";
            this.lnlLogOut.Size = new System.Drawing.Size(45, 13);
            this.lnlLogOut.TabIndex = 4;
            this.lnlLogOut.TabStop = true;
            this.lnlLogOut.Text = "Log Out";
            this.lnlLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlLogOut_LinkClicked);
            // 
            // lblLoginInfo
            // 
            this.lblLoginInfo.AutoSize = true;
            this.lblLoginInfo.Location = new System.Drawing.Point(875, 32);
            this.lblLoginInfo.Name = "lblLoginInfo";
            this.lblLoginInfo.Size = new System.Drawing.Size(67, 19);
            this.lblLoginInfo.TabIndex = 3;
            this.lblLoginInfo.Text = "Welcome,";
            this.lblLoginInfo.Click += new System.EventHandler(this.lblLoginInfo_Click);
            // 
            // pnlProfile
            // 
            this.pnlProfile.Controls.Add(this.btnOwnPayslips);
            this.pnlProfile.Controls.Add(this.btnInformation);
            this.pnlProfile.HorizontalScrollbarBarColor = true;
            this.pnlProfile.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlProfile.HorizontalScrollbarSize = 10;
            this.pnlProfile.Location = new System.Drawing.Point(204, 16);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(512, 57);
            this.pnlProfile.TabIndex = 6;
            this.pnlProfile.VerticalScrollbarBarColor = true;
            this.pnlProfile.VerticalScrollbarHighlightOnWheel = false;
            this.pnlProfile.VerticalScrollbarSize = 10;
            // 
            // btnOwnPayslips
            // 
            this.btnOwnPayslips.BackColor = System.Drawing.Color.Gray;
            this.btnOwnPayslips.Location = new System.Drawing.Point(200, 3);
            this.btnOwnPayslips.Name = "btnOwnPayslips";
            this.btnOwnPayslips.Size = new System.Drawing.Size(191, 42);
            this.btnOwnPayslips.TabIndex = 7;
            this.btnOwnPayslips.Text = "Own Payslips";
            this.btnOwnPayslips.UseCustomBackColor = true;
            this.btnOwnPayslips.UseSelectable = true;
            this.btnOwnPayslips.Click += new System.EventHandler(this.btnOwnPayslips_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.BackColor = System.Drawing.Color.Gray;
            this.btnInformation.Location = new System.Drawing.Point(3, 3);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(191, 42);
            this.btnInformation.TabIndex = 6;
            this.btnInformation.Text = "Information";
            this.btnInformation.UseCustomBackColor = true;
            this.btnInformation.UseSelectable = true;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // EmployeeDashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 553);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EmployeeDashForm";
            this.Text = "EmployeeDashForm";
            this.Load += new System.EventHandler(this.EmployeeDashForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.pnlProfile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel pnlEmpLoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.LinkLabel lnlLogOut;
        private MetroFramework.Controls.MetroLabel lblLoginInfo;
        private MetroFramework.Controls.MetroPanel pnlProfile;
        private MetroFramework.Controls.MetroButton btnOwnPayslips;
        private MetroFramework.Controls.MetroButton btnInformation;
    }
}