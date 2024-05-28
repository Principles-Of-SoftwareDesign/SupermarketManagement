namespace SupermarketManagement.Views
{
    partial class ViewCashiers
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            passwordTxt = new TextBox();
            passwordLabel = new Label();
            numberTxt = new TextBox();
            numberLabel = new Label();
            emailTxt = new TextBox();
            emailLabel = new Label();
            nameTxt = new TextBox();
            nameLabel = new Label();
            panel1 = new Panel();
            btn_delete = new Button();
            btn_add = new Button();
            btn_update = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(0, 350);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(913, 331);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Email";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "PhoneNumber";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Password";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(403, 223);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(327, 27);
            passwordTxt.TabIndex = 28;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI Semibold", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(144, 223);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(115, 32);
            passwordLabel.TabIndex = 27;
            passwordLabel.Text = "Password";
            // 
            // numberTxt
            // 
            numberTxt.Location = new Point(403, 165);
            numberTxt.Name = "numberTxt";
            numberTxt.Size = new Size(327, 27);
            numberTxt.TabIndex = 26;
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new Font("Segoe UI Semibold", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numberLabel.Location = new Point(125, 165);
            numberLabel.Margin = new Padding(4, 0, 4, 0);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(179, 32);
            numberLabel.TabIndex = 25;
            numberLabel.Text = "Phone Number";
            numberLabel.Click += numberLabel_Click;
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(403, 104);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(327, 27);
            emailTxt.TabIndex = 24;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Semibold", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(159, 104);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(72, 32);
            emailLabel.TabIndex = 23;
            emailLabel.Text = "Email";
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(403, 41);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(327, 27);
            nameTxt.TabIndex = 22;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(159, 41);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(79, 32);
            nameLabel.TabIndex = 21;
            nameLabel.Text = "Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(btn_add);
            panel1.Controls.Add(btn_update);
            panel1.Controls.Add(passwordTxt);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(numberTxt);
            panel1.Controls.Add(numberLabel);
            panel1.Controls.Add(emailTxt);
            panel1.Controls.Add(emailLabel);
            panel1.Controls.Add(nameTxt);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(344, 22);
            panel1.Margin = new Padding(1, 1, 1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(913, 684);
            panel1.TabIndex = 29;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(255, 192, 192);
            btn_delete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.Location = new Point(558, 294);
            btn_delete.Margin = new Padding(4, 4, 4, 4);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(100, 36);
            btn_delete.TabIndex = 31;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(255, 192, 192);
            btn_add.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.Location = new Point(244, 294);
            btn_add.Margin = new Padding(4, 4, 4, 4);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(100, 36);
            btn_add.TabIndex = 29;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(255, 192, 192);
            btn_update.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.Location = new Point(409, 294);
            btn_update.Margin = new Padding(4, 4, 4, 4);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(100, 36);
            btn_update.TabIndex = 30;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(87, 417);
            label9.Name = "label9";
            label9.Size = new Size(189, 38);
            label9.TabIndex = 35;
            label9.Text = "View Admins";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(94, 326);
            label8.Name = "label8";
            label8.Size = new Size(167, 38);
            label8.TabIndex = 34;
            label8.Text = "Add Admin";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(105, 589);
            label7.Name = "label7";
            label7.Size = new Size(110, 38);
            label7.TabIndex = 33;
            label7.Text = "Logout";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(105, 254);
            label6.Name = "label6";
            label6.Size = new Size(124, 38);
            label6.TabIndex = 32;
            label6.Text = "Cashiers";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(105, 170);
            label5.Name = "label5";
            label5.Size = new Size(132, 38);
            label5.TabIndex = 31;
            label5.Text = "Products";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(94, 88);
            label4.Name = "label4";
            label4.Size = new Size(155, 38);
            label4.TabIndex = 30;
            label4.Text = "Categories";
            label4.Click += label4_Click;
            // 
            // ViewCashiers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1284, 695);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Name = "ViewCashiers";
            Text = "CashierView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox passwordTxt;
        private Label passwordLabel;
        private TextBox numberTxt;
        private Label numberLabel;
        private TextBox emailTxt;
        private Label emailLabel;
        private TextBox nameTxt;
        private Label nameLabel;
        private Panel panel1;
        private Button btn_delete;
        private Button btn_add;
        private Button btn_update;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}