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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panelDesktop = new Panel();
            btnClose = new FontAwesome.Sharp.IconPictureBox();
            panel1 = new Panel();
            btnLinkedin = new FontAwesome.Sharp.IconPictureBox();
            btnInstagram = new FontAwesome.Sharp.IconPictureBox();
            btnGitHub = new FontAwesome.Sharp.IconPictureBox();
            btnHome = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            gbxConexaoBanco = new GroupBox();
            txtPort = new TextBox();
            btnConectar = new FontAwesome.Sharp.IconButton();
            lblPort = new Label();
            txtHost = new TextBox();
            lblPassword = new Label();
            txtDatabase = new TextBox();
            lblDatabase = new Label();
            txtUser = new TextBox();
            lblUser = new Label();
            txtPassword = new TextBox();
            lblHost = new Label();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnLinkedin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnInstagram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnGitHub).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            gbxConexaoBanco.SuspendLayout();
            SuspendLayout();
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.White;
            panelDesktop.Controls.Add(btnClose);
            panelDesktop.Controls.Add(panel1);
            panelDesktop.Controls.Add(gbxConexaoBanco);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(0, 0);
            panelDesktop.MinimumSize = new Size(1113, 640);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1116, 643);
            panelDesktop.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.ForeColor = Color.FromArgb(57, 57, 57);
            btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            btnClose.IconColor = Color.FromArgb(57, 57, 57);
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 30;
            btnClose.Location = new Point(1079, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 74;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(57, 57, 57);
            panel1.Controls.Add(btnLinkedin);
            panel1.Controls.Add(btnInstagram);
            panel1.Controls.Add(btnGitHub);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 643);
            panel1.TabIndex = 73;
            // 
            // btnLinkedin
            // 
            btnLinkedin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLinkedin.BackColor = Color.Transparent;
            btnLinkedin.IconChar = FontAwesome.Sharp.IconChar.Linkedin;
            btnLinkedin.IconColor = Color.White;
            btnLinkedin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLinkedin.IconSize = 45;
            btnLinkedin.Location = new Point(411, 577);
            btnLinkedin.Name = "btnLinkedin";
            btnLinkedin.Size = new Size(45, 45);
            btnLinkedin.TabIndex = 76;
            btnLinkedin.TabStop = false;
            btnLinkedin.Click += btnLinkedin_Click;
            // 
            // btnInstagram
            // 
            btnInstagram.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnInstagram.BackColor = Color.Transparent;
            btnInstagram.IconChar = FontAwesome.Sharp.IconChar.Instagram;
            btnInstagram.IconColor = Color.White;
            btnInstagram.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInstagram.IconSize = 45;
            btnInstagram.Location = new Point(360, 577);
            btnInstagram.Name = "btnInstagram";
            btnInstagram.Size = new Size(45, 45);
            btnInstagram.TabIndex = 75;
            btnInstagram.TabStop = false;
            btnInstagram.Click += btnInstagram_Click;
            // 
            // btnGitHub
            // 
            btnGitHub.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGitHub.BackColor = Color.Transparent;
            btnGitHub.IconChar = FontAwesome.Sharp.IconChar.Github;
            btnGitHub.IconColor = Color.White;
            btnGitHub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGitHub.IconSize = 45;
            btnGitHub.Location = new Point(309, 577);
            btnGitHub.Name = "btnGitHub";
            btnGitHub.Size = new Size(45, 45);
            btnGitHub.TabIndex = 74;
            btnGitHub.TabStop = false;
            btnGitHub.Click += btnGitHub_Click;
            // 
            // btnHome
            // 
            btnHome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(209, 169);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(114, 109);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 73;
            btnHome.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(77, 298);
            label1.Name = "label1";
            label1.Size = new Size(397, 62);
            label1.TabIndex = 5;
            label1.Text = "Bem-vindo(a) ao ISManager!";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(61, 577);
            label3.Name = "label3";
            label3.Size = new Size(242, 34);
            label3.TabIndex = 5;
            label3.Text = "Desenvolvido por: André Oliveira";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gbxConexaoBanco
            // 
            gbxConexaoBanco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gbxConexaoBanco.Controls.Add(txtPort);
            gbxConexaoBanco.Controls.Add(btnConectar);
            gbxConexaoBanco.Controls.Add(lblPort);
            gbxConexaoBanco.Controls.Add(txtHost);
            gbxConexaoBanco.Controls.Add(lblPassword);
            gbxConexaoBanco.Controls.Add(txtDatabase);
            gbxConexaoBanco.Controls.Add(lblDatabase);
            gbxConexaoBanco.Controls.Add(txtUser);
            gbxConexaoBanco.Controls.Add(lblUser);
            gbxConexaoBanco.Controls.Add(txtPassword);
            gbxConexaoBanco.Controls.Add(lblHost);
            gbxConexaoBanco.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxConexaoBanco.ForeColor = Color.FromArgb(57, 57, 57);
            gbxConexaoBanco.Location = new Point(720, 68);
            gbxConexaoBanco.Name = "gbxConexaoBanco";
            gbxConexaoBanco.Size = new Size(257, 512);
            gbxConexaoBanco.TabIndex = 71;
            gbxConexaoBanco.TabStop = false;
            gbxConexaoBanco.Text = "Conectar ao MySQL";
            // 
            // txtPort
            // 
            txtPort.BackColor = Color.FromArgb(241, 243, 244);
            txtPort.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPort.ForeColor = Color.FromArgb(57, 57, 57);
            txtPort.Location = new Point(60, 133);
            txtPort.MaxLength = 80;
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(132, 33);
            txtPort.TabIndex = 64;
            txtPort.Text = "3306";
            txtPort.TextAlign = HorizontalAlignment.Center;
            // 
            // btnConectar
            // 
            btnConectar.BackColor = Color.SeaGreen;
            btnConectar.FlatStyle = FlatStyle.Flat;
            btnConectar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConectar.ForeColor = Color.FromArgb(57, 57, 57);
            btnConectar.IconChar = FontAwesome.Sharp.IconChar.Database;
            btnConectar.IconColor = Color.FromArgb(57, 57, 57);
            btnConectar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConectar.IconSize = 30;
            btnConectar.ImageAlign = ContentAlignment.MiddleRight;
            btnConectar.Location = new Point(62, 440);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(132, 38);
            btnConectar.TabIndex = 59;
            btnConectar.Text = "    Conectar";
            btnConectar.TextAlign = ContentAlignment.MiddleLeft;
            btnConectar.UseVisualStyleBackColor = false;
            btnConectar.Click += btnConectar_Click;
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.BackColor = Color.Transparent;
            lblPort.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPort.ForeColor = Color.FromArgb(57, 57, 57);
            lblPort.Location = new Point(101, 110);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(51, 25);
            lblPort.TabIndex = 68;
            lblPort.Text = "Port";
            // 
            // txtHost
            // 
            txtHost.BackColor = Color.FromArgb(241, 243, 244);
            txtHost.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHost.ForeColor = Color.FromArgb(57, 57, 57);
            txtHost.Location = new Point(60, 60);
            txtHost.MaxLength = 80;
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(132, 33);
            txtHost.TabIndex = 60;
            txtHost.Text = "localhost";
            txtHost.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(57, 57, 57);
            lblPassword.Location = new Point(79, 264);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(97, 25);
            lblPassword.TabIndex = 69;
            lblPassword.Text = "Password";
            // 
            // txtDatabase
            // 
            txtDatabase.BackColor = Color.FromArgb(241, 243, 244);
            txtDatabase.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDatabase.ForeColor = Color.FromArgb(57, 57, 57);
            txtDatabase.Location = new Point(62, 375);
            txtDatabase.MaxLength = 80;
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(132, 33);
            txtDatabase.TabIndex = 61;
            txtDatabase.Text = "ismanager";
            txtDatabase.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDatabase
            // 
            lblDatabase.AutoSize = true;
            lblDatabase.BackColor = Color.Transparent;
            lblDatabase.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatabase.ForeColor = Color.FromArgb(57, 57, 57);
            lblDatabase.Location = new Point(79, 347);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(93, 25);
            lblDatabase.TabIndex = 65;
            lblDatabase.Text = "Database";
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(241, 243, 244);
            txtUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.ForeColor = Color.FromArgb(57, 57, 57);
            txtUser.Location = new Point(62, 213);
            txtUser.MaxLength = 80;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(132, 33);
            txtUser.TabIndex = 62;
            txtUser.Text = "root";
            txtUser.TextAlign = HorizontalAlignment.Center;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.FromArgb(57, 57, 57);
            lblUser.Location = new Point(101, 185);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(52, 25);
            lblUser.TabIndex = 66;
            lblUser.Text = "User";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(241, 243, 244);
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(57, 57, 57);
            txtPassword.Location = new Point(62, 292);
            txtPassword.MaxLength = 80;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(132, 33);
            txtPassword.TabIndex = 63;
            txtPassword.Text = "061127";
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // lblHost
            // 
            lblHost.AutoSize = true;
            lblHost.BackColor = Color.Transparent;
            lblHost.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHost.ForeColor = Color.FromArgb(57, 57, 57);
            lblHost.Location = new Point(101, 35);
            lblHost.Name = "lblHost";
            lblHost.Size = new Size(54, 25);
            lblHost.TabIndex = 67;
            lblHost.Text = "Host";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 643);
            Controls.Add(panelDesktop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnLinkedin).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnInstagram).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnGitHub).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            gbxConexaoBanco.ResumeLayout(false);
            gbxConexaoBanco.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDesktop;
        private Label label3;
        private Label label1;
        private GroupBox gbxConexaoBanco;
        public TextBox txtPort;
        private FontAwesome.Sharp.IconButton btnConectar;
        private Label lblPort;
        public TextBox txtHost;
        private Label lblPassword;
        public TextBox txtDatabase;
        private Label lblDatabase;
        public TextBox txtUser;
        private Label lblUser;
        public TextBox txtPassword;
        private Label lblHost;
        private Panel panel1;
        private PictureBox btnHome;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private FontAwesome.Sharp.IconPictureBox btnLinkedin;
        private FontAwesome.Sharp.IconPictureBox btnInstagram;
        private FontAwesome.Sharp.IconPictureBox btnGitHub;
    }
}