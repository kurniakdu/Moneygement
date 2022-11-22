namespace Moneygement
{
    partial class SignupPage
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.pnlPhone = new System.Windows.Forms.Panel();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.pbPhone = new System.Windows.Forms.PictureBox();
            this.pnlName = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.pbName = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.pbEmail = new System.Windows.Forms.PictureBox();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.pbUsername = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            this.pnlPhone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhone)).BeginInit();
            this.pnlName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).BeginInit();
            this.pnlEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).BeginInit();
            this.pnlUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(190)))), ((int)(((byte)(203)))));
            this.pnlSide.Controls.Add(this.pbLogo);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(344, 600);
            this.pnlSide.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Moneygement.Properties.Resources.Group_12;
            this.pbLogo.Location = new System.Drawing.Point(23, 283);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(299, 72);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(246)))));
            this.pnlMain.Controls.Add(this.btnBack);
            this.pnlMain.Controls.Add(this.pnlPassword);
            this.pnlMain.Controls.Add(this.pnlPhone);
            this.pnlMain.Controls.Add(this.pnlName);
            this.pnlMain.Controls.Add(this.btnLogin);
            this.pnlMain.Controls.Add(this.pnlEmail);
            this.pnlMain.Controls.Add(this.pnlUsername);
            this.pnlMain.Controls.Add(this.lblLogin);
            this.pnlMain.Controls.Add(this.btnMinimize);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(344, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(656, 600);
            this.pnlMain.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.btnBack.Location = new System.Drawing.Point(199, 482);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(277, 24);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back to Login Page";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlPassword
            // 
            this.pnlPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPassword.Controls.Add(this.tbPassword);
            this.pnlPassword.Controls.Add(this.pbPassword);
            this.pnlPassword.Location = new System.Drawing.Point(199, 374);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(277, 42);
            this.pnlPassword.TabIndex = 7;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(246)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(41, 11);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PlaceholderText = "Password";
            this.tbPassword.Size = new System.Drawing.Size(222, 18);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // pbPassword
            // 
            this.pbPassword.Image = global::Moneygement.Properties.Resources._lock;
            this.pbPassword.Location = new System.Drawing.Point(5, 6);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(30, 30);
            this.pbPassword.TabIndex = 1;
            this.pbPassword.TabStop = false;
            this.pbPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPassword_MouseDown);
            this.pbPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPassword_MouseUp);
            // 
            // pnlPhone
            // 
            this.pnlPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPhone.Controls.Add(this.tbPhone);
            this.pnlPhone.Controls.Add(this.pbPhone);
            this.pnlPhone.Location = new System.Drawing.Point(199, 326);
            this.pnlPhone.Name = "pnlPhone";
            this.pnlPhone.Size = new System.Drawing.Size(277, 42);
            this.pnlPhone.TabIndex = 6;
            // 
            // tbPhone
            // 
            this.tbPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(246)))));
            this.tbPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPhone.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPhone.Location = new System.Drawing.Point(41, 11);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.PlaceholderText = "Phone";
            this.tbPhone.Size = new System.Drawing.Size(222, 18);
            this.tbPhone.TabIndex = 2;
            // 
            // pbPhone
            // 
            this.pbPhone.Image = global::Moneygement.Properties.Resources.Phoneicon2;
            this.pbPhone.Location = new System.Drawing.Point(5, 6);
            this.pbPhone.Name = "pbPhone";
            this.pbPhone.Size = new System.Drawing.Size(30, 30);
            this.pbPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPhone.TabIndex = 1;
            this.pbPhone.TabStop = false;
            // 
            // pnlName
            // 
            this.pnlName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlName.Controls.Add(this.tbName);
            this.pnlName.Controls.Add(this.pbName);
            this.pnlName.Location = new System.Drawing.Point(199, 230);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(277, 42);
            this.pnlName.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(246)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbName.Location = new System.Drawing.Point(41, 11);
            this.tbName.Name = "tbName";
            this.tbName.PlaceholderText = "Name";
            this.tbName.Size = new System.Drawing.Size(222, 18);
            this.tbName.TabIndex = 1;
            // 
            // pbName
            // 
            this.pbName.Image = global::Moneygement.Properties.Resources.user;
            this.pbName.InitialImage = null;
            this.pbName.Location = new System.Drawing.Point(5, 6);
            this.pbName.Name = "pbName";
            this.pbName.Size = new System.Drawing.Size(30, 30);
            this.pbName.TabIndex = 0;
            this.pbName.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(190)))), ((int)(((byte)(203)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(190)))), ((int)(((byte)(203)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(199, 441);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(277, 35);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Create Account";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlEmail
            // 
            this.pnlEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmail.Controls.Add(this.tbEmail);
            this.pnlEmail.Controls.Add(this.pbEmail);
            this.pnlEmail.Location = new System.Drawing.Point(199, 278);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(277, 42);
            this.pnlEmail.TabIndex = 5;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(246)))));
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.Location = new System.Drawing.Point(41, 11);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PlaceholderText = "Email";
            this.tbEmail.Size = new System.Drawing.Size(222, 18);
            this.tbEmail.TabIndex = 2;
            // 
            // pbEmail
            // 
            this.pbEmail.Image = global::Moneygement.Properties.Resources.Emailicon3;
            this.pbEmail.InitialImage = null;
            this.pbEmail.Location = new System.Drawing.Point(5, 7);
            this.pbEmail.Name = "pbEmail";
            this.pbEmail.Size = new System.Drawing.Size(30, 30);
            this.pbEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbEmail.TabIndex = 1;
            this.pbEmail.TabStop = false;
            // 
            // pnlUsername
            // 
            this.pnlUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsername.Controls.Add(this.tbUsername);
            this.pnlUsername.Controls.Add(this.pbUsername);
            this.pnlUsername.Location = new System.Drawing.Point(199, 182);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(277, 42);
            this.pnlUsername.TabIndex = 4;
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(246)))));
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUsername.Location = new System.Drawing.Point(41, 11);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PlaceholderText = "Username";
            this.tbUsername.Size = new System.Drawing.Size(222, 18);
            this.tbUsername.TabIndex = 1;
            // 
            // pbUsername
            // 
            this.pbUsername.Image = global::Moneygement.Properties.Resources.user;
            this.pbUsername.InitialImage = null;
            this.pbUsername.Location = new System.Drawing.Point(5, 6);
            this.pbUsername.Name = "pbUsername";
            this.pbUsername.Size = new System.Drawing.Size(30, 30);
            this.pbUsername.TabIndex = 0;
            this.pbUsername.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Poppins Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.lblLogin.Location = new System.Drawing.Point(224, 128);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(214, 34);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Sign up new account";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::Moneygement.Properties.Resources.Vector;
            this.btnMinimize.Location = new System.Drawing.Point(572, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Moneygement.Properties.Resources.X;
            this.btnClose.Location = new System.Drawing.Point(614, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SignupPage
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignupPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignupPage";
            this.pnlSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            this.pnlPhone.ResumeLayout(false);
            this.pnlPhone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhone)).EndInit();
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).EndInit();
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).EndInit();
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).EndInit();
            this.ResumeLayout(false);

        }

        private Panel pnlSide;
        private PictureBox pbLogo;
        private Panel pnlMain;
        private Button btnMinimize;
        private Button btnClose;
        private Label lblLogin;
        private Panel pnlEmail;
        private PictureBox pbEmail;
        private Panel pnlUsername;
        private PictureBox pbUsername;
        private TextBox tbEmail;
        private TextBox tbUsername;
        private Button btnLogin;
        private Panel pnlPassword;
        private TextBox tbPassword;
        private PictureBox pbPassword;
        private Panel pnlPhone;
        private TextBox tbPhone;
        private PictureBox pbPhone;
        private Panel pnlName;
        private TextBox tbName;
        private PictureBox pbName;
        private Button btnBack;
    }
    #endregion
}