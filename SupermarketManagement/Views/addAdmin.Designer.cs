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
            AdminNavbar = new TabControl();
            home = new TabPage();
            ViewAdmins = new TabPage();
            adding = new TabPage();
            panel1 = new Panel();
            AdminNavbar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(980, 233);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(430, 61);
            nameTxt.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(456, 251);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(155, 62);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name";
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(980, 379);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(430, 61);
            emailTxt.TabIndex = 5;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Semibold", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(456, 379);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(142, 62);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email";
            // 
            // numberTxt
            // 
            numberTxt.Location = new Point(980, 517);
            numberTxt.Name = "numberTxt";
            numberTxt.Size = new Size(430, 61);
            numberTxt.TabIndex = 7;
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new Font("Segoe UI Semibold", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numberLabel.Location = new Point(371, 517);
            numberLabel.Margin = new Padding(4, 0, 4, 0);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(349, 62);
            numberLabel.TabIndex = 6;
            numberLabel.Text = "Phone Number";
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(980, 678);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(430, 61);
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
            passwordLabel.Size = new Size(227, 62);
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
            // AdminNavbar
            // 
            AdminNavbar.Controls.Add(home);
            AdminNavbar.Controls.Add(ViewAdmins);
            AdminNavbar.Controls.Add(adding);
            AdminNavbar.Dock = DockStyle.Top;
            AdminNavbar.Location = new Point(0, 0);
            AdminNavbar.Name = "AdminNavbar";
            AdminNavbar.SelectedIndex = 0;
            AdminNavbar.Size = new Size(2777, 47);
            AdminNavbar.TabIndex = 12;
            // 
            // home
            // 
            home.Location = new Point(10, 71);
            home.Name = "home";
            home.Padding = new Padding(3);
            home.Size = new Size(2757, 0);
            home.TabIndex = 1;
            home.Text = "Home";
            home.UseVisualStyleBackColor = true;
            // 
            // ViewAdmins
            // 
            ViewAdmins.Location = new Point(10, 58);
            ViewAdmins.Name = "ViewAdmins";
            ViewAdmins.Size = new Size(1633, 0);
            ViewAdmins.TabIndex = 2;
            ViewAdmins.Text = "View Admins";
            ViewAdmins.UseVisualStyleBackColor = true;
            // 
            // adding
            // 
            adding.Location = new Point(10, 58);
            adding.Name = "adding";
            adding.Size = new Size(1633, 0);
            adding.TabIndex = 3;
            adding.Text = "Add Admin";
            adding.UseVisualStyleBackColor = true;
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
            panel1.Location = new Point(709, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(1994, 1229);
            panel1.TabIndex = 13;
            // 
            // AddAdminView
            // 
            AutoScaleDimensions = new SizeF(22F, 54F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(2777, 1510);
            Controls.Add(panel1);
            Controls.Add(AdminNavbar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AddAdminView";
            Text = "Add Admin";
            AdminNavbar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private TabControl AdminNavbar;
        private TabPage home;
        private TabPage ViewAdmins;
        private TabPage adding;
        private Panel panel1;
    }
}
