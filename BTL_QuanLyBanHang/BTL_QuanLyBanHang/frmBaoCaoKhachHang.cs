using BTL_QuanLyBanHang.Report;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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

namespace BTL_QuanLyBanHang
{
    public partial class frmBaoCaoKhachHang : Form
    {
        public string fullPath = @"E:\btl\BTL_QuanLyBanHang\BTL_QuanLyBanHang\Report\ReportKhachHang.rpt";
        public frmBaoCaoKhachHang()
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
                DataTable tb = new DataTable("Bang");
                ad.Fill(tb);
                //Gán nguồn dữ liệu
                cbTenKhach.DataSource = tb;
                cbTenKhach.DisplayMember = tb.Columns["sTenKhach"].ToString();
                cbTenKhach.ValueMember = tb.Columns["sMaKhach"].ToString();
                crvKhachHang.Refresh();
            }
        }

        private void frmBaoCaoKhachHang_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load(fullPath);
            crvKhachHang.ReportSource = report;
            crvKhachHang.Refresh();
            //LoadReport();
            laydulieucombobox();
        }
        private void LoadReport()
        {
            string sql = "Select tblKhach.sMaKhach, " +
                "tblKhach.sTenKhach, tblKhach.sDiaChi, " +
                "tblKhach.sDienThoai, tblHoaDonBan.dNgayBan, tblHoaDonBan.fTongTien " +
                "from tblKhach, tblHoaDonBan where tblKhach.sMaKhach = tblHoaDonBan.sMaKhach";
            string constr = ConfigurationManager.ConnectionStrings["btl_qlbh"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                SqlDataAdapter ad = new SqlDataAdapter(sql, constr);
                DataTable tb = new DataTable("BangHoaDon");
                ad.Fill(tb);
                //Gán nguồn dữ liệu
                ReportKhachHang rptKhachHang = new ReportKhachHang();
                rptKhachHang.SetDataSource(tb);
                //Hiển thị báo cáo
                //crvKhachHang.ReportSource = rptKhachHang;
                //crvKhachHang.Refresh();
            }
        }

       
        private void btnTimKh_Click_1(object sender, EventArgs e)
        {
            
                if (cbTenKhach.Text == "")
                {
                    MessageBox.Show("Ban chua nhap gia tri");
                }
                else
                {
                    string sql = "Select tblKhach.sMaKhach, " +
               "tblKhach.sTenKhach, tblKhach.sDiaChi, " +
               "tblKhach.sDienThoai, tblHoaDonBan.dNgayBan, tblHoaDonBan.fTongTien " +
               "from tblKhach, tblHoaDonBan where tblKhach.sMaKhach = tblHoaDonBan.sMaKhach AND" +
               " tblHoaDonBan.sMaKhach ='" + cbTenKhach.SelectedValue.ToString() + "'";
                    string constr = ConfigurationManager.ConnectionStrings["btl_qlbh"].ConnectionString;
                    using (SqlConnection cnn = new SqlConnection(constr))
                    {
                        SqlDataAdapter ad = new SqlDataAdapter(sql, constr);
                        DataTable tb = new DataTable("BangTimKiem");
                        ad.Fill(tb);
                        //Gán nguồn dữ liệu
                        ReportKhachHang rptKhachHang = new ReportKhachHang();
                        rptKhachHang.SetDataSource(tb);
                        //Hiển thị báo cáo
                        crvKhachHang.ReportSource = rptKhachHang;
                        crvKhachHang.Refresh();
                    }
                }

        }
        
        

        private void btnTimTxt_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                if(txtSDT.Text == "")
                {
                    MessageBox.Show("Chua nhap 1 trong 2 du lieu can tim");
                }
                else
                {
                    string sql = "Select tblKhach.sMaKhach, " +
              "tblKhach.sTenKhach, tblKhach.sDiaChi, " +
              "tblKhach.sDienThoai, tblHoaDonBan.dNgayBan, tblHoaDonBan.fTongTien " +
              "from tblKhach, tblHoaDonBan where tblKhach.sMaKhach = tblHoaDonBan.sMaKhach AND" +
              " tblKhach.sDienThoai ='" + txtSDT.Text.Trim() + "'";
                    string constr = ConfigurationManager.ConnectionStrings["btl_qlbh"].ConnectionString;
                    using (SqlConnection cnn = new SqlConnection(constr))
                    {
                        SqlDataAdapter ad = new SqlDataAdapter(sql, constr);
                        DataTable tb = new DataTable("BangTimKiem");
                        ad.Fill(tb);
                        //Gán nguồn dữ liệu
                        ReportKhachHang rptKhachHang = new ReportKhachHang();
                        rptKhachHang.SetDataSource(tb);
                        //Hiển thị báo cáo
                        crvKhachHang.ReportSource = rptKhachHang;
                        crvKhachHang.Refresh();
                    }
                }
            }
            else
            {
                string sql = "Select tblKhach.sMaKhach, " +
               "tblKhach.sTenKhach, tblKhach.sDiaChi, " +
               "tblKhach.sDienThoai, tblHoaDonBan.dNgayBan, tblHoaDonBan.fTongTien " +
               "from tblKhach, tblHoaDonBan where tblKhach.sMaKhach = tblHoaDonBan.sMaKhach AND" +
               " tblHoaDonBan.sMaKhach ='" + txtMaKH.Text + "'";
                string constr = ConfigurationManager.ConnectionStrings["btl_qlbh"].ConnectionString;
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    SqlDataAdapter ad = new SqlDataAdapter(sql, constr);
                    DataTable tb = new DataTable("BangTimKiem");
                    ad.Fill(tb);
                    //Gán nguồn dữ liệu
                    ReportKhachHang rptKhachHang = new ReportKhachHang();
                    rptKhachHang.SetDataSource(tb);
                    //Hiển thị báo cáo
                    crvKhachHang.ReportSource = rptKhachHang;
                    crvKhachHang.Refresh();
                }
            }
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
