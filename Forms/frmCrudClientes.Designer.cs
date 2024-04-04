using ISManager.Class;

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
            pnlFormLoader = new Panel();
            groupBox2 = new GroupBox();
            chkOpcao3 = new CheckBox();
            chkPesquisa = new CheckBox();
            chkOpcao2 = new CheckBox();
            chkDocumentacao = new CheckBox();
            chkOpcao1 = new CheckBox();
            chkZendesk = new CheckBox();
            groupBox1 = new GroupBox();
            txtDataFechamento = new Class.CustomDatePicker();
            txtDataEntrada = new Class.CustomDatePicker();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnConfirmar = new FontAwesome.Sharp.IconButton();
            pnlFormLoader.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblObservacao
            // 
            lblObservacao.AutoSize = true;
            lblObservacao.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObservacao.ForeColor = Color.White;
            lblObservacao.Location = new Point(39, 328);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(124, 25);
            lblObservacao.TabIndex = 58;
            lblObservacao.Text = "Observações";
            // 
            // lblDataFechamento
            // 
            lblDataFechamento.AutoSize = true;
            lblDataFechamento.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataFechamento.ForeColor = Color.White;
            lblDataFechamento.Location = new Point(343, 269);
            lblDataFechamento.Name = "lblDataFechamento";
            lblDataFechamento.Size = new Size(163, 25);
            lblDataFechamento.TabIndex = 57;
            lblDataFechamento.Text = "Data fechamento";
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoras.ForeColor = Color.White;
            lblHoras.Location = new Point(43, 268);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(153, 25);
            lblHoras.TabIndex = 56;
            lblHoras.Text = "Horas utilizadas";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(270, 129);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(67, 25);
            lblStatus.TabIndex = 55;
            lblStatus.Text = "Status";
            // 
            // lblBackup
            // 
            lblBackup.AutoSize = true;
            lblBackup.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBackup.ForeColor = Color.White;
            lblBackup.Location = new Point(374, 202);
            lblBackup.Name = "lblBackup";
            lblBackup.Size = new Size(78, 25);
            lblBackup.TabIndex = 54;
            lblBackup.Text = "Backup";
            // 
            // lblIsm
            // 
            lblIsm.AutoSize = true;
            lblIsm.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIsm.ForeColor = Color.White;
            lblIsm.Location = new Point(477, 126);
            lblIsm.Name = "lblIsm";
            lblIsm.Size = new Size(47, 25);
            lblIsm.TabIndex = 53;
            lblIsm.Text = "ISM";
            // 
            // lblNecessidade
            // 
            lblNecessidade.AutoSize = true;
            lblNecessidade.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNecessidade.ForeColor = Color.White;
            lblNecessidade.Location = new Point(41, 204);
            lblNecessidade.Name = "lblNecessidade";
            lblNecessidade.Size = new Size(121, 25);
            lblNecessidade.TabIndex = 52;
            lblNecessidade.Text = "Necessidade";
            // 
            // lblDataEntrada
            // 
            lblDataEntrada.AutoSize = true;
            lblDataEntrada.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataEntrada.ForeColor = Color.White;
            lblDataEntrada.Location = new Point(37, 129);
            lblDataEntrada.Name = "lblDataEntrada";
            lblDataEntrada.Size = new Size(81, 25);
            lblDataEntrada.TabIndex = 51;
            lblDataEntrada.Text = "Entrada";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(153, 54);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(66, 25);
            lblNome.TabIndex = 50;
            lblNome.Text = "Nome";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.White;
            lblId.Location = new Point(39, 53);
            lblId.Name = "lblId";
            lblId.Size = new Size(41, 25);
            lblId.TabIndex = 49;
            lblId.Text = "ID*";
            // 
            // cbxStatus
            // 
            cbxStatus.BackColor = Color.FromArgb(46, 51, 73);
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatus.FlatStyle = FlatStyle.Flat;
            cbxStatus.Font = new Font("Segoe UI", 12F);
            cbxStatus.ForeColor = Color.White;
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Finalizada", "Em andamento", "Parada", "Cancelada" });
            cbxStatus.Location = new Point(343, 129);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(127, 29);
            cbxStatus.TabIndex = 3;
            // 
            // cbxBackup
            // 
            cbxBackup.BackColor = Color.FromArgb(46, 51, 73);
            cbxBackup.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBackup.FlatStyle = FlatStyle.Flat;
            cbxBackup.Font = new Font("Segoe UI", 12F);
            cbxBackup.ForeColor = Color.White;
            cbxBackup.FormattingEnabled = true;
            cbxBackup.Items.AddRange(new object[] { "Cloud", "Pen drive", "HD externo", "Sem backup" });
            cbxBackup.Location = new Point(458, 202);
            cbxBackup.Name = "cbxBackup";
            cbxBackup.Size = new Size(186, 29);
            cbxBackup.TabIndex = 6;
            // 
            // cbxIsm
            // 
            cbxIsm.BackColor = Color.FromArgb(46, 51, 73);
            cbxIsm.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxIsm.FlatStyle = FlatStyle.Flat;
            cbxIsm.Font = new Font("Segoe UI", 12F);
            cbxIsm.ForeColor = Color.White;
            cbxIsm.FormattingEnabled = true;
            cbxIsm.Items.AddRange(new object[] { "André", "Edivania" });
            cbxIsm.Location = new Point(527, 128);
            cbxIsm.Name = "cbxIsm";
            cbxIsm.Size = new Size(113, 29);
            cbxIsm.TabIndex = 4;
            // 
            // cbxNecessidade
            // 
            cbxNecessidade.BackColor = Color.FromArgb(46, 51, 73);
            cbxNecessidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNecessidade.DropDownWidth = 190;
            cbxNecessidade.FlatStyle = FlatStyle.Flat;
            cbxNecessidade.Font = new Font("Segoe UI", 12F);
            cbxNecessidade.ForeColor = Color.White;
            cbxNecessidade.FormattingEnabled = true;
            cbxNecessidade.ItemHeight = 21;
            cbxNecessidade.Items.AddRange(new object[] { "Fiscal", "Gerencial", "Fiscal/Gerencial" });
            cbxNecessidade.Location = new Point(172, 204);
            cbxNecessidade.Name = "cbxNecessidade";
            cbxNecessidade.Size = new Size(179, 29);
            cbxNecessidade.TabIndex = 5;
            // 
            // txtObservacao
            // 
            txtObservacao.BackColor = Color.FromArgb(46, 51, 73);
            txtObservacao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObservacao.ForeColor = Color.White;
            txtObservacao.Location = new Point(39, 356);
            txtObservacao.MaxLength = 255;
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(600, 122);
            txtObservacao.TabIndex = 9;
            // 
            // txtHoras
            // 
            txtHoras.BackColor = Color.FromArgb(46, 51, 73);
            txtHoras.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoras.ForeColor = Color.White;
            txtHoras.Location = new Point(202, 268);
            txtHoras.Name = "txtHoras";
            txtHoras.PlaceholderText = "00:00:00";
            txtHoras.Size = new Size(124, 33);
            txtHoras.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(46, 51, 73);
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.White;
            txtNome.Location = new Point(222, 51);
            txtNome.MaxLength = 80;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(417, 33);
            txtNome.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(46, 51, 73);
            txtId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.ForeColor = Color.White;
            txtId.Location = new Point(82, 51);
            txtId.MaxLength = 4;
            txtId.Name = "txtId";
            txtId.Size = new Size(65, 33);
            txtId.TabIndex = 0;
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.Controls.Add(groupBox2);
            pnlFormLoader.Controls.Add(groupBox1);
            pnlFormLoader.Dock = DockStyle.Fill;
            pnlFormLoader.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            pnlFormLoader.ForeColor = Color.White;
            pnlFormLoader.Location = new Point(0, 0);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(1114, 639);
            pnlFormLoader.TabIndex = 59;
            pnlFormLoader.Paint += pnlFormLoader_Paint;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkOpcao3);
            groupBox2.Controls.Add(chkPesquisa);
            groupBox2.Controls.Add(chkOpcao2);
            groupBox2.Controls.Add(chkDocumentacao);
            groupBox2.Controls.Add(chkOpcao1);
            groupBox2.Controls.Add(chkZendesk);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(767, 34);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(295, 566);
            groupBox2.TabIndex = 66;
            groupBox2.TabStop = false;
            groupBox2.Text = "Checklist";
            // 
            // chkOpcao3
            // 
            chkOpcao3.Appearance = Appearance.Button;
            chkOpcao3.AutoSize = true;
            chkOpcao3.FlatAppearance.BorderSize = 0;
            chkOpcao3.FlatAppearance.CheckedBackColor = Color.Transparent;
            chkOpcao3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            chkOpcao3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            chkOpcao3.FlatStyle = FlatStyle.Flat;
            chkOpcao3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            chkOpcao3.ForeColor = Color.White;
            chkOpcao3.Image = Properties.Resources._unchecked;
            chkOpcao3.Location = new Point(37, 493);
            chkOpcao3.Name = "chkOpcao3";
            chkOpcao3.Size = new Size(131, 35);
            chkOpcao3.TabIndex = 66;
            chkOpcao3.Text = "  Opção 3";
            chkOpcao3.TextAlign = ContentAlignment.BottomCenter;
            chkOpcao3.TextImageRelation = TextImageRelation.ImageBeforeText;
            chkOpcao3.UseVisualStyleBackColor = true;
            chkOpcao3.CheckedChanged += chkCheckedCh;
            // 
            // chkPesquisa
            // 
            chkPesquisa.Appearance = Appearance.Button;
            chkPesquisa.AutoSize = true;
            chkPesquisa.FlatAppearance.BorderSize = 0;
            chkPesquisa.FlatAppearance.CheckedBackColor = Color.Transparent;
            chkPesquisa.FlatAppearance.MouseDownBackColor = Color.Transparent;
            chkPesquisa.FlatAppearance.MouseOverBackColor = Color.Transparent;
            chkPesquisa.FlatStyle = FlatStyle.Flat;
            chkPesquisa.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            chkPesquisa.ForeColor = Color.White;
            chkPesquisa.Image = Properties.Resources._unchecked;
            chkPesquisa.Location = new Point(37, 225);
            chkPesquisa.Name = "chkPesquisa";
            chkPesquisa.Size = new Size(134, 35);
            chkPesquisa.TabIndex = 64;
            chkPesquisa.Text = "  Pesquisa";
            chkPesquisa.TextAlign = ContentAlignment.BottomCenter;
            chkPesquisa.TextImageRelation = TextImageRelation.ImageBeforeText;
            chkPesquisa.UseVisualStyleBackColor = true;
            chkPesquisa.CheckedChanged += chkCheckedCh;
            // 
            // chkOpcao2
            // 
            chkOpcao2.Appearance = Appearance.Button;
            chkOpcao2.AutoSize = true;
            chkOpcao2.FlatAppearance.BorderSize = 0;
            chkOpcao2.FlatAppearance.CheckedBackColor = Color.Transparent;
            chkOpcao2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            chkOpcao2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            chkOpcao2.FlatStyle = FlatStyle.Flat;
            chkOpcao2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            chkOpcao2.ForeColor = Color.White;
            chkOpcao2.Image = Properties.Resources._unchecked;
            chkOpcao2.Location = new Point(37, 402);
            chkOpcao2.Name = "chkOpcao2";
            chkOpcao2.Size = new Size(131, 35);
            chkOpcao2.TabIndex = 65;
            chkOpcao2.Text = "  Opção 2";
            chkOpcao2.TextAlign = ContentAlignment.BottomCenter;
            chkOpcao2.TextImageRelation = TextImageRelation.ImageBeforeText;
            chkOpcao2.UseVisualStyleBackColor = true;
            chkOpcao2.CheckedChanged += chkCheckedCh;
            // 
            // chkDocumentacao
            // 
            chkDocumentacao.Appearance = Appearance.Button;
            chkDocumentacao.AutoSize = true;
            chkDocumentacao.FlatAppearance.BorderSize = 0;
            chkDocumentacao.FlatAppearance.CheckedBackColor = Color.Transparent;
            chkDocumentacao.FlatAppearance.MouseDownBackColor = Color.Transparent;
            chkDocumentacao.FlatAppearance.MouseOverBackColor = Color.Transparent;
            chkDocumentacao.FlatStyle = FlatStyle.Flat;
            chkDocumentacao.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            chkDocumentacao.ForeColor = Color.White;
            chkDocumentacao.Image = Properties.Resources._unchecked;
            chkDocumentacao.Location = new Point(37, 135);
            chkDocumentacao.Name = "chkDocumentacao";
            chkDocumentacao.Size = new Size(192, 35);
            chkDocumentacao.TabIndex = 60;
            chkDocumentacao.Text = "  Documentação";
            chkDocumentacao.TextAlign = ContentAlignment.BottomCenter;
            chkDocumentacao.TextImageRelation = TextImageRelation.ImageBeforeText;
            chkDocumentacao.UseVisualStyleBackColor = true;
            chkDocumentacao.CheckedChanged += chkCheckedCh;
            // 
            // chkOpcao1
            // 
            chkOpcao1.Appearance = Appearance.Button;
            chkOpcao1.AutoSize = true;
            chkOpcao1.FlatAppearance.BorderSize = 0;
            chkOpcao1.FlatAppearance.CheckedBackColor = Color.Transparent;
            chkOpcao1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            chkOpcao1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            chkOpcao1.FlatStyle = FlatStyle.Flat;
            chkOpcao1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            chkOpcao1.ForeColor = Color.White;
            chkOpcao1.Image = Properties.Resources._unchecked;
            chkOpcao1.Location = new Point(37, 312);
            chkOpcao1.Name = "chkOpcao1";
            chkOpcao1.Size = new Size(131, 35);
            chkOpcao1.TabIndex = 61;
            chkOpcao1.Text = "  Opção 1";
            chkOpcao1.TextAlign = ContentAlignment.BottomCenter;
            chkOpcao1.TextImageRelation = TextImageRelation.ImageBeforeText;
            chkOpcao1.UseVisualStyleBackColor = true;
            chkOpcao1.CheckedChanged += chkCheckedCh;
            // 
            // chkZendesk
            // 
            chkZendesk.Appearance = Appearance.Button;
            chkZendesk.AutoSize = true;
            chkZendesk.FlatAppearance.BorderSize = 0;
            chkZendesk.FlatAppearance.CheckedBackColor = Color.Transparent;
            chkZendesk.FlatAppearance.MouseDownBackColor = Color.Transparent;
            chkZendesk.FlatAppearance.MouseOverBackColor = Color.Transparent;
            chkZendesk.FlatStyle = FlatStyle.Flat;
            chkZendesk.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            chkZendesk.ForeColor = Color.White;
            chkZendesk.Image = Properties.Resources._unchecked;
            chkZendesk.Location = new Point(37, 48);
            chkZendesk.Name = "chkZendesk";
            chkZendesk.Size = new Size(133, 35);
            chkZendesk.TabIndex = 63;
            chkZendesk.Text = "  Zendesk";
            chkZendesk.TextAlign = ContentAlignment.BottomCenter;
            chkZendesk.TextImageRelation = TextImageRelation.ImageBeforeText;
            chkZendesk.UseVisualStyleBackColor = true;
            chkZendesk.CheckedChanged += chkCheckedCh;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxNecessidade);
            groupBox1.Controls.Add(cbxStatus);
            groupBox1.Controls.Add(txtDataFechamento);
            groupBox1.Controls.Add(txtHoras);
            groupBox1.Controls.Add(txtDataEntrada);
            groupBox1.Controls.Add(txtObservacao);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(btnConfirmar);
            groupBox1.Controls.Add(lblNome);
            groupBox1.Controls.Add(lblBackup);
            groupBox1.Controls.Add(lblStatus);
            groupBox1.Controls.Add(lblObservacao);
            groupBox1.Controls.Add(cbxIsm);
            groupBox1.Controls.Add(lblIsm);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(lblId);
            groupBox1.Controls.Add(cbxBackup);
            groupBox1.Controls.Add(lblNecessidade);
            groupBox1.Controls.Add(lblHoras);
            groupBox1.Controls.Add(lblDataFechamento);
            groupBox1.Controls.Add(lblDataEntrada);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(52, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(682, 566);
            groupBox1.TabIndex = 59;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados cadastrais";
            // 
            // txtDataFechamento
            // 
            txtDataFechamento.BorderColor = Color.White;
            txtDataFechamento.BorderSize = 1;
            txtDataFechamento.CustomFormat = "yyyy-MM-dd";
            txtDataFechamento.Font = new Font("Segoe UI", 11F);
            txtDataFechamento.Format = DateTimePickerFormat.Custom;
            txtDataFechamento.Location = new Point(506, 266);
            txtDataFechamento.MinimumSize = new Size(0, 35);
            txtDataFechamento.Name = "txtDataFechamento";
            txtDataFechamento.Size = new Size(133, 35);
            txtDataFechamento.SkinColor = Color.FromArgb(46, 51, 73);
            txtDataFechamento.TabIndex = 8;
            txtDataFechamento.TextColor = Color.White;
            txtDataFechamento.Value = new DateTime(2024, 4, 1, 0, 0, 0, 0);
            // 
            // txtDataEntrada
            // 
            txtDataEntrada.BorderColor = Color.White;
            txtDataEntrada.BorderSize = 1;
            txtDataEntrada.CalendarFont = new Font("Segoe UI", 11F);
            txtDataEntrada.CustomFormat = "yyyy-MM-dd";
            txtDataEntrada.Font = new Font("Segoe UI", 11F);
            txtDataEntrada.Format = DateTimePickerFormat.Custom;
            txtDataEntrada.Location = new Point(115, 126);
            txtDataEntrada.MinimumSize = new Size(0, 35);
            txtDataEntrada.Name = "txtDataEntrada";
            txtDataEntrada.Size = new Size(127, 35);
            txtDataEntrada.SkinColor = Color.FromArgb(46, 51, 73);
            txtDataEntrada.TabIndex = 2;
            txtDataEntrada.TextColor = Color.White;
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
            btnCancelar.Location = new Point(343, 499);
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
            btnConfirmar.Location = new Point(222, 499);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(104, 38);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "   Salvar";
            btnConfirmar.TextAlign = ContentAlignment.MiddleLeft;
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // frmCrudClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1114, 639);
            Controls.Add(pnlFormLoader);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1114, 639);
            Name = "frmCrudClientes";
            Text = "frmCrudClientes";
            Load += frmCrudClientes_Load;
            pnlFormLoader.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        public ComboBox cbxStatus;
        public ComboBox cbxBackup;
        public ComboBox cbxIsm;
        public ComboBox cbxNecessidade;
        public TextBox txtObservacao;
        public TextBox txtHoras;
        public TextBox txtNome;
        public TextBox txtId;
        public Panel pnlFormLoader;
        public FontAwesome.Sharp.IconButton btnConfirmar;
        public FontAwesome.Sharp.IconButton btnCancelar;
        public CustomDatePicker txtDataFechamento;
        public CustomDatePicker txtDataEntrada;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        public CheckBox chkDocumentacao;
        public CheckBox chkPesquisa;
        public CheckBox chkZendesk;
        public CheckBox chkOpcao1;
        public CheckBox chkOpcao2;
        public CheckBox chkOpcao3;
    }
}