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
    public partial class SalaryForm : Form
    {
        HRMSdbContext1 context = new HRMSdbContext1();
        public SalaryForm()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.init();
        }

        private void dgvDesigDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvSalaryDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.loaddetail(Int32.Parse(id));
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.loaddetail(-1);
            dgvSalaryDetails.ClearSelection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.loadDetails(txtSearch.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            salary sal;

            if (txtbasic.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter Basic", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtempid.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Insert Employee Id", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dtpsal.Value == DateTime.Now)
            {
                MetroFramework.MetroMessageBox.Show(this, "Insert Date", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // var d = context.salaries.FirstOrDefault(c => c.salId == id1);


            if (txtid.Text == "")
            {
                sal = new salary();
                context.salaries.Add(sal);
            }
            else
            {
                int id1 = Int32.Parse(txtid.Text);
                sal = context.salaries.FirstOrDefault(s => s.salId == id1);
                if (sal == null)
                {
                    this.init();
                    return;
                }

            }
            double b, c, h;
            if(!double.TryParse(txtbasic.Text,out b))
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter Correct Basic", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(txtca.Text, out c))
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter Correct CA", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(txtha.Text, out h))
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter Correct Basic", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sal.basic = b;
            sal.ca = c;
            sal.ha = h;
            sal.empId = Int32.Parse(txtempid.Text);
            sal.salDate = dtpsal.Value.ToShortDateString();
            if (rbvalid.Checked)
            { sal.isActive = "valid"; }
            if (rbinvalid.Checked)
            { sal.isActive = "invalid"; }


            context.SaveChanges();
            this.loadDetails(txtSearch.Text);
        }

        private void init()
        {
            txtid.Text = txtbasic.Text = txtca.Text = txtha.Text = txtempid.Text = txtSearch.Text = "";
            rbvalid.Checked = rbinvalid.Checked = false;
            dtpsal.Value = DateTime.Now;


            this.loadDetails();
            loaddetail(-1);

        }
        private void loadDetails(string src = "")
        {
            var sal = context.salaries.ToList();
            int id1;
            if (Int32.TryParse(src, out id1))
            {

                sal = sal.Where(e => e.salId == id1).ToList();
            }
            dgvSalaryDetails.AutoGenerateColumns = false;
            dgvSalaryDetails.DataSource = sal.ToList();
            dgvSalaryDetails.Refresh();
            
            if (sal.Count > 0)
                this.loaddetail(sal.First().salId);
            else
            {
                loaddetail(-1);
            }
            
        }
        private void loaddetail(int id)
        {
            var sal = context.salaries.FirstOrDefault(e => e.salId == id);
            if (sal == null)
            {
                txtid.Text = txtbasic.Text = txtca.Text = txtha.Text = txtempid.Text = txtSearch.Text = "";
                rbvalid.Checked = rbinvalid.Checked = false;
                dtpsal.Value = DateTime.Now;

            }
            else
            {

                txtid.Text = sal.salId.ToString();
                txtbasic.Text = sal.basic.ToString();
                txtca.Text = sal.ca.ToString();
                txtha.Text = sal.ha.ToString();
                txtempid.Text = sal.empId.ToString();
                dtpsal.Value = Convert.ToDateTime(sal.salDate);
                if (sal.isActive == "valid")
                { this.rbvalid.Checked = true; }
                if (sal.isActive == "invalid")
                { this.rbinvalid.Checked = true; }

            }
        }

        private void SalaryForm_Load(object sender, EventArgs e)
        {
            init();
        }
    }
}
