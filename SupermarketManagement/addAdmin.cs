using MySql.Data.MySqlClient;

namespace SupermarketManagement
{
    public partial class addAdmin : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        dbConnection dbConnection = new dbConnection();
        Hashing hashing = new Hashing();

        public addAdmin()
        {
            InitializeComponent();
            conn = new MySqlConnection(dbConnection.connect());
        }

        private void addAdminBtn_Click(object sender, EventArgs e)
        {
            string hashedPassword = hashing.hashPassword(passwordTxt.Text);

            if ((nameTxt.Text == string.Empty) || (emailTxt.Text == string.Empty) || (numberTxt.Text == string.Empty) || (passwordTxt.Text == string.Empty))
            {
                MessageBox.Show("Warning: Required FIll All Fields", "Add Admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                conn.Open();
                cmd = new MySqlCommand("INSERT INTO admin (name,email,phone_number,password) VALUES  (@Name,@email,@phone_number,@password)", conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Name", nameTxt.Text);
                cmd.Parameters.AddWithValue("@phone_number", numberTxt.Text);
                cmd.Parameters.AddWithValue("@email", emailTxt.Text);
                cmd.Parameters.AddWithValue("@password", hashedPassword);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    ViewAdmins viewAdmins = new ViewAdmins();
                    viewAdmins.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Error: No rows were affected.", "Add Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();

            }
        }
    }
}
