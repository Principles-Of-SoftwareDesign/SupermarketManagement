using MySql.Data.MySqlClient;
using SupermarketManagement.Config;

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

        //hide password + make validations////
        private void addAdminBtn_Click(object sender, EventArgs e)
        {
           }
    }
}
