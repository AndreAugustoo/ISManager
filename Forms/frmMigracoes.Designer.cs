﻿namespace ISManager
{
    partial class frmMigracoes
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
            btnSair = new Button();
            lblMigracoes = new Label();
            pnlMigracoes = new Panel();
            label1 = new Label();
            btnFiltrar = new FontAwesome.Sharp.IconButton();
            btnExcluir = new FontAwesome.Sharp.IconButton();
            btnAlterar = new FontAwesome.Sharp.IconButton();
            btnCadastrar = new FontAwesome.Sharp.IconButton();
            cbxFiltro = new ComboBox();
            lblNumeroRegistro = new Label();
            txtFiltro = new TextBox();
            dtGridMigracoes = new DataGridView();
            pnlMigracoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridMigracoes).BeginInit();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(1069, 12);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(33, 33);
            btnSair.TabIndex = 7;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // lblMigracoes
            // 
            lblMigracoes.AutoSize = true;
            lblMigracoes.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMigracoes.ForeColor = Color.White;
            lblMigracoes.Location = new Point(42, 21);
            lblMigracoes.Name = "lblMigracoes";
            lblMigracoes.Size = new Size(312, 38);
            lblMigracoes.TabIndex = 6;
            lblMigracoes.Text = "Controle de migrações";
            // 
            // pnlMigracoes
            // 
            pnlMigracoes.Controls.Add(label1);
            pnlMigracoes.Controls.Add(btnSair);
            pnlMigracoes.Controls.Add(btnFiltrar);
            pnlMigracoes.Controls.Add(lblMigracoes);
            pnlMigracoes.Controls.Add(btnExcluir);
            pnlMigracoes.Controls.Add(btnAlterar);
            pnlMigracoes.Controls.Add(btnCadastrar);
            pnlMigracoes.Controls.Add(cbxFiltro);
            pnlMigracoes.Controls.Add(lblNumeroRegistro);
            pnlMigracoes.Controls.Add(txtFiltro);
            pnlMigracoes.Controls.Add(dtGridMigracoes);
            pnlMigracoes.Dock = DockStyle.Fill;
            pnlMigracoes.Location = new Point(0, 0);
            pnlMigracoes.Name = "pnlMigracoes";
            pnlMigracoes.Size = new Size(1114, 700);
            pnlMigracoes.TabIndex = 15;
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
            cbxFiltro.Items.AddRange(new object[] { "ID", "Nome", "Status" });
            cbxFiltro.Location = new Point(45, 91);
            cbxFiltro.Name = "cbxFiltro";
            cbxFiltro.Size = new Size(104, 31);
            cbxFiltro.TabIndex = 0;
            cbxFiltro.Text = "ID";
            // 
            // lblNumeroRegistro
            // 
            lblNumeroRegistro.AutoSize = true;
            lblNumeroRegistro.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumeroRegistro.ForeColor = Color.FromArgb(158, 161, 176);
            lblNumeroRegistro.Location = new Point(42, 656);
            lblNumeroRegistro.Name = "lblNumeroRegistro";
            lblNumeroRegistro.Size = new Size(262, 20);
            lblNumeroRegistro.TabIndex = 7;
            lblNumeroRegistro.Text = "Número de registros encontrados: 0";
            // 
            // txtFiltro
            // 
            txtFiltro.BackColor = Color.FromArgb(46, 51, 73);
            txtFiltro.Font = new Font("Segoe UI", 14F);
            txtFiltro.ForeColor = Color.White;
            txtFiltro.Location = new Point(165, 91);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.PlaceholderText = "  Filtro";
            txtFiltro.Size = new Size(262, 32);
            txtFiltro.TabIndex = 1;
            // 
            // dtGridMigracoes
            // 
            dtGridMigracoes.AllowUserToAddRows = false;
            dtGridMigracoes.AllowUserToDeleteRows = false;
            dtGridMigracoes.AllowUserToOrderColumns = true;
            dtGridMigracoes.AllowUserToResizeRows = false;
            dtGridMigracoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtGridMigracoes.BackgroundColor = Color.FromArgb(46, 51, 73);
            dtGridMigracoes.BorderStyle = BorderStyle.None;
            dtGridMigracoes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtGridMigracoes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(24, 30, 54);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(24, 30, 54);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dtGridMigracoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtGridMigracoes.ColumnHeadersHeight = 30;
            dtGridMigracoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtGridMigracoes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtGridMigracoes.EnableHeadersVisualStyles = false;
            dtGridMigracoes.GridColor = Color.FromArgb(74, 79, 99);
            dtGridMigracoes.Location = new Point(42, 152);
            dtGridMigracoes.MultiSelect = false;
            dtGridMigracoes.Name = "dtGridMigracoes";
            dtGridMigracoes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopLeft;
            dtGridMigracoes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtGridMigracoes.RowHeadersVisible = false;
            dtGridMigracoes.RowHeadersWidth = 4;
            dtGridMigracoes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(74, 79, 99);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dtGridMigracoes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dtGridMigracoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGridMigracoes.Size = new Size(1024, 482);
            dtGridMigracoes.TabIndex = 6;
            dtGridMigracoes.TabStop = false;
            // 
            // frmMigracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1114, 700);
            Controls.Add(pnlMigracoes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMigracoes";
            Text = "Migracoes";
            pnlMigracoes.ResumeLayout(false);
            pnlMigracoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridMigracoes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSair;
        private Label lblMigracoes;
        private Panel pnlMigracoes;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnFiltrar;
        private FontAwesome.Sharp.IconButton btnExcluir;
        private FontAwesome.Sharp.IconButton btnAlterar;
        private FontAwesome.Sharp.IconButton btnCadastrar;
        private ComboBox cbxFiltro;
        private Label lblNumeroRegistro;
        private TextBox txtFiltro;
        private DataGridView dtGridMigracoes;
    }
}