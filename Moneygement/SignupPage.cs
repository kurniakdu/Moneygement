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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Moneygement
{
    public partial class SignupPage : Form
    {
        public SignupPage()
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.FormClosed += (s, args) => this.Close();
            login.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PgsqlConnect dbconnect = new PgsqlConnect();
            try
            {
                dbconnect.conn = new NpgsqlConnection(dbconnect.connstring);
                dbconnect.conn.Open();
                dbconnect.sql = @"select st_insert(:_username,:_password,:_name,:_email,:_phone)";
                dbconnect.cmd = new NpgsqlCommand(dbconnect.sql, dbconnect.conn);
                dbconnect.cmd.Parameters.AddWithValue("_username", tbUsername.Text);
                dbconnect.cmd.Parameters.AddWithValue("_password", tbPassword.Text);
                dbconnect.cmd.Parameters.AddWithValue("_name", tbName.Text);
                dbconnect.cmd.Parameters.AddWithValue("_email", tbEmail.Text);
                dbconnect.cmd.Parameters.AddWithValue("_phone", tbPhone.Text);
                if ((int)dbconnect.cmd.ExecuteScalar() == 1)
                {
                    DialogResult dialogResult = MessageBox.Show("Account successfully created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbUsername.Text = tbPassword.Text = tbName.Text = tbEmail.Text = tbPhone.Text = null;
                    dbconnect.conn.Close();
                    if (dialogResult == DialogResult.OK)
                    {
                        this.Hide();
                        LoginPage login = new LoginPage();
                        login.FormClosed += (s, args) => this.Close();
                        login.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbconnect.conn.Close();
            }
        }
    }
}
