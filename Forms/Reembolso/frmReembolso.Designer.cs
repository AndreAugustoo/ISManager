namespace ISManager.Forms
{
    partial class frmReembolso
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
            cbxFiltro = new ComboBox();
            lblNumeroRegistro = new Label();
            dtGridClientes = new DataGridView();
            panelReembolso = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtGridClientes).BeginInit();
            SuspendLayout();
            // 
            // lblRegistroExibido
            // 
            lblRegistroExibido.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblRegistroExibido.AutoSize = true;
            lblRegistroExibido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistroExibido.ForeColor = Color.FromArgb(57, 57, 57);
            lblRegistroExibido.Location = new Point(410, 596);
            lblRegistroExibido.Name = "lblRegistroExibido";
            lblRegistroExibido.Size = new Size(233, 20);
            lblRegistroExibido.TabIndex = 26;
            lblRegistroExibido.Text = "Número de registros exibidos: 0";
            // 
            // lblDataFim
            // 
            lblDataFim.AutoSize = true;
            lblDataFim.Font = new Font("Segoe UI", 14F);
            lblDataFim.ForeColor = Color.FromArgb(57, 57, 57);
            lblDataFim.Location = new Point(423, 32);
            lblDataFim.Name = "lblDataFim";
            lblDataFim.Size = new Size(38, 25);
            lblDataFim.TabIndex = 25;
            lblDataFim.Text = "até";
            // 
            // lblDataInicio
            // 
            lblDataInicio.AutoSize = true;
            lblDataInicio.Font = new Font("Segoe UI", 14F);
            lblDataInicio.ForeColor = Color.FromArgb(57, 57, 57);
            lblDataInicio.Location = new Point(208, 32);
            lblDataInicio.Name = "lblDataInicio";
            lblDataInicio.Size = new Size(81, 25);
            lblDataInicio.TabIndex = 24;
            lblDataInicio.Text = "Data de:";
            // 
            // dtpDataFim
            // 
            dtpDataFim.BorderColor = Color.FromArgb(57, 57, 57);
            dtpDataFim.BorderSize = 1;
            dtpDataFim.CalendarFont = new Font("Segoe UI", 11F);
            dtpDataFim.CustomFormat = "yyyy-MM-dd";
            dtpDataFim.Font = new Font("Segoe UI", 11F);
            dtpDataFim.Format = DateTimePickerFormat.Custom;
            dtpDataFim.Location = new Point(467, 27);
            dtpDataFim.MinimumSize = new Size(0, 35);
            dtpDataFim.Name = "dtpDataFim";
            dtpDataFim.Size = new Size(120, 35);
            dtpDataFim.SkinColor = Color.FromArgb(241, 243, 244);
            dtpDataFim.TabIndex = 23;
            dtpDataFim.TextColor = Color.FromArgb(57, 57, 57);
            // 
            // dtpDataInicio
            // 
            dtpDataInicio.BorderColor = Color.FromArgb(57, 57, 57);
            dtpDataInicio.BorderSize = 1;
            dtpDataInicio.CalendarFont = new Font("Segoe UI", 11F);
            dtpDataInicio.CustomFormat = "yyyy-MM-dd";
            dtpDataInicio.Font = new Font("Segoe UI", 11F);
            dtpDataInicio.Format = DateTimePickerFormat.Custom;
            dtpDataInicio.Location = new Point(295, 27);
            dtpDataInicio.MinimumSize = new Size(0, 35);
            dtpDataInicio.Name = "dtpDataInicio";
            dtpDataInicio.Size = new Size(122, 35);
            dtpDataInicio.SkinColor = Color.FromArgb(241, 243, 244);
            dtpDataInicio.TabIndex = 22;
            dtpDataInicio.TextColor = Color.FromArgb(57, 57, 57);
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(57, 57, 57);
            label1.Location = new Point(793, 596);
            label1.Name = "label1";
            label1.Size = new Size(275, 20);
            label1.TabIndex = 21;
            label1.Text = "Exibição de registros limitada em: 100";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFiltrar.BackColor = Color.Silver;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrar.ForeColor = Color.FromArgb(57, 57, 57);
            btnFiltrar.IconChar = FontAwesome.Sharp.IconChar.Filter;
            btnFiltrar.IconColor = Color.FromArgb(57, 57, 57);
            btnFiltrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFiltrar.IconSize = 30;
            btnFiltrar.ImageAlign = ContentAlignment.MiddleRight;
            btnFiltrar.Location = new Point(606, 25);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(104, 38);
            btnFiltrar.TabIndex = 15;
            btnFiltrar.Text = "    Filtrar";
            btnFiltrar.TextAlign = ContentAlignment.MiddleLeft;
            btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.BackColor = Color.IndianRed;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.FromArgb(57, 57, 57);
            btnExcluir.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnExcluir.IconColor = Color.FromArgb(57, 57, 57);
            btnExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExcluir.IconSize = 28;
            btnExcluir.ImageAlign = ContentAlignment.MiddleRight;
            btnExcluir.Location = new Point(964, 25);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(104, 38);
            btnExcluir.TabIndex = 18;
            btnExcluir.Text = "    Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleLeft;
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            btnAlterar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAlterar.BackColor = Color.LightSteelBlue;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.ForeColor = Color.FromArgb(57, 57, 57);
            btnAlterar.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            btnAlterar.IconColor = Color.FromArgb(57, 57, 57);
            btnAlterar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAlterar.IconSize = 30;
            btnAlterar.ImageAlign = ContentAlignment.MiddleRight;
            btnAlterar.Location = new Point(845, 25);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(104, 38);
            btnAlterar.TabIndex = 17;
            btnAlterar.Text = "    Abrir";
            btnAlterar.TextAlign = ContentAlignment.MiddleLeft;
            btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCadastrar.BackColor = Color.SeaGreen;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.FromArgb(57, 57, 57);
            btnCadastrar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnCadastrar.IconColor = Color.FromArgb(57, 57, 57);
            btnCadastrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCadastrar.IconSize = 30;
            btnCadastrar.ImageAlign = ContentAlignment.MiddleRight;
            btnCadastrar.Location = new Point(726, 25);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(104, 38);
            btnCadastrar.TabIndex = 16;
            btnCadastrar.Text = "    Novo";
            btnCadastrar.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // cbxFiltro
            // 
            cbxFiltro.BackColor = Color.FromArgb(241, 243, 244);
            cbxFiltro.Font = new Font("Segoe UI", 13F);
            cbxFiltro.ForeColor = Color.FromArgb(57, 57, 57);
            cbxFiltro.FormattingEnabled = true;
            cbxFiltro.IntegralHeight = false;
            cbxFiltro.ItemHeight = 23;
            cbxFiltro.Items.AddRange(new object[] { "ID", "Nome", "ISM", "Status", "Data entrada", "Data fechamento" });
            cbxFiltro.Location = new Point(47, 31);
            cbxFiltro.Name = "cbxFiltro";
            cbxFiltro.Size = new Size(147, 31);
            cbxFiltro.TabIndex = 14;
            cbxFiltro.Text = "ID";
            // 
            // lblNumeroRegistro
            // 
            lblNumeroRegistro.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblNumeroRegistro.AutoSize = true;
            lblNumeroRegistro.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumeroRegistro.ForeColor = Color.FromArgb(57, 57, 57);
            lblNumeroRegistro.Location = new Point(44, 596);
            lblNumeroRegistro.Name = "lblNumeroRegistro";
            lblNumeroRegistro.Size = new Size(208, 20);
            lblNumeroRegistro.TabIndex = 20;
            lblNumeroRegistro.Text = "Número total de registros: 0";
            // 
            // dtGridClientes
            // 
            dtGridClientes.AllowUserToAddRows = false;
            dtGridClientes.AllowUserToDeleteRows = false;
            dtGridClientes.AllowUserToOrderColumns = true;
            dtGridClientes.AllowUserToResizeRows = false;
            dtGridClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtGridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtGridClientes.BackgroundColor = Color.White;
            dtGridClientes.BorderStyle = BorderStyle.None;
            dtGridClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtGridClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(25, 25, 25);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(25, 25, 25);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dtGridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtGridClientes.ColumnHeadersHeight = 30;
            dtGridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Gainsboro;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(57, 57, 57);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtGridClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dtGridClientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtGridClientes.EnableHeadersVisualStyles = false;
            dtGridClientes.GridColor = Color.FromArgb(241, 243, 244);
            dtGridClientes.Location = new Point(44, 92);
            dtGridClientes.MultiSelect = false;
            dtGridClientes.Name = "dtGridClientes";
            dtGridClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopLeft;
            dtGridClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtGridClientes.RowHeadersVisible = false;
            dtGridClientes.RowHeadersWidth = 4;
            dtGridClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(57, 57, 57);
            dataGridViewCellStyle4.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(57, 57, 57);
            dtGridClientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtGridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGridClientes.Size = new Size(1024, 482);
            dtGridClientes.TabIndex = 19;
            dtGridClientes.TabStop = false;
            // 
            // panelReembolso
            // 
            panelReembolso.BackColor = Color.White;
            panelReembolso.Dock = DockStyle.Fill;
            panelReembolso.Location = new Point(0, 0);
            panelReembolso.Name = "panelReembolso";
            panelReembolso.Size = new Size(1113, 640);
            panelReembolso.TabIndex = 27;
            // 
            // frmReembolso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 640);
            Controls.Add(lblRegistroExibido);
            Controls.Add(lblDataFim);
            Controls.Add(lblDataInicio);
            Controls.Add(dtpDataFim);
            Controls.Add(dtpDataInicio);
            Controls.Add(label1);
            Controls.Add(btnFiltrar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnCadastrar);
            Controls.Add(cbxFiltro);
            Controls.Add(lblNumeroRegistro);
            Controls.Add(dtGridClientes);
            Controls.Add(panelReembolso);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmReembolso";
            Text = "Reembolso";
            ((System.ComponentModel.ISupportInitialize)dtGridClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistroExibido;
        private Label lblDataFim;
        private Label lblDataInicio;
        public Class.CustomDatePicker dtpDataFim;
        public Class.CustomDatePicker dtpDataInicio;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnFiltrar;
        private FontAwesome.Sharp.IconButton btnExcluir;
        private FontAwesome.Sharp.IconButton btnAlterar;
        private FontAwesome.Sharp.IconButton btnCadastrar;
        private ComboBox cbxFiltro;
        private Label lblNumeroRegistro;
        private DataGridView dtGridClientes;
        private Panel panelReembolso;
    }
}