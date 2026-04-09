using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CalorieProj
{
    public partial class Registration : Form
    {
        private Form loginForm; 

     
        public Registration(Form login)
        {
            InitializeComponent();
            loginForm = login;
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = "INSERT INTO users (username, password) VALUES (@username, @password)";
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registered Successfully!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Registration failed: " + ex.Message);
                    return;
                }
            }

      
            loginForm.Show();
            this.Close();
        }

   
        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();     
        }
    }
}