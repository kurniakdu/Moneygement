﻿using System;
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
    }
}
