namespace ISManager
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
            label1 = new Label();
            btnSair = new Button();
            lblMigracoes = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(260, 243);
            label1.Name = "label1";
            label1.Size = new Size(208, 37);
            label1.TabIndex = 0;
            label1.Text = "Em construção...";
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
            btnSair.TabIndex = 7;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // lblMigracoes
            // 
            lblMigracoes.AutoSize = true;
            lblMigracoes.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMigracoes.ForeColor = Color.White;
            lblMigracoes.Location = new Point(12, 9);
            lblMigracoes.Name = "lblMigracoes";
            lblMigracoes.Size = new Size(152, 38);
            lblMigracoes.TabIndex = 6;
            lblMigracoes.Text = "Migrações";
            // 
            // frmMigracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(765, 577);
            Controls.Add(btnSair);
            Controls.Add(lblMigracoes);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMigracoes";
            Text = "frmMigracoes";
            Load += frmMigracoes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSair;
        private Label lblMigracoes;
    }
}