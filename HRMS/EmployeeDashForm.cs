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
    public partial class EmployeeDashForm : Form
    {
        HRMSdbContext1 context = new HRMSdbContext1();
        MainForm mf;
        employee emp;
        public EmployeeDashForm(employee emp,MainForm mf)
        {
            this.mf = mf;
            this.emp = emp;
            
            InitializeComponent();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            lnlLogOut.Hide();
            employee em = context.employees.FirstOrDefault(ep => ep.empId == emp.empId);
            ProfileForm sf = new ProfileForm(em);
            sf.TopLevel = false;
            sf.AutoScroll = true;
            sf.FormBorderStyle = FormBorderStyle.None;
            sf.Dock = DockStyle.Fill;
            this.pnlEmpLoad.Controls.Clear();
            this.pnlEmpLoad.Controls.Add(sf);
            sf.Show();
        }

        private void EmployeeDashForm_Load(object sender, EventArgs e)
        {
            lnlLogOut.Hide();
            employee em = context.employees.FirstOrDefault(ep=>ep.empId==emp.empId);
            ProfileForm sf = new ProfileForm(em);
            sf.TopLevel = false;
            sf.AutoScroll = true;
            sf.FormBorderStyle = FormBorderStyle.None;
            sf.Dock = DockStyle.Fill;
            this.pnlEmpLoad.Controls.Clear();
            this.pnlEmpLoad.Controls.Add(sf);
            sf.Show();
            lblLoginInfo.Text += emp.empName;
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

        private void btnOwnPayslips_Click(object sender, EventArgs e)
        {
            lnlLogOut.Hide();
            ProfilePaySlipForm sf = new ProfilePaySlipForm(this.emp);
            sf.TopLevel = false;
            sf.AutoScroll = true;
            sf.FormBorderStyle = FormBorderStyle.None;
            sf.Dock = DockStyle.Fill;
            this.pnlEmpLoad.Controls.Clear();
            this.pnlEmpLoad.Controls.Add(sf);
            sf.Show();
        }
    }
}
