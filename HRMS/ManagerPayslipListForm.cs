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
    public partial class ManagerPayslipListForm : Form
    {
        HRMSdbContext1 context = new HRMSdbContext1();
        public ManagerPayslipListForm()
        {
            InitializeComponent();
            dgvdetails.AutoGenerateColumns = false;
        }
        private void init()
        {
            txtpId.Text = txtpDate.Text = txtbasic.Text = txtca.Text = txtha.Text = txtaddition.Text = txtDeduction.Text = txtSalId.Text = "";
            rbtnYes.Checked = false;
            rbtnno.Checked = false;


            this.loadDetails();
            loaddetail(-1);

        }
        private void loadDetails(string src = "")
        {
            //var sal = context.salaries.Where(e => e.employee.usertype.utypeId == 3).ToList();
            var payslist = context.payslips.Where(p=>p.salary.employee.usertype.utypeId==3).ToList();
            int id1;
            if (Int32.TryParse(src, out id1))
            {
                payslist = payslist.Where(e => e.payslipId == id1).ToList();
            }
            dgvdetails.DataSource = payslist.ToList();
            dgvdetails.Refresh();

            if (payslist.Count > 0)
                this.loaddetail(payslist.First().payslipId);
            else
            {
                loaddetail(-1);
            }

        }
        private void loaddetail(int id)
        {
            var payslist = context.payslips.FirstOrDefault(p => p.payslipId == id);

            if (payslist == null)
            {
                txtpId.Text = txtpDate.Text = txtbasic.Text = txtca.Text = txtha.Text = txtaddition.Text = txtDeduction.Text = txtSalId.Text = "";
                rbtnYes.Checked = false;
                rbtnno.Checked = false;

            }
            else
            {
                txtpId.Text = payslist.payslipId.ToString();
                txtpDate.Text = payslist.payslipDate.ToShortDateString();
                txtbasic.Text = payslist.basic.ToString();
                txtca.Text = payslist.ca.ToString();
                txtha.Text = payslist.ha.ToString();
                txtaddition.Text = payslist.addition.ToString();
                txtDeduction.Text = payslist.deduction.ToString();
                txtSalId.Text = payslist.salId.ToString();
                rbtnYes.Checked = payslist.genarate == "Yes" ? true : false;

                rbtnno.Checked = payslist.genarate == "No" ? true : false;
                if (rbtnYes.Checked)
                {
                    rbtnno.Hide();
                }
                else
                {
                    rbtnno.Show();
                }
            }

        }



        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.init();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            this.loadDetails(txtsrch.Text);
        }

        private void dgvdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvdetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.loaddetail(Int32.Parse(id));
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtpId.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Select a PaySlip ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int id = Int32.Parse(txtpId.Text);
            var pay = context.payslips.FirstOrDefault(p => p.payslipId == id);
            double total = pay.ha + pay.ca + pay.basic + pay.addition - pay.deduction;
            pay.genarate = rbtnYes.Checked == true ? "Yes" : "No";
            context.SaveChanges();
            string[] date = txtpDate.Text.Split('/');

            string ab = date[0];
            string b = date[2];
            if (ab == "1")
            { ab = "01"; }
            if (ab == "2")
            { ab = "02"; }
            if (ab == "3")
            { ab = "03"; }
            if (ab == "4")
            { ab = "04"; }
            if (ab == "5")
            { ab = "05"; }
            if (ab == "6")
            { ab = "06"; }
            if (ab == "7")
            { ab = "07"; }
            if (ab == "8")
            { ab = "08"; }
            if (ab == "9")
            { ab = "09"; }
            var payrl = context.payrolls.FirstOrDefault(p => p.month == ab && p.year == b);
            if (payrl != null)
            {
                if (pay.genarate == "Yes")
                {
                    payrl.total += total;
                    //context.payrolls.(payrl);
                    context.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Payslip Updated", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            this.loadDetails(txtsrch.Text);

        }



        private void payslipListForm_Load_1(object sender, EventArgs e)
        {
            init();
        }
    }
}
