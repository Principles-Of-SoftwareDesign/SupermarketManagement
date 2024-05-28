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
            SuspendLayout();
            // 
            // discountTxt
            // 
            discountTxt.Location = new Point(463, 398);
            discountTxt.Margin = new Padding(6, 6, 6, 6);
            discountTxt.Name = "discountTxt";
            discountTxt.Size = new Size(690, 47);
            discountTxt.TabIndex = 4;
            // 
            // discountBtn
            // 
            discountBtn.BackColor = SystemColors.HotTrack;
            discountBtn.ForeColor = Color.White;
            discountBtn.Location = new Point(487, 588);
            discountBtn.Margin = new Padding(6, 6, 6, 6);
            discountBtn.Name = "discountBtn";
            discountBtn.Size = new Size(672, 156);
            discountBtn.TabIndex = 11;
            discountBtn.Text = "Add discount";
            discountBtn.UseVisualStyleBackColor = false;
            discountBtn.Click += discountBtn_Click;
            // 
            // Invoice
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2776, 1512);
            Controls.Add(discountBtn);
            Controls.Add(discountTxt);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Invoice";
            Text = "Invoice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox discountTxt;
        private Button discountBtn;
    }
}