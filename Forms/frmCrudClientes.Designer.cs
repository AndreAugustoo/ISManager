namespace ISManager.Forms
{
    partial class frmCrudClientes
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
            lblObservacao = new Label();
            lblDataFechamento = new Label();
            lblHoras = new Label();
            lblStatus = new Label();
            lblBackup = new Label();
            lblIsm = new Label();
            lblNecessidade = new Label();
            lblDataEntrada = new Label();
            lblNome = new Label();
            lblId = new Label();
            cbxStatus = new ComboBox();
            cbxBackup = new ComboBox();
            cbxIsm = new ComboBox();
            cbxNecessidade = new ComboBox();
            txtObservacao = new TextBox();
            txtHoras = new TextBox();
            txtNome = new TextBox();
            txtId = new TextBox();
            btnSair = new Button();
            lblTitle = new Label();
            pnlFormLoader = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnConfirmar = new FontAwesome.Sharp.IconButton();
            txtDataEntrada = new Class.CustomDatePicker();
            txtDataFechamento = new Class.CustomDatePicker();
            pnlFormLoader.SuspendLayout();
            SuspendLayout();
            // 
            // lblObservacao
            // 
            lblObservacao.AutoSize = true;
            lblObservacao.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObservacao.ForeColor = Color.FromArgb(158, 161, 176);
            lblObservacao.Location = new Point(83, 324);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(124, 25);
            lblObservacao.TabIndex = 58;
            lblObservacao.Text = "Observações";
            // 
            // lblDataFechamento
            // 
            lblDataFechamento.AutoSize = true;
            lblDataFechamento.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataFechamento.ForeColor = Color.FromArgb(158, 161, 176);
            lblDataFechamento.Location = new Point(387, 263);
            lblDataFechamento.Name = "lblDataFechamento";
            lblDataFechamento.Size = new Size(163, 25);
            lblDataFechamento.TabIndex = 57;
            lblDataFechamento.Text = "Data fechamento";
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoras.ForeColor = Color.FromArgb(158, 161, 176);
            lblHoras.Location = new Point(80, 263);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(153, 25);
            lblHoras.TabIndex = 56;
            lblHoras.Text = "Horas utilizadas";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.FromArgb(158, 161, 176);
            lblStatus.Location = new Point(313, 134);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(67, 25);
            lblStatus.TabIndex = 55;
            lblStatus.Text = "Status";
            // 
            // lblBackup
            // 
            lblBackup.AutoSize = true;
            lblBackup.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBackup.ForeColor = Color.FromArgb(158, 161, 176);
            lblBackup.Location = new Point(413, 202);
            lblBackup.Name = "lblBackup";
            lblBackup.Size = new Size(78, 25);
            lblBackup.TabIndex = 54;
            lblBackup.Text = "Backup";
            // 
            // lblIsm
            // 
            lblIsm.AutoSize = true;
            lblIsm.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIsm.ForeColor = Color.FromArgb(158, 161, 176);
            lblIsm.Location = new Point(520, 131);
            lblIsm.Name = "lblIsm";
            lblIsm.Size = new Size(47, 25);
            lblIsm.TabIndex = 53;
            lblIsm.Text = "ISM";
            // 
            // lblNecessidade
            // 
            lblNecessidade.AutoSize = true;
            lblNecessidade.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNecessidade.ForeColor = Color.FromArgb(158, 161, 176);
            lblNecessidade.Location = new Point(80, 199);
            lblNecessidade.Name = "lblNecessidade";
            lblNecessidade.Size = new Size(121, 25);
            lblNecessidade.TabIndex = 52;
            lblNecessidade.Text = "Necessidade";
            // 
            // lblDataEntrada
            // 
            lblDataEntrada.AutoSize = true;
            lblDataEntrada.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataEntrada.ForeColor = Color.FromArgb(158, 161, 176);
            lblDataEntrada.Location = new Point(80, 134);
            lblDataEntrada.Name = "lblDataEntrada";
            lblDataEntrada.Size = new Size(81, 25);
            lblDataEntrada.TabIndex = 51;
            lblDataEntrada.Text = "Entrada";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.FromArgb(158, 161, 176);
            lblNome.Location = new Point(189, 76);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(66, 25);
            lblNome.TabIndex = 50;
            lblNome.Text = "Nome";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.FromArgb(158, 161, 176);
            lblId.Location = new Point(80, 76);
            lblId.Name = "lblId";
            lblId.Size = new Size(32, 25);
            lblId.TabIndex = 49;
            lblId.Text = "ID";
            // 
            // cbxStatus
            // 
            cbxStatus.BackColor = Color.FromArgb(74, 79, 99);
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatus.FlatStyle = FlatStyle.Flat;
            cbxStatus.Font = new Font("Segoe UI", 12F);
            cbxStatus.ForeColor = Color.White;
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Finalizada", "Em andamento", "Parada", "Cancelada" });
            cbxStatus.Location = new Point(386, 134);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(127, 29);
            cbxStatus.TabIndex = 3;
            // 
            // cbxBackup
            // 
            cbxBackup.BackColor = Color.FromArgb(74, 79, 99);
            cbxBackup.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBackup.FlatStyle = FlatStyle.Flat;
            cbxBackup.Font = new Font("Segoe UI", 12F);
            cbxBackup.ForeColor = Color.White;
            cbxBackup.FormattingEnabled = true;
            cbxBackup.Items.AddRange(new object[] { "Cloud", "Pen drive", "HD externo", "Sem backup" });
            cbxBackup.Location = new Point(497, 202);
            cbxBackup.Name = "cbxBackup";
            cbxBackup.Size = new Size(186, 29);
            cbxBackup.TabIndex = 6;
            // 
            // cbxIsm
            // 
            cbxIsm.BackColor = Color.FromArgb(74, 79, 99);
            cbxIsm.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxIsm.FlatStyle = FlatStyle.Flat;
            cbxIsm.Font = new Font("Segoe UI", 12F);
            cbxIsm.ForeColor = Color.White;
            cbxIsm.FormattingEnabled = true;
            cbxIsm.Items.AddRange(new object[] { "André", "Edivania" });
            cbxIsm.Location = new Point(570, 133);
            cbxIsm.Name = "cbxIsm";
            cbxIsm.Size = new Size(113, 29);
            cbxIsm.TabIndex = 4;
            // 
            // cbxNecessidade
            // 
            cbxNecessidade.BackColor = Color.FromArgb(74, 79, 99);
            cbxNecessidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNecessidade.DropDownWidth = 190;
            cbxNecessidade.FlatStyle = FlatStyle.Flat;
            cbxNecessidade.Font = new Font("Segoe UI", 12F);
            cbxNecessidade.ForeColor = Color.White;
            cbxNecessidade.FormattingEnabled = true;
            cbxNecessidade.ItemHeight = 21;
            cbxNecessidade.Items.AddRange(new object[] { "Fiscal", "Gerencial", "Fiscal/Gerencial" });
            cbxNecessidade.Location = new Point(211, 204);
            cbxNecessidade.Name = "cbxNecessidade";
            cbxNecessidade.Size = new Size(179, 29);
            cbxNecessidade.TabIndex = 5;
            // 
            // txtObservacao
            // 
            txtObservacao.BackColor = Color.FromArgb(74, 79, 99);
            txtObservacao.BorderStyle = BorderStyle.None;
            txtObservacao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObservacao.ForeColor = Color.White;
            txtObservacao.Location = new Point(83, 352);
            txtObservacao.MaxLength = 255;
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(600, 122);
            txtObservacao.TabIndex = 9;
            // 
            // txtHoras
            // 
            txtHoras.BackColor = Color.FromArgb(74, 79, 99);
            txtHoras.BorderStyle = BorderStyle.None;
            txtHoras.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoras.ForeColor = Color.White;
            txtHoras.Location = new Point(239, 263);
            txtHoras.Name = "txtHoras";
            txtHoras.PlaceholderText = "00:00:00";
            txtHoras.Size = new Size(124, 26);
            txtHoras.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(74, 79, 99);
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.White;
            txtNome.Location = new Point(261, 75);
            txtNome.MaxLength = 80;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(428, 26);
            txtNome.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(74, 79, 99);
            txtId.BorderStyle = BorderStyle.None;
            txtId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.ForeColor = Color.White;
            txtId.Location = new Point(118, 75);
            txtId.MaxLength = 4;
            txtId.Name = "txtId";
            txtId.Size = new Size(65, 26);
            txtId.TabIndex = 0;
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSair
            // 
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(732, -1);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(33, 33);
            btnSair.TabIndex = 36;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(120, 38);
            lblTitle.TabIndex = 35;
            lblTitle.Text = "Clientes";
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.Controls.Add(txtDataFechamento);
            pnlFormLoader.Controls.Add(txtDataEntrada);
            pnlFormLoader.Controls.Add(btnCancelar);
            pnlFormLoader.Controls.Add(btnConfirmar);
            pnlFormLoader.Controls.Add(lblBackup);
            pnlFormLoader.Controls.Add(lblObservacao);
            pnlFormLoader.Controls.Add(lblIsm);
            pnlFormLoader.Controls.Add(lblId);
            pnlFormLoader.Controls.Add(lblNecessidade);
            pnlFormLoader.Controls.Add(lblDataFechamento);
            pnlFormLoader.Controls.Add(lblDataEntrada);
            pnlFormLoader.Controls.Add(lblTitle);
            pnlFormLoader.Controls.Add(lblHoras);
            pnlFormLoader.Controls.Add(cbxBackup);
            pnlFormLoader.Controls.Add(txtId);
            pnlFormLoader.Controls.Add(cbxIsm);
            pnlFormLoader.Controls.Add(lblStatus);
            pnlFormLoader.Controls.Add(cbxNecessidade);
            pnlFormLoader.Controls.Add(lblNome);
            pnlFormLoader.Controls.Add(txtNome);
            pnlFormLoader.Controls.Add(txtObservacao);
            pnlFormLoader.Controls.Add(txtHoras);
            pnlFormLoader.Controls.Add(cbxStatus);
            pnlFormLoader.Dock = DockStyle.Fill;
            pnlFormLoader.Location = new Point(0, 0);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(765, 577);
            pnlFormLoader.TabIndex = 59;
            pnlFormLoader.Paint += pnlFormLoader_Paint;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(46, 51, 73);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.FromArgb(46, 51, 73);
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 28;
            btnCancelar.ImageAlign = ContentAlignment.MiddleRight;
            btnCancelar.Location = new Point(387, 495);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 38);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = " Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleLeft;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.SeaGreen;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.FromArgb(46, 51, 73);
            btnConfirmar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnConfirmar.IconColor = Color.FromArgb(46, 51, 73);
            btnConfirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfirmar.IconSize = 30;
            btnConfirmar.ImageAlign = ContentAlignment.MiddleRight;
            btnConfirmar.Location = new Point(266, 495);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(104, 38);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "   Salvar";
            btnConfirmar.TextAlign = ContentAlignment.MiddleLeft;
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtDataEntrada
            // 
            txtDataEntrada.BorderColor = Color.PaleVioletRed;
            txtDataEntrada.BorderSize = 0;
            txtDataEntrada.CalendarFont = new Font("Segoe UI", 11F);
            txtDataEntrada.CustomFormat = "yyyy-MM-dd";
            txtDataEntrada.Font = new Font("Segoe UI", 11F);
            txtDataEntrada.Format = DateTimePickerFormat.Custom;
            txtDataEntrada.Location = new Point(158, 131);
            txtDataEntrada.MinimumSize = new Size(0, 35);
            txtDataEntrada.Name = "txtDataEntrada";
            txtDataEntrada.Size = new Size(127, 35);
            txtDataEntrada.SkinColor = Color.FromArgb(74, 79, 99);
            txtDataEntrada.TabIndex = 2;
            txtDataEntrada.TextColor = Color.White;
            // 
            // txtDataFechamento
            // 
            txtDataFechamento.BorderColor = Color.PaleVioletRed;
            txtDataFechamento.BorderSize = 0;
            txtDataFechamento.CustomFormat = "yyyy-MM-dd";
            txtDataFechamento.Font = new Font("Segoe UI", 11F);
            txtDataFechamento.Format = DateTimePickerFormat.Custom;
            txtDataFechamento.Location = new Point(550, 260);
            txtDataFechamento.MinimumSize = new Size(0, 35);
            txtDataFechamento.Name = "txtDataFechamento";
            txtDataFechamento.Size = new Size(133, 35);
            txtDataFechamento.SkinColor = Color.FromArgb(74, 79, 99);
            txtDataFechamento.TabIndex = 8;
            txtDataFechamento.TextColor = Color.White;
            txtDataFechamento.Value = new DateTime(2024, 4, 1, 0, 0, 0, 0);
            // 
            // frmCrudClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(765, 577);
            Controls.Add(btnSair);
            Controls.Add(pnlFormLoader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCrudClientes";
            Text = "frmCrudClientes";
            Load += frmCrudClientes_Load;
            pnlFormLoader.ResumeLayout(false);
            pnlFormLoader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblObservacao;
        private Label lblDataFechamento;
        private Label lblHoras;
        private Label lblStatus;
        private Label lblBackup;
        private Label lblIsm;
        private Label lblNecessidade;
        private Label lblDataEntrada;
        private Label lblNome;
        private Label lblId;
        private Button btnSair;
        public ComboBox cbxStatus;
        public ComboBox cbxBackup;
        public ComboBox cbxIsm;
        public ComboBox cbxNecessidade;
        public TextBox txtObservacao;
        public TextBox txtHoras;
        public TextBox txtNome;
        public TextBox txtId;
        public Label lblTitle;
        public Panel pnlFormLoader;
        public FontAwesome.Sharp.IconButton btnConfirmar;
        public FontAwesome.Sharp.IconButton btnCancelar;
        public Class.CustomDatePicker txtDataFechamento;
        public Class.CustomDatePicker txtDataEntrada;
    }
}