namespace HRMS
{
    partial class SalaryForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.dgvSalaryDetails = new MetroFramework.Controls.MetroGrid();
            this.dgvSalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBasic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIsactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.rbinvalid = new System.Windows.Forms.RadioButton();
            this.rbvalid = new System.Windows.Forms.RadioButton();
            this.dtpsal = new MetroFramework.Controls.MetroDateTime();
            this.txtbasic = new MetroFramework.Controls.MetroTextBox();
            this.txtca = new MetroFramework.Controls.MetroTextBox();
            this.txtempid = new MetroFramework.Controls.MetroTextBox();
            this.txtha = new MetroFramework.Controls.MetroTextBox();
            this.txtid = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryDetails)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1173, 488);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.metroPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroPanel2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(817, 482);
            this.tableLayoutPanel2.TabIndex = 0;
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
            this.metroPanel1.Size = new System.Drawing.Size(811, 44);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRefresh.Location = new System.Drawing.Point(6, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(71, 23);
            this.btnRefresh.TabIndex = 6;
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
            this.txtSearch.Location = new System.Drawing.Point(546, 11);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search Salary ID";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(107, 23);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search Salary ID";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearch.Location = new System.Drawing.Point(659, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.dgvSalaryDetails);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 53);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(811, 426);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // dgvSalaryDetails
            // 
            this.dgvSalaryDetails.AllowUserToAddRows = false;
            this.dgvSalaryDetails.AllowUserToDeleteRows = false;
            this.dgvSalaryDetails.AllowUserToResizeRows = false;
            this.dgvSalaryDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSalaryDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalaryDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSalaryDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalaryDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalaryDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaryDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSalId,
            this.dgvEmpName,
            this.dgvEmpId,
            this.dgvSalDate,
            this.dgvBasic,
            this.dgvCA,
            this.dgvHa,
            this.dgvIsactive});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalaryDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalaryDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalaryDetails.EnableHeadersVisualStyles = false;
            this.dgvSalaryDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSalaryDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSalaryDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvSalaryDetails.Name = "dgvSalaryDetails";
            this.dgvSalaryDetails.ReadOnly = true;
            this.dgvSalaryDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalaryDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalaryDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSalaryDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalaryDetails.Size = new System.Drawing.Size(811, 426);
            this.dgvSalaryDetails.TabIndex = 5;
            this.dgvSalaryDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDesigDetails_CellClick);
            // 
            // dgvSalId
            // 
            this.dgvSalId.DataPropertyName = "salId";
            this.dgvSalId.HeaderText = "Salary ID";
            this.dgvSalId.Name = "dgvSalId";
            this.dgvSalId.ReadOnly = true;
            this.dgvSalId.Width = 70;
            // 
            // dgvEmpName
            // 
            this.dgvEmpName.DataPropertyName = "empName";
            this.dgvEmpName.HeaderText = "Employee Name";
            this.dgvEmpName.Name = "dgvEmpName";
            this.dgvEmpName.ReadOnly = true;
            // 
            // dgvEmpId
            // 
            this.dgvEmpId.DataPropertyName = "empId";
            this.dgvEmpId.HeaderText = "Employee ID";
            this.dgvEmpId.Name = "dgvEmpId";
            this.dgvEmpId.ReadOnly = true;
            this.dgvEmpId.Width = 70;
            // 
            // dgvSalDate
            // 
            this.dgvSalDate.DataPropertyName = "salDate";
            this.dgvSalDate.HeaderText = "Salary Date";
            this.dgvSalDate.Name = "dgvSalDate";
            this.dgvSalDate.ReadOnly = true;
            // 
            // dgvBasic
            // 
            this.dgvBasic.DataPropertyName = "basic";
            this.dgvBasic.HeaderText = "Basic";
            this.dgvBasic.Name = "dgvBasic";
            this.dgvBasic.ReadOnly = true;
            // 
            // dgvCA
            // 
            this.dgvCA.DataPropertyName = "ca";
            this.dgvCA.HeaderText = "CA";
            this.dgvCA.Name = "dgvCA";
            this.dgvCA.ReadOnly = true;
            // 
            // dgvHa
            // 
            this.dgvHa.DataPropertyName = "ha";
            this.dgvHa.HeaderText = "HA";
            this.dgvHa.Name = "dgvHa";
            this.dgvHa.ReadOnly = true;
            // 
            // dgvIsactive
            // 
            this.dgvIsactive.DataPropertyName = "isActive";
            this.dgvIsactive.HeaderText = "IsActive";
            this.dgvIsactive.Name = "dgvIsactive";
            this.dgvIsactive.ReadOnly = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.metroPanel3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(826, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(344, 482);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.label3);
            this.metroPanel3.Controls.Add(this.rbinvalid);
            this.metroPanel3.Controls.Add(this.rbvalid);
            this.metroPanel3.Controls.Add(this.dtpsal);
            this.metroPanel3.Controls.Add(this.txtbasic);
            this.metroPanel3.Controls.Add(this.txtca);
            this.metroPanel3.Controls.Add(this.txtempid);
            this.metroPanel3.Controls.Add(this.txtha);
            this.metroPanel3.Controls.Add(this.txtid);
            this.metroPanel3.Controls.Add(this.label8);
            this.metroPanel3.Controls.Add(this.label7);
            this.metroPanel3.Controls.Add(this.label6);
            this.metroPanel3.Controls.Add(this.label5);
            this.metroPanel3.Controls.Add(this.label4);
            this.metroPanel3.Controls.Add(this.label2);
            this.metroPanel3.Controls.Add(this.btnNew);
            this.metroPanel3.Controls.Add(this.btnSave);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(3, 3);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(338, 476);
            this.metroPanel3.TabIndex = 0;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Salary Status:";
            // 
            // rbinvalid
            // 
            this.rbinvalid.AutoSize = true;
            this.rbinvalid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbinvalid.Location = new System.Drawing.Point(188, 302);
            this.rbinvalid.Name = "rbinvalid";
            this.rbinvalid.Size = new System.Drawing.Size(56, 17);
            this.rbinvalid.TabIndex = 45;
            this.rbinvalid.TabStop = true;
            this.rbinvalid.Text = "Invalid";
            this.rbinvalid.UseVisualStyleBackColor = true;
            // 
            // rbvalid
            // 
            this.rbvalid.AutoSize = true;
            this.rbvalid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbvalid.Location = new System.Drawing.Point(134, 302);
            this.rbvalid.Name = "rbvalid";
            this.rbvalid.Size = new System.Drawing.Size(48, 17);
            this.rbvalid.TabIndex = 44;
            this.rbvalid.TabStop = true;
            this.rbvalid.Text = "Valid";
            this.rbvalid.UseVisualStyleBackColor = true;
            // 
            // dtpsal
            // 
            this.dtpsal.AccessibleName = "";
            this.dtpsal.Location = new System.Drawing.Point(134, 107);
            this.dtpsal.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpsal.Name = "dtpsal";
            this.dtpsal.Size = new System.Drawing.Size(132, 29);
            this.dtpsal.TabIndex = 43;
            // 
            // txtbasic
            // 
            this.txtbasic.AccessibleName = "";
            // 
            // 
            // 
            this.txtbasic.CustomButton.Image = null;
            this.txtbasic.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txtbasic.CustomButton.Name = "";
            this.txtbasic.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbasic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbasic.CustomButton.TabIndex = 1;
            this.txtbasic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbasic.CustomButton.UseSelectable = true;
            this.txtbasic.CustomButton.Visible = false;
            this.txtbasic.Lines = new string[0];
            this.txtbasic.Location = new System.Drawing.Point(134, 145);
            this.txtbasic.MaxLength = 32767;
            this.txtbasic.Name = "txtbasic";
            this.txtbasic.PasswordChar = '\0';
            this.txtbasic.PromptText = "Basic";
            this.txtbasic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbasic.SelectedText = "";
            this.txtbasic.SelectionLength = 0;
            this.txtbasic.SelectionStart = 0;
            this.txtbasic.ShortcutsEnabled = true;
            this.txtbasic.Size = new System.Drawing.Size(132, 23);
            this.txtbasic.TabIndex = 42;
            this.txtbasic.UseSelectable = true;
            this.txtbasic.WaterMark = "Basic";
            this.txtbasic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbasic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtca
            // 
            this.txtca.AccessibleName = "";
            // 
            // 
            // 
            this.txtca.CustomButton.Image = null;
            this.txtca.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txtca.CustomButton.Name = "";
            this.txtca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtca.CustomButton.TabIndex = 1;
            this.txtca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtca.CustomButton.UseSelectable = true;
            this.txtca.CustomButton.Visible = false;
            this.txtca.Lines = new string[0];
            this.txtca.Location = new System.Drawing.Point(134, 184);
            this.txtca.MaxLength = 32767;
            this.txtca.Name = "txtca";
            this.txtca.PasswordChar = '\0';
            this.txtca.PromptText = "CA";
            this.txtca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtca.SelectedText = "";
            this.txtca.SelectionLength = 0;
            this.txtca.SelectionStart = 0;
            this.txtca.ShortcutsEnabled = true;
            this.txtca.Size = new System.Drawing.Size(132, 23);
            this.txtca.TabIndex = 41;
            this.txtca.UseSelectable = true;
            this.txtca.WaterMark = "CA";
            this.txtca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtempid
            // 
            this.txtempid.AccessibleName = "";
            // 
            // 
            // 
            this.txtempid.CustomButton.Image = null;
            this.txtempid.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txtempid.CustomButton.Name = "";
            this.txtempid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtempid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtempid.CustomButton.TabIndex = 1;
            this.txtempid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtempid.CustomButton.UseSelectable = true;
            this.txtempid.CustomButton.Visible = false;
            this.txtempid.Lines = new string[0];
            this.txtempid.Location = new System.Drawing.Point(134, 256);
            this.txtempid.MaxLength = 32767;
            this.txtempid.Name = "txtempid";
            this.txtempid.PasswordChar = '\0';
            this.txtempid.PromptText = "Employee ID";
            this.txtempid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtempid.SelectedText = "";
            this.txtempid.SelectionLength = 0;
            this.txtempid.SelectionStart = 0;
            this.txtempid.ShortcutsEnabled = true;
            this.txtempid.Size = new System.Drawing.Size(132, 23);
            this.txtempid.TabIndex = 40;
            this.txtempid.UseSelectable = true;
            this.txtempid.WaterMark = "Employee ID";
            this.txtempid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtempid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtha
            // 
            this.txtha.AccessibleName = "";
            // 
            // 
            // 
            this.txtha.CustomButton.Image = null;
            this.txtha.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txtha.CustomButton.Name = "";
            this.txtha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtha.CustomButton.TabIndex = 1;
            this.txtha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtha.CustomButton.UseSelectable = true;
            this.txtha.CustomButton.Visible = false;
            this.txtha.Lines = new string[0];
            this.txtha.Location = new System.Drawing.Point(134, 221);
            this.txtha.MaxLength = 32767;
            this.txtha.Name = "txtha";
            this.txtha.PasswordChar = '\0';
            this.txtha.PromptText = "HA";
            this.txtha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtha.SelectedText = "";
            this.txtha.SelectionLength = 0;
            this.txtha.SelectionStart = 0;
            this.txtha.ShortcutsEnabled = true;
            this.txtha.Size = new System.Drawing.Size(132, 23);
            this.txtha.TabIndex = 39;
            this.txtha.UseSelectable = true;
            this.txtha.WaterMark = "HA";
            this.txtha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtid
            // 
            this.txtid.AccessibleName = "";
            // 
            // 
            // 
            this.txtid.CustomButton.Image = null;
            this.txtid.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txtid.CustomButton.Name = "";
            this.txtid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtid.CustomButton.TabIndex = 1;
            this.txtid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtid.CustomButton.UseSelectable = true;
            this.txtid.CustomButton.Visible = false;
            this.txtid.Lines = new string[0];
            this.txtid.Location = new System.Drawing.Point(134, 68);
            this.txtid.MaxLength = 32767;
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.PromptText = "Auto Genarated";
            this.txtid.ReadOnly = true;
            this.txtid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtid.SelectedText = "";
            this.txtid.SelectionLength = 0;
            this.txtid.SelectionStart = 0;
            this.txtid.ShortcutsEnabled = true;
            this.txtid.Size = new System.Drawing.Size(132, 23);
            this.txtid.TabIndex = 38;
            this.txtid.UseSelectable = true;
            this.txtid.WaterMark = "Auto Genarated";
            this.txtid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(89, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(84, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Basic:\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(100, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "CA:\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(99, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "HA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(40, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Employee ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(63, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Salary ID:";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNew.Location = new System.Drawing.Point(123, 11);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(120, 33);
            this.btnNew.TabIndex = 31;
            this.btnNew.Text = "New";
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSave.Location = new System.Drawing.Point(134, 336);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 32);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 488);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SalaryForm";
            this.Text = "SalaryForm";
            this.Load += new System.EventHandler(this.SalaryForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryDetails)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbinvalid;
        private System.Windows.Forms.RadioButton rbvalid;
        private MetroFramework.Controls.MetroDateTime dtpsal;
        private MetroFramework.Controls.MetroTextBox txtbasic;
        private MetroFramework.Controls.MetroTextBox txtca;
        private MetroFramework.Controls.MetroTextBox txtempid;
        private MetroFramework.Controls.MetroTextBox txtha;
        private MetroFramework.Controls.MetroTextBox txtid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroGrid dgvSalaryDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBasic;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIsactive;
    }
}