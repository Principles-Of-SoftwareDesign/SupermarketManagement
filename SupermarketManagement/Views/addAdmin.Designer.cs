namespace SupermarketManagement
{
    partial class AddAdminView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameTxt = new TextBox();
            nameLabel = new Label();
            emailTxt = new TextBox();
            emailLabel = new Label();
            numberTxt = new TextBox();
            numberLabel = new Label();
            passwordTxt = new TextBox();
            passwordLabel = new Label();
            addAdminBtn = new Button();
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(980, 233);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(430, 34);
            nameTxt.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(456, 251);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(79, 32);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name";
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(980, 379);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(430, 34);
            emailTxt.TabIndex = 5;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Semibold", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(456, 379);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(72, 32);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email";
            // 
            // numberTxt
            // 
            numberTxt.Location = new Point(980, 517);
            numberTxt.Name = "numberTxt";
            numberTxt.Size = new Size(430, 34);
            numberTxt.TabIndex = 7;
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new Font("Segoe UI Semibold", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numberLabel.Location = new Point(371, 517);
            numberLabel.Margin = new Padding(4, 0, 4, 0);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(179, 32);
            numberLabel.TabIndex = 6;
            numberLabel.Text = "Phone Number";
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(980, 678);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(430, 34);
            passwordTxt.TabIndex = 9;
            passwordTxt.UseSystemPasswordChar = true;
            passwordTxt.TextChanged += passwordTxt_TextChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI Semibold", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(422, 678);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(115, 32);
            passwordLabel.TabIndex = 8;
            passwordLabel.Text = "Password";
            // 
            // addAdminBtn
            // 
            addAdminBtn.BackColor = Color.FromArgb(255, 192, 192);
            addAdminBtn.Font = new Font("Segoe UI Semibold", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addAdminBtn.ForeColor = Color.Black;
            addAdminBtn.Location = new Point(848, 946);
            addAdminBtn.Name = "addAdminBtn";
            addAdminBtn.Size = new Size(448, 86);
            addAdminBtn.TabIndex = 10;
            addAdminBtn.Text = "Add New Admin";
            addAdminBtn.UseVisualStyleBackColor = false;
            addAdminBtn.Click += addAdminBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(addAdminBtn);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(passwordTxt);
            panel1.Controls.Add(numberLabel);
            panel1.Controls.Add(numberTxt);
            panel1.Controls.Add(emailLabel);
            panel1.Controls.Add(emailTxt);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(nameTxt);
            panel1.Location = new Point(381, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(1994, 1229);
            panel1.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(74, 489);
            label9.Name = "label9";
            label9.Size = new Size(189, 38);
            label9.TabIndex = 20;
            label9.Text = "View Admins";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(81, 398);
            label8.Name = "label8";
            label8.Size = new Size(167, 38);
            label8.TabIndex = 19;
            label8.Text = "Add Admin";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(92, 661);
            label7.Name = "label7";
            label7.Size = new Size(110, 38);
            label7.TabIndex = 18;
            label7.Text = "Logout";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(92, 326);
            label6.Name = "label6";
            label6.Size = new Size(124, 38);
            label6.TabIndex = 17;
            label6.Text = "Cashiers";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(92, 242);
            label5.Name = "label5";
            label5.Size = new Size(132, 38);
            label5.TabIndex = 16;
            label5.Text = "Products";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(81, 160);
            label4.Name = "label4";
            label4.Size = new Size(155, 38);
            label4.TabIndex = 15;
            label4.Text = "Categories";
            label4.Click += label4_Click;
            // 
            // AddAdminView
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1924, 1055);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AddAdminView";
            Text = "Add Admin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox nameTxt;
        private Label nameLabel;
        private TextBox emailTxt;
        private Label emailLabel;
        private TextBox numberTxt;
        private Label numberLabel;
        private TextBox passwordTxt;
        private Label passwordLabel;
        private Button addAdminBtn;
        private Panel panel1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}
