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
            label7 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // addorderBtn
            // 
            addorderBtn.BackColor = Color.FromArgb(255, 192, 192);
            addorderBtn.Font = new Font("Segoe UI Semibold", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addorderBtn.ForeColor = Color.Black;
            addorderBtn.Location = new Point(331, 429);
            addorderBtn.Name = "addorderBtn";
            addorderBtn.Size = new Size(198, 48);
            addorderBtn.TabIndex = 28;
            addorderBtn.Text = "Add Order";
            addorderBtn.UseVisualStyleBackColor = false;
            addorderBtn.Click += addorderBtn_Click_1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(401, 255);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(327, 27);
            txtQuantity.TabIndex = 25;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Segoe UI Semibold", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantityLabel.ForeColor = SystemColors.Desktop;
            quantityLabel.Location = new Point(165, 242);
            quantityLabel.Margin = new Padding(4, 0, 4, 0);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(131, 37);
            quantityLabel.TabIndex = 24;
            quantityLabel.Text = "Quantity:";
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(401, 126);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(327, 28);
            cmbProduct.TabIndex = 23;
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Font = new Font("Segoe UI Semibold", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productLabel.ForeColor = SystemColors.Desktop;
            productLabel.Location = new Point(165, 122);
            productLabel.Margin = new Padding(4, 0, 4, 0);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(121, 37);
            productLabel.TabIndex = 22;
            productLabel.Text = "Product:";
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
            panel1.Location = new Point(265, 56);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 629);
            panel1.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(90, 530);
            label7.Name = "label7";
            label7.Size = new Size(110, 38);
            label7.TabIndex = 31;
            label7.Text = "Logout";
            label7.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(80, 273);
            label5.Name = "label5";
            label5.Size = new Size(154, 38);
            label5.TabIndex = 30;
            label5.Text = "Add Order";
            // 
            // addOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1287, 643);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "addOrder";
            Text = "addOrder";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addorderBtn;
        private TextBox txtQuantity;
        private Label quantityLabel;
        private ComboBox cmbProduct;
        private Label productLabel;
        private Panel panel1;
        private Label label7;
        private Label label5;
    }
}
