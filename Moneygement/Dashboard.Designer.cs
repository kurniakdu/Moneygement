namespace Moneygement
{
    partial class Dashboard
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
            this.pnlSide = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            this.lblSavings = new System.Windows.Forms.Label();
            this.lblExpense = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.pbMonthly = new System.Windows.Forms.PictureBox();
            this.pbSavings = new System.Windows.Forms.PictureBox();
            this.pbExpense = new System.Windows.Forms.PictureBox();
            this.pbIncome = new System.Windows.Forms.PictureBox();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.lblSayHi = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonthly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSavings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(190)))), ((int)(((byte)(203)))));
            this.pnlSide.Controls.Add(this.btnSettings);
            this.pnlSide.Controls.Add(this.btnLogout);
            this.pnlSide.Controls.Add(this.btnHistory);
            this.pnlSide.Controls.Add(this.btnTransaction);
            this.pnlSide.Controls.Add(this.btnDashboard);
            this.pnlSide.Controls.Add(this.pbLogo);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(200, 600);
            this.pnlSide.TabIndex = 4;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSettings.Image = global::Moneygement.Properties.Resources.Settingsbtn;
            this.btnSettings.Location = new System.Drawing.Point(0, 484);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(200, 32);
            this.btnSettings.TabIndex = 13;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Image = global::Moneygement.Properties.Resources.Logoutbtn;
            this.btnLogout.Location = new System.Drawing.Point(0, 522);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 32);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHistory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHistory.Image = global::Moneygement.Properties.Resources.Historybtn1;
            this.btnHistory.Location = new System.Drawing.Point(0, 247);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(200, 32);
            this.btnHistory.TabIndex = 11;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTransaction.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTransaction.Image = global::Moneygement.Properties.Resources.Transactionbtn;
            this.btnTransaction.Location = new System.Drawing.Point(0, 209);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(200, 32);
            this.btnTransaction.TabIndex = 10;
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDashboard.Image = global::Moneygement.Properties.Resources.Dashboardbtn;
            this.btnDashboard.Location = new System.Drawing.Point(0, 171);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 32);
            this.btnDashboard.TabIndex = 9;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Moneygement.Properties.Resources.Group_12;
            this.pbLogo.Location = new System.Drawing.Point(14, 14);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(170, 47);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(246)))));
            this.pnlMain.Controls.Add(this.dgvSummary);
            this.pnlMain.Controls.Add(this.lblSavings);
            this.pnlMain.Controls.Add(this.lblExpense);
            this.pnlMain.Controls.Add(this.lblIncome);
            this.pnlMain.Controls.Add(this.pbMonthly);
            this.pnlMain.Controls.Add(this.pbSavings);
            this.pnlMain.Controls.Add(this.pbExpense);
            this.pnlMain.Controls.Add(this.pbIncome);
            this.pnlMain.Controls.Add(this.pbProfile);
            this.pnlMain.Controls.Add(this.lblSayHi);
            this.pnlMain.Controls.Add(this.lblDashboard);
            this.pnlMain.Controls.Add(this.btnMinimize);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(200, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 600);
            this.pnlMain.TabIndex = 5;
            // 
            // dgvSummary
            // 
            this.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummary.Location = new System.Drawing.Point(68, 327);
            this.dgvSummary.Name = "dgvSummary";
            this.dgvSummary.RowTemplate.Height = 25;
            this.dgvSummary.Size = new System.Drawing.Size(584, 245);
            this.dgvSummary.TabIndex = 16;
            // 
            // lblSavings
            // 
            this.lblSavings.AutoSize = true;
            this.lblSavings.BackColor = System.Drawing.Color.White;
            this.lblSavings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSavings.Location = new System.Drawing.Point(554, 193);
            this.lblSavings.Name = "lblSavings";
            this.lblSavings.Size = new System.Drawing.Size(76, 24);
            this.lblSavings.TabIndex = 15;
            this.lblSavings.Text = "Savings";
            // 
            // lblExpense
            // 
            this.lblExpense.AutoSize = true;
            this.lblExpense.BackColor = System.Drawing.Color.White;
            this.lblExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExpense.Location = new System.Drawing.Point(328, 193);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(86, 24);
            this.lblExpense.TabIndex = 14;
            this.lblExpense.Text = "Expense";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.BackColor = System.Drawing.Color.White;
            this.lblIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIncome.Location = new System.Drawing.Point(100, 193);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(73, 24);
            this.lblIncome.TabIndex = 13;
            this.lblIncome.Text = "Income";
            // 
            // pbMonthly
            // 
            this.pbMonthly.Image = global::Moneygement.Properties.Resources.Monthlysum3;
            this.pbMonthly.Location = new System.Drawing.Point(48, 261);
            this.pbMonthly.Name = "pbMonthly";
            this.pbMonthly.Size = new System.Drawing.Size(625, 327);
            this.pbMonthly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMonthly.TabIndex = 12;
            this.pbMonthly.TabStop = false;
            // 
            // pbSavings
            // 
            this.pbSavings.Image = global::Moneygement.Properties.Resources.Totalsavings1;
            this.pbSavings.Location = new System.Drawing.Point(503, 162);
            this.pbSavings.Name = "pbSavings";
            this.pbSavings.Size = new System.Drawing.Size(170, 75);
            this.pbSavings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSavings.TabIndex = 11;
            this.pbSavings.TabStop = false;
            // 
            // pbExpense
            // 
            this.pbExpense.Image = global::Moneygement.Properties.Resources.Totalexpense11;
            this.pbExpense.Location = new System.Drawing.Point(277, 162);
            this.pbExpense.Name = "pbExpense";
            this.pbExpense.Size = new System.Drawing.Size(170, 75);
            this.pbExpense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExpense.TabIndex = 10;
            this.pbExpense.TabStop = false;
            // 
            // pbIncome
            // 
            this.pbIncome.Image = global::Moneygement.Properties.Resources.Totalincome1;
            this.pbIncome.Location = new System.Drawing.Point(48, 162);
            this.pbIncome.Name = "pbIncome";
            this.pbIncome.Size = new System.Drawing.Size(170, 75);
            this.pbIncome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIncome.TabIndex = 9;
            this.pbIncome.TabStop = false;
            // 
            // pbProfile
            // 
            this.pbProfile.Image = global::Moneygement.Properties.Resources.user;
            this.pbProfile.InitialImage = null;
            this.pbProfile.Location = new System.Drawing.Point(600, 65);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(40, 40);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbProfile.TabIndex = 8;
            this.pbProfile.TabStop = false;
            // 
            // lblSayHi
            // 
            this.lblSayHi.AutoSize = true;
            this.lblSayHi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSayHi.Location = new System.Drawing.Point(637, 75);
            this.lblSayHi.Name = "lblSayHi";
            this.lblSayHi.Size = new System.Drawing.Size(55, 16);
            this.lblSayHi.TabIndex = 7;
            this.lblSayHi.Text = "Hi, user!";
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDashboard.Location = new System.Drawing.Point(48, 108);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(102, 24);
            this.lblDashboard.TabIndex = 6;
            this.lblDashboard.Text = "Dashboard";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::Moneygement.Properties.Resources.Vector;
            this.btnMinimize.Location = new System.Drawing.Point(716, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Moneygement.Properties.Resources.X;
            this.btnClose.Location = new System.Drawing.Point(758, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.pnlSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonthly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSavings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnlSide;
        private Panel pnlMain;
        private Button btnMinimize;
        private Button btnClose;
        private PictureBox pbLogo;
        private PictureBox pbProfile;
        private Label lblSayHi;
        private Label lblDashboard;
        private Button btnHistory;
        private Button btnTransaction;
        private Button btnDashboard;
        private Button btnSettings;
        private Button btnLogout;
        private PictureBox pbSavings;
        private PictureBox pbExpense;
        private PictureBox pbIncome;
        private PictureBox pbMonthly;
        private Label lblIncome;
        private Label lblExpense;
        private Label lblSavings;
        private DataGridView dgvSummary;
    }
}