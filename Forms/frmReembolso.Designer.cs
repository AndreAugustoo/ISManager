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
            panelReembolso = new Panel();
            lblSair = new Label();
            panelReembolso.SuspendLayout();
            SuspendLayout();
            // 
            // panelReembolso
            // 
            panelReembolso.Controls.Add(lblSair);
            panelReembolso.Dock = DockStyle.Fill;
            panelReembolso.Location = new Point(0, 0);
            panelReembolso.Name = "panelReembolso";
            panelReembolso.Size = new Size(1113, 640);
            panelReembolso.TabIndex = 18;
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
            // frmReembolso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 640);
            Controls.Add(panelReembolso);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmReembolso";
            Text = "Reembolso";
            panelReembolso.ResumeLayout(false);
            panelReembolso.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelReembolso;
        private Label lblSair;
    }
}