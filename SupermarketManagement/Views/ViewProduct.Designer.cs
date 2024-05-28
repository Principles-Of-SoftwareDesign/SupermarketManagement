namespace SupermarketManagement
{
    partial class ViewProduct
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_quantity;

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
            dataGridView1 = new DataGridView();
            txt_id = new TextBox();
            txt_name = new TextBox();
            txt_category = new TextBox();
            txt_price = new TextBox();
            txt_quantity = new TextBox();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_search = new Button();
            txt_search = new TextBox();
            lbl_id = new Label();
            lbl_name = new Label();
            lbl_category = new Label();
            lbl_price = new Label();
            lbl_quantity = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView1.Location = new Point(850, 63);
            dataGridView1.Margin = new Padding(8, 9, 8, 9);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.Size = new Size(1360, 1262);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(340, 63);
            txt_id.Margin = new Padding(8, 9, 8, 9);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(418, 47);
            txt_id.TabIndex = 1;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(340, 189);
            txt_name.Margin = new Padding(8, 9, 8, 9);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(418, 47);
            txt_name.TabIndex = 2;
            // 
            // txt_category
            // 
            txt_category.Location = new Point(340, 315);
            txt_category.Margin = new Padding(8, 9, 8, 9);
            txt_category.Name = "txt_category";
            txt_category.Size = new Size(418, 47);
            txt_category.TabIndex = 3;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(340, 442);
            txt_price.Margin = new Padding(8, 9, 8, 9);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(418, 47);
            txt_price.TabIndex = 4;
            // 
            // txt_quantity
            // 
            txt_quantity.Location = new Point(340, 568);
            txt_quantity.Margin = new Padding(8, 9, 8, 9);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(418, 47);
            txt_quantity.TabIndex = 5;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(85, 694);
            btn_add.Margin = new Padding(8, 9, 8, 9);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(212, 73);
            btn_add.TabIndex = 6;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(340, 694);
            btn_update.Margin = new Padding(8, 9, 8, 9);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(212, 73);
            btn_update.TabIndex = 7;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(595, 694);
            btn_delete.Margin = new Padding(8, 9, 8, 9);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(212, 73);
            btn_delete.TabIndex = 8;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(567, 820);
            btn_search.Margin = new Padding(8, 9, 8, 9);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(212, 73);
            btn_search.TabIndex = 14;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(85, 820);
            txt_search.Margin = new Padding(8, 9, 8, 9);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(418, 47);
            txt_search.TabIndex = 15;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(85, 63);
            lbl_id.Margin = new Padding(8, 0, 8, 0);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(54, 41);
            lbl_id.TabIndex = 9;
            lbl_id.Text = "ID:";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(85, 189);
            lbl_name.Margin = new Padding(8, 0, 8, 0);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(104, 41);
            lbl_name.TabIndex = 10;
            lbl_name.Text = "Name:";
            // 
            // lbl_category
            // 
            lbl_category.AutoSize = true;
            lbl_category.Location = new Point(85, 315);
            lbl_category.Margin = new Padding(8, 0, 8, 0);
            lbl_category.Name = "lbl_category";
            lbl_category.Size = new Size(146, 41);
            lbl_category.TabIndex = 11;
            lbl_category.Text = "Category:";
            // 
            // lbl_price
            // 
            lbl_price.AutoSize = true;
            lbl_price.Location = new Point(85, 442);
            lbl_price.Margin = new Padding(8, 0, 8, 0);
            lbl_price.Name = "lbl_price";
            lbl_price.Size = new Size(89, 41);
            lbl_price.TabIndex = 12;
            lbl_price.Text = "Price:";
            // 
            // lbl_quantity
            // 
            lbl_quantity.AutoSize = true;
            lbl_quantity.Location = new Point(85, 568);
            lbl_quantity.Margin = new Padding(8, 0, 8, 0);
            lbl_quantity.Name = "lbl_quantity";
            lbl_quantity.Size = new Size(139, 41);
            lbl_quantity.TabIndex = 13;
            lbl_quantity.Text = "Quantity:";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 12;
            dataGridViewTextBoxColumn1.Name = "ID";
            dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 12;
            dataGridViewTextBoxColumn2.Name = "Name";
            dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.MinimumWidth = 12;
            dataGridViewTextBoxColumn3.Name = "Category";
            dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.MinimumWidth = 12;
            dataGridViewTextBoxColumn4.Name = "Price";
            dataGridViewTextBoxColumn4.Width = 250;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.MinimumWidth = 12;
            dataGridViewTextBoxColumn5.Name = "Quantity";
            dataGridViewTextBoxColumn5.Width = 250;
            // 
            // ViewProduct
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2267, 1419);
            Controls.Add(txt_search);
            Controls.Add(btn_search);
            Controls.Add(lbl_quantity);
            Controls.Add(lbl_price);
            Controls.Add(lbl_category);
            Controls.Add(lbl_name);
            Controls.Add(lbl_id);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(txt_quantity);
            Controls.Add(txt_price);
            Controls.Add(txt_category);
            Controls.Add(txt_name);
            Controls.Add(txt_id);
            Controls.Add(dataGridView1);
            Margin = new Padding(8, 9, 8, 9);
            Name = "ViewProduct";
            Text = "ViewProduct";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
