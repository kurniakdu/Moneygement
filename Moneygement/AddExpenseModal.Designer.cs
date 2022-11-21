namespace Moneygement
{
    partial class AddExpenseModal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAddExpense = new System.Windows.Forms.Label();
            this.lblExpName = new System.Windows.Forms.Label();
            this.lblExpAmount = new System.Windows.Forms.Label();
            this.lblExpCategory = new System.Windows.Forms.Label();
            this.tbExpName = new System.Windows.Forms.TextBox();
            this.tbExpAmount = new System.Windows.Forms.TextBox();
            this.tbExpCategory = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddExpense
            // 
            this.lblAddExpense.AutoSize = true;
            this.lblAddExpense.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddExpense.Location = new System.Drawing.Point(104, 29);
            this.lblAddExpense.Name = "lblAddExpense";
            this.lblAddExpense.Size = new System.Drawing.Size(126, 28);
            this.lblAddExpense.TabIndex = 0;
            this.lblAddExpense.Text = "Add Expense";
            // 
            // lblExpName
            // 
            this.lblExpName.AutoSize = true;
            this.lblExpName.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExpName.Location = new System.Drawing.Point(59, 75);
            this.lblExpName.Name = "lblExpName";
            this.lblExpName.Size = new System.Drawing.Size(102, 22);
            this.lblExpName.TabIndex = 1;
            this.lblExpName.Text = "Expense Name :";
            // 
            // lblExpAmount
            // 
            this.lblExpAmount.AutoSize = true;
            this.lblExpAmount.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExpAmount.Location = new System.Drawing.Point(59, 133);
            this.lblExpAmount.Name = "lblExpAmount";
            this.lblExpAmount.Size = new System.Drawing.Size(64, 22);
            this.lblExpAmount.TabIndex = 2;
            this.lblExpAmount.Text = "Amount :";
            // 
            // lblExpCategory
            // 
            this.lblExpCategory.AutoSize = true;
            this.lblExpCategory.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExpCategory.Location = new System.Drawing.Point(59, 190);
            this.lblExpCategory.Name = "lblExpCategory";
            this.lblExpCategory.Size = new System.Drawing.Size(71, 22);
            this.lblExpCategory.TabIndex = 3;
            this.lblExpCategory.Text = "Category :";
            // 
            // tbExpName
            // 
            this.tbExpName.Location = new System.Drawing.Point(59, 93);
            this.tbExpName.Name = "tbExpName";
            this.tbExpName.Size = new System.Drawing.Size(208, 23);
            this.tbExpName.TabIndex = 4;
            // 
            // tbExpAmount
            // 
            this.tbExpAmount.Location = new System.Drawing.Point(59, 151);
            this.tbExpAmount.Name = "tbExpAmount";
            this.tbExpAmount.Size = new System.Drawing.Size(208, 23);
            this.tbExpAmount.TabIndex = 5;
            // 
            // tbExpCategory
            // 
            this.tbExpCategory.Location = new System.Drawing.Point(59, 208);
            this.tbExpCategory.Name = "tbExpCategory";
            this.tbExpCategory.Size = new System.Drawing.Size(208, 23);
            this.tbExpCategory.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(73, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 24);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(183, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 24);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddExpenseModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbExpCategory);
            this.Controls.Add(this.tbExpAmount);
            this.Controls.Add(this.tbExpName);
            this.Controls.Add(this.lblExpCategory);
            this.Controls.Add(this.lblExpAmount);
            this.Controls.Add(this.lblExpName);
            this.Controls.Add(this.lblAddExpense);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddExpenseModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddExpenseModal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAddExpense;
        private Label lblExpName;
        private Label lblExpAmount;
        private Label lblExpCategory;
        private TextBox tbExpName;
        private TextBox tbExpAmount;
        private TextBox tbExpCategory;
        private Button btnAdd;
        private Button btnCancel;
    }
}