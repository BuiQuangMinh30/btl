using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BTL_QuanLyBanHang.Class;        //Sử dụng class Functions.cs
using System.Configuration;

namespace BTL_QuanLyBanHang
{
    public partial class frmDanhMucNhanVien : Form
    {
        public DataTable tbNV;
        public frmDanhMucNhanVien()
        {
            InitializeComponent();
        }

        private void frmDanhMucNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            LoadDataGridViewNV();
        }

        public void LoadDataGridViewNV()
        {
            string sql;
            sql = "select * from tblNhanVien";
            tbNV = Functions.GetDataTable(sql);
            dgrNhanVien.DataSource = tbNV;

            dgrNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgrNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgrNhanVien.Columns[2].HeaderText = "Giới tính";
            dgrNhanVien.Columns[3].HeaderText = "Địa chỉ";
            dgrNhanVien.Columns[4].HeaderText = "Điện thoại";
            dgrNhanVien.Columns[5].HeaderText = "Ngày sinh";

            dgrNhanVien.Columns[1].Width = 150;
            dgrNhanVien.Columns[3].Width = 150;

            dgrNhanVien.AllowUserToAddRows = false;
            dgrNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgrNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chết độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNV.Focus();
                return;
            }

            if (tbNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtMaNV.Text= dgrNhanVien.CurrentRow.Cells["sMaNhanVien"].Value.ToString();
            txtTenNV.Text = dgrNhanVien.CurrentRow.Cells["sTenNhanVien"].Value.ToString();
            if (dgrNhanVien.CurrentRow.Cells["sGioiTinh"].Value.ToString() == "Nam") cbGioitinh.Checked = true;
            else cbGioitinh.Checked = false;
            txtDiaChiNV.Text = dgrNhanVien.CurrentRow.Cells["sDiaChi"].Value.ToString();
            mtbDienThoaiNV.Text = dgrNhanVien.CurrentRow.Cells["sDienThoai"].Value.ToString();
            dtpNgaySinh.Value = (DateTime)dgrNhanVien.CurrentRow.Cells["dNgaysinh"].Value;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValue();
            txtMaNV.Enabled = true;
            txtMaNV.Focus();
        }

        private void ResetValue()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtDiaChiNV.Text = "";
            cbGioitinh.Checked = false;
            dtpNgaySinh.Value = DateTime.Now;
            mtbDienThoaiNV.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            string gt;
            if (txtMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            if (txtTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
                return;
            }
            if (txtDiaChiNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChiNV.Focus();
                return;
            }
            if (mtbDienThoaiNV.Text == "   -   -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbDienThoaiNV.Focus();
                return;
            }

            if (cbGioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";

            if (dtpNgaySinh.Text == "  /  /    ")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return;
            }
            if (!Functions.IsDate(dtpNgaySinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return;
            }

            sql = "select * from tblNhanVien where sMaNhanVien = N'" + txtMaNV.Text + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại, vui lòng nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                txtMaNV.Text = "";
                return;
            }

            sql = "select * from tblNhanVien where sDienThoai = N'" + mtbDienThoaiNV.Text + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Số điện thoại đã tồn tại, vui lòng nhập số điện thoại khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbDienThoaiNV.Focus();
                mtbDienThoaiNV.Text = "";
                return;
            }

            string constr = ConfigurationManager.ConnectionStrings["btl_qlbh"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_tblNhanVien_Insert";
                    cmd.Parameters.AddWithValue("@sMaNhanVien", txtMaNV.Text);
                    cmd.Parameters.AddWithValue("@sTenNhanVien", txtTenNV.Text);
                    cmd.Parameters.AddWithValue("@sGioiTinh", gt);
                    cmd.Parameters.AddWithValue("@sDiaChi", txtDiaChiNV.Text);
                    cmd.Parameters.AddWithValue("@sDienThoai", mtbDienThoaiNV.Text);
                    cmd.Parameters.AddWithValue("@dNgaySinh", Functions.ConvertDateTime(dtpNgaySinh.Text));
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                   
                    cnn.Close();
                    LoadDataGridViewNV();
                }
            }
            ResetValue();                 //Xóa trắng
            txtMaNV.Enabled = true; //Cho phép nhập mới
            txtMaNV.Focus();
        }
    

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaNV.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thoát danh mục nhân viên!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string gt,sql;
            if (tbNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
                return;
            }
            if (txtDiaChiNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChiNV.Focus();
                return;
            }
            if (mtbDienThoaiNV.Text == "   -   -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbDienThoaiNV.Focus();
                return;
            }
            if (cbGioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            if (dtpNgaySinh.Text == "  /  /    ")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return;
            }
            if (!Functions.IsDate(dtpNgaySinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Text = "";
                dtpNgaySinh.Focus();
                return;
            }
            sql = "select * from tblNhanVien where sDienThoai = N'" + mtbDienThoaiNV.Text + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Số điện thoại đã tồn tại, vui lòng nhập số điện thoại khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbDienThoaiNV.Focus();
                mtbDienThoaiNV.Text = "";
                return;
            }

            string constr = ConfigurationManager.ConnectionStrings["btl_qlbh"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_tblNhanVien_Update";
                    cmd.Parameters.AddWithValue("@sMaNhanVien", txtMaNV.Text);
                    cmd.Parameters.AddWithValue("@sTenNhanVien", txtTenNV.Text);
                    cmd.Parameters.AddWithValue("@sGioiTinh", gt);
                    cmd.Parameters.AddWithValue("@sDiaChi", txtDiaChiNV.Text);
                    cmd.Parameters.AddWithValue("@sDienThoai", mtbDienThoaiNV.Text);
                    cmd.Parameters.AddWithValue("@dNgaySinh", dtpNgaySinh.Text);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                  
                    cnn.Close();
                    LoadDataGridViewNV();
                    cnn.Close();
                    ResetValue();
                    btnBoQua.Enabled = false;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblNhanVien WHERE sMaNhanVien=N'" + txtMaNV.Text + "'";
                Functions.GetDataTable(sql);
                LoadDataGridViewNV();
                ResetValue();
            }
        }
    }
}
