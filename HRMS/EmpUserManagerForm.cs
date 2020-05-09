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
    public partial class EmpUserManagerForm : Form
    {
        HRMSdbContext1 context = new HRMSdbContext1();
        public EmpUserManagerForm()
        {
            InitializeComponent();
        }
        private void fullrefresh()
        {

            loaddetails();
            loaddetail(-1);
        }
        private void loaddetails(string str = "")
        {
            var emp = context.employees.Where(ep=>ep.usertype.utypeId==3).ToList();
            if (str != "")
            {
                emp = emp.Where(e => e.empId.ToString() == str).ToList();
            }
            dgvempuserDetails.AutoGenerateColumns = false;
            dgvempuserDetails.DataSource = emp.ToList();
            dgvempuserDetails.Refresh();

            if (emp.Count > 0)
            {
                loaddetail(emp.First().empId);
            }
            else
            {
                loaddetail(-1);
            }
        }
        private void loaddetail(int id)
        {
            var emp = context.employees.FirstOrDefault(u => u.empId == id);
            if (emp == null)
            {
                txtId.Text = txtuserId.Text = txtPass.Text = txtSearch.Text = "";
            }
            else
            {
                txtId.Text = emp.empId.ToString(); txtuserId.Text = emp.userId; txtPass.Text = emp.pass;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                return;
            }
            loaddetails(txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fullrefresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = txtuserId.Text = txtPass.Text = txtSearch.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            fullrefresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtId.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Select a Employee", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtuserId.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter a User Id", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter a Password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int n = Int32.Parse(txtId.Text);

            user user = new user();
            context.users.Add(user);

            user.empId = n;
            user.pass = txtPass.Text;
            user.userId = txtuserId.Text;

            context.SaveChanges();
            fullrefresh();

            dgvempuserDetails.ClearSelection();
            for (int i = 0; i < dgvempuserDetails.Rows.Count; i++)
            {
                int a = Int32.Parse(dgvempuserDetails.Rows[i].Cells[0].Value.ToString());
                if (a == n)
                {
                    dgvempuserDetails.Rows[i].Selected = true;
                    loaddetail(a);
                }
            }
            MetroFramework.MetroMessageBox.Show(this, "Oparation inserted", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        private void dgvEmpRolesDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string n = dgvempuserDetails.CurrentRow.Cells[0].Value.ToString();
            loaddetail(Int32.Parse(n));
        }

        

        private void EmpUserManagerForm_Load_1(object sender, EventArgs e)
        {
            fullrefresh();
        }
    }
}
