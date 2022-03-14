using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;            //Sử dụng hiển thị messagebox

namespace BTL_QuanLyBanHang.Class
{
    class Functions
    {
        public static SqlConnection con; //Khai báo đối tượng kết nối
                                         
        //Phương thức tĩnh: gọi trực tiếp không cần khởi tạo đối tượng của class Functions
        public static void Connect()
        {
            con = new SqlConnection();    //Khởi tạo đối tượng
            con.ConnectionString = @"Data Source=DESKTOP-8GD1V6M;Initial Catalog=BTL_QuanLyBanHang;Integrated Security=True";

            if (con.State != ConnectionState.Open)
            {
                con.Open();         
                MessageBox.Show("Kết nối thành công!");
            }
            else
            {
                MessageBox.Show("Không thể kết nối không thành công!");
            }
        }

        public static void Disconnect()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();     //Đóng kết nối
                con.Dispose();   //Giải phóng tài nguyên
                con = null;
            }
        }

        //Phương thức thực hiện câu lệnh select lấy dữ liệu
        public static DataTable GetDataTable(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            //Định nghĩa đối tượng thuộc lớp SqlDataAdapter

            //Khai báo đối tượng table thuộc lớp datatable
            DataTable table = new DataTable();
            adapter.Fill(table);  //Đổ kết quả câu lệnh sql vào table
            return table;
        }

        public static void FillComBoBox(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            cbo.DataSource = tb;
            cbo.ValueMember = ma;    //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị
        }

        //Có tác dụng lấy dữ liệu từ một câu lệnh SQL.
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }

        //Check khóa
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            if (tb.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsDate(string date)
        {
            string[] elements = date.Split('/');
            if ((Convert.ToInt32(elements[0]) >= 1) && (Convert.ToInt32(elements[0]) <= 12) &&
                (Convert.ToInt32(elements[1]) >= 1) && (Convert.ToInt32(elements[1]) <= 31) &&
                (Convert.ToInt32(elements[2]) >= 1900) && (Convert.ToInt32(elements[2]) <= 2004))
                return true;
            else return false;
        }

        public static string ConvertDateTime(string date)
        {
            string[] elements = date.Split('/');
            string dt = string.Format("{0}/{1}/{2}", elements[0], elements[1], elements[2]);
            return dt;
        }
    }
}
