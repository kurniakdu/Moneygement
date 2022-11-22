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
using System.Xml.Linq;

namespace Moneygement
{
    public partial class AddIncomeModal : Form
    {
        public AddIncomeModal()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PgsqlConnect dbconnect = new PgsqlConnect();
            try
            {
                dbconnect.conn = new NpgsqlConnection(dbconnect.connstring);
                dbconnect.conn.Open();
                dbconnect.sql = @"select income_insert(:_income_name,:_income_amount,:_income_category)";
                dbconnect.cmd = new NpgsqlCommand(dbconnect.sql, dbconnect.conn);
                dbconnect.cmd.Parameters.AddWithValue("_income_name", tbIncName.Text);
                dbconnect.cmd.Parameters.AddWithValue("_income_amount", Convert.ToInt32(tbIncAmount.Text));
                dbconnect.cmd.Parameters.AddWithValue("_income_category", tbIncCategory.Text);
                if ((int)dbconnect.cmd.ExecuteScalar() == 1)
                {
                    DialogResult dialogResult = MessageBox.Show("Income successfully added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbIncName.Text = tbIncAmount.Text = tbIncCategory.Text = null;
                    dbconnect.conn.Close();
                    if (dialogResult == DialogResult.OK)
                    {
                        this.Hide();
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
