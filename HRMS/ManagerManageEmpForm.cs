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
    public partial class ManagerManageEmpForm : Form
    {
        HRMSdbContext1 context = new HRMSdbContext1();
        public ManagerManageEmpForm()
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
            var employee = context.employees.Where(ep => ep.usertype.utypeId==3).ToList();
            if (str != "")
            {
                employee = employee.Where(emp => emp.empName.ToUpper().Contains(str.ToUpper())).ToList();
            }
            dgvDetails.AutoGenerateColumns = false;
            dgvDetails.DataSource = employee.ToList();
            dgvDetails.Refresh();

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
                txtId.Text = txtName.Text = dtpJoiningDate.Text = txtEmail.Text = txtPhone.Text = txtAddress.Text = txtSearch.Text = "";
                rbtnMale.Checked = rbtnFemale.Checked = chkJava.Checked = chkCsharp.Checked = chkAlgo.Checked = rbtnIsActiveYes.Checked = rbtnIsActiveNo.Checked = false;

            }
            else
            {
                txtId.Text = employee.empId.ToString(); txtName.Text = employee.empName; txtEmail.Text = employee.empEmail; txtPhone.Text = employee.empPhone; txtAddress.Text = employee.empAddress;
                rbtnMale.Checked = employee.empGender.ToUpper() == "MALE" ? true : false;
                rbtnFemale.Checked = employee.empGender.ToUpper() == "FEMALE" ? true : false;
                rbtnIsActiveYes.Checked = employee.empIsActive.ToUpper() == "YES" ? true : false;
                rbtnIsActiveNo.Checked = employee.empIsActive.ToUpper() == "NO" ? true : false;
                string[] arr = employee.empSkill.Split(',');
                if (arr.Contains("Java"))
                {
                    chkJava.Checked = true;
                }
                if (arr.Contains("C#"))
                {
                    chkCsharp.Checked = true;
                }
                if (arr.Contains("Algorithm"))
                {
                    chkAlgo.Checked = true;
                }
                dtpJoiningDate.Text = employee.joiningDate.ToShortDateString();

            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                return;
            }
            loaddetails(txtSearch.Text);
            salaryHide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtId.Text = txtName.Text = dtpJoiningDate.Text = txtEmail.Text = txtPhone.Text = txtAddress.Text = "";
            rbtnMale.Checked = rbtnFemale.Checked = chkJava.Checked = chkCsharp.Checked = chkAlgo.Checked = rbtnIsActiveYes.Checked = rbtnIsActiveNo.Checked = false;
            fullrefresh();
            salaryHide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvDetails.ClearSelection();
            txtSearch.Text = txtId.Text = txtName.Text = dtpJoiningDate.Text = txtEmail.Text = txtPhone.Text = txtAddress.Text = txtHa.Text = txtCa.Text = txtBasic.Text = "";
            rbtnValid.Checked = rbtnInvalid.Checked = rbtnMale.Checked = rbtnFemale.Checked = chkJava.Checked = chkCsharp.Checked = chkAlgo.Checked = rbtnIsActiveYes.Checked = rbtnIsActiveNo.Checked = false;

        }

        private void dgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string n = dgvDetails.CurrentRow.Cells[0].Value.ToString();
            loaddetail(Int32.Parse(n));
            salaryHide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter Name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(dtpJoiningDate.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter Date", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rbtnMale.Checked == false && rbtnFemale.Checked == false)
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter Gender", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (chkJava.Checked == false && chkCsharp.Checked == false && chkAlgo.Checked == false)
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter Skills", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter Email", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter Phone", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter Address", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rbtnIsActiveYes.Checked == false && rbtnIsActiveNo.Checked == false)
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter IsActive", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtBasic.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter Basic Salary", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtCa.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter CA", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtHa.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter HA", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rbtnInvalid.Checked == false && rbtnValid.Checked == false)
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter IsActive", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            employee employee;
            if (string.IsNullOrEmpty(txtId.Text))
            {
                employee = new employee();
                context.employees.Add(employee);
            }
            else
            {
                int n = Int32.Parse(txtId.Text);
                employee = context.employees.FirstOrDefault(emp => emp.empId == n);
            }

            employee.empName = txtName.Text;
            employee.joiningDate = Convert.ToDateTime(dtpJoiningDate.Text);
            employee.empGender = rbtnMale.Checked == true ? "Male" : "Female";
            string skill = "";
            if (chkAlgo.Checked)
            {
                skill += string.IsNullOrEmpty(skill) ? "Algorithm" : ",Algorithm";
            }
            if (chkCsharp.Checked)
            {
                skill += string.IsNullOrEmpty(skill) ? "C#" : ",C#";
            }
            if (chkJava.Checked)
            {
                skill += string.IsNullOrEmpty(skill) ? "Java" : ",Java";
            }
            employee.empSkill = skill;
            employee.empEmail = txtEmail.Text;
            employee.empPhone = txtPhone.Text;
            employee.empAddress = txtAddress.Text;
            employee.empIsActive = rbtnIsActiveYes.Checked == true ? "Yes" : "No";
            context.SaveChanges();
            var u = context.usertypes.FirstOrDefault(ui => ui.utypeId ==3);
            u.employees.Add(employee);
            context.SaveChanges();
            salary sal;
            if (string.IsNullOrEmpty(txtId.Text))
            {
                sal = new salary();
                context.salaries.Add(sal);
                sal.empId = employee.empId;
                double b, h, c;
                if (!double.TryParse(txtBasic.Text, out b) || !double.TryParse(txtCa.Text, out c) || !double.TryParse(txtHa.Text, out h))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Enter Correct Format of Basic,CA,HA", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                sal.basic = b;
                sal.ca = c;
                sal.ha = h;
                sal.isActive = rbtnValid.Checked == true ? "valid" : "invalid";
                sal.salDate = dtpJoiningDate.Text;
                context.SaveChanges();
            }
            fullrefresh();
            dgvDetails.ClearSelection();
            for (int i = 0; i < dgvDetails.Rows.Count; i++)
            {
                int n = Int32.Parse(dgvDetails.Rows[i].Cells[0].Value.ToString());
                if (n == employee.empId)
                {
                    dgvDetails.Rows[i].Selected = true;
                    loaddetail(n);
                }
            }
            salaryHide();
            MetroFramework.MetroMessageBox.Show(this, "Oparation inserted", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Question);


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            fullrefresh();
            salaryShow();
        }
        private void salaryHide()
        {
            btnSave.Location = new System.Drawing.Point(63, 359);
            btnClear.Location = new System.Drawing.Point(140, 359);
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();
            txtBasic.Hide();
            txtCa.Hide();
            txtHa.Hide();
            rbtnInvalid.Hide();
            rbtnValid.Hide();

        }
        private void salaryShow()
        {
            btnSave.Location = new System.Drawing.Point(63, 515);
            btnClear.Location = new System.Drawing.Point(140, 515);
            label10.Show();
            label11.Show();
            label12.Show();
            label13.Show();
            label14.Show();
            txtBasic.Show();
            txtCa.Show();
            txtHa.Show();
            rbtnInvalid.Show();
            rbtnValid.Show();
        }

        private void ManagerManageEmpForm_Load(object sender, EventArgs e)
        {
            
                fullrefresh();
                salaryHide();
            
        }
    }
}
