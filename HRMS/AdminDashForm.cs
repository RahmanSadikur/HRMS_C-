using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS
{
    public partial class AdminDashForm : Form
    {
        MainForm mf;
        employee emp;
        HRMSdbContext1 context = new HRMSdbContext1();
        public AdminDashForm(employee emp,MainForm mf)
        {
            this.mf = mf;
            this.emp = emp;
            InitializeComponent();
        }
        private void btndashboard_Click(object sender, EventArgs e)
        {
            pnlemployess.Hide();
            lnlLogOut.Hide();
            pnlPayslip.Hide();
            pnlProfile.Hide();
            AdminDashForm dlf = new AdminDashForm(this.emp,this.mf);
            dlf.TopLevel = false;
            dlf.AutoScroll = true;
            dlf.FormBorderStyle = FormBorderStyle.None;
            dlf.Dock = DockStyle.Fill;
            this.pnladminload.Controls.Clear();
            this.pnladminload.Controls.Add(dlf.pnladminload);
            dlf.Show();
        }

        private void btnemployee_Click(object sender, EventArgs e)
        {
            pnlemployess.Show();
            lnlLogOut.Hide();
            pnlPayslip.Hide();
            pnlProfile.Hide();
            ManageEmployeeForm mef = new ManageEmployeeForm();
            mef.TopLevel = false;
            mef.AutoScroll = true;
            mef.FormBorderStyle = FormBorderStyle.None;
            mef.Dock = DockStyle.Fill;
            this.pnladminload.Controls.Clear();
            this.pnladminload.Controls.Add(mef);
            mef.Show();
        }

        private void AdminDashForm_Load(object sender, EventArgs e)
        {
            lblLoginInfo.Text += this.mf.userid;
            lnlLogOut.Hide();
            fullrefresh();
            pnlPayslip.Hide();
            pnlemployess.Hide();
            pnlProfile.Hide();
        }
        
        private void fullrefresh()
        {
            lnlLogOut.Hide();
            pnlPayslip.Hide();
            loaddetails();
            //loaddetails(-1);
        }
        private void loaddetails(string str = "")
        {
            var employee = context.employees.ToList();
            if (str != "")
            {
                employee = employee.Where(emp => emp.empName.ToUpper().Contains(str.ToUpper())).ToList();
            }
            dgvDetails.AutoGenerateColumns = false;
            dgvDetails.DataSource = employee.ToList();
            dgvDetails.Refresh();
        }

        private void mbtnSearch_Click(object sender, EventArgs e)
        {
            this.loaddetails(txtSearch.Text);
            lnlLogOut.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loaddetails(txtSearch.Text);
            lnlLogOut.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            fullrefresh();
        }

        

        private void btnemployesInfos_Click(object sender, EventArgs e)
        {
            lnlLogOut.Hide();
            pnlPayslip.Hide();
            pnlProfile.Hide();
            ManageEmployeeForm mef = new ManageEmployeeForm();
            mef.TopLevel = false;
            mef.AutoScroll = true;
            mef.FormBorderStyle = FormBorderStyle.None;
            mef.Dock = DockStyle.Fill;
            this.pnladminload.Controls.Clear();
            this.pnladminload.Controls.Add(mef);
            mef.Show();
        }

        private void btnemployesRoles_Click(object sender, EventArgs e)
        {
            lnlLogOut.Hide();
            pnlPayslip.Hide();
            pnlProfile.Hide();
            EmployessRoles erf = new EmployessRoles();
            erf.TopLevel = false;
            erf.AutoScroll = true;
            erf.FormBorderStyle = FormBorderStyle.None;
            erf.Dock = DockStyle.Fill;
            this.pnladminload.Controls.Clear();
            this.pnladminload.Controls.Add(erf);
            erf.Show();

        }

        private void btnempuser_Click(object sender, EventArgs e)
        {
            lnlLogOut.Hide();
            pnlPayslip.Hide();
            pnlProfile.Hide();
            EmployeeUserInfo euf = new EmployeeUserInfo();
            euf.TopLevel = false;
            euf.AutoScroll = true;
            euf.FormBorderStyle = FormBorderStyle.None;
            euf.Dock = DockStyle.Fill;
            this.pnladminload.Controls.Clear();
            this.pnladminload.Controls.Add(euf);
            euf.Show();

        }

        private void btndept_Click(object sender, EventArgs e)
        {
            lnlLogOut.Hide();
            pnlemployess.Hide();
            pnlPayslip.Hide();
            pnlProfile.Hide();
            DepartmentForm df = new DepartmentForm();
            df.TopLevel = false;
            df.AutoScroll = true;
            df.FormBorderStyle = FormBorderStyle.None;
            df.Dock = DockStyle.Fill;
            this.pnladminload.Controls.Clear();
            this.pnladminload.Controls.Add(df);
            df.Show();
        }

        private void btndesignation_Click(object sender, EventArgs e)
        {
            lnlLogOut.Hide();
            pnlemployess.Hide();
            pnlPayslip.Hide();
            pnlProfile.Hide();
            DesignationForm dg = new DesignationForm();
            dg.TopLevel = false;
            dg.AutoScroll = true;
            dg.FormBorderStyle = FormBorderStyle.None;
            dg.Dock = DockStyle.Fill;
            this.pnladminload.Controls.Clear();
            this.pnladminload.Controls.Add(dg);
            dg.Show();
        }

        

        private void lblLoginInfo_Click(object sender, EventArgs e)
        {
            lnlLogOut.Show();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            lnlLogOut.Hide();
            pnlemployess.Hide();
            pnlPayslip.Hide();
            pnlProfile.Hide();
            SalaryForm sf = new SalaryForm();
            sf.TopLevel = false;
            sf.AutoScroll = true;
            sf.FormBorderStyle = FormBorderStyle.None;
            sf.Dock = DockStyle.Fill;
            this.pnladminload.Controls.Clear();
            this.pnladminload.Controls.Add(sf);
            sf.Show();
        }

        private void lnlLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.mf.userid = "";
            LoginForm lg = new LoginForm(this.mf);
            lg.TopLevel = false;
            lg.AutoScroll = true;
            lg.FormBorderStyle = FormBorderStyle.None;
            lg.Dock = DockStyle.Fill;
            this.mf.pnlmain.Controls.Clear();
            this.mf.pnlmain.Controls.Add(lg);
            lg.Show();
        }

        private void btnpayRoll_Click(object sender, EventArgs e)
        {
            lnlLogOut.Hide();
            pnlemployess.Hide();
            pnlPayslip.Hide();
            pnlProfile.Hide();
            AdminPayRollForm sf = new AdminPayRollForm();
            sf.TopLevel = false;
            sf.AutoScroll = true;
            sf.FormBorderStyle = FormBorderStyle.None;
            sf.Dock = DockStyle.Fill;
            this.pnladminload.Controls.Clear();
            this.pnladminload.Controls.Add(sf);
            sf.Show();
        }

        private void btnPaySlip_Click(object sender, EventArgs e)
        {
            lnlLogOut.Hide();
            pnlemployess.Hide();
            pnlPayslip.Show();
            pnlProfile.Hide();
            pnlPayslip.Location = new System.Drawing.Point(288, 27);
            payslipForm sf = new payslipForm();
            sf.TopLevel = false;
            sf.AutoScroll = true;
            sf.FormBorderStyle = FormBorderStyle.None;
            sf.Dock = DockStyle.Fill;
            this.pnladminload.Controls.Clear();
            this.pnladminload.Controls.Add(sf);
            sf.Show();
        }

        private void btnPaySlipGenarate_Click(object sender, EventArgs e)
        {
            lnlLogOut.Hide();
            pnlemployess.Hide();
            pnlPayslip.Show();
            pnlProfile.Hide();
            pnlPayslip.Location = new System.Drawing.Point(288, 27);
            payslipForm sf = new payslipForm();
            sf.TopLevel = false;
            sf.AutoScroll = true;
            sf.FormBorderStyle = FormBorderStyle.None;
            sf.Dock = DockStyle.Fill;
            this.pnladminload.Controls.Clear();
            this.pnladminload.Controls.Add(sf);
            sf.Show();

        }

        private void btnPaySlipList_Click(object sender, EventArgs e)
        {
            lnlLogOut.Hide();
            pnlemployess.Hide();
            pnlPayslip.Show();
            pnlProfile.Hide();
            pnlPayslip.Location = new System.Drawing.Point(288, 27);
            payslipListForm sf = new payslipListForm();
            sf.TopLevel = false;
            sf.AutoScroll = true;
            sf.FormBorderStyle = FormBorderStyle.None;
            sf.Dock = DockStyle.Fill;
            this.pnladminload.Controls.Clear();
            this.pnladminload.Controls.Add(sf);
            sf.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            lnlLogOut.Hide();
            pnlemployess.Hide();
            pnlPayslip.Hide();
            pnlProfile.Show();
            pnlProfile.Location = new System.Drawing.Point(288, 27);
            ProfileForm sf = new ProfileForm(this.emp);
            sf.TopLevel = false;
            sf.AutoScroll = true;
            sf.FormBorderStyle = FormBorderStyle.None;
            sf.Dock = DockStyle.Fill;
            this.pnladminload.Controls.Clear();
            this.pnladminload.Controls.Add(sf);
            sf.Show();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            lnlLogOut.Hide();
            pnlemployess.Hide();
            pnlPayslip.Hide();
            pnlProfile.Show();
            pnlProfile.Location = new System.Drawing.Point(288, 27);
            ProfileForm sf = new ProfileForm(this.emp);
            sf.TopLevel = false;
            sf.AutoScroll = true;
            sf.FormBorderStyle = FormBorderStyle.None;
            sf.Dock = DockStyle.Fill;
            this.pnladminload.Controls.Clear();
            this.pnladminload.Controls.Add(sf);
            sf.Show();
        }

        private void btnOwnPayslips_Click(object sender, EventArgs e)
        {
            lnlLogOut.Hide();
            pnlemployess.Hide();
            pnlPayslip.Hide();
            pnlProfile.Show();
            pnlProfile.Location = new System.Drawing.Point(288, 27);
            ProfilePaySlipForm sf = new ProfilePaySlipForm(this.emp);
            sf.TopLevel = false;
            sf.AutoScroll = true;
            sf.FormBorderStyle = FormBorderStyle.None;
            sf.Dock = DockStyle.Fill;
            this.pnladminload.Controls.Clear();
            this.pnladminload.Controls.Add(sf);
            sf.Show();

        }
    }
}
