using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            PgsqlConnect dbconnect = new PgsqlConnect();
            dbconnect.conn = new NpgsqlConnection(dbconnect.connstring);
            dbconnect.conn.Open();
            dbconnect.cmd = new NpgsqlCommand("Select * from users where username= '" + tbUsername.Text + "' and password = '" + tbPassword.Text + "'", dbconnect.conn);
            NpgsqlDataReader dr = dbconnect.cmd.ExecuteReader();

            try
            {
                if (dr.Read())
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
                dbconnect.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbconnect.conn.Close();
            }
            
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignupPage signup = new SignupPage();
            signup.FormClosed += (s, args) => this.Close();
            signup.ShowDialog();
        }
    }
}
