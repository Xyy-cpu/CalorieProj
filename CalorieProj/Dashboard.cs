using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System;
using System.Data;
using System.Windows.Forms;

namespace CalorieProj
{
    public partial class Dashboard : Form
    {
        private int loggedInUserId;


        public Dashboard(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
            LoadUserGoal();
            LoadHistory();
        }

        private void LoadUserGoal()
        {
            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();
                string query = "SELECT calorie_goal FROM users WHERE user_id=@user_id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user_id", loggedInUserId);
                object result = cmd.ExecuteScalar();
                if (result != null)
                    txtGoal.Text = result.ToString();
            }
        }

        private void Goalbtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtGoal.Text, out int goal))
            {
                using (MySqlConnection con = Database.GetConnection())
                {
                    con.Open();
                    string query = "UPDATE users SET calorie_goal=@goal WHERE user_id=@user_id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@goal", goal);
                    cmd.Parameters.AddWithValue("@user_id", loggedInUserId);
                    cmd.ExecuteNonQuery();
                }
                UpdateProgress();
            }
        }


        private void Consbtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Calorietaken.Text, out int calories))
            {
                using (MySqlConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = "INSERT INTO calorie_logs (user_id, calories, date_logged) VALUES (@user_id, @calories, NOW())";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@user_id", loggedInUserId);
                    cmd.Parameters.AddWithValue("@calories", calories);

                    cmd.ExecuteNonQuery();
                }

                Calorietaken.Clear();
                LoadHistory();
                UpdateProgress();
            }
        }
        private void LoadHistory()
        {
            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();
                string query = "SELECT calories, date_logged FROM calorie_logs WHERE user_id=@user_id ORDER BY date_logged DESC";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                adapter.SelectCommand.Parameters.AddWithValue("@user_id", loggedInUserId);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                HistoryData.DataSource = dt;
            }
            UpdateProgress();
        }


        private void UpdateProgress()
        {
            int totalCaloriesToday = 0;
            int goal = 0;

            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();


                string sumQuery = "SELECT SUM(calories) FROM calorie_logs WHERE user_id=@user_id AND DATE(date_logged)=CURDATE()";
                MySqlCommand sumCmd = new MySqlCommand(sumQuery, con);
                sumCmd.Parameters.AddWithValue("@user_id", loggedInUserId);
                object sumResult = sumCmd.ExecuteScalar();
                totalCaloriesToday = sumResult != DBNull.Value ? Convert.ToInt32(sumResult) : 0;


                string goalQuery = "SELECT calorie_goal FROM users WHERE user_id=@user_id";
                MySqlCommand goalCmd = new MySqlCommand(goalQuery, con);
                goalCmd.Parameters.AddWithValue("@user_id", loggedInUserId);
                object goalResult = goalCmd.ExecuteScalar();
                goal = goalResult != DBNull.Value ? Convert.ToInt32(goalResult) : 0;
            }

            GoalProglbl.Text = $"Today's Calories: {totalCaloriesToday} / {goal}";
            GoalProgress.Maximum = goal > 0 ? goal : 1;
            GoalProgress.Value = Math.Min(totalCaloriesToday, GoalProgress.Maximum);
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }
    }
}