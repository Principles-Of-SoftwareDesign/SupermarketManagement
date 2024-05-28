namespace SupermarketManagement.Views
{
    partial class addOrder
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
            addorderBtn = new Button();
            txtQuantity = new TextBox();
            quantityLabel = new Label();
            cmbProduct = new ComboBox();
            productLabel = new Label();
            SuspendLayout();
            // 
            // addorderBtn
            // 
            addorderBtn.BackColor = SystemColors.Highlight;
            addorderBtn.ForeColor = Color.White;
            addorderBtn.Location = new Point(544, 290);
            addorderBtn.Margin = new Padding(4);
            addorderBtn.Name = "addorderBtn";
            addorderBtn.Size = new Size(181, 60);
            addorderBtn.TabIndex = 28;
            addorderBtn.Text = "Add Order";
            addorderBtn.UseVisualStyleBackColor = false;
            addorderBtn.Click += addorderBtn_Click_1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(199, 189);
            txtQuantity.Margin = new Padding(4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(408, 31);
            txtQuantity.TabIndex = 25;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.ForeColor = SystemColors.Highlight;
            quantityLabel.Location = new Point(49, 189);
            quantityLabel.Margin = new Padding(5, 0, 5, 0);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(84, 25);
            quantityLabel.TabIndex = 24;
            quantityLabel.Text = "Quantity:";
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(199, 101);
            cmbProduct.Margin = new Padding(4);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(408, 33);
            cmbProduct.TabIndex = 23;
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.ForeColor = SystemColors.Highlight;
            productLabel.Location = new Point(55, 101);
            productLabel.Margin = new Padding(5, 0, 5, 0);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(78, 25);
            productLabel.TabIndex = 22;
            productLabel.Text = "Product:";
            // 
            // addOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(addorderBtn);
            Controls.Add(txtQuantity);
            Controls.Add(quantityLabel);
            Controls.Add(cmbProduct);
            Controls.Add(productLabel);
            Name = "addOrder";
            Text = "addOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addorderBtn;
        private TextBox txtQuantity;
        private Label quantityLabel;
        private ComboBox cmbProduct;
        private Label productLabel;
    }
}
