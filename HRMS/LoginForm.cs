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
    public partial class LoginForm : Form
    {
        HRMSdbContext1 context = new HRMSdbContext1();
        MainForm mf;
        public LoginForm(MainForm mf)
        {
            this.mf = mf;
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtusername.Text = txtpassword.Text = "";
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusername.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Enter UserID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtpassword.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Enter Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var user = context.users.FirstOrDefault(u => u.userId == txtusername.Text && u.pass == txtpassword.Text);
            
            if(user==null)
            {
                MetroFramework.MetroMessageBox.Show(this,"Invalid UserID or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if(user.employee.empIsActive.ToUpper()=="No".ToUpper())
            {
                MetroFramework.MetroMessageBox.Show(this, "User is Inactive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(user.employee.usertype.utypeName.ToString()=="admin")
            {
                employee emp = context.employees.FirstOrDefault(ep => ep.empId == user.empId);
                this.mf.userid = emp.empName;
                AdminDashForm adf = new AdminDashForm(emp,this.mf);
                adf.TopLevel = false;
                adf.AutoScroll = true;
                adf.FormBorderStyle = FormBorderStyle.None;
                adf.Dock = DockStyle.Fill;
                this.mf.pnlmain.Controls.Clear();
                this.mf.pnlmain.Controls.Add(adf);
                
                adf.Show();
            }
            else if(user.employee.usertype.utypeName.ToString()=="manager")
            {
                employee emp = context.employees.FirstOrDefault(ep => ep.empId == user.empId);
                ManagerDashForm mdf = new ManagerDashForm(emp,this.mf);
                mdf.TopLevel = false;
                mdf.AutoScroll = true;
                mdf.FormBorderStyle = FormBorderStyle.None;
                mdf.Dock = DockStyle.Fill;
                this.mf.pnlmain.Controls.Clear();
                this.mf.pnlmain.Controls.Add(mdf);
                mdf.Show();

            }
            else
            {
                employee emp = context.employees.FirstOrDefault(ep => ep.empId == user.empId);
                EmployeeDashForm mdf = new EmployeeDashForm(emp, this.mf);
                mdf.TopLevel = false;
                mdf.AutoScroll = true;
                mdf.FormBorderStyle = FormBorderStyle.None;
                mdf.Dock = DockStyle.Fill;
                this.mf.pnlmain.Controls.Clear();
                this.mf.pnlmain.Controls.Add(mdf);
                mdf.Show();
            }
        }

        
    }
}
