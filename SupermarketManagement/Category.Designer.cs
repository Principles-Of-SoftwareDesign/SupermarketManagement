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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(21, 77);
            label1.Name = "label1";
            label1.Size = new Size(136, 27);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Location = new Point(21, 154);
            label2.Name = "label2";
            label2.Size = new Size(136, 32);
            label2.TabIndex = 1;
            label2.Text = "Category Name:";
            label2.Click += label2_Click;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(163, 151);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(177, 27);
            txt_name.TabIndex = 3;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(12, 269);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(116, 37);
            btn_add.TabIndex = 4;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(395, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(338, 401);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 53;
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
            txt_id.Location = new Point(163, 77);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(177, 27);
            txt_id.TabIndex = 2;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(146, 269);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 37);
            btn_update.TabIndex = 6;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(257, 269);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 37);
            btn_delete.TabIndex = 7;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 482);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(dataGridView1);
            Controls.Add(btn_add);
            Controls.Add(txt_name);
            Controls.Add(txt_id);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Category";
            Text = "Category";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_name;
        private Button btn_add;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private TextBox txt_id;
        private Button btn_update;
        private Button btn_delete;
    }
}