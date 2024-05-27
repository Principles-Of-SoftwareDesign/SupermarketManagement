﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using SupermarketManagement.Config;

namespace SupermarketManagement
{
    public partial class Category : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        //int i = 0;

        dbConnection dbconn = new dbConnection();

        public Category()
        {
            InitializeComponent();
            conn = new MySqlConnection(dbconn.connect());
        }

        private void Category_Load(object sender, EventArgs e)
        {
            LoadRecord();
        }

        private void LoadRecord()
        {
            dataGridView1.Rows.Clear();
            conn.Open();
            cmd = new MySqlCommand("SELECT * FROM `category`", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["category_id"].ToString(), reader["name"].ToString());

                //dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, reader["name"].ToString());

            }
            reader.Close();
            conn.Close();
        }

        public void clear()
        {
            txt_id.Clear();
            txt_name.Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if ((txt_id.Text == string.Empty) || (txt_name.Text == string.Empty))
            {
                MessageBox.Show("Please fill both the ID and Name fields!", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                conn.Open();
                cmd = new MySqlCommand("INSERT INTO `category`(`category_id`, `name`) VALUES (@category_id, @name)", conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@category_id", txt_id.Text);
                cmd.Parameters.AddWithValue("@name", txt_name.Text);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Record saved successfully!", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record save failed!", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                conn.Close();
                LoadRecord();
                clear();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
