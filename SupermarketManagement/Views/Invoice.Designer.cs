namespace SupermarketManagement.Views
{
    partial class Invoice
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
            discountTxt = new TextBox();
            discountBtn = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            label5 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // discountTxt
            // 
            discountTxt.Location = new Point(377, 165);
            discountTxt.Margin = new Padding(1, 1, 1, 1);
            discountTxt.Name = "discountTxt";
            discountTxt.Size = new Size(327, 27);
            discountTxt.TabIndex = 4;
            // 
            // discountBtn
            // 
            discountBtn.BackColor = Color.FromArgb(255, 192, 192);
            discountBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discountBtn.ForeColor = Color.Black;
            discountBtn.Location = new Point(265, 247);
            discountBtn.Margin = new Padding(1, 1, 1, 1);
            discountBtn.Name = "discountBtn";
            discountBtn.Size = new Size(316, 76);
            discountBtn.TabIndex = 11;
            discountBtn.Text = "Add discount";
            discountBtn.UseVisualStyleBackColor = false;
            discountBtn.Click += discountBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 189);
            label1.Name = "label1";
            label1.Size = new Size(170, 31);
            label1.TabIndex = 12;
            label1.Text = "Discount Code";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(308, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(993, 524);
            panel1.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(79, 451);
            label7.Name = "label7";
            label7.Size = new Size(110, 38);
            label7.TabIndex = 19;
            label7.Text = "Logout";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(62, 223);
            label5.Name = "label5";
            label5.Size = new Size(154, 38);
            label5.TabIndex = 17;
            label5.Text = "Add Order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 159);
            label2.Name = "label2";
            label2.Size = new Size(166, 31);
            label2.TabIndex = 12;
            label2.Text = "Discount Code";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(discountBtn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(discountTxt);
            panel2.Location = new Point(277, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(808, 425);
            panel2.TabIndex = 13;
            panel2.Paint += panel2_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(53, 483);
            label3.Name = "label3";
            label3.Size = new Size(110, 38);
            label3.TabIndex = 24;
            label3.Text = "Logout";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(53, 221);
            label10.Name = "label10";
            label10.Size = new Size(154, 38);
            label10.TabIndex = 21;
            label10.Text = "Add Order";
            // 
            // Invoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1084, 644);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(panel2);
            Margin = new Padding(1, 1, 1, 1);
            Name = "Invoice";
            Text = "Invoice";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox discountTxt;
        private Button discountBtn;
        private Label label1;
        private Panel panel1;
        private Label label7;
        private Label label5;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Label label10;
    }
}