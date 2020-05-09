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
    public partial class ProfilePaySlipForm : Form
    {
        HRMSdbContext1 context =new HRMSdbContext1();
        employee emp;
        public ProfilePaySlipForm(employee emp)
        {
            this.emp = emp;
            InitializeComponent();
            dgvPayslipdetails.AutoGenerateColumns = false;
        }

        private void ProfilePaySlipForm_Load(object sender, EventArgs e)
        {
            loadDetils();
        }
        private void loadDetils()
        {  
            var sal = context.salaries.FirstOrDefault(s=>s.empId==emp.empId);
            var payslip = context.payslips.Where(p=>p.salId==sal.salId).ToList();
            dgvPayslipdetails.DataSource = payslip.ToList();
            dgvPayslipdetails.Refresh();

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            loadDetils();
        }
    }
}
