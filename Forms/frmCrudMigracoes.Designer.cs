namespace ISManager.Forms
{
    partial class frmCrudMigracoes
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
            panelCrudMigracoes = new Panel();
            groupBox1 = new GroupBox();
            cbxStatus = new ComboBox();
            txtDataFechamento = new Class.CustomDatePicker();
            txtHoras = new TextBox();
            txtDataEntrada = new Class.CustomDatePicker();
            txtObservacao = new TextBox();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            txtNome = new TextBox();
            btnConfirmar = new FontAwesome.Sharp.IconButton();
            lblNome = new Label();
            lblStatus = new Label();
            lblObservacao = new Label();
            cbxIsm = new ComboBox();
            lblIsm = new Label();
            txtId = new TextBox();
            lblId = new Label();
            lblHoras = new Label();
            lblDataFechamento = new Label();
            lblUltimaAtualizacao = new Label();
            panelCrudMigracoes.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelCrudMigracoes
            // 
            panelCrudMigracoes.BackColor = Color.White;
            panelCrudMigracoes.Controls.Add(groupBox1);
            panelCrudMigracoes.Dock = DockStyle.Fill;
            panelCrudMigracoes.Location = new Point(0, 0);
            panelCrudMigracoes.MinimumSize = new Size(1114, 639);
            panelCrudMigracoes.Name = "panelCrudMigracoes";
            panelCrudMigracoes.Size = new Size(1114, 639);
            panelCrudMigracoes.TabIndex = 68;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(cbxStatus);
            groupBox1.Controls.Add(txtDataFechamento);
            groupBox1.Controls.Add(txtHoras);
            groupBox1.Controls.Add(txtDataEntrada);
            groupBox1.Controls.Add(txtObservacao);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(btnConfirmar);
            groupBox1.Controls.Add(lblNome);
            groupBox1.Controls.Add(lblStatus);
            groupBox1.Controls.Add(lblObservacao);
            groupBox1.Controls.Add(cbxIsm);
            groupBox1.Controls.Add(lblIsm);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(lblId);
            groupBox1.Controls.Add(lblHoras);
            groupBox1.Controls.Add(lblDataFechamento);
            groupBox1.Controls.Add(lblUltimaAtualizacao);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(57, 57, 57);
            groupBox1.Location = new Point(211, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(682, 566);
            groupBox1.TabIndex = 67;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados cadastrais";
            // 
            // cbxStatus
            // 
            cbxStatus.BackColor = Color.FromArgb(241, 243, 244);
            cbxStatus.Font = new Font("Segoe UI", 12F);
            cbxStatus.ForeColor = Color.FromArgb(57, 57, 57);
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Em andamento", "Atualizado", "Pendente", "Não atualizar" });
            cbxStatus.Location = new Point(116, 252);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(127, 29);
            cbxStatus.TabIndex = 3;
            // 
            // txtDataFechamento
            // 
            txtDataFechamento.BorderColor = Color.FromArgb(57, 57, 57);
            txtDataFechamento.BorderSize = 1;
            txtDataFechamento.CustomFormat = "yyyy-MM-dd";
            txtDataFechamento.Font = new Font("Segoe UI", 11F);
            txtDataFechamento.Format = DateTimePickerFormat.Custom;
            txtDataFechamento.Location = new Point(505, 147);
            txtDataFechamento.MinimumSize = new Size(0, 35);
            txtDataFechamento.Name = "txtDataFechamento";
            txtDataFechamento.Size = new Size(133, 35);
            txtDataFechamento.SkinColor = Color.FromArgb(241, 243, 244);
            txtDataFechamento.TabIndex = 8;
            txtDataFechamento.TextColor = Color.FromArgb(57, 57, 57);
            txtDataFechamento.Value = new DateTime(2024, 4, 1, 0, 0, 0, 0);
            // 
            // txtHoras
            // 
            txtHoras.BackColor = Color.FromArgb(241, 243, 244);
            txtHoras.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoras.ForeColor = Color.FromArgb(57, 57, 57);
            txtHoras.Location = new Point(515, 248);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(124, 33);
            txtHoras.TabIndex = 7;
            // 
            // txtDataEntrada
            // 
            txtDataEntrada.BorderColor = Color.FromArgb(57, 57, 57);
            txtDataEntrada.BorderSize = 1;
            txtDataEntrada.CalendarFont = new Font("Segoe UI", 11F);
            txtDataEntrada.CustomFormat = "yyyy-MM-dd";
            txtDataEntrada.Font = new Font("Segoe UI", 11F);
            txtDataEntrada.Format = DateTimePickerFormat.Custom;
            txtDataEntrada.Location = new Point(209, 149);
            txtDataEntrada.MinimumSize = new Size(0, 35);
            txtDataEntrada.Name = "txtDataEntrada";
            txtDataEntrada.Size = new Size(127, 35);
            txtDataEntrada.SkinColor = Color.FromArgb(241, 243, 244);
            txtDataEntrada.TabIndex = 2;
            txtDataEntrada.TextColor = Color.FromArgb(57, 57, 57);
            // 
            // txtObservacao
            // 
            txtObservacao.BackColor = Color.FromArgb(241, 243, 244);
            txtObservacao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObservacao.ForeColor = Color.FromArgb(57, 57, 57);
            txtObservacao.Location = new Point(39, 356);
            txtObservacao.MaxLength = 255;
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(600, 122);
            txtObservacao.TabIndex = 9;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(57, 57, 57);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.FromArgb(57, 57, 57);
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 28;
            btnCancelar.ImageAlign = ContentAlignment.MiddleRight;
            btnCancelar.Location = new Point(343, 499);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 38);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = " Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleLeft;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(241, 243, 244);
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.FromArgb(57, 57, 57);
            txtNome.Location = new Point(222, 51);
            txtNome.MaxLength = 80;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(417, 33);
            txtNome.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.SeaGreen;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.FromArgb(57, 57, 57);
            btnConfirmar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnConfirmar.IconColor = Color.FromArgb(57, 57, 57);
            btnConfirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfirmar.IconSize = 30;
            btnConfirmar.ImageAlign = ContentAlignment.MiddleRight;
            btnConfirmar.Location = new Point(222, 499);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(104, 38);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "   Salvar";
            btnConfirmar.TextAlign = ContentAlignment.MiddleLeft;
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.White;
            lblNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.FromArgb(57, 57, 57);
            lblNome.Location = new Point(153, 54);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(66, 25);
            lblNome.TabIndex = 50;
            lblNome.Text = "Nome";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.White;
            lblStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.FromArgb(57, 57, 57);
            lblStatus.Location = new Point(44, 252);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(67, 25);
            lblStatus.TabIndex = 55;
            lblStatus.Text = "Status";
            // 
            // lblObservacao
            // 
            lblObservacao.AutoSize = true;
            lblObservacao.BackColor = Color.White;
            lblObservacao.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObservacao.ForeColor = Color.FromArgb(57, 57, 57);
            lblObservacao.Location = new Point(39, 328);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(124, 25);
            lblObservacao.TabIndex = 58;
            lblObservacao.Text = "Observações";
            // 
            // cbxIsm
            // 
            cbxIsm.BackColor = Color.FromArgb(241, 243, 244);
            cbxIsm.Font = new Font("Segoe UI", 12F);
            cbxIsm.ForeColor = Color.FromArgb(57, 57, 57);
            cbxIsm.FormattingEnabled = true;
            cbxIsm.Items.AddRange(new object[] { "André", "Edivania" });
            cbxIsm.Location = new Point(318, 252);
            cbxIsm.Name = "cbxIsm";
            cbxIsm.Size = new Size(113, 29);
            cbxIsm.TabIndex = 4;
            // 
            // lblIsm
            // 
            lblIsm.AutoSize = true;
            lblIsm.BackColor = Color.White;
            lblIsm.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIsm.ForeColor = Color.FromArgb(57, 57, 57);
            lblIsm.Location = new Point(265, 252);
            lblIsm.Name = "lblIsm";
            lblIsm.Size = new Size(47, 25);
            lblIsm.TabIndex = 53;
            lblIsm.Text = "ISM";
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(241, 243, 244);
            txtId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.ForeColor = Color.FromArgb(57, 57, 57);
            txtId.Location = new Point(82, 51);
            txtId.MaxLength = 4;
            txtId.Name = "txtId";
            txtId.Size = new Size(65, 33);
            txtId.TabIndex = 0;
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.White;
            lblId.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.FromArgb(57, 57, 57);
            lblId.Location = new Point(39, 53);
            lblId.Name = "lblId";
            lblId.Size = new Size(41, 25);
            lblId.TabIndex = 49;
            lblId.Text = "ID*";
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.BackColor = Color.White;
            lblHoras.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoras.ForeColor = Color.FromArgb(57, 57, 57);
            lblHoras.Location = new Point(437, 251);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(72, 25);
            lblHoras.TabIndex = 56;
            lblHoras.Text = "Versão";
            // 
            // lblDataFechamento
            // 
            lblDataFechamento.AutoSize = true;
            lblDataFechamento.BackColor = Color.White;
            lblDataFechamento.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataFechamento.ForeColor = Color.FromArgb(57, 57, 57);
            lblDataFechamento.Location = new Point(342, 152);
            lblDataFechamento.Name = "lblDataFechamento";
            lblDataFechamento.Size = new Size(157, 25);
            lblDataFechamento.TabIndex = 57;
            lblDataFechamento.Text = "Data atualização";
            // 
            // lblUltimaAtualizacao
            // 
            lblUltimaAtualizacao.AutoSize = true;
            lblUltimaAtualizacao.BackColor = Color.White;
            lblUltimaAtualizacao.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUltimaAtualizacao.ForeColor = Color.FromArgb(57, 57, 57);
            lblUltimaAtualizacao.Location = new Point(36, 152);
            lblUltimaAtualizacao.Name = "lblUltimaAtualizacao";
            lblUltimaAtualizacao.Size = new Size(174, 25);
            lblUltimaAtualizacao.TabIndex = 51;
            lblUltimaAtualizacao.Text = "Última atualização";
            // 
            // frmCrudMigracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 600);
            Controls.Add(panelCrudMigracoes);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1114, 639);
            Name = "frmCrudMigracoes";
            Text = "frmCrudMigracoes";
            panelCrudMigracoes.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCrudMigracoes;
        private GroupBox groupBox1;
        public ComboBox cbxStatus;
        public Class.CustomDatePicker txtDataFechamento;
        public TextBox txtHoras;
        public Class.CustomDatePicker txtDataEntrada;
        public TextBox txtObservacao;
        public FontAwesome.Sharp.IconButton btnCancelar;
        public TextBox txtNome;
        public FontAwesome.Sharp.IconButton btnConfirmar;
        private Label lblNome;
        private Label lblStatus;
        private Label lblObservacao;
        public ComboBox cbxIsm;
        private Label lblIsm;
        public TextBox txtId;
        private Label lblId;
        private Label lblHoras;
        private Label lblDataFechamento;
        private Label lblUltimaAtualizacao;
    }
}