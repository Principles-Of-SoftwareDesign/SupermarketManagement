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
            ID = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
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
            panel1 = new Panel();
            ID = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            label9 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView1.Location = new Point(0, 476);
            dataGridView1.Margin = new Padding(8, 8, 8, 8);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.Size = new Size(2476, 660);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ID.HeaderText = "dataGridViewTextBoxColumn1";
            ID.MinimumWidth = 12;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 472;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn2.HeaderText = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.MinimumWidth = 12;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 472;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn3.HeaderText = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.MinimumWidth = 12;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 472;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn4.HeaderText = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.MinimumWidth = 12;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 472;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn5.HeaderText = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.MinimumWidth = 12;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 472;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(253, 74);
            txt_id.Margin = new Padding(8, 8, 8, 8);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(418, 47);
            txt_id.TabIndex = 1;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(253, 213);
            txt_name.Margin = new Padding(8, 8, 8, 8);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(418, 47);
            txt_name.TabIndex = 2;
            // 
            // txt_category
            // 
            txt_category.Location = new Point(1961, 74);
            txt_category.Margin = new Padding(8, 8, 8, 8);
            txt_category.Name = "txt_category";
            txt_category.Size = new Size(418, 47);
            txt_category.TabIndex = 3;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(1128, 74);
            txt_price.Margin = new Padding(8, 8, 8, 8);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(418, 47);
            txt_price.TabIndex = 4;
            // 
            // txt_quantity
            // 
            txt_quantity.Location = new Point(1128, 203);
            txt_quantity.Margin = new Padding(8, 8, 8, 8);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(418, 47);
            txt_quantity.TabIndex = 5;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(255, 192, 192);
            btn_add.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.Location = new Point(778, 385);
            btn_add.Margin = new Padding(8, 8, 8, 8);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(212, 74);
            btn_add.TabIndex = 6;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(255, 192, 192);
            btn_update.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.Location = new Point(1128, 385);
            btn_update.Margin = new Padding(8, 8, 8, 8);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(212, 74);
            btn_update.TabIndex = 7;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(255, 192, 192);
            btn_delete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.Location = new Point(1445, 385);
            btn_delete.Margin = new Padding(8, 8, 8, 8);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(212, 74);
            btn_delete.TabIndex = 8;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.FromArgb(255, 192, 192);
            btn_search.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search.Location = new Point(1687, 215);
            btn_search.Margin = new Padding(8, 8, 8, 8);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(212, 74);
            btn_search.TabIndex = 14;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(1942, 228);
            txt_search.Margin = new Padding(8, 8, 8, 8);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(418, 47);
            txt_search.TabIndex = 15;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("Segoe UI Semibold", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_id.Location = new Point(87, 68);
            lbl_id.Margin = new Padding(8, 0, 8, 0);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(86, 62);
            lbl_id.TabIndex = 9;
            lbl_id.Text = "ID:";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI Semibold", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_name.Location = new Point(55, 203);
            lbl_name.Margin = new Padding(8, 0, 8, 0);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(166, 62);
            lbl_name.TabIndex = 10;
            lbl_name.Text = "Name:";
            // 
            // lbl_category
            // 
            lbl_category.AutoSize = true;
            lbl_category.Font = new Font("Segoe UI Semibold", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_category.Location = new Point(1645, 68);
            lbl_category.Margin = new Padding(8, 0, 8, 0);
            lbl_category.Name = "lbl_category";
            lbl_category.Size = new Size(233, 62);
            lbl_category.TabIndex = 11;
            lbl_category.Text = "Category:";
            // 
            // lbl_price
            // 
            lbl_price.AutoSize = true;
            lbl_price.Font = new Font("Segoe UI Semibold", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_price.Location = new Point(922, 74);
            lbl_price.Margin = new Padding(8, 0, 8, 0);
            lbl_price.Name = "lbl_price";
            lbl_price.Size = new Size(141, 62);
            lbl_price.TabIndex = 12;
            lbl_price.Text = "Price:";
            // 
            // lbl_quantity
            // 
            lbl_quantity.AutoSize = true;
            lbl_quantity.Font = new Font("Segoe UI Semibold", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_quantity.Location = new Point(854, 213);
            lbl_quantity.Margin = new Padding(8, 0, 8, 0);
            lbl_quantity.Name = "lbl_quantity";
            lbl_quantity.Size = new Size(223, 62);
            lbl_quantity.TabIndex = 13;
            lbl_quantity.Text = "Quantity:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lbl_id);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(txt_search);
            panel1.Controls.Add(txt_id);
            panel1.Controls.Add(btn_search);
            panel1.Controls.Add(lbl_price);
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(lbl_quantity);
            panel1.Controls.Add(btn_add);
            panel1.Controls.Add(btn_update);
            panel1.Controls.Add(txt_price);
            panel1.Controls.Add(lbl_name);
            panel1.Controls.Add(txt_quantity);
            panel1.Controls.Add(lbl_category);
            panel1.Controls.Add(txt_category);
            panel1.Controls.Add(txt_name);
            panel1.Location = new Point(444, 57);
            panel1.Margin = new Padding(6, 6, 6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(2476, 1136);
            panel1.TabIndex = 16;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ID.HeaderText = "dataGridViewTextBoxColumn1";
            ID.MinimumWidth = 12;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 239;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn2.HeaderText = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.MinimumWidth = 12;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 239;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn3.HeaderText = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.MinimumWidth = 12;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 239;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn4.HeaderText = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.MinimumWidth = 12;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 239;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn5.HeaderText = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.MinimumWidth = 12;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 239;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 31);
            label3.Name = "label3";
            label3.Size = new Size(159, 38);
            label3.TabIndex = 17;
            label3.Text = "Dashboard";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 93);
            label4.Name = "label4";
            label4.Size = new Size(307, 74);
            label4.TabIndex = 18;
            label4.Text = "Categories";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 175);
            label5.Name = "label5";
            label5.Size = new Size(260, 74);
            label5.TabIndex = 19;
            label5.Text = "Products";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(29, 259);
            label6.Name = "label6";
            label6.Size = new Size(245, 74);
            label6.TabIndex = 20;
            label6.Text = "Cashiers";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(43, 530);
            label7.Name = "label7";
            label7.Size = new Size(216, 74);
            label7.TabIndex = 21;
            label7.Text = "Logout";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(18, 331);
            label8.Name = "label8";
            label8.Size = new Size(326, 74);
            label8.TabIndex = 22;
            label8.Text = "Add Admin";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(11, 422);
            label9.Name = "label9";
            label9.Size = new Size(189, 38);
            label9.TabIndex = 23;
            label9.Text = "View Admins";
            // 
            // ViewProduct
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(2945, 1600);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Margin = new Padding(8, 8, 8, 8);
            Name = "ViewProduct";
            Text = "ViewProduct";
            Load += ViewProduct_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panel1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Label label9;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
