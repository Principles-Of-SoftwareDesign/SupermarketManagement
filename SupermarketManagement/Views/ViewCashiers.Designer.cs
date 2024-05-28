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
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            addAdminBtn = new Button();
            label1 = new Label();
            passwordTxt = new TextBox();
            passwordLabel = new Label();
            numberTxt = new TextBox();
            numberLabel = new Label();
            emailTxt = new TextBox();
            emailLabel = new Label();
            nameTxt = new TextBox();
            nameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(820, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(499, 601);
            dataGridView1.TabIndex = 16;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(addAdminBtn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -187);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 988);
            panel1.TabIndex = 17;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.ForeColor = Color.White;
            button3.Location = new Point(46, 294);
            button3.Name = "button3";
            button3.Size = new Size(172, 45);
            button3.TabIndex = 25;
            button3.Text = "Home";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.ForeColor = Color.White;
            button2.Location = new Point(46, 390);
            button2.Name = "button2";
            button2.Size = new Size(172, 48);
            button2.TabIndex = 24;
            button2.Text = "Add Cashier";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.ForeColor = Color.White;
            button1.Location = new Point(46, 484);
            button1.Name = "button1";
            button1.Size = new Size(172, 44);
            button1.TabIndex = 23;
            button1.Text = "Delete Cashier";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // addAdminBtn
            // 
            addAdminBtn.BackColor = SystemColors.HotTrack;
            addAdminBtn.ForeColor = Color.White;
            addAdminBtn.Location = new Point(46, 578);
            addAdminBtn.Name = "addAdminBtn";
            addAdminBtn.Size = new Size(172, 48);
            addAdminBtn.TabIndex = 22;
            addAdminBtn.Text = "Update Cashiers";
            addAdminBtn.UseVisualStyleBackColor = false;
            addAdminBtn.Click += addAdminBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(113, 115);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 13;
            label1.Text = "Home";
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(444, 306);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(327, 27);
            passwordTxt.TabIndex = 28;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(270, 306);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 27;
            passwordLabel.Text = "Password";
            // 
            // numberTxt
            // 
            numberTxt.Location = new Point(444, 216);
            numberTxt.Name = "numberTxt";
            numberTxt.Size = new Size(327, 27);
            numberTxt.TabIndex = 26;
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new Point(270, 216);
            numberLabel.Margin = new Padding(4, 0, 4, 0);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(108, 20);
            numberLabel.TabIndex = 25;
            numberLabel.Text = "Phone Number";
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(444, 141);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(327, 27);
            emailTxt.TabIndex = 24;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(270, 141);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 20);
            emailLabel.TabIndex = 23;
            emailLabel.Text = "Email";
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(444, 63);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(327, 27);
            nameTxt.TabIndex = 22;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(270, 63);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(49, 20);
            nameLabel.TabIndex = 21;
            nameLabel.Text = "Name";
            // 
            // ViewCashiers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 615);
            Controls.Add(passwordTxt);
            Controls.Add(passwordLabel);
            Controls.Add(numberTxt);
            Controls.Add(numberLabel);
            Controls.Add(emailTxt);
            Controls.Add(emailLabel);
            Controls.Add(nameTxt);
            Controls.Add(nameLabel);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
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
        private Panel panel1;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button addAdminBtn;
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
    }
}