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
    public partial class AdminPayRollForm : Form
    {
        public static int t = 0;
        HRMSdbContext1 context = new HRMSdbContext1();
        public AdminPayRollForm()
        {
            InitializeComponent();
            dgvPayRolldetails.AutoGenerateColumns = false;
            dtpmmyy.Format = DateTimePickerFormat.Custom;
            dtpmmyy.CustomFormat = "MM/yyyy";
            dtpmmyy.ShowUpDown = true;
            t = 0;
        }

        private void AdminPayRollForm_Load(object sender, EventArgs e)
        {
            this.init();
        }
        private void init()
        {
            txtpayrollId.Text = txttotal.Text = txtSearch.Text = "";
            dtpmmyy.Value = DateTime.Now;
            rbtninactive.Checked = rbtnactive.Checked = false;
            t = 0;
            this.loadDetails();
            this.loaddetail(-1);

        }
        private void loadDetails(string src = "")
        {
            var payrl = context.payrolls.ToList();
            
            if (src != "")
            {
                payrl = context.payrolls.Where(e => e.year.Contains(src)).ToList();
            }
            dgvPayRolldetails.DataSource = payrl.ToList();
            dgvPayRolldetails.Refresh();
            if (payrl.Count > 0)
                this.loaddetail(payrl.First().payrollId);
            else
            {
                loaddetail(-1);
            }

        }
        private void loaddetail(int id)
        {
            var payrl = context.payrolls.FirstOrDefault(e => e.payrollId == id);
            if (payrl == null)
            {
                txtpayrollId.Text = txttotal.Text = "";
                dtpmmyy.Value = DateTime.Now;
                rbtninactive.Checked = rbtnactive.Checked = false;

            }
            else
            {

                txtpayrollId.Text = payrl.payrollId.ToString();
                txttotal.Text = payrl.total.ToString();
                string mon, yr, date;
                mon = payrl.month;
                yr = payrl.year;
                date = mon + "/" + yr;
                dtpmmyy.Value = Convert.ToDateTime(date);
                rbtnactive.Checked = payrl.status == "Active" ? true:false;
                rbtninactive.Checked = payrl.status == "Inactive" ? true:false;

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.init();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.loaddetail(-1);
            dgvPayRolldetails.ClearSelection();
            t = 1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.loadDetails(txtSearch.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] date = dtpmmyy.Text.ToString().Split('/');
            string m = date[0];
            string y = date[1];
            string s = rbtnactive.Checked == true ? "Active" : "Inactive";
            var p = context.payrolls.FirstOrDefault(pp => pp.month == m && pp.year == y&&pp.status==s);
            if (p != null)
            {
                MetroFramework.MetroMessageBox.Show(this, "This Pay Roll already exists ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            payroll payrl;
            if (txtpayrollId.Text=="")
            {
                payrl = new payroll();
                context.payrolls.Add(payrl);
            }
            
            else
            {
                int id1 = Int32.Parse(txtpayrollId.Text);
                payrl = context.payrolls.FirstOrDefault(c => c.payrollId == id1);
                if (payrl == null)
                {
                    this.init();
                    return;
                }

            }
                
            
            payrl.month = m;
            payrl.year = y;
            payrl.status = rbtnactive.Checked ? "Active" : "Inactive";
            payrl.total = string.IsNullOrEmpty(txttotal.Text)? 0:double.Parse(txttotal.Text);

            context.SaveChanges();
            init();
            this.loaddetail(-1);
        }

        private void dgvPayRolldetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvPayRolldetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.loaddetail(Int32.Parse(id));
            }
            
        }
    }
}
