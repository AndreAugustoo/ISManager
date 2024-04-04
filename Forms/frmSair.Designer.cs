namespace ISManager
{
    partial class frmSair
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
            lblSair = new Label();
            btnSair = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // lblSair
            // 
            lblSair.AutoSize = true;
            lblSair.BackColor = Color.Transparent;
            lblSair.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSair.ForeColor = Color.FromArgb(57, 57, 57);
            lblSair.Location = new Point(430, 218);
            lblSair.Name = "lblSair";
            lblSair.Size = new Size(252, 76);
            lblSair.TabIndex = 6;
            lblSair.Text = "Deseja realmente \r\nsair do sitema?";
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.IndianRed;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 15.25F, FontStyle.Bold);
            btnSair.ForeColor = Color.FromArgb(57, 57, 57);
            btnSair.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            btnSair.IconColor = Color.FromArgb(57, 57, 57);
            btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSair.IconSize = 30;
            btnSair.ImageAlign = ContentAlignment.MiddleRight;
            btnSair.Location = new Point(477, 308);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(115, 51);
            btnSair.TabIndex = 15;
            btnSair.Text = "    Sair";
            btnSair.TextAlign = ContentAlignment.MiddleLeft;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // frmSair
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1114, 639);
            Controls.Add(btnSair);
            Controls.Add(lblSair);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1114, 639);
            Name = "frmSair";
            Text = "Sair";
            Load += frmSair_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSair;
        private FontAwesome.Sharp.IconButton btnSair;
    }
}