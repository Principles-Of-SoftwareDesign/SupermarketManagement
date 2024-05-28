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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // dataGridView1
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "Id" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Name", DataPropertyName = "Name" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Category", DataPropertyName = "Category" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Price", DataPropertyName = "Price" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Quantity", DataPropertyName = "Quantity" }
            });
            this.dataGridView1.Location = new System.Drawing.Point(300, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 400);
            this.dataGridView1.TabIndex = 0;

            // txt_id
            this.txt_id.Location = new System.Drawing.Point(120, 20);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(150, 20);
            this.txt_id.TabIndex = 1;

            // txt_name
            this.txt_name.Location = new System.Drawing.Point(120, 60);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(150, 20);
            this.txt_name.TabIndex = 2;

            // txt_category
            this.txt_category.Location = new System.Drawing.Point(120, 100);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(150, 20);
            this.txt_category.TabIndex = 3;

            // txt_price
            this.txt_price.Location = new System.Drawing.Point(120, 140);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(150, 20);
            this.txt_price.TabIndex = 4;

            // txt_quantity
            this.txt_quantity.Location = new System.Drawing.Point(120, 180);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(150, 20);
            this.txt_quantity.TabIndex = 5;

            // btn_add
            this.btn_add.Location = new System.Drawing.Point(30, 220);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;

            // btn_update
            this.btn_update.Location = new System.Drawing.Point(120, 220);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;

            // btn_delete
            this.btn_delete.Location = new System.Drawing.Point(210, 220);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;

            // lbl_id
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(30, 20);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 13);
            this.lbl_id.TabIndex = 9;
            this.lbl_id.Text = "ID:";

            // lbl_name
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(30, 60);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 10;
            this.lbl_name.Text = "Name:";

            // lbl_category
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(30, 100);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(52, 13);
            this.lbl_category.TabIndex = 11;
            this.lbl_category.Text = "Category:";

            // lbl_price
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(30, 140);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(34, 13);
            this.lbl_price.TabIndex = 12;
            this.lbl_price.Text = "Price:";

            // lbl_quantity
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(30, 180);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(49, 13);
            this.lbl_quantity.TabIndex = 13;
            this.lbl_quantity.Text = "Quantity:";

            // ViewProduct
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_category);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewProduct";
            this.Text = "ViewProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
