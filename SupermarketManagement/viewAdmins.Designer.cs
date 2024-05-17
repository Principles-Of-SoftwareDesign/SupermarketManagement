namespace SupermarketManagement
{
    partial class ViewAdmins
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
            idColumn = new DataGridViewTextBoxColumn();
            nameColumn = new DataGridViewTextBoxColumn();
            emailColumn = new DataGridViewTextBoxColumn();
            numberColumn = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            viewAdminsLabel = new Label();
            addAdminLabel = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idColumn, nameColumn, emailColumn, numberColumn });
            dataGridView1.Location = new Point(375, 25);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(918, 522);
            dataGridView1.TabIndex = 13;
            // 
            // idColumn
            // 
            idColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idColumn.HeaderText = "#ID";
            idColumn.MinimumWidth = 6;
            idColumn.Name = "idColumn";
            idColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameColumn.HeaderText = "Name";
            nameColumn.MinimumWidth = 6;
            nameColumn.Name = "nameColumn";
            nameColumn.ReadOnly = true;
            // 
            // emailColumn
            // 
            emailColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            emailColumn.HeaderText = "Email";
            emailColumn.MinimumWidth = 6;
            emailColumn.Name = "emailColumn";
            emailColumn.ReadOnly = true;
            // 
            // numberColumn
            // 
            numberColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            numberColumn.HeaderText = "PhoneNumber";
            numberColumn.MinimumWidth = 6;
            numberColumn.Name = "numberColumn";
            numberColumn.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(viewAdminsLabel);
            panel1.Controls.Add(addAdminLabel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, -45);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 988);
            panel1.TabIndex = 14;
            // 
            // viewAdminsLabel
            // 
            viewAdminsLabel.AutoSize = true;
            viewAdminsLabel.ForeColor = Color.White;
            viewAdminsLabel.Location = new Point(87, 424);
            viewAdminsLabel.Margin = new Padding(6, 0, 6, 0);
            viewAdminsLabel.Name = "viewAdminsLabel";
            viewAdminsLabel.Size = new Size(124, 28);
            viewAdminsLabel.TabIndex = 15;
            viewAdminsLabel.Text = "View Admins";
            // 
            // addAdminLabel
            // 
            addAdminLabel.AutoSize = true;
            addAdminLabel.ForeColor = Color.White;
            addAdminLabel.Location = new Point(87, 276);
            addAdminLabel.Margin = new Padding(6, 0, 6, 0);
            addAdminLabel.Name = "addAdminLabel";
            addAdminLabel.Size = new Size(112, 28);
            addAdminLabel.TabIndex = 14;
            addAdminLabel.Text = "Add Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(113, 115);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 13;
            label1.Text = "Home";
            // 
            // ViewAdmins
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 590);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "ViewAdmins";
            Text = "viewAdmins";
            Load += ViewAdmins_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn emailColumn;
        private DataGridViewTextBoxColumn numberColumn;
        private Panel panel1;
        private Label viewAdminsLabel;
        private Label addAdminLabel;
        private Label label1;
    }
}