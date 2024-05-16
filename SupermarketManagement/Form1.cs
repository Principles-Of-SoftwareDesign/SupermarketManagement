using MySql.Data.MySqlClient;
namespace SupermarketManagement
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        dbConnection dbConnection = new dbConnection();
        Validation validation = new Validation();

        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection(dbConnection.connect());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addAdminBtn_Click(object sender, EventArgs e)
        {
            string hashedPassword = validation.hashPassword(passwordTxt.Text);

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
                    MessageBox.Show("Added Successfully", "Add Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
