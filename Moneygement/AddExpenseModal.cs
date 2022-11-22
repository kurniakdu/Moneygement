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
    public partial class AddExpenseModal : Form
    {
        public AddExpenseModal()
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
                dbconnect.sql = @"select expense_insert(:_expense_name,:_expense_amount,:_expense_category)";
                dbconnect.cmd = new NpgsqlCommand(dbconnect.sql, dbconnect.conn);
                dbconnect.cmd.Parameters.AddWithValue("_expense_name", tbExpName.Text);
                dbconnect.cmd.Parameters.AddWithValue("_expense_amount", Convert.ToInt32(tbExpAmount.Text));
                dbconnect.cmd.Parameters.AddWithValue("_expense_category", tbExpCategory.Text);
                if ((int)dbconnect.cmd.ExecuteScalar() == 1)
                {
                    DialogResult dialogResult = MessageBox.Show("Expense successfully added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbExpName.Text = tbExpAmount.Text = tbExpCategory.Text = null;
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
