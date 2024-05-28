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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // addorderBtn
            // 
            addorderBtn.BackColor = Color.FromArgb(255, 192, 192);
            addorderBtn.Font = new Font("Segoe UI Semibold", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addorderBtn.ForeColor = Color.Black;
            addorderBtn.Location = new Point(703, 879);
            addorderBtn.Margin = new Padding(7, 7, 7, 7);
            addorderBtn.Name = "addorderBtn";
            addorderBtn.Size = new Size(421, 98);
            addorderBtn.TabIndex = 28;
            addorderBtn.Text = "Add Order";
            addorderBtn.UseVisualStyleBackColor = false;
            addorderBtn.Click += addorderBtn_Click_1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(853, 522);
            txtQuantity.Margin = new Padding(7, 7, 7, 7);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(691, 47);
            txtQuantity.TabIndex = 25;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Segoe UI Semibold", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantityLabel.ForeColor = SystemColors.Desktop;
            quantityLabel.Location = new Point(350, 497);
            quantityLabel.Margin = new Padding(8, 0, 8, 0);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(257, 72);
            quantityLabel.TabIndex = 24;
            quantityLabel.Text = "Quantity:";
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(853, 259);
            cmbProduct.Margin = new Padding(7, 7, 7, 7);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(691, 49);
            cmbProduct.TabIndex = 23;
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Font = new Font("Segoe UI Semibold", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productLabel.ForeColor = SystemColors.Desktop;
            productLabel.Location = new Point(350, 250);
            productLabel.Margin = new Padding(8, 0, 8, 0);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(237, 72);
            productLabel.TabIndex = 22;
            productLabel.Text = "Product:";
            productLabel.Click += productLabel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(addorderBtn);
            panel1.Controls.Add(quantityLabel);
            panel1.Controls.Add(txtQuantity);
            panel1.Controls.Add(cmbProduct);
            panel1.Controls.Add(productLabel);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(825, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(1790, 1289);
            panel1.TabIndex = 29;
            panel1.Paint += panel1_Paint;
            // 
            // addOrder
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(2785, 1507);
            Controls.Add(panel1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "addOrder";
            Text = "addOrder";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button addorderBtn;
        private TextBox txtQuantity;
        private Label quantityLabel;
        private ComboBox cmbProduct;
        private Label productLabel;
        private Panel panel1;
    }
}
