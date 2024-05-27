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
            panel1 = new Panel();
            label2 = new Label();
            viewAdminsLabel = new Label();
            addCashierLabel = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(355, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(942, 505);
            dataGridView1.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(viewAdminsLabel);
            panel1.Controls.Add(addCashierLabel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -187);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 988);
            panel1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(113, 320);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 16;
            label2.Text = "Home";
            label2.Click += label2_Click;
            // 
            // viewAdminsLabel
            // 
            viewAdminsLabel.AutoSize = true;
            viewAdminsLabel.Font = new Font("Segoe UI", 12F);
            viewAdminsLabel.ForeColor = Color.White;
            viewAdminsLabel.Location = new Point(87, 562);
            viewAdminsLabel.Margin = new Padding(6, 0, 6, 0);
            viewAdminsLabel.Name = "viewAdminsLabel";
            viewAdminsLabel.Size = new Size(129, 28);
            viewAdminsLabel.TabIndex = 15;
            viewAdminsLabel.Text = "View Cashiers";
           
            // 
            // addCashierLabel
            // 
            addCashierLabel.AutoSize = true;
            addCashierLabel.Font = new Font("Segoe UI", 12F);
            addCashierLabel.ForeColor = Color.White;
            addCashierLabel.Location = new Point(87, 427);
            addCashierLabel.Margin = new Padding(6, 0, 6, 0);
            addCashierLabel.Name = "addCashierLabel";
            addCashierLabel.Size = new Size(117, 28);
            addCashierLabel.TabIndex = 14;
            addCashierLabel.Text = "Add Cashier";
           
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
            // ViewCashiers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 615);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "ViewCashiers";
            Text = "CashierView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label viewAdminsLabel;
        private Label addCashierLabel;
        private Label label1;
        private Label label2;
    }
}