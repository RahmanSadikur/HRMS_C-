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
    public partial class DepartmentForm : Form
    {
        HRMSdbContext1 context = new HRMSdbContext1();
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            this.init();
        }
        private void init()
        {
            loadDetails();
            loaddetail(-1);
            
        }
        private void loadDetails(string src = "")
        {
            var department = context.departments.ToList();

            if (src != "")
            {
                department = department.Where(e => e.deptName.ToLower().Contains(src.ToLower())).ToList();
            }
            dgvDepartmentDetails.AutoGenerateColumns = false;
            dgvDepartmentDetails.DataSource = department.ToList();
            dgvDepartmentDetails.Refresh();
            if (department.Count > 0)
            {
                loaddetail(department.First().deptId);
            }
            else
            {
                loaddetail(-1);
            }

        }
        private void loaddetail(int id)
        {
            var dept = context.departments.FirstOrDefault(e => e.deptId == id);
            if (dept == null)
            {
                txtDeptId.Text = txtdeptName.Text = "";

            }
            else
            {
                txtDeptId.Text = dept.deptId.ToString();
                txtdeptName.Text = dept.deptName.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            this.init();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.loadDetails(txtSearch.Text);
        }

        private void dgvDepartmentDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvDepartmentDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.loaddetail(Int32.Parse(id));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDeptId.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter a Department Id", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id;

            if(Int32.TryParse(txtDeptId.Text,out id))
            {
                var dept=context.departments.FirstOrDefault(d=>d.deptId==id);
                if (dept == null)
                {
                    this.init();
                    return;
                }
                context.departments.Remove(dept);
                context.SaveChanges();
                init();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter Correct Id", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            init();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtdeptName.Text = txtDeptId.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id;
            if (Int32.TryParse(txtDeptId.Text, out id))
            {
                department dept;

                if (txtdeptName.Text == "")

                {
                    MetroFramework.MetroMessageBox.Show(this, "Enter a Name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var d = context.departments.FirstOrDefault(c => c.deptId == id);


                if (d == null)
                {
                    dept = new department();
                    context.departments.Add(dept);
                }
                else
                {

                    dept = context.departments.FirstOrDefault(c => c.deptId == id);
                    if (dept == null)
                    {
                        this.init();
                        return;
                    }

                }
                dept.deptName = txtdeptName.Text;
                dept.deptId = id;
                context.SaveChanges();
                init();
                dgvDepartmentDetails.ClearSelection();
                for (int i = 0; i < dgvDepartmentDetails.Rows.Count; i++)
                {
                    int a = Int32.Parse(dgvDepartmentDetails.Rows[i].Cells[0].Value.ToString());
                    if (a == dept.deptId)
                    {
                        dgvDepartmentDetails.Rows[i].Selected = true;
                        loaddetail(a);
                    }
                }
                MetroFramework.MetroMessageBox.Show(this, "Oparation inserted", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter Correct Id", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
