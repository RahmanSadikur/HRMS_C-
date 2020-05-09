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
    public partial class ManagerPayslipForm : Form
    {
        HRMSdbContext1 context = new HRMSdbContext1();
        string gnrt;
        int id2;
        public ManagerPayslipForm()
        {
            InitializeComponent();
            dgvdetails.AutoGenerateColumns = false;
        }
        private void init()
        {
            txtid.Text = txtbasic.Text = txtca.Text = txtha.Text = txtaddition.Text = txtDeduction.Text = txtsrch.Text = "";
            lvlempName.Text = lvldesig.Text = txttotal.Text = lvlid.Text = "";
            dtpDate.Text = DateTime.Now.ToShortDateString().ToString();
            rbyes.Checked = false;
            rbno.Checked = false;


            this.loadDetails();


        }
        private void loadDetails(string src = "")
        {
            
            var sal = context.salaries.Where(e=>e.employee.usertype.utypeId==3&& e.isActive=="valid").ToList();
            int id1;
            if (Int32.TryParse(src, out id1))
            {

                sal = sal.Where(e => e.empId == id1).ToList();
            }
            dgvdetails.DataSource = sal.ToList();
            dgvdetails.Refresh();

            if (sal.Count > 0)
                this.loaddetail(sal.First().empId);
            else
            {
                loaddetail(-1);
            }

        }
        private void loaddetail(int id)
        {


            var sal = context.salaries.FirstOrDefault(e => e.empId == id);

            if (sal == null)
            {
                txtid.Text = txtbasic.Text = txtca.Text = txtha.Text = txtaddition.Text = txtDeduction.Text = txtsrch.Text = "";
                lvlempName.Text = lvldesig.Text = txttotal.Text = lvlid.Text = "";
                dtpDate.Text = DateTime.Now.ToShortDateString();
                rbyes.Checked = false;
                rbno.Checked = false;

            }
            else
            {

                //txtid.Text = pay.payslipId.ToString();
                txtbasic.Text = sal.basic.ToString();
                txtca.Text = sal.ca.ToString();
                txtha.Text = sal.ha.ToString();
                //txtaddition.Text = pay.addition.ToString();
                // txtDeduction.Text = pay.deduction.ToString();
                dtpDate.Text = DateTime.Now.ToShortDateString().ToString();
                lvlempName.Text = sal.empName;
                lvldesig.Text = sal.desigName;
                lvlid.Text = sal.salId.ToString();
                //id2 = Int32.Parse(lvlid.Text);



            }
           
           


        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.loaddetail(-1);
            dgvdetails.ClearSelection();
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
            payslip pay;
            int id1;
            if (!Int32.TryParse(txtid.Text, out id1))


            {
                pay = new payslip();
                context.payslips.Add(pay);
            }
            else
            {
                pay = context.payslips.FirstOrDefault(p => p.payslipId == id1);
                if (pay == null)
                {
                    this.init();
                    return;
                }
            }
            pay.basic = double.Parse(txtbasic.Text);
            pay.ca = double.Parse(txtca.Text);
            pay.ha = double.Parse(txtha.Text);
            double a, d;
            if (double.TryParse(txtaddition.Text, out a))
            {
                pay.addition = a;
            }
            else { pay.addition = 0; }
            if (double.TryParse(txtDeduction.Text, out d))
            {
                pay.deduction = d;
            }
            else { pay.deduction = 0; }

            if (rbyes.Checked)
            {
                pay.genarate = "Yes";
                gnrt = "Yes";
            }
            if (rbno.Checked)
            {
                pay.genarate = "No";
                gnrt = "No";
            }
            id2 = Int32.Parse(lvlid.Text);
            pay.salId = id2;
            pay.payslipDate = Convert.ToDateTime(dtpDate.Text);
            context.SaveChanges();
            //this.loadDetails(txtsrch.Text);
            double total = pay.ha + pay.ca + pay.basic + pay.addition - pay.deduction;
            txttotal.Text = total.ToString();




            string[] date = dtpDate.Text.Split('/');

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
                if (gnrt == "Yes")
                {
                    payrl.total += total;
                    //context.payrolls.(payrl);
                    context.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Payslip Genaretaed", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            this.loadDetails(txtsrch.Text);

        }

        private void ManagerPayslipForm_Load(object sender, EventArgs e)
        {
            init();
        }
    }
}
