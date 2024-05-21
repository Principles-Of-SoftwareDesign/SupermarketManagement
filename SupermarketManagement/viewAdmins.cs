using MySql.Data.MySqlClient;

namespace SupermarketManagement
{
    public partial class ViewAdmins : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        dbConnection dbConnection = new dbConnection();
        public ViewAdmins()
        {
            InitializeComponent();
            conn = new MySqlConnection(dbConnection.connect());
        }

        public void loadData()
        {
            dataGridView1.Rows.Clear();
            conn.Open();
            cmd = new MySqlCommand("SELECT * FROM `admin`", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, reader["name"].ToString(), reader["email"].ToString(), reader["phone_number"].ToString());
            }
            reader.Close();
            conn.Close();
        }

        private void ViewAdmins_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
