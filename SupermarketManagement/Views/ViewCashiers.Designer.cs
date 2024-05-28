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
            dataGridView1.Location = new Point(0, 718);
            dataGridView1.Margin = new Padding(6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1941, 679);
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
            passwordTxt.Location = new Point(856, 458);
            passwordTxt.Margin = new Padding(6);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(690, 47);
            passwordTxt.TabIndex = 28;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI Semibold", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(305, 458);
            passwordLabel.Margin = new Padding(8, 0, 8, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(227, 62);
            passwordLabel.TabIndex = 27;
            passwordLabel.Text = "Password";
            // 
            // numberTxt
            // 
            numberTxt.Location = new Point(856, 339);
            numberTxt.Margin = new Padding(6);
            numberTxt.Name = "numberTxt";
            numberTxt.Size = new Size(690, 47);
            numberTxt.TabIndex = 26;
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new Font("Segoe UI Semibold", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numberLabel.Location = new Point(265, 339);
            numberLabel.Margin = new Padding(8, 0, 8, 0);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(349, 62);
            numberLabel.TabIndex = 25;
            numberLabel.Text = "Phone Number";
            numberLabel.Click += numberLabel_Click;
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(856, 213);
            emailTxt.Margin = new Padding(6);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(690, 47);
            emailTxt.TabIndex = 24;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Semibold", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(337, 213);
            emailLabel.Margin = new Padding(8, 0, 8, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(142, 62);
            emailLabel.TabIndex = 23;
            emailLabel.Text = "Email";
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(856, 84);
            nameTxt.Margin = new Padding(6);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(690, 47);
            nameTxt.TabIndex = 22;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(337, 84);
            nameLabel.Margin = new Padding(8, 0, 8, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(155, 62);
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
            panel1.Location = new Point(731, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(1941, 1403);
            panel1.TabIndex = 29;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(255, 192, 192);
            btn_delete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.Location = new Point(1186, 602);
            btn_delete.Margin = new Padding(8);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(212, 74);
            btn_delete.TabIndex = 31;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(255, 192, 192);
            btn_add.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.Location = new Point(519, 602);
            btn_add.Margin = new Padding(8);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(212, 74);
            btn_add.TabIndex = 29;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(255, 192, 192);
            btn_update.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.Location = new Point(869, 602);
            btn_update.Margin = new Padding(8);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(212, 74);
            btn_update.TabIndex = 30;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // ViewCashiers
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(2850, 1497);
            Controls.Add(panel1);
            Margin = new Padding(6);
            Name = "ViewCashiers";
            Text = "CashierView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
    }
}