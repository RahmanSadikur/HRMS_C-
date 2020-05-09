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
    public partial class DesignationForm : Form
    {
        HRMSdbContext1 context = new HRMSdbContext1();
        public DesignationForm()
        {
            InitializeComponent();
        }

        private void DesignationForm_Load(object sender, EventArgs e)
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
            var designation = context.designations.ToList();

            if (src != "")
            {
                designation = designation.Where(de => de.desigName.ToLower().Contains(src.ToLower())).ToList();
            }
            dgvDesigDetails.AutoGenerateColumns = false;
            dgvDesigDetails.DataSource = designation.ToList();
            dgvDesigDetails.Refresh();
            if (designation.Count > 0)
            {
                loaddetail(designation.First().desigId);
            }
            else
            {
                loaddetail(-1);
            }

        }
        private void loaddetail(int id)
        {
            var desig = context.designations.FirstOrDefault(e => e.desigId == id);
            if (desig == null)
            {
                txtDesigName.Text = txtDesigId.Text = "";

            }
            else
            {
                txtDesigId.Text = desig.desigId.ToString();
                txtDesigName.Text = desig.desigName.ToString();
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

        private void dgvDesigDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvDesigDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.loaddetail(Int32.Parse(id));
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            init();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDesigId.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter a Designation Id", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id;

            if (Int32.TryParse(txtDesigId.Text, out id))
            {
                var desig = context.designations.FirstOrDefault(d => d.desigId == id);
                if (desig == null)
                {
                    this.init();
                    return;
                }
                context.designations.Remove(desig);
                context.SaveChanges();
                init();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter Correct Id", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDesigId.Text = txtDesigName.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id;
            if (Int32.TryParse(txtDesigId.Text, out id))
            {
                designation desig;

                if (txtDesigName.Text == "")

                {
                    MetroFramework.MetroMessageBox.Show(this, "Enter a Name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var d = context.designations.FirstOrDefault(c => c.desigId == id);


                if (d == null)
                {
                    desig = new designation();
                    context.designations.Add(desig);
                }
                else
                {

                    desig = context.designations.FirstOrDefault(c => c.desigId == id);
                    if (desig == null)
                    {
                        this.init();
                        return;
                    }

                }
                desig.desigName = txtDesigName.Text;
                desig.desigId = id;
                context.SaveChanges();
                init();
                dgvDesigDetails.ClearSelection();
                for (int i = 0; i < dgvDesigDetails.Rows.Count; i++)
                {
                    int a = Int32.Parse(dgvDesigDetails.Rows[i].Cells[0].Value.ToString());
                    if (a == desig.desigId)
                    {
                        dgvDesigDetails.Rows[i].Selected = true;
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
