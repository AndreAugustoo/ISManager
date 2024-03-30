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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            panel1 = new Panel();
            pnlNav = new Panel();
            btnSair = new Button();
            btnMigracoes = new Button();
            btnClientes = new Button();
            btnDashboard = new Button();
            panel2 = new Panel();
            lblNome = new Label();
            lblSubNome = new Label();
            pictureBox1 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            pnlFormLoader = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
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
            panel1.Size = new Size(186, 577);
            panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.SteelBlue;
            pnlNav.Location = new Point(0, 193);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(3, 100);
            pnlNav.TabIndex = 3;
            // 
            // btnSair
            // 
            btnSair.Dock = DockStyle.Bottom;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.FromArgb(0, 126, 249);
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(0, 535);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(186, 42);
            btnSair.TabIndex = 1;
            btnSair.Text = "Sair";
            btnSair.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            btnSair.Leave += btnSair_Leave;
            // 
            // btnMigracoes
            // 
            btnMigracoes.Dock = DockStyle.Top;
            btnMigracoes.FlatAppearance.BorderSize = 0;
            btnMigracoes.FlatStyle = FlatStyle.Flat;
            btnMigracoes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMigracoes.ForeColor = Color.FromArgb(0, 126, 249);
            btnMigracoes.ImageAlign = ContentAlignment.MiddleLeft;
            btnMigracoes.Location = new Point(0, 232);
            btnMigracoes.Name = "btnMigracoes";
            btnMigracoes.Size = new Size(186, 42);
            btnMigracoes.TabIndex = 1;
            btnMigracoes.Text = "Migrações";
            btnMigracoes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMigracoes.UseVisualStyleBackColor = true;
            btnMigracoes.Click += btnMigracoes_Click;
            btnMigracoes.Leave += btnMigracoes_Leave;
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.FromArgb(0, 126, 249);
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 190);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(186, 42);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            btnClientes.Leave += btnClientes_Leave;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.FromArgb(0, 126, 249);
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 148);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(186, 42);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            btnDashboard.Leave += btnDashboard_Leave;
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
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.Dock = DockStyle.Bottom;
            pnlFormLoader.Location = new Point(186, 0);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(765, 577);
            pnlFormLoader.TabIndex = 4;
            pnlFormLoader.Paint += pnlFormLoader_Paint;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 577);
            Controls.Add(pnlFormLoader);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblSubNome;
        private PictureBox pictureBox1;
        private Button btnDashboard;
        private Button btnSair;
        private Button btnMigracoes;
        private Button btnClientes;
        private Panel pnlNav;
        private Label lblNome;
        private ErrorProvider errorProvider1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Panel pnlFormLoader;
    }
}
