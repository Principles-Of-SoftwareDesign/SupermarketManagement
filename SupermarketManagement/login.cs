using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupermarketManagement.Config;
using Org.BouncyCastle.Crypto.Generators;


namespace SupermarketManagement
{
    public partial class login : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        private Hashing hashing;
        dbConnection dbconn = new dbConnection();
        public login()
        {
            InitializeComponent();
            conn = new MySqlConnection(dbconn.connect());
            this.hashing = new Hashing();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("SELECT * FROM `users` WHERE email ='" + txtUserName.Text +"'", conn) ;
           // cmd = new MySqlCommand("SELECT * FROM `users` WHERE email ='"+ txtUserName.Text +"'  AND password='"+ txtpassword.Text+"'", conn);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string storedHashedPassword = reader["password"].ToString();
                    if (hashing.VerifyPassword(txtpassword.Text,storedHashedPassword))
                    {

                        int role = Convert.ToInt32(reader["role"]);
                        if (role == 1)
                             {
                            AddAdminView admin=new AddAdminView();
                            admin.Show();
                            this.Hide();
                        }
                        else
                        {
                         Category form = new Category();
                          form.Show();
                           this.Hide();
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show(" password you entered is incorrect,try again");
                    }
                }
            }
            //  if (reader.Read())
            // {
            // if (reader["role"] = 1)
            //{

            // }
            //}
            else
            {
                MessageBox.Show("The username and password you entered is incorrect,try again");
                txtUserName.Clear();
                txtpassword.Clear();
                txtUserName.Focus();
            }
            reader.Close();
            conn.Close();
              

            
        }
    }
}
