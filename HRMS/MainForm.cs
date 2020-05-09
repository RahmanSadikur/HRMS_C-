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
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public Panel pnlmain;
        public string userid;
        public MainForm()
        {
            InitializeComponent();
            this.pnlmain = pnlMain;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm(this);
            lg.TopLevel = false;
            lg.AutoScroll = true;
            lg.FormBorderStyle = FormBorderStyle.None;
            lg.Dock = DockStyle.Fill;
            this.pnlmain.Controls.Clear();
            this.pnlmain.Controls.Add(lg);
            lg.Show();
        }
    }
}
