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

namespace BTL_QuanLyBanHang
{
    public partial class frmBaoCaoQLHD : Form
    {
        public string fullPath = @"E:\btl\BTL_QuanLyBanHang\BTL_QuanLyBanHang\Report\CRqlhd.rpt";
        public frmBaoCaoQLHD()
        {
            InitializeComponent();
        }

        private void frmBaoCaoQLHD_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load(fullPath);
            crvQLHD.ReportSource = report;
            crvQLHD.Refresh();
            LoadReport();
        }
        private void LoadReport()
        {
            string sql = "Select tblHoaDonBan.sMaNhanVien, tblHoaDonBan.sMaHDBan, "+
                " tblChiTietHoaDonBan.sMaHDBan, tblChiTietHoaDonBan.iSoLuong," +
                "tblChiTietHoaDonBan.fDonGia,tblChiTietHoaDonBan.fThanhTien," +
                "tblNhanVien.sMaNhanVien, tblNhanVien.sTenNhanVien from  tblHoaDonBan, tblNhanVien," +
                "tblChiTietHoaDonBan where tblHoaDonBan.sMaHDBan = tblChiTietHoaDonBan.sMaHDBan and " +
                "tblHoaDonBan.sMaNhanVien = tblNhanVien.sMaNhanVien";
            string constr = ConfigurationManager.ConnectionStrings["btl_qlbh"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                SqlDataAdapter ad = new SqlDataAdapter(sql, constr);
                DataTable tb = new DataTable("BangQuanLyHoaDon");
                ad.Fill(tb);
                //Gán nguồn dữ liệu
                CRqlhd rqlhd = new CRqlhd();
                rqlhd.SetDataSource(tb);
                //Hiển thị báo cáo
                crvQLHD.ReportSource = rqlhd;
                crvQLHD.Refresh();
            }
        }
    }
}
