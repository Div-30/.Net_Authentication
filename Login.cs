using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace THURSDAY_APP
{
    public partial class Login : Form
    {
        public static string connString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connString);
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailBox.Text) || string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }
            try
            {
                //Insert Query
                string qry = "SELECT userEmail, userPassword, userRole FROM INVENTORY_USERS WHERE userEmail=@userEmail";
                // Initialize sql command
                SqlCommand cmd = new SqlCommand(qry, conn);
                // set parameters
                cmd.Parameters.AddWithValue("@userEmail", emailBox.Text.Trim());
                //open connection
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    // execute command to retrieve user data
                    SqlDataReader reader = cmd.ExecuteReader();
                    // read data
                    if (reader.Read())
                    {

                        string user_password = reader["userPassword"].ToString();
                        string userRole = reader["userRole"].ToString();
                        //verify password
                        if (BCrypt.Net.BCrypt.Verify(passwordBox.Text.Trim(), user_password))
                        {
                            if (userRole == "ADMIN")
                            {
                                Dashboard dashboard = new Dashboard();
                                dashboard.Show();
                                this.Hide();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password");

                    }

                        // close operation
                        conn.Close();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
