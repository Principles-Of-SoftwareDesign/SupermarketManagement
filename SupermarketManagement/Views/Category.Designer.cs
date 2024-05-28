namespace SupermarketManagement
{
    partial class Category
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            txt_name = new TextBox();
            btn_add = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            txt_id = new TextBox();
            btn_update = new Button();
            btn_delete = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(207, 59);
            label1.Name = "label1";
            label1.Size = new Size(53, 42);
            label1.TabIndex = 0;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(672, 64);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 1;
            label2.Text = "Category Name:";
            label2.Click += label2_Click;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(806, 65);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(195, 27);
            txt_name.TabIndex = 3;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(255, 192, 192);
            btn_add.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.Location = new Point(321, 180);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(116, 37);
            btn_add.TabIndex = 4;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Window;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = Color.Black;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle13;
            dataGridView1.Location = new Point(0, 267);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1149, 347);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(279, 65);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(194, 27);
            txt_id.TabIndex = 2;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(255, 192, 192);
            btn_update.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.Location = new Point(519, 180);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 37);
            btn_update.TabIndex = 6;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(255, 192, 192);
            btn_delete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.Location = new Point(672, 180);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 37);
            btn_delete.TabIndex = 7;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(btn_update);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_add);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_name);
            panel1.Controls.Add(txt_id);
            panel1.Location = new Point(214, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(1152, 614);
            panel1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 89);
            label4.Name = "label4";
            label4.Size = new Size(155, 38);
            label4.TabIndex = 9;
            label4.Text = "Categories";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 171);
            label5.Name = "label5";
            label5.Size = new Size(132, 38);
            label5.TabIndex = 10;
            label5.Text = "Products";
            label5.Click += this.label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(33, 255);
            label6.Name = "label6";
            label6.Size = new Size(124, 38);
            label6.TabIndex = 11;
            label6.Text = "Cashiers";
            label6.Click += this.label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(33, 590);
            label7.Name = "label7";
            label7.Size = new Size(110, 38);
            label7.TabIndex = 12;
            label7.Text = "Logout";
            label7.Click += this.label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 327);
            label8.Name = "label8";
            label8.Size = new Size(167, 38);
            label8.TabIndex = 13;
            label8.Text = "Add Admin";
            label8.Click += this.label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 418);
            label9.Name = "label9";
            label9.Size = new Size(189, 38);
            label9.TabIndex = 14;
            label9.Text = "View Admins";
            label9.Click += label9_Click;
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1365, 672);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Name = "Category";
            Text = "Category";
            Load += Category_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_name;
        private Button btn_add;
        private DataGridView dataGridView1;
        private TextBox txt_id;
        private Button btn_update;
        private Button btn_delete;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label label8;
        private Label label9;
    }
}