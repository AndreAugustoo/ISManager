namespace ISManager
{
    partial class frmDashboard
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
            label2 = new Label();
            lblTotalImplantacoes = new Label();
            label4 = new Label();
            panelTotalImplantacao = new Panel();
            panelTotalCancelado = new Panel();
            label1 = new Label();
            label3 = new Label();
            lblTotalCancelado = new Label();
            lblTotalAberto = new Label();
            panelTotalFinalizado = new Panel();
            label7 = new Label();
            label8 = new Label();
            lblTotalFechado = new Label();
            panel4 = new Panel();
            label5 = new Label();
            label9 = new Label();
            panel5 = new Panel();
            label11 = new Label();
            label12 = new Label();
            panelTotalAberto = new Panel();
            label10 = new Label();
            label13 = new Label();
            panel7 = new Panel();
            label15 = new Label();
            label16 = new Label();
            panel8 = new Panel();
            panelTotalImplantacao.SuspendLayout();
            panelTotalCancelado.SuspendLayout();
            panelTotalFinalizado.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panelTotalAberto.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(19, 13);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 0;
            label2.Text = "Total";
            // 
            // lblTotalImplantacoes
            // 
            lblTotalImplantacoes.AutoSize = true;
            lblTotalImplantacoes.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalImplantacoes.ForeColor = Color.White;
            lblTotalImplantacoes.Location = new Point(12, 38);
            lblTotalImplantacoes.Name = "lblTotalImplantacoes";
            lblTotalImplantacoes.Size = new Size(88, 51);
            lblTotalImplantacoes.TabIndex = 1;
            lblTotalImplantacoes.Text = "999";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 107);
            label4.Name = "label4";
            label4.Size = new Size(139, 17);
            label4.TabIndex = 2;
            label4.Text = "Total de implantações.";
            // 
            // panelTotalImplantacao
            // 
            panelTotalImplantacao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelTotalImplantacao.AutoSize = true;
            panelTotalImplantacao.BackColor = Color.FromArgb(255, 128, 40);
            panelTotalImplantacao.Controls.Add(label4);
            panelTotalImplantacao.Controls.Add(label2);
            panelTotalImplantacao.Controls.Add(lblTotalImplantacoes);
            panelTotalImplantacao.Location = new Point(95, 88);
            panelTotalImplantacao.Name = "panelTotalImplantacao";
            panelTotalImplantacao.Size = new Size(227, 142);
            panelTotalImplantacao.TabIndex = 10;
            // 
            // panelTotalCancelado
            // 
            panelTotalCancelado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelTotalCancelado.AutoSize = true;
            panelTotalCancelado.BackColor = Color.FromArgb(226, 50, 90);
            panelTotalCancelado.Controls.Add(label1);
            panelTotalCancelado.Controls.Add(label3);
            panelTotalCancelado.Controls.Add(lblTotalCancelado);
            panelTotalCancelado.Location = new Point(561, 88);
            panelTotalCancelado.Name = "panelTotalCancelado";
            panelTotalCancelado.Size = new Size(227, 142);
            panelTotalCancelado.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 107);
            label1.Name = "label1";
            label1.Size = new Size(156, 17);
            label1.TabIndex = 2;
            label1.Text = "Implantações canceladas.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(19, 13);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 0;
            label3.Text = "Canceladas";
            // 
            // lblTotalCancelado
            // 
            lblTotalCancelado.AutoSize = true;
            lblTotalCancelado.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalCancelado.ForeColor = Color.White;
            lblTotalCancelado.Location = new Point(12, 38);
            lblTotalCancelado.Name = "lblTotalCancelado";
            lblTotalCancelado.Size = new Size(88, 51);
            lblTotalCancelado.TabIndex = 1;
            lblTotalCancelado.Text = "999";
            // 
            // lblTotalAberto
            // 
            lblTotalAberto.AutoSize = true;
            lblTotalAberto.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalAberto.ForeColor = Color.White;
            lblTotalAberto.Location = new Point(12, 38);
            lblTotalAberto.Name = "lblTotalAberto";
            lblTotalAberto.Size = new Size(88, 51);
            lblTotalAberto.TabIndex = 1;
            lblTotalAberto.Text = "999";
            // 
            // panelTotalFinalizado
            // 
            panelTotalFinalizado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelTotalFinalizado.AutoSize = true;
            panelTotalFinalizado.BackColor = Color.FromArgb(50, 226, 178);
            panelTotalFinalizado.Controls.Add(label7);
            panelTotalFinalizado.Controls.Add(label8);
            panelTotalFinalizado.Controls.Add(lblTotalFechado);
            panelTotalFinalizado.Location = new Point(328, 88);
            panelTotalFinalizado.Name = "panelTotalFinalizado";
            panelTotalFinalizado.Size = new Size(227, 142);
            panelTotalFinalizado.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 107);
            label7.Name = "label7";
            label7.Size = new Size(153, 17);
            label7.TabIndex = 2;
            label7.Text = "Implantações finalizadas.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(19, 13);
            label8.Name = "label8";
            label8.Size = new Size(105, 25);
            label8.TabIndex = 0;
            label8.Text = "Finalizadas";
            // 
            // lblTotalFechado
            // 
            lblTotalFechado.AutoSize = true;
            lblTotalFechado.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalFechado.ForeColor = Color.White;
            lblTotalFechado.Location = new Point(12, 38);
            lblTotalFechado.Name = "lblTotalFechado";
            lblTotalFechado.Size = new Size(88, 51);
            lblTotalFechado.TabIndex = 1;
            lblTotalFechado.Text = "999";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.AutoSize = true;
            panel4.BackColor = Color.FromArgb(241, 243, 244);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(95, 236);
            panel4.Name = "panel4";
            panel4.Size = new Size(227, 332);
            panel4.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(57, 57, 57);
            label5.Location = new Point(12, 301);
            label5.Name = "label5";
            label5.Size = new Size(137, 17);
            label5.TabIndex = 2;
            label5.Text = "Descrição do gráfico1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(57, 57, 57);
            label9.Location = new Point(19, 13);
            label9.Name = "label9";
            label9.Size = new Size(88, 25);
            label9.TabIndex = 0;
            label9.Text = "Gráfico 1";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.AutoSize = true;
            panel5.BackColor = Color.FromArgb(241, 243, 244);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label12);
            panel5.Location = new Point(328, 236);
            panel5.Name = "panel5";
            panel5.Size = new Size(460, 332);
            panel5.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(57, 57, 57);
            label11.Location = new Point(19, 301);
            label11.Name = "label11";
            label11.Size = new Size(141, 17);
            label11.TabIndex = 2;
            label11.Text = "Descrição do gráfico 2";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(57, 57, 57);
            label12.Location = new Point(19, 13);
            label12.Name = "label12";
            label12.Size = new Size(88, 25);
            label12.TabIndex = 0;
            label12.Text = "Gráfico 2";
            // 
            // panelTotalAberto
            // 
            panelTotalAberto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelTotalAberto.AutoSize = true;
            panelTotalAberto.BackColor = Color.FromArgb(0, 126, 249);
            panelTotalAberto.Controls.Add(label10);
            panelTotalAberto.Controls.Add(label13);
            panelTotalAberto.Controls.Add(lblTotalAberto);
            panelTotalAberto.Location = new Point(794, 88);
            panelTotalAberto.Name = "panelTotalAberto";
            panelTotalAberto.Size = new Size(227, 142);
            panelTotalAberto.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(12, 107);
            label10.Name = "label10";
            label10.Size = new Size(180, 17);
            label10.TabIndex = 2;
            label10.Text = "Implantações em andamento.";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.FlatStyle = FlatStyle.Flat;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(19, 13);
            label13.Name = "label13";
            label13.Size = new Size(139, 25);
            label13.TabIndex = 0;
            label13.Text = "Em andamento";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel7.AutoSize = true;
            panel7.BackColor = Color.FromArgb(241, 243, 244);
            panel7.Controls.Add(label15);
            panel7.Controls.Add(label16);
            panel7.Location = new Point(794, 236);
            panel7.Name = "panel7";
            panel7.Size = new Size(227, 332);
            panel7.TabIndex = 12;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(57, 57, 57);
            label15.Location = new Point(12, 301);
            label15.Name = "label15";
            label15.Size = new Size(141, 17);
            label15.TabIndex = 2;
            label15.Text = "Descrição do gráfico 3";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.FlatStyle = FlatStyle.Flat;
            label16.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(57, 57, 57);
            label16.Location = new Point(19, 13);
            label16.Name = "label16";
            label16.Size = new Size(88, 25);
            label16.TabIndex = 0;
            label16.Text = "Gráfico 3";
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1114, 639);
            panel8.TabIndex = 13;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1114, 639);
            Controls.Add(panel7);
            Controls.Add(panelTotalAberto);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panelTotalFinalizado);
            Controls.Add(panelTotalCancelado);
            Controls.Add(panelTotalImplantacao);
            Controls.Add(panel8);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1114, 639);
            Name = "frmDashboard";
            Text = "Dashboard";
            Load += frmDashboard_Load;
            panelTotalImplantacao.ResumeLayout(false);
            panelTotalImplantacao.PerformLayout();
            panelTotalCancelado.ResumeLayout(false);
            panelTotalCancelado.PerformLayout();
            panelTotalFinalizado.ResumeLayout(false);
            panelTotalFinalizado.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panelTotalAberto.ResumeLayout(false);
            panelTotalAberto.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label2;
        private Label label4;
        private Label label1;
        private Label label3;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label10;
        private Label label13;
        private Label label15;
        private Label label16;
        public Panel panelTotalImplantacao;
        public Panel panelTotalCancelado;
        public Panel panelTotalFinalizado;
        public Panel panel4;
        public Panel panel5;
        public Panel panelTotalAberto;
        public Panel panel7;
        public Label lblTotalImplantacoes;
        public Label lblTotalAberto;
        public Label lblTotalFechado;
        public Label lblTotalCancelado;
        private Panel panel8;
    }
}