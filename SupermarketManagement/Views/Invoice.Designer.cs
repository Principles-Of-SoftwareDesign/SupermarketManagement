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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // discountTxt
            // 
            discountTxt.Location = new Point(495, 193);
            discountTxt.Name = "discountTxt";
            discountTxt.Size = new Size(327, 27);
            discountTxt.TabIndex = 4;
            // 
            // discountBtn
            // 
            discountBtn.BackColor = Color.FromArgb(255, 192, 192);
            discountBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discountBtn.ForeColor = Color.Black;
            discountBtn.Location = new Point(319, 362);
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
            panel1.Controls.Add(discountBtn);
            panel1.Controls.Add(discountTxt);
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
            // Invoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1298, 618);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "Invoice";
            Text = "Invoice";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}