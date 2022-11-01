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
    public partial class Dashboard : Form
    {
        public Dashboard()
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

        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            this.Hide();
            IncomeDashboard Indashboard = new IncomeDashboard();
            Indashboard.FormClosed += (s, args) => this.Close();
            Indashboard.ShowDialog();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExpenseDashboard Exdashboard = new ExpenseDashboard();
            Exdashboard.FormClosed += (s, args) => this.Close();
            Exdashboard.ShowDialog();
        }
    }
}
