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
            AdminNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(687, 141);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(327, 61);
            nameTxt.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(364, 144);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(128, 54);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name";
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(687, 215);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(327, 61);
            emailTxt.TabIndex = 5;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(364, 222);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(117, 54);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email";
            // 
            // numberTxt
            // 
            numberTxt.Location = new Point(687, 297);
            numberTxt.Name = "numberTxt";
            numberTxt.Size = new Size(327, 61);
            numberTxt.TabIndex = 7;
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new Point(364, 297);
            numberLabel.Margin = new Padding(4, 0, 4, 0);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(292, 54);
            numberLabel.TabIndex = 6;
            numberLabel.Text = "Phone Number";
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(687, 384);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(327, 61);
            passwordTxt.TabIndex = 9;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(364, 387);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(188, 54);
            passwordLabel.TabIndex = 8;
            passwordLabel.Text = "Password";
            // 
            // addAdminBtn
            // 
            addAdminBtn.BackColor = SystemColors.HotTrack;
            addAdminBtn.ForeColor = Color.White;
            addAdminBtn.Location = new Point(519, 489);
            addAdminBtn.Name = "addAdminBtn";
            addAdminBtn.Size = new Size(316, 76);
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
            AdminNavbar.Size = new Size(1653, 47);
            AdminNavbar.TabIndex = 12;
            // 
            // home
            // 
            home.Location = new Point(10, 71);
            home.Name = "home";
            home.Padding = new Padding(3);
            home.Size = new Size(1633, 0);
            home.TabIndex = 1;
            home.Text = "Home";
            home.UseVisualStyleBackColor = true;
            // 
            // ViewAdmins
            // 
            ViewAdmins.Location = new Point(10, 58);
            ViewAdmins.Name = "ViewAdmins";
            ViewAdmins.Size = new Size(1260, 0);
            ViewAdmins.TabIndex = 2;
            ViewAdmins.Text = "View Admins";
            ViewAdmins.UseVisualStyleBackColor = true;
            // 
            // adding
            // 
            adding.Location = new Point(10, 58);
            adding.Name = "adding";
            adding.Size = new Size(1260, 0);
            adding.TabIndex = 3;
            adding.Text = "Add Admin";
            adding.UseVisualStyleBackColor = true;
            // 
            // AddAdminView
            // 
            AutoScaleDimensions = new SizeF(22F, 54F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1653, 950);
            Controls.Add(AdminNavbar);
            Controls.Add(addAdminBtn);
            Controls.Add(passwordTxt);
            Controls.Add(passwordLabel);
            Controls.Add(numberTxt);
            Controls.Add(numberLabel);
            Controls.Add(emailTxt);
            Controls.Add(emailLabel);
            Controls.Add(nameTxt);
            Controls.Add(nameLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Text = "Add Admin";
            AdminNavbar.ResumeLayout(false);
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
        private TabControl AdminNavbar;
        private TabPage home;
        private TabPage ViewAdmins;
        private TabPage adding;
    }
}
