namespace SupermarketManagement.Views
{
    partial class ViewProduct
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
            panel1 = new Panel();
            label2 = new Label();
            viewProductLabel = new Label();
            addProductLabel = new Label();
            label1 = new Label();
            dataGridViewProduct = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(viewProductLabel);
            panel1.Controls.Add(addProductLabel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, -405);
            panel1.Margin = new Padding(8);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 2025);
            panel1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(240, 656);
            label2.Margin = new Padding(13, 0, 13, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 54);
            label2.TabIndex = 16;
            label2.Text = "Home";
            // 
            // viewProductLabel
            // 
            viewProductLabel.AutoSize = true;
            viewProductLabel.Font = new Font("Segoe UI", 12F);
            viewProductLabel.ForeColor = Color.White;
            viewProductLabel.Location = new Point(172, 1180);
            viewProductLabel.Margin = new Padding(13, 0, 13, 0);
            viewProductLabel.Name = "viewProductLabel";
            viewProductLabel.Size = new Size(274, 54);
            viewProductLabel.TabIndex = 15;
            viewProductLabel.Text = "View Products";
            // 
            // addProductLabel
            // 
            addProductLabel.AutoSize = true;
            addProductLabel.Font = new Font("Segoe UI", 12F);
            addProductLabel.ForeColor = Color.White;
            addProductLabel.Location = new Point(185, 910);
            addProductLabel.Margin = new Padding(13, 0, 13, 0);
            addProductLabel.Name = "addProductLabel";
            addProductLabel.Size = new Size(246, 54);
            addProductLabel.TabIndex = 14;
            addProductLabel.Text = "Add Product";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(240, 236);
            label1.Margin = new Padding(13, 0, 13, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 41);
            label1.TabIndex = 13;
            label1.Text = "Home";
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Location = new Point(617, 88);
            dataGridViewProduct.Margin = new Padding(6);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.RowHeadersWidth = 51;
            dataGridViewProduct.Size = new Size(1580, 1050);
            dataGridViewProduct.TabIndex = 19;
            // 
            // ViewProduct
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2247, 1214);
            Controls.Add(dataGridViewProduct);
            Controls.Add(panel1);
            Name = "ViewProduct";
            Text = "ViewProduct";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label viewProductLabel;
        private Label addProductLabel;
        private Label label1;
        private DataGridView dataGridViewProduct;
    }
}