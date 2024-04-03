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
            txtFiltro = new TextBox();
            lblClientes = new Label();
            btnSair = new Button();
            lblNumeroRegistro = new Label();
            cbxFiltro = new ComboBox();
            pnlClientes = new Panel();
            lblRegistroExibido = new Label();
            lblDataFim = new Label();
            lblDataInicio = new Label();
            dtpDataFim = new Class.CustomDatePicker();
            dtpDataInicio = new Class.CustomDatePicker();
            label1 = new Label();
            btnFiltrar = new FontAwesome.Sharp.IconButton();
            btnExcluir = new FontAwesome.Sharp.IconButton();
            btnAlterar = new FontAwesome.Sharp.IconButton();
            btnCadastrar = new FontAwesome.Sharp.IconButton();
            dtGridClientes = new DataGridView();
            pnlClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridClientes).BeginInit();
            SuspendLayout();
            // 
            // txtFiltro
            // 
            txtFiltro.BackColor = Color.FromArgb(46, 51, 73);
            txtFiltro.Font = new Font("Segoe UI", 14F);
            txtFiltro.ForeColor = Color.White;
            txtFiltro.Location = new Point(213, 90);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.PlaceholderText = "  Filtro";
            txtFiltro.Size = new Size(371, 32);
            txtFiltro.TabIndex = 1;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClientes.ForeColor = Color.White;
            lblClientes.Location = new Point(42, 8);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(352, 38);
            lblClientes.TabIndex = 3;
            lblClientes.Text = "Controle de implantações";
            // 
            // btnSair
            // 
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(1068, 11);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(33, 33);
            btnSair.TabIndex = 6;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // lblNumeroRegistro
            // 
            lblNumeroRegistro.AutoSize = true;
            lblNumeroRegistro.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumeroRegistro.ForeColor = Color.FromArgb(158, 161, 176);
            lblNumeroRegistro.Location = new Point(42, 656);
            lblNumeroRegistro.Name = "lblNumeroRegistro";
            lblNumeroRegistro.Size = new Size(208, 20);
            lblNumeroRegistro.TabIndex = 7;
            lblNumeroRegistro.Text = "Número total de registros: 0";
            // 
            // cbxFiltro
            // 
            cbxFiltro.BackColor = Color.FromArgb(46, 51, 73);
            cbxFiltro.FlatStyle = FlatStyle.Flat;
            cbxFiltro.Font = new Font("Segoe UI", 13F);
            cbxFiltro.ForeColor = Color.FromArgb(188, 191, 206);
            cbxFiltro.FormattingEnabled = true;
            cbxFiltro.IntegralHeight = false;
            cbxFiltro.ItemHeight = 23;
            cbxFiltro.Items.AddRange(new object[] { "ID", "Nome", "ISM", "Status", "Data entrada", "Data fechamento" });
            cbxFiltro.Location = new Point(45, 91);
            cbxFiltro.Name = "cbxFiltro";
            cbxFiltro.Size = new Size(147, 31);
            cbxFiltro.TabIndex = 0;
            cbxFiltro.Text = "ID";
            cbxFiltro.SelectedValueChanged += cbxFiltro_SelectedValueChanged;
            // 
            // pnlClientes
            // 
            pnlClientes.Controls.Add(lblRegistroExibido);
            pnlClientes.Controls.Add(lblDataFim);
            pnlClientes.Controls.Add(lblDataInicio);
            pnlClientes.Controls.Add(dtpDataFim);
            pnlClientes.Controls.Add(dtpDataInicio);
            pnlClientes.Controls.Add(label1);
            pnlClientes.Controls.Add(btnFiltrar);
            pnlClientes.Controls.Add(btnExcluir);
            pnlClientes.Controls.Add(btnAlterar);
            pnlClientes.Controls.Add(btnCadastrar);
            pnlClientes.Controls.Add(btnSair);
            pnlClientes.Controls.Add(cbxFiltro);
            pnlClientes.Controls.Add(lblNumeroRegistro);
            pnlClientes.Controls.Add(txtFiltro);
            pnlClientes.Controls.Add(lblClientes);
            pnlClientes.Controls.Add(dtGridClientes);
            pnlClientes.Location = new Point(1, 1);
            pnlClientes.Name = "pnlClientes";
            pnlClientes.Size = new Size(1114, 700);
            pnlClientes.TabIndex = 14;
            // 
            // lblRegistroExibido
            // 
            lblRegistroExibido.AutoSize = true;
            lblRegistroExibido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistroExibido.ForeColor = Color.FromArgb(158, 161, 176);
            lblRegistroExibido.Location = new Point(408, 656);
            lblRegistroExibido.Name = "lblRegistroExibido";
            lblRegistroExibido.Size = new Size(233, 20);
            lblRegistroExibido.TabIndex = 13;
            lblRegistroExibido.Text = "Número de registros exibidos: 0";
            // 
            // lblDataFim
            // 
            lblDataFim.AutoSize = true;
            lblDataFim.Font = new Font("Segoe UI", 14F);
            lblDataFim.ForeColor = Color.White;
            lblDataFim.Location = new Point(421, 92);
            lblDataFim.Name = "lblDataFim";
            lblDataFim.Size = new Size(38, 25);
            lblDataFim.TabIndex = 12;
            lblDataFim.Text = "até";
            // 
            // lblDataInicio
            // 
            lblDataInicio.AutoSize = true;
            lblDataInicio.Font = new Font("Segoe UI", 14F);
            lblDataInicio.ForeColor = Color.White;
            lblDataInicio.Location = new Point(206, 92);
            lblDataInicio.Name = "lblDataInicio";
            lblDataInicio.Size = new Size(81, 25);
            lblDataInicio.TabIndex = 11;
            lblDataInicio.Text = "Data de:";
            // 
            // dtpDataFim
            // 
            dtpDataFim.BorderColor = Color.White;
            dtpDataFim.BorderSize = 1;
            dtpDataFim.CalendarFont = new Font("Segoe UI", 11F);
            dtpDataFim.CustomFormat = "yyyy-MM-dd";
            dtpDataFim.Font = new Font("Segoe UI", 11F);
            dtpDataFim.Format = DateTimePickerFormat.Custom;
            dtpDataFim.Location = new Point(465, 87);
            dtpDataFim.MinimumSize = new Size(0, 35);
            dtpDataFim.Name = "dtpDataFim";
            dtpDataFim.Size = new Size(120, 35);
            dtpDataFim.SkinColor = Color.FromArgb(46, 51, 73);
            dtpDataFim.TabIndex = 10;
            dtpDataFim.TextColor = Color.White;
            // 
            // dtpDataInicio
            // 
            dtpDataInicio.BorderColor = Color.White;
            dtpDataInicio.BorderSize = 1;
            dtpDataInicio.CalendarFont = new Font("Segoe UI", 11F);
            dtpDataInicio.CustomFormat = "yyyy-MM-dd";
            dtpDataInicio.Font = new Font("Segoe UI", 11F);
            dtpDataInicio.Format = DateTimePickerFormat.Custom;
            dtpDataInicio.Location = new Point(293, 87);
            dtpDataInicio.MinimumSize = new Size(0, 35);
            dtpDataInicio.Name = "dtpDataInicio";
            dtpDataInicio.Size = new Size(122, 35);
            dtpDataInicio.SkinColor = Color.FromArgb(46, 51, 73);
            dtpDataInicio.TabIndex = 9;
            dtpDataInicio.TextColor = Color.White;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(158, 161, 176);
            label1.Location = new Point(791, 656);
            label1.Name = "label1";
            label1.Size = new Size(275, 20);
            label1.TabIndex = 8;
            label1.Text = "Exibição de registros limitada em: 500";
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.Silver;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrar.ForeColor = Color.FromArgb(46, 51, 73);
            btnFiltrar.IconChar = FontAwesome.Sharp.IconChar.Filter;
            btnFiltrar.IconColor = Color.FromArgb(46, 51, 73);
            btnFiltrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFiltrar.IconSize = 30;
            btnFiltrar.ImageAlign = ContentAlignment.MiddleRight;
            btnFiltrar.Location = new Point(604, 85);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(104, 38);
            btnFiltrar.TabIndex = 2;
            btnFiltrar.Text = "    Filtrar";
            btnFiltrar.TextAlign = ContentAlignment.MiddleLeft;
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.IndianRed;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.FromArgb(46, 51, 73);
            btnExcluir.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnExcluir.IconColor = Color.FromArgb(46, 51, 73);
            btnExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExcluir.IconSize = 28;
            btnExcluir.ImageAlign = ContentAlignment.MiddleRight;
            btnExcluir.Location = new Point(962, 85);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(104, 38);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "    Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleLeft;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.LightSteelBlue;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.ForeColor = Color.FromArgb(46, 51, 73);
            btnAlterar.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            btnAlterar.IconColor = Color.FromArgb(46, 51, 73);
            btnAlterar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAlterar.IconSize = 30;
            btnAlterar.ImageAlign = ContentAlignment.MiddleRight;
            btnAlterar.Location = new Point(843, 85);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(104, 38);
            btnAlterar.TabIndex = 4;
            btnAlterar.Text = "    Abrir";
            btnAlterar.TextAlign = ContentAlignment.MiddleLeft;
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.SeaGreen;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.FromArgb(46, 51, 73);
            btnCadastrar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnCadastrar.IconColor = Color.FromArgb(46, 51, 73);
            btnCadastrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCadastrar.IconSize = 30;
            btnCadastrar.ImageAlign = ContentAlignment.MiddleRight;
            btnCadastrar.Location = new Point(724, 85);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(104, 38);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "    Novo";
            btnCadastrar.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // dtGridClientes
            // 
            dtGridClientes.AllowUserToAddRows = false;
            dtGridClientes.AllowUserToDeleteRows = false;
            dtGridClientes.AllowUserToOrderColumns = true;
            dtGridClientes.AllowUserToResizeRows = false;
            dtGridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtGridClientes.BackgroundColor = Color.FromArgb(46, 51, 73);
            dtGridClientes.BorderStyle = BorderStyle.None;
            dtGridClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtGridClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(24, 30, 54);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(24, 30, 54);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dtGridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtGridClientes.ColumnHeadersHeight = 30;
            dtGridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtGridClientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtGridClientes.EnableHeadersVisualStyles = false;
            dtGridClientes.GridColor = Color.FromArgb(74, 79, 99);
            dtGridClientes.Location = new Point(42, 152);
            dtGridClientes.MultiSelect = false;
            dtGridClientes.Name = "dtGridClientes";
            dtGridClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopLeft;
            dtGridClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtGridClientes.RowHeadersVisible = false;
            dtGridClientes.RowHeadersWidth = 4;
            dtGridClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(74, 79, 99);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dtGridClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dtGridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGridClientes.Size = new Size(1024, 482);
            dtGridClientes.TabIndex = 6;
            dtGridClientes.TabStop = false;
            dtGridClientes.CellMouseDoubleClick += dtGridClientes_CellMouseDoubleClick;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1114, 700);
            Controls.Add(pnlClientes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmClientes";
            Text = "Implantações";
            Load += frmClientes_Load;
            pnlClientes.ResumeLayout(false);
            pnlClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtFiltro;
        private Label lblClientes;
        private Button btnSair;
        private Label lblNumeroRegistro;
        private ComboBox cbxFiltro;
        private Panel pnlClientes;
        private DataGridView dtGridClientes;
        private FontAwesome.Sharp.IconButton btnCadastrar;
        private FontAwesome.Sharp.IconButton btnExcluir;
        private FontAwesome.Sharp.IconButton btnAlterar;
        private FontAwesome.Sharp.IconButton btnFiltrar;
        private Label label1;
        private Label lblDataFim;
        private Label lblDataInicio;
        public Class.CustomDatePicker dtpDataFim;
        public Class.CustomDatePicker dtpDataInicio;
        private Label lblRegistroExibido;
    }
}