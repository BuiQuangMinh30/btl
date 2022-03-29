using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyBanHang.Account
{
    public partial class frmSignUp : Form
    {
        string constr = @"Data Source=DESKTOP-8GD1V6M;Initial Catalog=BTL_QuanLyBanHang;Integrated Security=True";
        SqlConnection conn;
        SqlDataReader dr;
        public frmSignUp()
        {
            InitializeComponent();
            conn = new SqlConnection(constr);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(constr))
            {
                String query = "INSERT INTO tblUser (sUsername,sPassword) VALUES (@sUsername,@sPassword)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                   
                    command.Parameters.AddWithValue("@sUsername", txtUsername.Text);
                    command.Parameters.AddWithValue("@sPassword", txtPassword.Text);
                   
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                    else
                        MessageBox.Show("Sign Up Success, Already Login");
                        frmLogin frm = new frmLogin();
                        this.Hide();
                        frm.Show();
                }
            }
        }
    }
}
