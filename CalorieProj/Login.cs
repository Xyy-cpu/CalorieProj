using MySql.Data.MySqlClient;

namespace CalorieProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = "SELECT user_id FROM users WHERE username=@username AND password=@password";
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    int userId = Convert.ToInt32(result);

                    Dashboard dashboard = new Dashboard(userId);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registration regForm = new Registration(this);
            regForm.Show();
            this.Hide();
        }
    

    }
}
