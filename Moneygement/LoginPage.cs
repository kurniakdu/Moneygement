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

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=root;Database=db_moneygement";
        public static NpgsqlCommand cmd;

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
            bool DataFound = false;

            User user = new User();
            user.Username = tbUsername.Text;
            user.Password = tbPassword.Text;
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            cmd = new NpgsqlCommand("Select * from users where username= '" + tbUsername.Text + "' and password = '" + tbPassword.Text + "'", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                DataFound = true;
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.FormClosed += (s, args) => this.Close();
                dashboard.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Failed");  
            }
            conn.Close();
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
