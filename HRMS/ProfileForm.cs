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
    public partial class ProfileForm : Form
    {
        HRMSdbContext1 context =new HRMSdbContext1();
        employee emp;
        public ProfileForm(employee emp)
        {
            this.emp = emp;
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            loadDetails(this.emp.empId);
        }
        private void loadDetails(int id)
        {
            btnSave.Hide();
            
            txtId.Text = this.emp.empId.ToString();
            txtName.Text =this.emp.empName;
            txtJDate.Text = this.emp.joiningDate.ToShortDateString().ToString();
            txtGender.Text = this.emp.empGender;
            txtSkills.Text = this.emp.empSkill;
            txtEmail.Text = this.emp.empEmail;
            txtPhone.Text = this.emp.empPhone;
            txtAddress.Text = this.emp.empAddress;
            
            var sal = context.salaries.FirstOrDefault(s => s.empId == emp.empId);
            txtBasic.Text = sal.basic.ToString();
            txtCa.Text = sal.ca.ToString();
            txtHA.Text = sal.ha.ToString();
            txtIsActive.Text = sal.isActive;
            txtDeptName.Text = this.emp.deptName;
            txtDesigName.Text = this.emp.desigName;
            txtUserId.Text = this.emp.userId;
            txtPass.Text = this.emp.pass;
        }

        private void lblChangePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnSave.Show();
            txtPass.ReadOnly = false;
            txtPass.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var em = context.employees.FirstOrDefault(ep => ep.empId == emp.empId);
            user user = new user();
            context.users.Add(user);

            user.empId = em.empId;
            user.pass = txtPass.Text;
            user.userId = em.userId;

            context.SaveChanges();
            MetroFramework.MetroMessageBox.Show(this, "Oparation inserted", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Question);
            loadDetails(em.empId);
        }
    }
}
