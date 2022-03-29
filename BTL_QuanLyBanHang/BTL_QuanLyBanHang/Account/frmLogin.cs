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
    public partial class frmLogin : Form
    {
        string constr  = @"Data Source=DESKTOP-8GD1V6M;Initial Catalog=BTL_QuanLyBanHang;Integrated Security=True";
        SqlConnection conn;
        SqlDataReader dr;
        public frmLogin()
        {
            InitializeComponent();
            conn = new SqlConnection(constr);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [sUsername],[sPassword]
                FROM[dbo].[tblUser] where sUsername='" + txtUsername.Text + "' AND sPassword='" + txtPassword.Text + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                frmMain frm = new frmMain();
                this.Hide();
                frm.Show();

            }
            else
            {
                MessageBox.Show("Sai");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignUp frm = new frmSignUp();
            this.Hide();
            frm.Show();
        }
    }
}
