namespace Moneygement
{
    partial class AddIncomeModal
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
            this.lblAddIncome = new System.Windows.Forms.Label();
            this.lblIncName = new System.Windows.Forms.Label();
            this.lblIncAmount = new System.Windows.Forms.Label();
            this.lblIncCategory = new System.Windows.Forms.Label();
            this.tbIncName = new System.Windows.Forms.TextBox();
            this.tbIncAmount = new System.Windows.Forms.TextBox();
            this.tbIncCategory = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddIncome
            // 
            this.lblAddIncome.AutoSize = true;
            this.lblAddIncome.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddIncome.Location = new System.Drawing.Point(104, 29);
            this.lblAddIncome.Name = "lblAddIncome";
            this.lblAddIncome.Size = new System.Drawing.Size(120, 28);
            this.lblAddIncome.TabIndex = 0;
            this.lblAddIncome.Text = "Add Income";
            // 
            // lblIncName
            // 
            this.lblIncName.AutoSize = true;
            this.lblIncName.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIncName.Location = new System.Drawing.Point(59, 75);
            this.lblIncName.Name = "lblIncName";
            this.lblIncName.Size = new System.Drawing.Size(99, 22);
            this.lblIncName.TabIndex = 1;
            this.lblIncName.Text = "Income Name :";
            // 
            // lblIncAmount
            // 
            this.lblIncAmount.AutoSize = true;
            this.lblIncAmount.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIncAmount.Location = new System.Drawing.Point(59, 133);
            this.lblIncAmount.Name = "lblIncAmount";
            this.lblIncAmount.Size = new System.Drawing.Size(64, 22);
            this.lblIncAmount.TabIndex = 2;
            this.lblIncAmount.Text = "Amount :";
            // 
            // lblIncCategory
            // 
            this.lblIncCategory.AutoSize = true;
            this.lblIncCategory.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIncCategory.Location = new System.Drawing.Point(59, 190);
            this.lblIncCategory.Name = "lblIncCategory";
            this.lblIncCategory.Size = new System.Drawing.Size(71, 22);
            this.lblIncCategory.TabIndex = 3;
            this.lblIncCategory.Text = "Category :";
            // 
            // tbIncName
            // 
            this.tbIncName.Location = new System.Drawing.Point(59, 93);
            this.tbIncName.Name = "tbIncName";
            this.tbIncName.Size = new System.Drawing.Size(208, 23);
            this.tbIncName.TabIndex = 4;
            // 
            // tbIncAmount
            // 
            this.tbIncAmount.Location = new System.Drawing.Point(59, 151);
            this.tbIncAmount.Name = "tbIncAmount";
            this.tbIncAmount.Size = new System.Drawing.Size(208, 23);
            this.tbIncAmount.TabIndex = 5;
            // 
            // tbIncCategory
            // 
            this.tbIncCategory.Location = new System.Drawing.Point(59, 208);
            this.tbIncCategory.Name = "tbIncCategory";
            this.tbIncCategory.Size = new System.Drawing.Size(208, 23);
            this.tbIncCategory.TabIndex = 6;
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
            // AddIncomeModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbIncCategory);
            this.Controls.Add(this.tbIncAmount);
            this.Controls.Add(this.tbIncName);
            this.Controls.Add(this.lblIncCategory);
            this.Controls.Add(this.lblIncAmount);
            this.Controls.Add(this.lblIncName);
            this.Controls.Add(this.lblAddIncome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddIncomeModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddIncomeModal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAddIncome;
        private Label lblIncName;
        private Label lblIncAmount;
        private Label lblIncCategory;
        private TextBox tbIncName;
        private TextBox tbIncAmount;
        private TextBox tbIncCategory;
        private Button btnAdd;
        private Button btnCancel;
    }
}