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
            panel1 = new Panel();
            viewAdminsLabel = new Label();
            addAdminLabel = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(369, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(942, 505);
            dataGridView1.TabIndex = 15;
            // 
            // ViewAdmins
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 590);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "ViewAdmins";
            Text = "viewAdmins";
            Load += ViewAdmins_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label viewAdminsLabel;
        private Label addAdminLabel;
        private Label label1;
        private DataGridView dataGridView1;
    }
}