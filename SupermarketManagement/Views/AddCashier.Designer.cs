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
            AdminNavbar.Margin = new Padding(4, 4, 4, 4);
            AdminNavbar.Name = "AdminNavbar";
            AdminNavbar.SelectedIndex = 0;
            AdminNavbar.Size = new Size(1644, 59);
            AdminNavbar.TabIndex = 22;
            // 
            // home
            // 
            home.Location = new Point(4, 34);
            home.Margin = new Padding(4, 4, 4, 4);
            home.Name = "home";
            home.Padding = new Padding(4, 4, 4, 4);
            home.Size = new Size(1636, 21);
            home.TabIndex = 1;
            home.Text = "Home";
            home.UseVisualStyleBackColor = true;
            // 
            // ViewAdmins
            // 
            ViewAdmins.Location = new Point(4, 34);
            ViewAdmins.Margin = new Padding(4, 4, 4, 4);
            ViewAdmins.Name = "ViewAdmins";
            ViewAdmins.Size = new Size(1636, 21);
            ViewAdmins.TabIndex = 2;
            ViewAdmins.Text = "View Admins";
            ViewAdmins.UseVisualStyleBackColor = true;
            // 
            // adding
            // 
            adding.Location = new Point(4, 34);
            adding.Margin = new Padding(4, 4, 4, 4);
            adding.Name = "adding";
            adding.Size = new Size(1636, 21);
            adding.TabIndex = 3;
            adding.Text = "Add Admin";
            adding.UseVisualStyleBackColor = true;
            // 
            // addAdminBtn
            // 
            addAdminBtn.BackColor = SystemColors.HotTrack;
            addAdminBtn.ForeColor = Color.White;
            addAdminBtn.Location = new Point(655, 623);
            addAdminBtn.Margin = new Padding(4, 4, 4, 4);
            addAdminBtn.Name = "addAdminBtn";
            addAdminBtn.Size = new Size(291, 60);
            addAdminBtn.TabIndex = 21;
            addAdminBtn.Text = "Add New Cashier";
            addAdminBtn.UseVisualStyleBackColor = false;
            addAdminBtn.Click += addAdminBtn_Click;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(672, 524);
            passwordTxt.Margin = new Padding(4, 4, 4, 4);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(408, 31);
            passwordTxt.TabIndex = 20;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(455, 524);
            passwordLabel.Margin = new Padding(5, 0, 5, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(87, 25);
            passwordLabel.TabIndex = 19;
            passwordLabel.Text = "Password";
            // 
            // numberTxt
            // 
            numberTxt.Location = new Point(672, 411);
            numberTxt.Margin = new Padding(4, 4, 4, 4);
            numberTxt.Name = "numberTxt";
            numberTxt.Size = new Size(408, 31);
            numberTxt.TabIndex = 18;
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new Point(455, 411);
            numberLabel.Margin = new Padding(5, 0, 5, 0);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(132, 25);
            numberLabel.TabIndex = 17;
            numberLabel.Text = "Phone Number";
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(672, 318);
            emailTxt.Margin = new Padding(4, 4, 4, 4);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(408, 31);
            emailTxt.TabIndex = 16;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(455, 318);
            emailLabel.Margin = new Padding(5, 0, 5, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(54, 25);
            emailLabel.TabIndex = 15;
            emailLabel.Text = "Email";
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(672, 220);
            nameTxt.Margin = new Padding(4, 4, 4, 4);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(408, 31);
            nameTxt.TabIndex = 14;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(455, 220);
            nameLabel.Margin = new Padding(5, 0, 5, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(59, 25);
            nameLabel.TabIndex = 13;
            nameLabel.Text = "Name";
            // 
            // AddCashier
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1644, 724);
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
            Margin = new Padding(4, 4, 4, 4);
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