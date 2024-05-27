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
            txtprice = new TextBox();
            priceLabel = new Label();
            txtquantity = new TextBox();
            quantityLabel = new Label();
            txtname = new TextBox();
            name = new Label();
            SuspendLayout();
            // 
            // addorderBtn
            // 
            addorderBtn.BackColor = SystemColors.HotTrack;
            addorderBtn.ForeColor = Color.White;
            addorderBtn.Location = new Point(264, 352);
            addorderBtn.Margin = new Padding(4);
            addorderBtn.Name = "addorderBtn";
            addorderBtn.Size = new Size(291, 60);
            addorderBtn.TabIndex = 28;
            addorderBtn.Text = "Add Order";
            addorderBtn.UseVisualStyleBackColor = false;
            addorderBtn.Click += addAdminBtn_Click;
            // 
            // txtprice
            // 
            txtprice.Location = new Point(288, 249);
            txtprice.Margin = new Padding(4);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(408, 31);
            txtprice.TabIndex = 27;
            
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(88, 255);
            priceLabel.Margin = new Padding(5, 0, 5, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(53, 25);
            priceLabel.TabIndex = 26;
            priceLabel.Text = "Price:";
            // 
            // txtquantity
            // 
            txtquantity.Location = new Point(288, 165);
            txtquantity.Margin = new Padding(4);
            txtquantity.Name = "txtquantity";
            txtquantity.Size = new Size(408, 31);
            txtquantity.TabIndex = 25;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(88, 165);
            quantityLabel.Margin = new Padding(5, 0, 5, 0);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(84, 25);
            quantityLabel.TabIndex = 24;
            quantityLabel.Text = "Quantity:";
            // 
            // txtname
            // 
            txtname.Location = new Point(288, 74);
            txtname.Margin = new Padding(4);
            txtname.Name = "txtname";
            txtname.Size = new Size(408, 31);
            txtname.TabIndex = 23;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(88, 74);
            name.Margin = new Padding(5, 0, 5, 0);
            name.Name = "name";
            name.Size = new Size(111, 25);
            name.TabIndex = 22;
            name.Text = "Order name:";
            // 
            // addOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addorderBtn);
            Controls.Add(txtprice);
            Controls.Add(priceLabel);
            Controls.Add(txtquantity);
            Controls.Add(quantityLabel);
            Controls.Add(txtname);
            Controls.Add(name);
            Name = "addOrder";
            Text = "addOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addorderBtn;
        private TextBox txtprice;
        private Label priceLabel;
        private TextBox txtquantity;
        private Label quantityLabel;
        private TextBox txtname;
        private Label name;
    }
}