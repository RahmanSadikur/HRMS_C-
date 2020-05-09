namespace HRMS
{
    partial class ManagerDashForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlPayslip = new MetroFramework.Controls.MetroPanel();
            this.btnPaySlipList = new MetroFramework.Controls.MetroButton();
            this.btnPaySlipGenarate = new MetroFramework.Controls.MetroButton();
            this.pnlProfile = new MetroFramework.Controls.MetroPanel();
            this.btnOwnPayslips = new MetroFramework.Controls.MetroButton();
            this.btnInformation = new MetroFramework.Controls.MetroButton();
            this.lnlLogOut = new System.Windows.Forms.LinkLabel();
            this.lblLoginInfo = new MetroFramework.Controls.MetroLabel();
            this.pnlemployess = new MetroFramework.Controls.MetroPanel();
            this.btnempuser = new MetroFramework.Controls.MetroButton();
            this.btnemployesRoles = new MetroFramework.Controls.MetroButton();
            this.btnemployesInfos = new MetroFramework.Controls.MetroButton();
            this.pnladminload = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.dgvDetails = new MetroFramework.Controls.MetroGrid();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDesignationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvJoiningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSkills = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmpIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnProfile = new MetroFramework.Controls.MetroButton();
            this.btnSalary = new MetroFramework.Controls.MetroButton();
            this.btnPaySlip = new MetroFramework.Controls.MetroButton();
            this.btndashboard = new MetroFramework.Controls.MetroButton();
            this.btnemployee = new MetroFramework.Controls.MetroButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPayslip.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            this.pnlemployess.SuspendLayout();
            this.pnladminload.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnladminload, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1285, 548);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.pnlPayslip);
            this.panel1.Controls.Add(this.pnlProfile);
            this.panel1.Controls.Add(this.lnlLogOut);
            this.panel1.Controls.Add(this.lblLoginInfo);
            this.panel1.Controls.Add(this.pnlemployess);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(203, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 94);
            this.panel1.TabIndex = 5;
            // 
            // pnlPayslip
            // 
            this.pnlPayslip.Controls.Add(this.btnPaySlipList);
            this.pnlPayslip.Controls.Add(this.btnPaySlipGenarate);
            this.pnlPayslip.HorizontalScrollbarBarColor = true;
            this.pnlPayslip.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlPayslip.HorizontalScrollbarSize = 10;
            this.pnlPayslip.Location = new System.Drawing.Point(476, 0);
            this.pnlPayslip.Name = "pnlPayslip";
            this.pnlPayslip.Size = new System.Drawing.Size(407, 57);
            this.pnlPayslip.TabIndex = 7;
            this.pnlPayslip.VerticalScrollbarBarColor = true;
            this.pnlPayslip.VerticalScrollbarHighlightOnWheel = false;
            this.pnlPayslip.VerticalScrollbarSize = 10;
            // 
            // btnPaySlipList
            // 
            this.btnPaySlipList.BackColor = System.Drawing.Color.Gray;
            this.btnPaySlipList.Location = new System.Drawing.Point(200, 3);
            this.btnPaySlipList.Name = "btnPaySlipList";
            this.btnPaySlipList.Size = new System.Drawing.Size(191, 42);
            this.btnPaySlipList.TabIndex = 7;
            this.btnPaySlipList.Text = "PaySlip List";
            this.btnPaySlipList.UseCustomBackColor = true;
            this.btnPaySlipList.UseSelectable = true;
            this.btnPaySlipList.Click += new System.EventHandler(this.btnPaySlipList_Click);
            // 
            // btnPaySlipGenarate
            // 
            this.btnPaySlipGenarate.BackColor = System.Drawing.Color.Gray;
            this.btnPaySlipGenarate.Location = new System.Drawing.Point(3, 3);
            this.btnPaySlipGenarate.Name = "btnPaySlipGenarate";
            this.btnPaySlipGenarate.Size = new System.Drawing.Size(191, 42);
            this.btnPaySlipGenarate.TabIndex = 6;
            this.btnPaySlipGenarate.Text = "PaySlip Genarate";
            this.btnPaySlipGenarate.UseCustomBackColor = true;
            this.btnPaySlipGenarate.UseSelectable = true;
            this.btnPaySlipGenarate.Click += new System.EventHandler(this.btnPaySlipGenarate_Click);
            // 
            // pnlProfile
            // 
            this.pnlProfile.Controls.Add(this.btnOwnPayslips);
            this.pnlProfile.Controls.Add(this.btnInformation);
            this.pnlProfile.HorizontalScrollbarBarColor = true;
            this.pnlProfile.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlProfile.HorizontalScrollbarSize = 10;
            this.pnlProfile.Location = new System.Drawing.Point(41, 9);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(411, 48);
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
            // lnlLogOut
            // 
            this.lnlLogOut.AutoSize = true;
            this.lnlLogOut.Location = new System.Drawing.Point(950, 46);
            this.lnlLogOut.Name = "lnlLogOut";
            this.lnlLogOut.Size = new System.Drawing.Size(45, 13);
            this.lnlLogOut.TabIndex = 2;
            this.lnlLogOut.TabStop = true;
            this.lnlLogOut.Text = "Log Out";
            this.lnlLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlLogOut_LinkClicked);
            // 
            // lblLoginInfo
            // 
            this.lblLoginInfo.AutoSize = true;
            this.lblLoginInfo.Location = new System.Drawing.Point(889, 27);
            this.lblLoginInfo.Name = "lblLoginInfo";
            this.lblLoginInfo.Size = new System.Drawing.Size(67, 19);
            this.lblLoginInfo.TabIndex = 1;
            this.lblLoginInfo.Text = "Welcome,";
            this.lblLoginInfo.Click += new System.EventHandler(this.lblLoginInfo_Click);
            // 
            // pnlemployess
            // 
            this.pnlemployess.Controls.Add(this.btnempuser);
            this.pnlemployess.Controls.Add(this.btnemployesRoles);
            this.pnlemployess.Controls.Add(this.btnemployesInfos);
            this.pnlemployess.HorizontalScrollbarBarColor = true;
            this.pnlemployess.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlemployess.HorizontalScrollbarSize = 10;
            this.pnlemployess.Location = new System.Drawing.Point(179, 27);
            this.pnlemployess.Name = "pnlemployess";
            this.pnlemployess.Size = new System.Drawing.Size(597, 43);
            this.pnlemployess.TabIndex = 0;
            this.pnlemployess.VerticalScrollbarBarColor = true;
            this.pnlemployess.VerticalScrollbarHighlightOnWheel = false;
            this.pnlemployess.VerticalScrollbarSize = 10;
            // 
            // btnempuser
            // 
            this.btnempuser.BackColor = System.Drawing.Color.Gray;
            this.btnempuser.Location = new System.Drawing.Point(397, 3);
            this.btnempuser.Name = "btnempuser";
            this.btnempuser.Size = new System.Drawing.Size(191, 37);
            this.btnempuser.TabIndex = 3;
            this.btnempuser.Text = "Employee UserInfo";
            this.btnempuser.UseCustomBackColor = true;
            this.btnempuser.UseSelectable = true;
            this.btnempuser.Click += new System.EventHandler(this.btnempuser_Click);
            // 
            // btnemployesRoles
            // 
            this.btnemployesRoles.BackColor = System.Drawing.Color.Gray;
            this.btnemployesRoles.Location = new System.Drawing.Point(199, 3);
            this.btnemployesRoles.Name = "btnemployesRoles";
            this.btnemployesRoles.Size = new System.Drawing.Size(191, 37);
            this.btnemployesRoles.TabIndex = 3;
            this.btnemployesRoles.Text = "Employees Roles";
            this.btnemployesRoles.UseCustomBackColor = true;
            this.btnemployesRoles.UseSelectable = true;
            this.btnemployesRoles.Click += new System.EventHandler(this.btnemployesRoles_Click);
            // 
            // btnemployesInfos
            // 
            this.btnemployesInfos.BackColor = System.Drawing.Color.Gray;
            this.btnemployesInfos.Location = new System.Drawing.Point(2, 3);
            this.btnemployesInfos.Name = "btnemployesInfos";
            this.btnemployesInfos.Size = new System.Drawing.Size(191, 37);
            this.btnemployesInfos.TabIndex = 2;
            this.btnemployesInfos.Text = "Employees Infos";
            this.btnemployesInfos.UseCustomBackColor = true;
            this.btnemployesInfos.UseSelectable = true;
            this.btnemployesInfos.Click += new System.EventHandler(this.btnemployesInfos_Click);
            // 
            // pnladminload
            // 
            this.pnladminload.BackColor = System.Drawing.Color.White;
            this.pnladminload.CausesValidation = false;
            this.pnladminload.Controls.Add(this.tableLayoutPanel2);
            this.pnladminload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnladminload.Location = new System.Drawing.Point(203, 103);
            this.pnladminload.Name = "pnladminload";
            this.pnladminload.Size = new System.Drawing.Size(1079, 442);
            this.pnladminload.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.metroPanel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.metroPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1079, 442);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.dgvDetails);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 53);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1073, 386);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.AllowUserToResizeRows = false;
            this.dgvDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvName,
            this.dgvDesignationName,
            this.dgvDept,
            this.dgvJoiningDate,
            this.dgvSkills,
            this.dgvAddress,
            this.dgvEmail,
            this.dgvPhone,
            this.dgvEmpIsActive});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.EnableHeadersVisualStyles = false;
            this.dgvDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.Size = new System.Drawing.Size(1073, 386);
            this.dgvDetails.TabIndex = 2;
            // 
            // dgvID
            // 
            this.dgvID.DataPropertyName = "empId";
            this.dgvID.HeaderText = "ID";
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            // 
            // dgvName
            // 
            this.dgvName.DataPropertyName = "empName";
            this.dgvName.HeaderText = "Name";
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvDesignationName
            // 
            this.dgvDesignationName.DataPropertyName = "desigName";
            this.dgvDesignationName.HeaderText = "Designation";
            this.dgvDesignationName.Name = "dgvDesignationName";
            this.dgvDesignationName.ReadOnly = true;
            // 
            // dgvDept
            // 
            this.dgvDept.DataPropertyName = "deptName";
            this.dgvDept.HeaderText = "Department";
            this.dgvDept.Name = "dgvDept";
            this.dgvDept.ReadOnly = true;
            // 
            // dgvJoiningDate
            // 
            this.dgvJoiningDate.DataPropertyName = "joiningDate";
            this.dgvJoiningDate.HeaderText = "Joining Date";
            this.dgvJoiningDate.Name = "dgvJoiningDate";
            this.dgvJoiningDate.ReadOnly = true;
            // 
            // dgvSkills
            // 
            this.dgvSkills.DataPropertyName = "empSkill";
            this.dgvSkills.HeaderText = "Skills";
            this.dgvSkills.Name = "dgvSkills";
            this.dgvSkills.ReadOnly = true;
            // 
            // dgvAddress
            // 
            this.dgvAddress.DataPropertyName = "empAddress";
            this.dgvAddress.HeaderText = "Address";
            this.dgvAddress.Name = "dgvAddress";
            this.dgvAddress.ReadOnly = true;
            // 
            // dgvEmail
            // 
            this.dgvEmail.DataPropertyName = "empEmail";
            this.dgvEmail.HeaderText = "Email";
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.ReadOnly = true;
            // 
            // dgvPhone
            // 
            this.dgvPhone.DataPropertyName = "empPhone";
            this.dgvPhone.HeaderText = "Phone";
            this.dgvPhone.Name = "dgvPhone";
            this.dgvPhone.ReadOnly = true;
            // 
            // dgvEmpIsActive
            // 
            this.dgvEmpIsActive.DataPropertyName = "empIsActive";
            this.dgvEmpIsActive.HeaderText = "IsActive";
            this.dgvEmpIsActive.Name = "dgvEmpIsActive";
            this.dgvEmpIsActive.ReadOnly = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnRefresh);
            this.metroPanel1.Controls.Add(this.txtSearch);
            this.metroPanel1.Controls.Add(this.btnSearch);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1073, 44);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRefresh.Location = new System.Drawing.Point(3, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(71, 23);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(837, 10);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search Name";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(107, 23);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search Name";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearch.Location = new System.Drawing.Point(950, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.btnProfile);
            this.panel3.Controls.Add(this.btnSalary);
            this.panel3.Controls.Add(this.btnPaySlip);
            this.panel3.Controls.Add(this.btndashboard);
            this.panel3.Controls.Add(this.btnemployee);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 442);
            this.panel3.TabIndex = 3;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Gray;
            this.btnProfile.Location = new System.Drawing.Point(1, 42);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(191, 37);
            this.btnProfile.TabIndex = 9;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseCustomBackColor = true;
            this.btnProfile.UseSelectable = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.BackColor = System.Drawing.Color.Gray;
            this.btnSalary.Location = new System.Drawing.Point(1, 126);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(191, 37);
            this.btnSalary.TabIndex = 7;
            this.btnSalary.Text = "Salary";
            this.btnSalary.UseCustomBackColor = true;
            this.btnSalary.UseSelectable = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnPaySlip
            // 
            this.btnPaySlip.BackColor = System.Drawing.Color.Gray;
            this.btnPaySlip.Location = new System.Drawing.Point(1, 169);
            this.btnPaySlip.Name = "btnPaySlip";
            this.btnPaySlip.Size = new System.Drawing.Size(191, 37);
            this.btnPaySlip.TabIndex = 5;
            this.btnPaySlip.Text = "PaySlip";
            this.btnPaySlip.UseCustomBackColor = true;
            this.btnPaySlip.UseSelectable = true;
            this.btnPaySlip.Click += new System.EventHandler(this.btnPaySlip_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.BackColor = System.Drawing.Color.Gray;
            this.btndashboard.Location = new System.Drawing.Point(1, 1);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(191, 37);
            this.btndashboard.TabIndex = 3;
            this.btndashboard.Text = "DashBoard";
            this.btndashboard.UseCustomBackColor = true;
            this.btndashboard.UseSelectable = true;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // btnemployee
            // 
            this.btnemployee.BackColor = System.Drawing.Color.Gray;
            this.btnemployee.Location = new System.Drawing.Point(1, 83);
            this.btnemployee.Name = "btnemployee";
            this.btnemployee.Size = new System.Drawing.Size(191, 37);
            this.btnemployee.TabIndex = 0;
            this.btnemployee.Text = "Employees";
            this.btnemployee.UseCustomBackColor = true;
            this.btnemployee.UseSelectable = true;
            this.btnemployee.Click += new System.EventHandler(this.btnemployee_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 94);
            this.panel2.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(25, 34);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(142, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Manager Panel";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // ManagerDashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 548);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManagerDashForm";
            this.Text = "ManagerDashForm";
            this.Load += new System.EventHandler(this.ManagerDashForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPayslip.ResumeLayout(false);
            this.pnlProfile.ResumeLayout(false);
            this.pnlemployess.ResumeLayout(false);
            this.pnladminload.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lnlLogOut;
        private MetroFramework.Controls.MetroLabel lblLoginInfo;
        private MetroFramework.Controls.MetroPanel pnlemployess;
        private MetroFramework.Controls.MetroButton btnempuser;
        private MetroFramework.Controls.MetroButton btnemployesRoles;
        private MetroFramework.Controls.MetroButton btnemployesInfos;
        private System.Windows.Forms.Panel pnladminload;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid dgvDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDesignationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvJoiningDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSkills;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmpIsActive;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnSearch;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroButton btnSalary;
        private MetroFramework.Controls.MetroButton btnPaySlip;
        private MetroFramework.Controls.MetroButton btndashboard;
        private MetroFramework.Controls.MetroButton btnemployee;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel pnlProfile;
        private MetroFramework.Controls.MetroButton btnOwnPayslips;
        private MetroFramework.Controls.MetroButton btnInformation;
        private MetroFramework.Controls.MetroButton btnProfile;
        private MetroFramework.Controls.MetroPanel pnlPayslip;
        private MetroFramework.Controls.MetroButton btnPaySlipList;
        private MetroFramework.Controls.MetroButton btnPaySlipGenarate;
    }
}