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
            discountTxt.Location = new Point(218, 194);
            discountTxt.Name = "discountTxt";
            discountTxt.Size = new Size(327, 27);
            discountTxt.TabIndex = 4;
            // 
            // discountBtn
            // 
            discountBtn.BackColor = SystemColors.HotTrack;
            discountBtn.ForeColor = Color.White;
            discountBtn.Location = new Point(229, 287);
            discountBtn.Name = "discountBtn";
            discountBtn.Size = new Size(316, 76);
            discountBtn.TabIndex = 11;
            discountBtn.Text = "Add New Admin";
            discountBtn.UseVisualStyleBackColor = false;
            discountBtn.Click += discountBtn_Click;
            // 
            // Invoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(discountBtn);
            Controls.Add(discountTxt);
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