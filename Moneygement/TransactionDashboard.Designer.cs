namespace Moneygement
{
    partial class TransactionDashboard
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvExpense = new System.Windows.Forms.DataGridView();
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.btnAddIncome = new System.Windows.Forms.Button();
            this.pbTableExpense = new System.Windows.Forms.PictureBox();
            this.pbTableIncome = new System.Windows.Forms.PictureBox();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.lblSayHi = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTableExpense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTableIncome)).BeginInit();
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
            this.btnHistory.Click += new System.EventHandler(this.btnExpense_Click);
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
            this.pnlMain.Controls.Add(this.btnRefresh);
            this.pnlMain.Controls.Add(this.dgvExpense);
            this.pnlMain.Controls.Add(this.dgvIncome);
            this.pnlMain.Controls.Add(this.btnAddExpense);
            this.pnlMain.Controls.Add(this.btnAddIncome);
            this.pnlMain.Controls.Add(this.pbTableExpense);
            this.pnlMain.Controls.Add(this.pbTableIncome);
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
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(638, 559);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 23);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvExpense
            // 
            this.dgvExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpense.Location = new System.Drawing.Point(430, 305);
            this.dgvExpense.Name = "dgvExpense";
            this.dgvExpense.RowTemplate.Height = 25;
            this.dgvExpense.Size = new System.Drawing.Size(299, 224);
            this.dgvExpense.TabIndex = 16;
            // 
            // dgvIncome
            // 
            this.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncome.Location = new System.Drawing.Point(65, 305);
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.RowTemplate.Height = 25;
            this.dgvIncome.Size = new System.Drawing.Size(299, 224);
            this.dgvIncome.TabIndex = 15;
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.FlatAppearance.BorderSize = 0;
            this.btnAddExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExpense.Image = global::Moneygement.Properties.Resources.Addexpense1;
            this.btnAddExpense.Location = new System.Drawing.Point(414, 171);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(128, 59);
            this.btnAddExpense.TabIndex = 14;
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // btnAddIncome
            // 
            this.btnAddIncome.FlatAppearance.BorderSize = 0;
            this.btnAddIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIncome.Image = global::Moneygement.Properties.Resources.Addincome1;
            this.btnAddIncome.Location = new System.Drawing.Point(48, 171);
            this.btnAddIncome.Name = "btnAddIncome";
            this.btnAddIncome.Size = new System.Drawing.Size(128, 59);
            this.btnAddIncome.TabIndex = 13;
            this.btnAddIncome.UseVisualStyleBackColor = true;
            this.btnAddIncome.Click += new System.EventHandler(this.btnAddIncome_Click);
            // 
            // pbTableExpense
            // 
            this.pbTableExpense.Image = global::Moneygement.Properties.Resources.Tableexpense1;
            this.pbTableExpense.Location = new System.Drawing.Point(414, 247);
            this.pbTableExpense.Name = "pbTableExpense";
            this.pbTableExpense.Size = new System.Drawing.Size(332, 296);
            this.pbTableExpense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTableExpense.TabIndex = 12;
            this.pbTableExpense.TabStop = false;
            // 
            // pbTableIncome
            // 
            this.pbTableIncome.Image = global::Moneygement.Properties.Resources.Tableincome11;
            this.pbTableIncome.Location = new System.Drawing.Point(48, 247);
            this.pbTableIncome.Name = "pbTableIncome";
            this.pbTableIncome.Size = new System.Drawing.Size(332, 296);
            this.pbTableIncome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTableIncome.TabIndex = 11;
            this.pbTableIncome.TabStop = false;
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
            this.lblDashboard.Size = new System.Drawing.Size(108, 24);
            this.lblDashboard.TabIndex = 6;
            this.lblDashboard.Text = "Transaction";
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
            // TransactionDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardMoneygement1";
            this.pnlSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTableExpense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTableIncome)).EndInit();
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
        private PictureBox pbTableIncome;
        private PictureBox pbTableExpense;
        private Button btnAddExpense;
        private Button btnAddIncome;
        public DataGridView dgvExpense;
        public DataGridView dgvIncome;
        private Button btnRefresh;
    }
}