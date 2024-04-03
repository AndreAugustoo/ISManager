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
            panel1 = new Panel();
            pnlNav = new Panel();
            btnSair = new FontAwesome.Sharp.IconButton();
            btnMigracoes = new FontAwesome.Sharp.IconButton();
            btnClientes = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            lblNome = new Label();
            lblSubNome = new Label();
            pictureBox1 = new PictureBox();
            pnlFormLoader = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(pnlNav);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnMigracoes);
            panel1.Controls.Add(btnClientes);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 700);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.SteelBlue;
            pnlNav.Location = new Point(0, 193);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(5, 100);
            pnlNav.TabIndex = 3;
            // 
            // btnSair
            // 
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSair.ForeColor = Color.FromArgb(0, 126, 249);
            btnSair.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            btnSair.IconColor = Color.FromArgb(0, 126, 249);
            btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSair.IconSize = 34;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(0, 657);
            btnSair.Name = "btnSair";
            btnSair.Padding = new Padding(10, 0, 0, 0);
            btnSair.Size = new Size(186, 44);
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
            btnMigracoes.ForeColor = Color.FromArgb(0, 126, 249);
            btnMigracoes.IconChar = FontAwesome.Sharp.IconChar.NetworkWired;
            btnMigracoes.IconColor = Color.FromArgb(0, 126, 249);
            btnMigracoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMigracoes.IconSize = 34;
            btnMigracoes.ImageAlign = ContentAlignment.MiddleLeft;
            btnMigracoes.Location = new Point(0, 236);
            btnMigracoes.Name = "btnMigracoes";
            btnMigracoes.Padding = new Padding(10, 0, 0, 0);
            btnMigracoes.Size = new Size(186, 44);
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
            btnClientes.ForeColor = Color.FromArgb(0, 126, 249);
            btnClientes.IconChar = FontAwesome.Sharp.IconChar.User;
            btnClientes.IconColor = Color.FromArgb(0, 126, 249);
            btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClientes.IconSize = 34;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 192);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(10, 0, 0, 0);
            btnClientes.Size = new Size(186, 44);
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
            btnDashboard.ForeColor = Color.FromArgb(0, 126, 249);
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            btnDashboard.IconColor = Color.FromArgb(0, 126, 249);
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.IconSize = 34;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 148);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(186, 44);
            btnDashboard.TabIndex = 4;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblNome);
            panel2.Controls.Add(lblSubNome);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 148);
            panel2.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.FromArgb(24, 30, 54);
            lblNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.FromArgb(0, 126, 249);
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
            lblSubNome.Click += lblSubNome_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.BackColor = Color.FromArgb(46, 51, 73);
            pnlFormLoader.Dock = DockStyle.Fill;
            pnlFormLoader.Location = new Point(186, 0);
            pnlFormLoader.MinimumSize = new Size(765, 577);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(1114, 700);
            pnlFormLoader.TabIndex = 4;
            pnlFormLoader.Paint += pnlFormLoader_Paint;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1300, 700);
            Controls.Add(pnlFormLoader);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ISManager";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblSubNome;
        private PictureBox pictureBox1;
        private Button btnMigracoe;
        private Panel pnlNav;
        private Label lblNome;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Panel pnlFormLoader;
        private FontAwesome.Sharp.IconButton btnSair;
        private FontAwesome.Sharp.IconButton btnMigracoes;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnDashboard;
    }
}
