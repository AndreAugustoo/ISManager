namespace ISManager
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
            btnReembolso = new FontAwesome.Sharp.IconButton();
            btnRetreinamento = new FontAwesome.Sharp.IconButton();
            btnDocumentacao = new FontAwesome.Sharp.IconButton();
            btnSair = new FontAwesome.Sharp.IconButton();
            btnMigracoes = new FontAwesome.Sharp.IconButton();
            btnClientes = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            lblNome = new Label();
            lblSubNome = new Label();
            btnHome = new PictureBox();
            tgbChangeTheme = new Class.CustomToggleButton();
            panelDesktop = new Panel();
            panelTitleBar = new Panel();
            themeIcon = new PictureBox();
            btnMinimaze = new FontAwesome.Sharp.IconPictureBox();
            btnMaximaze = new FontAwesome.Sharp.IconPictureBox();
            btnClose = new FontAwesome.Sharp.IconPictureBox();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)themeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimaze).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximaze).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.White;
            panelMenu.Controls.Add(btnReembolso);
            panelMenu.Controls.Add(btnRetreinamento);
            panelMenu.Controls.Add(btnDocumentacao);
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
            // btnReembolso
            // 
            btnReembolso.Dock = DockStyle.Top;
            btnReembolso.FlatAppearance.BorderSize = 0;
            btnReembolso.FlatStyle = FlatStyle.Flat;
            btnReembolso.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReembolso.ForeColor = Color.FromArgb(57, 57, 57);
            btnReembolso.IconChar = FontAwesome.Sharp.IconChar.Automobile;
            btnReembolso.IconColor = Color.FromArgb(57, 57, 57);
            btnReembolso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReembolso.IconSize = 34;
            btnReembolso.ImageAlign = ContentAlignment.MiddleLeft;
            btnReembolso.Location = new Point(0, 398);
            btnReembolso.Name = "btnReembolso";
            btnReembolso.Padding = new Padding(10, 0, 0, 0);
            btnReembolso.Size = new Size(186, 50);
            btnReembolso.TabIndex = 10;
            btnReembolso.Text = "Reembolso";
            btnReembolso.UseVisualStyleBackColor = true;
            btnReembolso.Click += btnReembolso_Click;
            // 
            // btnRetreinamento
            // 
            btnRetreinamento.Dock = DockStyle.Top;
            btnRetreinamento.FlatAppearance.BorderSize = 0;
            btnRetreinamento.FlatStyle = FlatStyle.Flat;
            btnRetreinamento.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRetreinamento.ForeColor = Color.FromArgb(57, 57, 57);
            btnRetreinamento.IconChar = FontAwesome.Sharp.IconChar.PersonChalkboard;
            btnRetreinamento.IconColor = Color.FromArgb(57, 57, 57);
            btnRetreinamento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRetreinamento.IconSize = 34;
            btnRetreinamento.ImageAlign = ContentAlignment.MiddleLeft;
            btnRetreinamento.Location = new Point(0, 348);
            btnRetreinamento.Name = "btnRetreinamento";
            btnRetreinamento.Padding = new Padding(10, 0, 0, 0);
            btnRetreinamento.Size = new Size(186, 50);
            btnRetreinamento.TabIndex = 9;
            btnRetreinamento.Text = "Retreinamento";
            btnRetreinamento.UseVisualStyleBackColor = true;
            btnRetreinamento.Click += btnRetreinamento_Click;
            // 
            // btnDocumentacao
            // 
            btnDocumentacao.Dock = DockStyle.Top;
            btnDocumentacao.FlatAppearance.BorderSize = 0;
            btnDocumentacao.FlatStyle = FlatStyle.Flat;
            btnDocumentacao.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDocumentacao.ForeColor = Color.FromArgb(57, 57, 57);
            btnDocumentacao.IconChar = FontAwesome.Sharp.IconChar.File;
            btnDocumentacao.IconColor = Color.FromArgb(57, 57, 57);
            btnDocumentacao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDocumentacao.IconSize = 31;
            btnDocumentacao.ImageAlign = ContentAlignment.MiddleLeft;
            btnDocumentacao.Location = new Point(0, 298);
            btnDocumentacao.Name = "btnDocumentacao";
            btnDocumentacao.Padding = new Padding(10, 0, 0, 0);
            btnDocumentacao.Size = new Size(186, 50);
            btnDocumentacao.TabIndex = 8;
            btnDocumentacao.Text = "Documentação";
            btnDocumentacao.UseVisualStyleBackColor = true;
            btnDocumentacao.Click += btnDocumentacao_Click;
            // 
            // btnSair
            // 
            btnSair.Dock = DockStyle.Bottom;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSair.ForeColor = Color.FromArgb(57, 57, 57);
            btnSair.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            btnSair.IconColor = Color.FromArgb(57, 57, 57);
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
            btnMigracoes.ForeColor = Color.FromArgb(57, 57, 57);
            btnMigracoes.IconChar = FontAwesome.Sharp.IconChar.NetworkWired;
            btnMigracoes.IconColor = Color.FromArgb(57, 57, 57);
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
            btnClientes.ForeColor = Color.FromArgb(57, 57, 57);
            btnClientes.IconChar = FontAwesome.Sharp.IconChar.User;
            btnClientes.IconColor = Color.FromArgb(57, 57, 57);
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
            btnDashboard.ForeColor = Color.FromArgb(57, 57, 57);
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            btnDashboard.IconColor = Color.FromArgb(57, 57, 57);
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
            lblNome.ForeColor = Color.FromArgb(57, 57, 57);
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
            lblSubNome.ForeColor = Color.FromArgb(97, 97, 97);
            lblSubNome.Location = new Point(60, 110);
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
            // tgbChangeTheme
            // 
            tgbChangeTheme.AutoSize = true;
            tgbChangeTheme.Location = new Point(962, 6);
            tgbChangeTheme.MinimumSize = new Size(45, 22);
            tgbChangeTheme.Name = "tgbChangeTheme";
            tgbChangeTheme.OffBackColor = Color.FromArgb(57, 57, 57);
            tgbChangeTheme.OffToggleColor = Color.Gainsboro;
            tgbChangeTheme.OnBackColor = Color.Gainsboro;
            tgbChangeTheme.OnToggleColor = Color.White;
            tgbChangeTheme.Size = new Size(45, 22);
            tgbChangeTheme.TabIndex = 8;
            tgbChangeTheme.UseVisualStyleBackColor = true;
            tgbChangeTheme.CheckedChanged += tgbChangeTheme_CheckedChanged;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.White;
            panelDesktop.BackgroundImage = Properties.Resources.backgroundHome;
            panelDesktop.BackgroundImageLayout = ImageLayout.Zoom;
            panelDesktop.Location = new Point(187, 61);
            panelDesktop.MinimumSize = new Size(1113, 640);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1113, 640);
            panelDesktop.TabIndex = 4;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.White;
            panelTitleBar.Controls.Add(themeIcon);
            panelTitleBar.Controls.Add(btnMinimaze);
            panelTitleBar.Controls.Add(tgbChangeTheme);
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
            // themeIcon
            // 
            themeIcon.BackColor = Color.Transparent;
            themeIcon.Image = Properties.Resources.sunDark;
            themeIcon.InitialImage = Properties.Resources.calendarDark;
            themeIcon.Location = new Point(930, 3);
            themeIcon.Name = "themeIcon";
            themeIcon.Size = new Size(26, 26);
            themeIcon.SizeMode = PictureBoxSizeMode.Zoom;
            themeIcon.TabIndex = 9;
            themeIcon.TabStop = false;
            // 
            // btnMinimaze
            // 
            btnMinimaze.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimaze.BackColor = Color.Transparent;
            btnMinimaze.ForeColor = Color.FromArgb(57, 57, 57);
            btnMinimaze.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimaze.IconColor = Color.FromArgb(57, 57, 57);
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
            btnMaximaze.BackColor = Color.Transparent;
            btnMaximaze.ForeColor = Color.FromArgb(57, 57, 57);
            btnMaximaze.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximaze.IconColor = Color.FromArgb(57, 57, 57);
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
            btnClose.BackColor = Color.Transparent;
            btnClose.ForeColor = Color.FromArgb(57, 57, 57);
            btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            btnClose.IconColor = Color.FromArgb(57, 57, 57);
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
            lblTitleChildForm.BackColor = Color.Transparent;
            lblTitleChildForm.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitleChildForm.ForeColor = Color.FromArgb(82, 67, 254);
            lblTitleChildForm.Location = new Point(53, 16);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(176, 34);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Home";
            lblTitleChildForm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.Transparent;
            iconCurrentChildForm.ForeColor = Color.FromArgb(82, 67, 254);
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            iconCurrentChildForm.IconColor = Color.FromArgb(82, 67, 254);
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
            panelShadow.BackColor = Color.White;
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
            BackColor = Color.FromArgb(57, 57, 57);
            ClientSize = new Size(1300, 700);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelDesktop);
            Controls.Add(panelMenu);
            ForeColor = Color.FromArgb(241, 243, 244);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ISManager";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)themeIcon).EndInit();
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
        public Class.CustomToggleButton tgbChangeTheme;
        private PictureBox themeIcon;
        private FontAwesome.Sharp.IconButton btnRetreinamento;
        private FontAwesome.Sharp.IconButton btnDocumentacao;
        private FontAwesome.Sharp.IconButton btnReembolso;
    }
}
