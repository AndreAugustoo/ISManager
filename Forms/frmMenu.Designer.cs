﻿namespace ISManager
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            panelMenu = new Panel();
            pnlNav = new Panel();
            btnSair = new FontAwesome.Sharp.IconButton();
            btnMigracoes = new FontAwesome.Sharp.IconButton();
            btnClientes = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            lblNome = new Label();
            lblSubNome = new Label();
            btnHome = new PictureBox();
            panelDesktop = new Panel();
            label2 = new Label();
            label1 = new Label();
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
            panelTitleBar = new Panel();
            btnMinimaze = new FontAwesome.Sharp.IconPictureBox();
            btnMaximaze = new FontAwesome.Sharp.IconPictureBox();
            btnClose = new FontAwesome.Sharp.IconPictureBox();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelDesktop.SuspendLayout();
            gbxConexaoBanco.SuspendLayout();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimaze).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximaze).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(24, 30, 54);
            panelMenu.Controls.Add(pnlNav);
            panelMenu.Controls.Add(btnSair);
            panelMenu.Controls.Add(btnMigracoes);
            panelMenu.Controls.Add(btnClientes);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(186, 700);
            panelMenu.TabIndex = 0;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.White;
            pnlNav.Location = new Point(0, 193);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(5, 100);
            pnlNav.TabIndex = 3;
            pnlNav.Visible = false;
            // 
            // btnSair
            // 
            btnSair.Dock = DockStyle.Bottom;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSair.ForeColor = Color.White;
            btnSair.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            btnSair.IconColor = Color.White;
            btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSair.IconSize = 34;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(0, 650);
            btnSair.Name = "btnSair";
            btnSair.Padding = new Padding(10, 0, 0, 0);
            btnSair.Size = new Size(186, 50);
            btnSair.TabIndex = 7;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnMigracoes
            // 
            btnMigracoes.Dock = DockStyle.Top;
            btnMigracoes.FlatAppearance.BorderSize = 0;
            btnMigracoes.FlatStyle = FlatStyle.Flat;
            btnMigracoes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMigracoes.ForeColor = Color.White;
            btnMigracoes.IconChar = FontAwesome.Sharp.IconChar.NetworkWired;
            btnMigracoes.IconColor = Color.White;
            btnMigracoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMigracoes.IconSize = 34;
            btnMigracoes.ImageAlign = ContentAlignment.MiddleLeft;
            btnMigracoes.Location = new Point(0, 248);
            btnMigracoes.Name = "btnMigracoes";
            btnMigracoes.Padding = new Padding(10, 0, 0, 0);
            btnMigracoes.Size = new Size(186, 50);
            btnMigracoes.TabIndex = 6;
            btnMigracoes.Text = "Migrações";
            btnMigracoes.UseVisualStyleBackColor = true;
            btnMigracoes.Click += btnMigracoes_Click;
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClientes.ForeColor = Color.White;
            btnClientes.IconChar = FontAwesome.Sharp.IconChar.User;
            btnClientes.IconColor = Color.White;
            btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClientes.IconSize = 34;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 198);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(10, 0, 0, 0);
            btnClientes.Size = new Size(186, 50);
            btnClientes.TabIndex = 5;
            btnClientes.Text = "Implantações";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            btnDashboard.IconColor = Color.White;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.IconSize = 34;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 148);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(186, 50);
            btnDashboard.TabIndex = 4;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(lblNome);
            panelLogo.Controls.Add(lblSubNome);
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(186, 148);
            panelLogo.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(52, 88);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(79, 17);
            lblNome.TabIndex = 3;
            lblNome.Text = "TopGerente";
            // 
            // lblSubNome
            // 
            lblSubNome.AutoSize = true;
            lblSubNome.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubNome.ForeColor = Color.FromArgb(158, 161, 176);
            lblSubNome.Location = new Point(58, 110);
            lblSubNome.Name = "lblSubNome";
            lblSubNome.Size = new Size(63, 13);
            lblSubNome.TabIndex = 2;
            lblSubNome.Text = "ISManager";
            // 
            // btnHome
            // 
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(60, 22);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(63, 63);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(46, 51, 73);
            panelDesktop.Controls.Add(label2);
            panelDesktop.Controls.Add(label1);
            panelDesktop.Controls.Add(gbxConexaoBanco);
            panelDesktop.Location = new Point(186, 61);
            panelDesktop.MinimumSize = new Size(1114, 639);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1114, 639);
            panelDesktop.TabIndex = 4;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(81, 165);
            label2.Name = "label2";
            label2.Size = new Size(520, 312);
            label2.TabIndex = 72;
            label2.Text = "Para fazer uso do sistema \r\né necessário realizar \r\numa conexão com banco\r\nde dados  ao lado.\r\n\r\nCaso não possua\r\num acesso, será preciso\r\ncontatar o responsável.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(103, 59);
            label1.Name = "label1";
            label1.Size = new Size(520, 62);
            label1.TabIndex = 5;
            label1.Text = "Bem-vindo(a) ao ISManager!";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gbxConexaoBanco
            // 
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
            gbxConexaoBanco.ForeColor = Color.White;
            gbxConexaoBanco.Location = new Point(763, 49);
            gbxConexaoBanco.Name = "gbxConexaoBanco";
            gbxConexaoBanco.Size = new Size(257, 512);
            gbxConexaoBanco.TabIndex = 71;
            gbxConexaoBanco.TabStop = false;
            gbxConexaoBanco.Text = "Conectar ao MySQL";
            // 
            // txtPort
            // 
            txtPort.BackColor = Color.FromArgb(46, 51, 73);
            txtPort.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPort.ForeColor = Color.White;
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
            btnConectar.ForeColor = Color.FromArgb(46, 51, 73);
            btnConectar.IconChar = FontAwesome.Sharp.IconChar.Database;
            btnConectar.IconColor = Color.FromArgb(46, 51, 73);
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
            lblPort.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPort.ForeColor = Color.White;
            lblPort.Location = new Point(101, 110);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(51, 25);
            lblPort.TabIndex = 68;
            lblPort.Text = "Port";
            // 
            // txtHost
            // 
            txtHost.BackColor = Color.FromArgb(46, 51, 73);
            txtHost.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHost.ForeColor = Color.White;
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
            lblPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(79, 264);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(97, 25);
            lblPassword.TabIndex = 69;
            lblPassword.Text = "Password";
            // 
            // txtDatabase
            // 
            txtDatabase.BackColor = Color.FromArgb(46, 51, 73);
            txtDatabase.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDatabase.ForeColor = Color.White;
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
            lblDatabase.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatabase.ForeColor = Color.White;
            lblDatabase.Location = new Point(79, 347);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(93, 25);
            lblDatabase.TabIndex = 65;
            lblDatabase.Text = "Database";
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(46, 51, 73);
            txtUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.ForeColor = Color.White;
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
            lblUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(101, 185);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(52, 25);
            lblUser.TabIndex = 66;
            lblUser.Text = "User";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(46, 51, 73);
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.White;
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
            lblHost.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHost.ForeColor = Color.White;
            lblHost.Location = new Point(101, 35);
            lblHost.Name = "lblHost";
            lblHost.Size = new Size(54, 25);
            lblHost.TabIndex = 67;
            lblHost.Text = "Host";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(24, 30, 54);
            panelTitleBar.Controls.Add(btnMinimaze);
            panelTitleBar.Controls.Add(btnMaximaze);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(186, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1114, 55);
            panelTitleBar.TabIndex = 5;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMinimaze
            // 
            btnMinimaze.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimaze.BackColor = Color.FromArgb(24, 30, 54);
            btnMinimaze.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimaze.IconColor = Color.White;
            btnMinimaze.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimaze.IconSize = 25;
            btnMinimaze.Location = new Point(1024, 3);
            btnMinimaze.Name = "btnMinimaze";
            btnMinimaze.Size = new Size(25, 25);
            btnMinimaze.TabIndex = 4;
            btnMinimaze.TabStop = false;
            btnMinimaze.Click += btnMinimaze_Click;
            // 
            // btnMaximaze
            // 
            btnMaximaze.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximaze.BackColor = Color.FromArgb(24, 30, 54);
            btnMaximaze.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximaze.IconColor = Color.White;
            btnMaximaze.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximaze.IconSize = 25;
            btnMaximaze.Location = new Point(1055, 3);
            btnMaximaze.Name = "btnMaximaze";
            btnMaximaze.Size = new Size(25, 25);
            btnMaximaze.TabIndex = 3;
            btnMaximaze.TabStop = false;
            btnMaximaze.Click += btnMaximaze_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(24, 30, 54);
            btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            btnClose.IconColor = Color.White;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 25;
            btnClose.Location = new Point(1086, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.TabIndex = 2;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitleChildForm.ForeColor = Color.White;
            lblTitleChildForm.Location = new Point(53, 16);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(176, 34);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Home";
            lblTitleChildForm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(24, 30, 54);
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            iconCurrentChildForm.IconColor = Color.White;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 34;
            iconCurrentChildForm.Location = new Point(13, 16);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(34, 34);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(24, 30, 67);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(186, 55);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(1114, 5);
            panelShadow.TabIndex = 6;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 54);
            ClientSize = new Size(1300, 700);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelDesktop);
            Controls.Add(panelMenu);
            ForeColor = Color.FromArgb(24, 30, 54);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ISManager";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelDesktop.ResumeLayout(false);
            gbxConexaoBanco.ResumeLayout(false);
            gbxConexaoBanco.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimaze).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximaze).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Label lblSubNome;
        private PictureBox btnHome;
        private Button btnMigracoe;
        private Panel pnlNav;
        private Label lblNome;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnSair;
        private FontAwesome.Sharp.IconButton btnMigracoes;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel panelShadow;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private FontAwesome.Sharp.IconPictureBox btnMinimaze;
        private FontAwesome.Sharp.IconPictureBox btnMaximaze;
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
        private Label label2;
        private Label label1;
    }
}
