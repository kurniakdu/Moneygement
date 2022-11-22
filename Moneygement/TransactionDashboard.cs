using Npgsql;
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
    public partial class TransactionDashboard : Form
    {
        public TransactionDashboard()
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

        private void btnExpense_Click(object sender, EventArgs e)
        {
            this.Hide();
            HistoryDashboard Hidashboard = new HistoryDashboard();
            Hidashboard.FormClosed += (s, args) => this.Close();
            Hidashboard.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsDashboard Setdashboard = new SettingsDashboard();
            Setdashboard.FormClosed += (s, args) => this.Close();
            Setdashboard.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                LoginPage login = new LoginPage();
                login.FormClosed += (s, args) => this.Close();
                login.ShowDialog();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            AddIncomeModal incmodal = new AddIncomeModal();
            incmodal.ShowDialog();

        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            AddExpenseModal expmodal = new AddExpenseModal();
            expmodal.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PgsqlConnect dbconnect = new PgsqlConnect();
            TableView table = new TableView();
            dbconnect.conn = new NpgsqlConnection(dbconnect.connstring);
            dbconnect.conn.Open();
            // income table
            dgvIncome.DataSource = null;
            dbconnect.sql = "select * from income_select()";
            dbconnect.cmd = new NpgsqlCommand(dbconnect.sql, dbconnect.conn);
            table.dt = new DataTable();
            NpgsqlDataReader rdinc = dbconnect.cmd.ExecuteReader();
            table.dt.Load(rdinc);
            dgvIncome.DataSource = table.dt;
            // expense table
            dgvExpense.DataSource = null;
            dbconnect.sql = "select * from expense_select()";
            dbconnect.cmd = new NpgsqlCommand(dbconnect.sql, dbconnect.conn);
            table.dt = new DataTable();
            NpgsqlDataReader rdexp = dbconnect.cmd.ExecuteReader();
            table.dt.Load(rdexp);
            dgvExpense.DataSource = table.dt;
            dbconnect.conn.Close();
        }
    }
}
