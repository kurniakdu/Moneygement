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
    public partial class HistoryDashboard : Form
    {
        public HistoryDashboard()
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

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransactionDashboard Trdashboard = new TransactionDashboard();
            Trdashboard.FormClosed += (s, args) => this.Close();
            Trdashboard.ShowDialog();
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

        private void dgvHistory_Click(object sender, EventArgs e)
        {
            PgsqlConnect dbconnect = new PgsqlConnect();
            TableView table = new TableView();
            dbconnect.conn = new NpgsqlConnection(dbconnect.connstring);
            dbconnect.conn.Open();
            dgvHistory.DataSource = null;
            dbconnect.sql = "select * from show_all()";
            dbconnect.cmd = new NpgsqlCommand(dbconnect.sql, dbconnect.conn);
            table.dt = new DataTable();
            NpgsqlDataReader rd = dbconnect.cmd.ExecuteReader();
            table.dt.Load(rd);
            dgvHistory.DataSource = table.dt;
            dbconnect.conn.Close();
        }
    }
}
