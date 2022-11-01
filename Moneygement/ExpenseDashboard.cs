using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moneygement
{
    public partial class ExpenseDashboard : Form
    {
        public ExpenseDashboard()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.FormClosed += (s, args) => this.Close();
            dashboard.ShowDialog();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            this.Hide();
            IncomeDashboard Indashboard = new IncomeDashboard();
            Indashboard.FormClosed += (s, args) => this.Close();
            Indashboard.ShowDialog();
        }
    }
}
