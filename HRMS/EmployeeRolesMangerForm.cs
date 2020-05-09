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
    public partial class EmployeeRolesMangerForm : Form
    {
        HRMSdbContext1 context = new HRMSdbContext1();
        public EmployeeRolesMangerForm()
        {
            InitializeComponent();
        }
        private void EmployessRoles_Load(object sender, EventArgs e)
        {
            fullrefresh();
        }
        private void fullrefresh()
        {

            loaddetails();
            loaddetail(-1);
        }
        private void loaddetails(string str = "")
        {
            var employee = context.employees.Where(ep=>ep.usertype.utypeId==3).ToList();
            if (str != "")
            {
                employee = employee.Where(emp => emp.empName.ToUpper().Contains(str.ToUpper())).ToList();
            }
            dgvEmpRolesDetails.AutoGenerateColumns = false;
            dgvEmpRolesDetails.DataSource = employee.ToList();
            dgvEmpRolesDetails.Refresh();

            if (employee.Count > 0)
            {
                loaddetail(employee.First().empId);
            }
            else
            {
                loaddetail(-1);
            }
        }
        private void loaddetail(int id)
        {
            var employee = context.employees.FirstOrDefault(e => e.empId == id);
            if (employee == null)
            {
                txtId.Text = txtName.Text = txtSearch.Text = "";
                cbbDesignation.SelectedIndex = -1;
                cbbUsertype.SelectedIndex = -1;
                cbbDepartment.SelectedIndex = -1;
            }
            else
            {
                txtId.Text = employee.empId.ToString(); txtName.Text = employee.empName;
                cbbDepartment.DataSource = context.departments.ToList();
                cbbDepartment.DisplayMember = "deptName";
                cbbDepartment.SelectedIndex = cbbDepartment.FindStringExact(employee.deptName.ToString());
                cbbDesignation.DataSource = context.designations.ToList();
                cbbDesignation.DisplayMember = "desigName";
                cbbDesignation.SelectedIndex = cbbDesignation.FindStringExact(employee.desigName.ToString());
                cbbUsertype.DataSource = context.usertypes.Where(ut=>ut.utypeId==3).ToList();
                cbbUsertype.DisplayMember = "utypeName";
                cbbUsertype.SelectedIndex = cbbUsertype.FindStringExact(employee.utypeName.ToString());

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
            txtId.Text = txtName.Text = txtSearch.Text = "";
        }

        private void dgvEmpRolesDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string n = dgvEmpRolesDetails.CurrentRow.Cells[0].Value.ToString();
            loaddetail(Int32.Parse(n));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            loaddetail(-1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtId.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Select a Employee", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbbDepartment.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter Department", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbbDesignation.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter Designaton", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbbUsertype.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter User Type", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int n = Int32.Parse(txtId.Text);
            var employee = context.employees.FirstOrDefault(emp => emp.empId == n);
            var d = context.departments.FirstOrDefault(dp => dp.deptName == cbbDepartment.Text);
            d.employees.Add(employee);
            context.SaveChanges();
            var de = context.designations.FirstOrDefault(des => des.desigName == cbbDesignation.Text);
            de.employees.Add(employee);
            context.SaveChanges();
            var u = context.usertypes.FirstOrDefault(ui => ui.utypeName == cbbUsertype.Text);
            u.employees.Add(employee);
            context.SaveChanges();
            fullrefresh();
            dgvEmpRolesDetails.ClearSelection();
            for (int i = 0; i < dgvEmpRolesDetails.Rows.Count; i++)
            {
                int a = Int32.Parse(dgvEmpRolesDetails.Rows[i].Cells[0].Value.ToString());
                if (a == employee.empId)
                {
                    dgvEmpRolesDetails.Rows[i].Selected = true;
                    loaddetail(n);
                }
            }
            MetroFramework.MetroMessageBox.Show(this, "Oparation inserted", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }

}
