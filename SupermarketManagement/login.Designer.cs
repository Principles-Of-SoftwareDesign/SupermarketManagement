namespace SupermarketManagement
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            button1 = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            txtpassword = new TextBox();
            txtUserName = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(294, 374);
            button1.Name = "button1";
            button1.Size = new Size(246, 34);
            button1.TabIndex = 18;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Location = new Point(283, 295);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 3);
            panel2.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Location = new Point(280, 249);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 3);
            panel1.TabIndex = 16;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(218, 221);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(218, 267);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pristina", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(353, 129);
            label1.Name = "label1";
            label1.Size = new Size(84, 29);
            label1.TabIndex = 13;
            label1.Text = "LOG IN";
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Location = new Point(283, 264);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(297, 24);
            txtpassword.TabIndex = 12;
            txtpassword.TextChanged += txtpassword_TextChanged;
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Location = new Point(280, 221);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(300, 24);
            txtUserName.TabIndex = 11;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Capture;
            pictureBox1.Location = new Point(365, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(txtpassword);
            Controls.Add(txtUserName);
            Controls.Add(pictureBox1);
            Name = "login";
            Text = "login";
            Load += this.login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private TextBox txtpassword;
        private TextBox txtUserName;
        private PictureBox pictureBox1;
    }
}