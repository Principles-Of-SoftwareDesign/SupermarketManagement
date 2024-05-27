namespace SupermarketManagement.Views
{
    partial class AddCashier
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
            AdminNavbar = new TabControl();
            home = new TabPage();
            ViewAdmins = new TabPage();
            adding = new TabPage();
            addAdminBtn = new Button();
            passwordTxt = new TextBox();
            passwordLabel = new Label();
            numberTxt = new TextBox();
            numberLabel = new Label();
            emailTxt = new TextBox();
            emailLabel = new Label();
            nameTxt = new TextBox();
            nameLabel = new Label();
            AdminNavbar.SuspendLayout();
            SuspendLayout();
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
            AdminNavbar.Size = new Size(1315, 47);
            AdminNavbar.TabIndex = 22;
            // 
            // home
            // 
            home.Location = new Point(4, 29);
            home.Name = "home";
            home.Padding = new Padding(3);
            home.Size = new Size(1307, 14);
            home.TabIndex = 1;
            home.Text = "Home";
            home.UseVisualStyleBackColor = true;
            // 
            // ViewAdmins
            // 
            ViewAdmins.Location = new Point(4, 29);
            ViewAdmins.Name = "ViewAdmins";
            ViewAdmins.Size = new Size(1307, 14);
            ViewAdmins.TabIndex = 2;
            ViewAdmins.Text = "View Admins";
            ViewAdmins.UseVisualStyleBackColor = true;
            // 
            // adding
            // 
            adding.Location = new Point(4, 29);
            adding.Name = "adding";
            adding.Size = new Size(1307, 14);
            adding.TabIndex = 3;
            adding.Text = "Add Admin";
            adding.UseVisualStyleBackColor = true;
            // 
            // addAdminBtn
            // 
            addAdminBtn.BackColor = SystemColors.HotTrack;
            addAdminBtn.ForeColor = Color.White;
            addAdminBtn.Location = new Point(524, 498);
            addAdminBtn.Name = "addAdminBtn";
            addAdminBtn.Size = new Size(233, 48);
            addAdminBtn.TabIndex = 21;
            addAdminBtn.Text = "Add New Cashier";
            addAdminBtn.UseVisualStyleBackColor = false;
            addAdminBtn.Click += addAdminBtn_Click;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(538, 419);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(327, 27);
            passwordTxt.TabIndex = 20;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(364, 419);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 19;
            passwordLabel.Text = "Password";
            // 
            // numberTxt
            // 
            numberTxt.Location = new Point(538, 329);
            numberTxt.Name = "numberTxt";
            numberTxt.Size = new Size(327, 27);
            numberTxt.TabIndex = 18;
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new Point(364, 329);
            numberLabel.Margin = new Padding(4, 0, 4, 0);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(108, 20);
            numberLabel.TabIndex = 17;
            numberLabel.Text = "Phone Number";
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(538, 254);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(327, 27);
            emailTxt.TabIndex = 16;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(364, 254);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 20);
            emailLabel.TabIndex = 15;
            emailLabel.Text = "Email";
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(538, 176);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(327, 27);
            nameTxt.TabIndex = 14;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(364, 176);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(49, 20);
            nameLabel.TabIndex = 13;
            nameLabel.Text = "Name";
            // 
            // AddCashier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 579);
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
           
            Text = "AddCashier";
            AdminNavbar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl AdminNavbar;
        private TabPage home;
        private TabPage ViewAdmins;
        private TabPage adding;
        private Button addAdminBtn;
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