namespace SupermarketManagement.Views
{
    partial class AddProduct
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            nameTxt = new TextBox();
            nameLabel = new Label();
            categoryTxt = new TextBox();
            categoryLabel = new Label();
            priceTxt = new TextBox();
            priceLabel = new Label();
            quantityTxt = new TextBox();
            quantityLabel = new Label();
            addproductBtn = new Button();
            SuspendLayout();
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(687, 141);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(327, 47);
            nameTxt.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(364, 144);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(104, 41);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // categoryTxt
            // 
            categoryTxt.Location = new Point(687, 215);
            categoryTxt.Name = "categoryTxt";
            categoryTxt.Size = new Size(327, 47);
            categoryTxt.TabIndex = 5;
            // 
            // categoryLabel
            // 
            categoryLabel.Location = new Point(364, 222);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(163, 54);
            categoryLabel.TabIndex = 4;
            categoryLabel.Text = "Category:";
            // 
            // priceTxt
            // 
            priceTxt.Location = new Point(687, 297);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(327, 47);
            priceTxt.TabIndex = 7;
            // 
            // priceLabel
            // 
            priceLabel.Location = new Point(364, 297);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(292, 54);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "Price:";
            // 
            // quantityTxt
            // 
            quantityTxt.Location = new Point(687, 384);
            quantityTxt.Name = "quantityTxt";
            quantityTxt.Size = new Size(327, 47);
            quantityTxt.TabIndex = 9;
            // 
            // quantityLabel
            // 
            quantityLabel.Location = new Point(364, 387);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(188, 54);
            quantityLabel.TabIndex = 8;
            quantityLabel.Text = "Quantity:";
            // 
            // addproductBtn
            // 
            addproductBtn.Location = new Point(525, 494);
            addproductBtn.Name = "addproductBtn";
            addproductBtn.Size = new Size(270, 60);
            addproductBtn.TabIndex = 8;
            addproductBtn.Text = "Add New Product";
            addproductBtn.Click += btnAddProduct_Click;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 645);
            Controls.Add(nameTxt);
            Controls.Add(nameLabel);
            Controls.Add(categoryTxt);
            Controls.Add(categoryLabel);
            Controls.Add(priceTxt);
            Controls.Add(priceLabel);
            Controls.Add(quantityTxt);
            Controls.Add(quantityLabel);
            Controls.Add(addproductBtn);
            Text = "Add Product";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox categoryTxt;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button addproductBtn;
    }
}
