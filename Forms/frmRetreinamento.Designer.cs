namespace ISManager.Forms
{
    partial class frmRetreinamento
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
            panelRetreinamento = new Panel();
            lblSair = new Label();
            panelRetreinamento.SuspendLayout();
            SuspendLayout();
            // 
            // panelRetreinamento
            // 
            panelRetreinamento.Controls.Add(lblSair);
            panelRetreinamento.Dock = DockStyle.Fill;
            panelRetreinamento.Location = new Point(0, 0);
            panelRetreinamento.MinimumSize = new Size(1114, 639);
            panelRetreinamento.Name = "panelRetreinamento";
            panelRetreinamento.Size = new Size(1114, 639);
            panelRetreinamento.TabIndex = 18;
            // 
            // lblSair
            // 
            lblSair.AutoSize = true;
            lblSair.BackColor = Color.Transparent;
            lblSair.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSair.ForeColor = Color.FromArgb(57, 57, 57);
            lblSair.Location = new Point(439, 271);
            lblSair.Name = "lblSair";
            lblSair.Size = new Size(233, 38);
            lblSair.TabIndex = 6;
            lblSair.Text = "Em construção...";
            // 
            // frmRetreinamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 639);
            Controls.Add(panelRetreinamento);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1114, 639);
            Name = "frmRetreinamento";
            Text = "frmRetreinamento";
            panelRetreinamento.ResumeLayout(false);
            panelRetreinamento.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelRetreinamento;
        private Label lblSair;
    }
}