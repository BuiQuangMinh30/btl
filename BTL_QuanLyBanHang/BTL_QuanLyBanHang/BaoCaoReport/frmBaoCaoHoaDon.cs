using BTL_QuanLyBanHang.Report;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyBanHang.BaoCaoReport
{
    public partial class frmBaoCaoHoaDon : Form
    {
        public string fullPath = @"E:\btl\BTL_QuanLyBanHang\BTL_QuanLyBanHang\Report\ReportChiTietHoaDon.rpt";

        public frmBaoCaoHoaDon()
        {
            InitializeComponent();
        }
        public void laydulieucombobox()
        {
            string sql = "Select * from tblKhach ";

            string constr = ConfigurationManager.ConnectionStrings["btl_qlbh"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                SqlDataAdapter ad = new SqlDataAdapter(sql, constr);
                DataTable tb = new DataTable("BangKH");
                ad.Fill(tb);
                //Gán nguồn dữ liệu
                cbListKh.DataSource = tb;
                cbListKh.DisplayMember = tb.Columns["sTenKhach"].ToString();
                cbListKh.ValueMember = tb.Columns["sMaKhach"].ToString();
                crvHDKhachHang.Refresh();
            }
        }

        private void frmBaoCaoHoaDon_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load(fullPath);
            crvHDKhachHang.ReportSource = report;
            crvHDKhachHang.Refresh();
            //LoadReport();
            laydulieucombobox();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

            if (cbListKh.Text == "")
            {
                MessageBox.Show("Ban chua nhap gia tri");
            }
            else
            {
                string sql = "Select tblKhach.sMaKhach, " +
           "tblKhach.sTenKhach, tblKhach.sDiaChi, " +
           "tblKhach.sDienThoai, tblHang.sTenHang, tblHoaDonBan.dNgayBan, tblChiTietHoaDonBan.sMaHang, " +
           "tblChiTietHoaDonBan.iSoLuong, tblChiTietHoaDonBan.fDonGia, tblChiTietHoaDonBan.fGiamGia," +
           " tblChiTietHoaDonBan.fThanhTien " +
           "from tblKhach, tblHoaDonBan, tblHang, tblChiTietHoaDonBan where tblKhach.sMaKhach = tblHoaDonBan.sMaKhach AND " +
           "tblHang.sMaHang = tblChiTietHoaDonBan.sMaHang AND tblChiTietHoaDonBan.sMaHDBan = tblHoaDonBan.sMaHDBan " +
           "AND tblKhach.sMaKhach ='"+ cbListKh.SelectedValue.ToString() + "'";
                //
                string constr = ConfigurationManager.ConnectionStrings["btl_qlbh"].ConnectionString;
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    SqlDataAdapter ad = new SqlDataAdapter(sql, constr);
                    DataTable tb = new DataTable("BangBaoCaoHoaDon");
                    ad.Fill(tb);
                    //Gán nguồn dữ liệu
                    ReportChiTietHoaDon rptHoaDon = new ReportChiTietHoaDon();
                    rptHoaDon.SetDataSource(tb);
                    //Hiển thị báo cáo
                    crvHDKhachHang.ReportSource = rptHoaDon;
                    crvHDKhachHang.Refresh();
                }
            }

        }
    }
}
