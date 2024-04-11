namespace ISManager.Forms
{
    partial class frmDocumentacao
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
            panelDocumentacao = new Panel();
            lblSair = new Label();
            panelDocumentacao.SuspendLayout();
            SuspendLayout();
            // 
            // panelDocumentacao
            // 
            panelDocumentacao.Controls.Add(lblSair);
            panelDocumentacao.Dock = DockStyle.Fill;
            panelDocumentacao.Location = new Point(0, 0);
            panelDocumentacao.Name = "panelDocumentacao";
            panelDocumentacao.Size = new Size(1114, 639);
            panelDocumentacao.TabIndex = 17;
            // 
            // lblSair
            // 
            lblSair.AutoSize = true;
            lblSair.BackColor = Color.Transparent;
            lblSair.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSair.ForeColor = Color.FromArgb(57, 57, 57);
            lblSair.Location = new Point(421, 266);
            lblSair.Name = "lblSair";
            lblSair.Size = new Size(233, 38);
            lblSair.TabIndex = 6;
            lblSair.Text = "Em construção...";
            // 
            // frmDocumentacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 639);
            Controls.Add(panelDocumentacao);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1114, 639);
            Name = "frmDocumentacao";
            Text = "Documentação";
            panelDocumentacao.ResumeLayout(false);
            panelDocumentacao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDocumentacao;
        private Label lblSair;
    }
}