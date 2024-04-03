namespace ISManager.Forms
{
    partial class frmLogin
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
            btnConectar = new FontAwesome.Sharp.IconButton();
            txtHost = new TextBox();
            txtDatabase = new TextBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            txtPort = new TextBox();
            lblHost = new Label();
            lblPassword = new Label();
            lblUser = new Label();
            lblPort = new Label();
            lblDatabase = new Label();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.BackColor = Color.SeaGreen;
            btnConectar.FlatStyle = FlatStyle.Flat;
            btnConectar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConectar.ForeColor = Color.FromArgb(46, 51, 73);
            btnConectar.IconChar = FontAwesome.Sharp.IconChar.Database;
            btnConectar.IconColor = Color.FromArgb(46, 51, 73);
            btnConectar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConectar.IconSize = 30;
            btnConectar.ImageAlign = ContentAlignment.MiddleRight;
            btnConectar.Location = new Point(304, 344);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(132, 38);
            btnConectar.TabIndex = 12;
            btnConectar.Text = "    Conectar";
            btnConectar.TextAlign = ContentAlignment.MiddleLeft;
            btnConectar.UseVisualStyleBackColor = false;
            // 
            // txtHost
            // 
            txtHost.BackColor = Color.FromArgb(46, 51, 73);
            txtHost.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHost.ForeColor = Color.White;
            txtHost.Location = new Point(196, 82);
            txtHost.MaxLength = 80;
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(132, 33);
            txtHost.TabIndex = 13;
            txtHost.Text = "localhost";
            txtHost.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDatabase
            // 
            txtDatabase.BackColor = Color.FromArgb(46, 51, 73);
            txtDatabase.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDatabase.ForeColor = Color.White;
            txtDatabase.Location = new Point(196, 249);
            txtDatabase.MaxLength = 80;
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(132, 33);
            txtDatabase.TabIndex = 14;
            txtDatabase.Text = "ismanger";
            txtDatabase.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(46, 51, 73);
            txtUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.ForeColor = Color.White;
            txtUser.Location = new Point(196, 161);
            txtUser.MaxLength = 80;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(132, 33);
            txtUser.TabIndex = 15;
            txtUser.Text = "root";
            txtUser.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(46, 51, 73);
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(412, 161);
            txtPassword.MaxLength = 80;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(132, 33);
            txtPassword.TabIndex = 16;
            txtPassword.Text = "061127";
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPort
            // 
            txtPort.BackColor = Color.FromArgb(46, 51, 73);
            txtPort.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPort.ForeColor = Color.White;
            txtPort.Location = new Point(412, 82);
            txtPort.MaxLength = 80;
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(132, 33);
            txtPort.TabIndex = 17;
            txtPort.Text = "3306";
            txtPort.TextAlign = HorizontalAlignment.Center;
            // 
            // lblHost
            // 
            lblHost.AutoSize = true;
            lblHost.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHost.ForeColor = Color.White;
            lblHost.Location = new Point(196, 54);
            lblHost.Name = "lblHost";
            lblHost.Size = new Size(54, 25);
            lblHost.TabIndex = 56;
            lblHost.Text = "Host";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(412, 128);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(97, 25);
            lblPassword.TabIndex = 57;
            lblPassword.Text = "Password";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(196, 128);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(52, 25);
            lblUser.TabIndex = 56;
            lblUser.Text = "User";
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPort.ForeColor = Color.White;
            lblPort.Location = new Point(412, 54);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(51, 25);
            lblPort.TabIndex = 57;
            lblPort.Text = "Port";
            // 
            // lblDatabase
            // 
            lblDatabase.AutoSize = true;
            lblDatabase.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatabase.ForeColor = Color.White;
            lblDatabase.Location = new Point(196, 221);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(93, 25);
            lblDatabase.TabIndex = 56;
            lblDatabase.Text = "Database";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 54);
            ClientSize = new Size(687, 450);
            Controls.Add(lblPort);
            Controls.Add(lblPassword);
            Controls.Add(lblDatabase);
            Controls.Add(lblUser);
            Controls.Add(lblHost);
            Controls.Add(txtPort);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(txtDatabase);
            Controls.Add(txtHost);
            Controls.Add(btnConectar);
            Name = "frmLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnConectar;
        public TextBox txtHost;
        public TextBox txtDatabase;
        public TextBox txtUser;
        public TextBox txtPassword;
        public TextBox txtPort;
        private Label lblHost;
        private Label lblPassword;
        private Label lblUser;
        private Label lblPort;
        private Label lblDatabase;
    }
}