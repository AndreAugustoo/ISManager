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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            flowLayoutPanel3 = new FlowLayoutPanel();
            label8 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            btnSair = new Button();
            lblDashboard = new Label();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.FromArgb(37, 42, 64);
            flowLayoutPanel3.Controls.Add(label8);
            flowLayoutPanel3.Location = new Point(142, 238);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(258, 300);
            flowLayoutPanel3.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(85, 25);
            label8.TabIndex = 0;
            label8.Text = "Earnings";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(37, 42, 64);
            flowLayoutPanel2.Controls.Add(label5);
            flowLayoutPanel2.Controls.Add(label6);
            flowLayoutPanel2.Controls.Add(label7);
            flowLayoutPanel2.Controls.Add(pictureBox3);
            flowLayoutPanel2.Location = new Point(403, 76);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(258, 130);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 0;
            label5.Text = "Earnings";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(50, 226, 178);
            label6.Location = new Point(3, 25);
            label6.Name = "label6";
            label6.Size = new Size(163, 38);
            label6.TabIndex = 1;
            label6.Text = "R$ 1234,50";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(158, 161, 176);
            label7.Location = new Point(3, 63);
            label7.Name = "label7";
            label7.Size = new Size(176, 17);
            label7.TabIndex = 2;
            label7.Text = "Detalhes dos ultimos 28 dias";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 83);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(93, 73);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(37, 42, 64);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Location = new Point(118, 76);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(258, 130);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 0;
            label2.Text = "Earnings";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 126, 249);
            label3.Location = new Point(3, 25);
            label3.Name = "label3";
            label3.Size = new Size(163, 38);
            label3.TabIndex = 1;
            label3.Text = "R$ 1234,50";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(158, 161, 176);
            label4.Location = new Point(3, 63);
            label4.Name = "label4";
            label4.Size = new Size(176, 17);
            label4.TabIndex = 2;
            label4.Text = "Detalhes dos ultimos 28 dias";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 73);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
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
            btnSair.TabIndex = 9;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.ForeColor = Color.FromArgb(158, 161, 176);
            lblDashboard.Location = new Point(12, 9);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(159, 38);
            lblDashboard.TabIndex = 8;
            lblDashboard.Text = "Dashboard";
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(765, 577);
            Controls.Add(btnSair);
            Controls.Add(lblDashboard);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDashboard";
            Text = "frmDashboard";
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel3;
        private Label label8;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private Button btnSair;
        private Label lblDashboard;
    }
}