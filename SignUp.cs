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
    
    public partial class SignUp : Form
    {
        public static string connString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connString);
        public SignUp()
        {
            InitializeComponent();
        }

        private static string hash(string password) {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            try {
                //Insert Query
                string qry = "INSERT INTO INVENTORY_USERS (fullName, userEmail, userPassword) VALUES (@fullName, @userEmail, @userPassword)";
                // Initialize sql command
                SqlCommand cmd = new SqlCommand(qry, conn);
                // set parameters
                cmd.Parameters.AddWithValue("@fullName", fullNameBox.Text.Trim());
                cmd.Parameters.AddWithValue("@userEmail", emailBox.Text.Trim());
                cmd.Parameters.AddWithValue("@userPassword", hash(passwordBox.Text.Trim()));
                //open connection
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    // saving operation
                    int rowAffected = cmd.ExecuteNonQuery();
                    if (rowAffected == 1)
                    {
                        MessageBox.Show("Account created successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Account creation failed. Please try again.");
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
