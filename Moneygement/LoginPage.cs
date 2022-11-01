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
    public partial class LoginPage : Form
    {
        public LoginPage()
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

        private void pbPassword_MouseDown(object sender, MouseEventArgs e)
        {
            tbPassword.UseSystemPasswordChar = false;
        }

        private void pbPassword_MouseUp(object sender, MouseEventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = tbUsername.Text;
            user.Password = tbPassword.Text;
            if (user.login(user.Username, user.Password))
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.FormClosed += (s, args) => this.Close();
                dashboard.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}