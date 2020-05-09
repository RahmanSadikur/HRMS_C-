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
    public partial class ManagerDashForm : Form
    {
        HRMSdbContext1 context = new HRMSdbContext1();
        employee emp;
        MainForm mf;
        public ManagerDashForm(employee emp,MainForm mf)
        {
            this.emp = emp;
            this.mf = mf;
            InitializeComponent();
        }

        private void ManagerDashForm_Load(object sender, EventArgs e)
        {
            lblLoginInfo.Text += this.emp.empName;
            lnlLogOut.Hide();
            fullrefresh();
            pnlemployess.Hide();
            pnlProfile.Hide();
            pnlPayslip.Hide();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            pnlemployess.Hide();
            lnlLogOut.Hide();
            pnlProfile.Hide();
            pnlPayslip.Hide();
            ManagerDashForm mdf = new ManagerDashForm(this.emp,this.mf);
            mdf.TopLevel = false;
            mdf.AutoScroll = true;
            mdf.FormBorderStyle = FormBorderStyle.None;
            mdf.Dock = DockStyle.Fill;
            this.pnladminload.Controls.Clear();
            this.pnladminload.Controls.Add(mdf.pnladminload);
            mdf.Show();
        }

        private void btnemployee_Click(object sender, EventArgs e)
        {
            pnlemployess.Show();
            pnlProfile.Hide();
            pnlPayslip.Hide();
            ManagerManageEmpForm mmef = new ManagerManageEmpForm();
            mmef.TopLevel = false;
            mmef.AutoScroll = true;
            mmef.FormBorderStyle = FormBorderStyle.None;
            mmef.Dock = DockStyle.Fill;
            this.pnladminload.Controls.Clear();
            this.pnladminload.Controls.Add(mmef);
            mmef.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            fullrefresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loaddetails(txtSearch.Text);
            lnlLogOut.Hide();
        }
        private void fullrefresh()
        {
            lnlLogOut.Hide();
            loaddetails();
            //loaddetails(-1);
        }
        private void loaddetails(string str = "")
        {
            var employee = context.employees.Where(ep=>ep.usertype.utypeId==3).ToList();
            if (str != "")
            {
                employee = employee.Where(emp => emp.empName.ToUpper().Contains(str.ToUpper())).ToList();
            }
            dgvDetails.AutoGenerateColumns = false;
            dgvDetails.DataSource = employee.ToList();
            dgvDetails.Refresh();
        }

        private void lblLoginInfo_Click(object sender, EventArgs e)
        {
            lnlLogOut.Show();
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

        private void btnemployesInfos_Click(object sender, EventArgs e)
        {
            pnlemployess.Show();
            pnlProfile.Hide();
            pnlPayslip.Hide();
            ManagerManageEmpForm mmef = new ManagerManageEmpForm();
            mmef.TopLevel = false;
            mmef.AutoScroll = true;
            mmef.FormBorderStyle = FormBorderStyle.None;
            mmef.Dock = DockStyle.Fill;
            this.pnladminload.Controls.Clear();
            this.pnladminload.Controls.Add(mmef);
            mmef.Show();
        }

        private void btnemployesRoles_Click(object sender, EventArgs e)
        {
            lnlLogOut.Hide();
            pnlProfile.Hide();
            pnlPayslip.Hide();
            EmployeeRolesMangerForm erf = new EmployeeRolesMangerForm();
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
            pnlProfile.Hide();
            pnlPayslip.Hide();
            EmpUserManagerForm erf = new EmpUserManagerForm();
            erf.TopLevel = false;
            erf.AutoScroll = true;
            erf.FormBorderStyle = FormBorderStyle.None;
            erf.Dock = DockStyle.Fill;
            this.pnladminload.Controls.Clear();
            this.pnladminload.Controls.Add(erf);
            erf.Show();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            lnlLogOut.Hide();
            pnlProfile.Hide();
            pnlemployess.Hide();
            pnlPayslip.Hide();
            ManagerSalaryForm erf = new ManagerSalaryForm();
            erf.TopLevel = false;
            erf.AutoScroll = true;
            erf.FormBorderStyle = FormBorderStyle.None;
            erf.Dock = DockStyle.Fill;
            this.pnladminload.Controls.Clear();
            this.pnladminload.Controls.Add(erf);
            erf.Show();
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

        private void btnPaySlip_Click(object sender, EventArgs e)
        {
            lnlLogOut.Hide();
            pnlemployess.Hide();
            pnlPayslip.Show();
            pnlProfile.Hide();
            pnlPayslip.Location = new System.Drawing.Point(288, 27);
            ManagerPayslipForm sf = new ManagerPayslipForm();
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
            ManagerPayslipForm sf = new ManagerPayslipForm();
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
            ManagerPayslipListForm sf = new ManagerPayslipListForm();
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
