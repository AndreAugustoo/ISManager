namespace ISManager
{
    partial class frmClientes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dtGridClientes = new DataGridView();
            txtFiltro = new TextBox();
            lblClientes = new Label();
            btnSair = new Button();
            lblNumeroRegistro = new Label();
            btnFiltrar = new Button();
            cbxFiltro = new ComboBox();
            btnCadastrar = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dtGridClientes).BeginInit();
            SuspendLayout();
            // 
            // dtGridClientes
            // 
            dtGridClientes.AllowUserToAddRows = false;
            dtGridClientes.AllowUserToDeleteRows = false;
            dtGridClientes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(46, 51, 73);
            dtGridClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtGridClientes.BackgroundColor = Color.FromArgb(46, 51, 73);
            dtGridClientes.BorderStyle = BorderStyle.None;
            dtGridClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtGridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtGridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtGridClientes.DefaultCellStyle = dataGridViewCellStyle3;
            dtGridClientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtGridClientes.GridColor = Color.FromArgb(46, 51, 73);
            dtGridClientes.Location = new Point(20, 155);
            dtGridClientes.MultiSelect = false;
            dtGridClientes.Name = "dtGridClientes";
            dtGridClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtGridClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(46, 51, 73);
            dtGridClientes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dtGridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGridClientes.Size = new Size(723, 383);
            dtGridClientes.TabIndex = 1;
            dtGridClientes.CellContentClick += dtGridClientes_CellContentClick;
            dtGridClientes.CellMouseDoubleClick += dtGridClientes_CellMouseDoubleClick;
            // 
            // txtFiltro
            // 
            txtFiltro.BackColor = Color.FromArgb(74, 79, 99);
            txtFiltro.BorderStyle = BorderStyle.None;
            txtFiltro.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFiltro.ForeColor = SystemColors.ScrollBar;
            txtFiltro.Location = new Point(277, 12);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.PlaceholderText = "  Filtro";
            txtFiltro.Size = new Size(124, 26);
            txtFiltro.TabIndex = 4;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClientes.ForeColor = Color.FromArgb(158, 161, 176);
            lblClientes.Location = new Point(12, 9);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(120, 38);
            lblClientes.TabIndex = 3;
            lblClientes.Text = "Clientes";
            lblClientes.Click += lblClientes_Click;
            // 
            // btnSair
            // 
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(731, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(33, 33);
            btnSair.TabIndex = 5;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // lblNumeroRegistro
            // 
            lblNumeroRegistro.AutoSize = true;
            lblNumeroRegistro.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumeroRegistro.ForeColor = Color.FromArgb(158, 161, 176);
            lblNumeroRegistro.Location = new Point(20, 548);
            lblNumeroRegistro.Name = "lblNumeroRegistro";
            lblNumeroRegistro.Size = new Size(262, 20);
            lblNumeroRegistro.TabIndex = 7;
            lblNumeroRegistro.Text = "Número de registros encontrados: 0";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(305, 44);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(96, 26);
            btnFiltrar.TabIndex = 8;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // cbxFiltro
            // 
            cbxFiltro.FormattingEnabled = true;
            cbxFiltro.Items.AddRange(new object[] { "ID", "Nome", "ISM", "Status" });
            cbxFiltro.Location = new Point(172, 15);
            cbxFiltro.Name = "cbxFiltro";
            cbxFiltro.Size = new Size(99, 23);
            cbxFiltro.TabIndex = 10;
            cbxFiltro.Text = "ID";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(446, 17);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(77, 30);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(529, 17);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(77, 30);
            btnAlterar.TabIndex = 12;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(612, 17);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(77, 30);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(765, 577);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnCadastrar);
            Controls.Add(cbxFiltro);
            Controls.Add(btnFiltrar);
            Controls.Add(lblNumeroRegistro);
            Controls.Add(btnSair);
            Controls.Add(txtFiltro);
            Controls.Add(lblClientes);
            Controls.Add(dtGridClientes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmClientes";
            Text = "frmClientes";
            Load += frmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dtGridClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtGridClientes;
        private TextBox txtFiltro;
        private Label lblClientes;
        private Button btnSair;
        private Label lblNumeroRegistro;
        private Button btnFiltrar;
        private ComboBox cbxFiltro;
        private Button btnCadastrar;
        private Button btnAlterar;
        private Button btnExcluir;
    }
}