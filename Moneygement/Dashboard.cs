using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransactionDashboard Trdashboard = new TransactionDashboard();
            Trdashboard.FormClosed += (s, args) => this.Close();
            Trdashboard.ShowDialog();
        }

        private void btnHistory_Click(object sender, EventArgs e)
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

        private void dgvSummary_Click(object sender, EventArgs e)
        {
            PgsqlConnect dbconnect = new PgsqlConnect();
            TableView table = new TableView();
            dbconnect.conn = new NpgsqlConnection(dbconnect.connstring);
            dbconnect.conn.Open();
            dgvSummary.DataSource = null;
            dbconnect.sql = "select * from show_all()";
            dbconnect.cmd = new NpgsqlCommand(dbconnect.sql, dbconnect.conn);
            table.dt = new DataTable();
            NpgsqlDataReader rd = dbconnect.cmd.ExecuteReader();
            table.dt.Load(rd);
            dgvSummary.DataSource = table.dt;
            dbconnect.conn.Close();
        }

        private void lblIncome_Click(object sender, EventArgs e)
        {
            
            PgsqlConnect dbconnect = new PgsqlConnect();
            dbconnect.conn = new NpgsqlConnection(dbconnect.connstring);
            dbconnect.conn.Open();
            dbconnect.sql = "select sum(income_amount) from income";
            dbconnect.cmd = new NpgsqlCommand(dbconnect.sql, dbconnect.conn);
            NpgsqlDataReader rd = dbconnect.cmd.ExecuteReader();
            if (rd.Read())
            {
                lblIncome.Text = rd[0].ToString();
            }
            else
            {
                lblIncome.Text = 0.ToString();
            }
            dbconnect.conn.Close();
        }

        private void lblExpense_Click(object sender, EventArgs e)
        {
            PgsqlConnect dbconnect = new PgsqlConnect();
            dbconnect.conn = new NpgsqlConnection(dbconnect.connstring);
            dbconnect.conn.Open();
            dbconnect.sql = "select sum(expense_amount) from expense";
            dbconnect.cmd = new NpgsqlCommand(dbconnect.sql, dbconnect.conn);
            NpgsqlDataReader rd = dbconnect.cmd.ExecuteReader();
            if (rd.Read())
            {
                lblExpense.Text = rd[0].ToString();
            }
            else
            {
                lblExpense.Text = 0.ToString();
            }
            dbconnect.conn.Close();
        }

        private void lblSavings_Click(object sender, EventArgs e)
        {

            PgsqlConnect dbconnect = new PgsqlConnect();
            dbconnect.conn = new NpgsqlConnection(dbconnect.connstring);
            dbconnect.conn.Open();
            dbconnect.sql = "select (select sum(income_amount) from income), (select sum(expense_amount) from expense)";
            dbconnect.cmd = new NpgsqlCommand(dbconnect.sql, dbconnect.conn);
            NpgsqlDataReader rd = dbconnect.cmd.ExecuteReader();
            if (rd.Read())
            {
                lblSavings.Text = ((dynamic)rd[0] - (dynamic)rd[1]).ToString();
            }
            else
            {
                lblSavings.Text = 0.ToString();
            }
            dbconnect.conn.Close();
        }
    }
}
