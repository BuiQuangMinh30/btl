
namespace BTL_QuanLyBanHang
{
    partial class frmHoaDonBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiemHD = new System.Windows.Forms.Button();
            this.cboMaHD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.cboMaKhach = new System.Windows.Forms.ComboBox();
            this.mtbDienThoaiKh = new System.Windows.Forms.MaskedTextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaHDBan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrHoaDonBanHang = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.cboMaHang = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.btnLuuHD = new System.Windows.Forms.Button();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrHoaDonBanHang)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiemHD);
            this.panel1.Controls.Add(this.cboMaHD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 1300);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2133, 93);
            this.panel1.TabIndex = 0;
            // 
            // btnTimKiemHD
            // 
            this.btnTimKiemHD.Image = global::BTL_QuanLyBanHang.Properties.Resources._1814075_find_magnifier_magnifying_glass_search_icon;
            this.btnTimKiemHD.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTimKiemHD.Location = new System.Drawing.Point(885, 14);
            this.btnTimKiemHD.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnTimKiemHD.Name = "btnTimKiemHD";
            this.btnTimKiemHD.Size = new System.Drawing.Size(315, 52);
            this.btnTimKiemHD.TabIndex = 2;
            this.btnTimKiemHD.Text = "Tìm Kiếm";
            this.btnTimKiemHD.UseVisualStyleBackColor = true;
            this.btnTimKiemHD.Click += new System.EventHandler(this.btnTimKiemHD_Click);
            // 
            // cboMaHD
            // 
            this.cboMaHD.FormattingEnabled = true;
            this.cboMaHD.Location = new System.Drawing.Point(272, 14);
            this.cboMaHD.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cboMaHD.Name = "cboMaHD";
            this.cboMaHD.Size = new System.Drawing.Size(540, 39);
            this.cboMaHD.TabIndex = 1;
            this.cboMaHD.DropDown += new System.EventHandler(this.cboMaHD_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2133, 417);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemKH);
            this.groupBox1.Controls.Add(this.cboMaKhach);
            this.groupBox1.Controls.Add(this.mtbDienThoaiKh);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.cboMaNV);
            this.groupBox1.Controls.Add(this.dtpNgayBan);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtMaHDBan);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(2133, 358);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(1812, 18);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(222, 63);
            this.btnThemKH.TabIndex = 20;
            this.btnThemKH.Text = "Thêm khách hàng";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // cboMaKhach
            // 
            this.cboMaKhach.FormattingEnabled = true;
            this.cboMaKhach.Location = new System.Drawing.Point(1245, 31);
            this.cboMaKhach.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cboMaKhach.Name = "cboMaKhach";
            this.cboMaKhach.Size = new System.Drawing.Size(447, 39);
            this.cboMaKhach.TabIndex = 19;
            this.cboMaKhach.TextChanged += new System.EventHandler(this.cboMaKhach_TextChanged);
            // 
            // mtbDienThoaiKh
            // 
            this.mtbDienThoaiKh.Location = new System.Drawing.Point(1245, 236);
            this.mtbDienThoaiKh.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.mtbDienThoaiKh.Mask = "(999) 000-0000";
            this.mtbDienThoaiKh.Name = "mtbDienThoaiKh";
            this.mtbDienThoaiKh.Size = new System.Drawing.Size(447, 38);
            this.mtbDienThoaiKh.TabIndex = 18;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(365, 229);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.ReadOnly = true;
            this.txtTenNV.Size = new System.Drawing.Size(447, 38);
            this.txtTenNV.TabIndex = 11;
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(365, 165);
            this.cboMaNV.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(447, 39);
            this.cboMaNV.TabIndex = 10;
            this.cboMaNV.TextChanged += new System.EventHandler(this.cboMaNV_TextChanged);
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBan.Location = new System.Drawing.Point(365, 98);
            this.dtpNgayBan.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(447, 38);
            this.dtpNgayBan.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(1245, 174);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(447, 38);
            this.txtDiaChi.TabIndex = 8;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(1245, 105);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(447, 38);
            this.txtTenKH.TabIndex = 8;
            // 
            // txtMaHDBan
            // 
            this.txtMaHDBan.Location = new System.Drawing.Point(365, 31);
            this.txtMaHDBan.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtMaHDBan.Name = "txtMaHDBan";
            this.txtMaHDBan.Size = new System.Drawing.Size(447, 38);
            this.txtMaHDBan.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(939, 253);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 32);
            this.label10.TabIndex = 7;
            this.label10.Text = "Điện thoại:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(939, 184);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 32);
            this.label9.TabIndex = 6;
            this.label9.Text = "Địa chỉ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(939, 117);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 32);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tên khách hàng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(939, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "Mã khách hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 253);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên nhân viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày bán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã hóa đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(789, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 53);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hóa Đơn Bán Hàng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 417);
            this.panel3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2133, 883);
            this.panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrHoaDonBanHang);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Size = new System.Drawing.Size(2133, 883);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // dgrHoaDonBanHang
            // 
            this.dgrHoaDonBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrHoaDonBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrHoaDonBanHang.Location = new System.Drawing.Point(8, 234);
            this.dgrHoaDonBanHang.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgrHoaDonBanHang.Name = "dgrHoaDonBanHang";
            this.dgrHoaDonBanHang.RowHeadersWidth = 102;
            this.dgrHoaDonBanHang.Size = new System.Drawing.Size(2117, 451);
            this.dgrHoaDonBanHang.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtTongTien);
            this.panel6.Controls.Add(this.label18);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(8, 685);
            this.panel6.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2117, 81);
            this.panel6.TabIndex = 2;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(1651, 12);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(337, 38);
            this.txtTongTien.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1472, 19);
            this.label18.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(149, 32);
            this.label18.TabIndex = 2;
            this.label18.Text = "Tổng tiền: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(27, 2);
            this.label17.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(375, 32);
            this.label17.TabIndex = 0;
            this.label17.Text = "Nháy đúp vào 1 dòng để xóa";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.txtThanhTien);
            this.panel5.Controls.Add(this.txtGiamGia);
            this.panel5.Controls.Add(this.txtSoLuong);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.txtDonGiaBan);
            this.panel5.Controls.Add(this.txtTenHang);
            this.panel5.Controls.Add(this.cboMaHang);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(8, 38);
            this.panel5.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2117, 196);
            this.panel5.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1464, 143);
            this.label16.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(158, 32);
            this.label16.TabIndex = 7;
            this.label16.Text = "Thành tiền:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(792, 143);
            this.label15.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(175, 32);
            this.label15.TabIndex = 6;
            this.label15.Text = "Giảm Giá: %";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(1651, 126);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(337, 38);
            this.txtThanhTien.TabIndex = 5;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(1005, 129);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(337, 38);
            this.txtGiamGia.TabIndex = 5;
            this.txtGiamGia.TextChanged += new System.EventHandler(this.txtGiamGia_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(312, 129);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(337, 38);
            this.txtSoLuong.TabIndex = 5;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(99, 145);
            this.label14.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 32);
            this.label14.TabIndex = 4;
            this.label14.Text = "Số lượng:";
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Location = new System.Drawing.Point(1651, 31);
            this.txtDonGiaBan.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.ReadOnly = true;
            this.txtDonGiaBan.Size = new System.Drawing.Size(337, 38);
            this.txtDonGiaBan.TabIndex = 3;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(1005, 33);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.ReadOnly = true;
            this.txtTenHang.Size = new System.Drawing.Size(337, 38);
            this.txtTenHang.TabIndex = 2;
            // 
            // cboMaHang
            // 
            this.cboMaHang.FormattingEnabled = true;
            this.cboMaHang.Location = new System.Drawing.Point(312, 33);
            this.cboMaHang.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cboMaHang.Name = "cboMaHang";
            this.cboMaHang.Size = new System.Drawing.Size(337, 39);
            this.cboMaHang.TabIndex = 1;
            this.cboMaHang.TextChanged += new System.EventHandler(this.cboMaHang_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1456, 50);
            this.label13.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 32);
            this.label13.TabIndex = 0;
            this.label13.Text = "Đơn giá:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(784, 50);
            this.label12.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên hàng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(91, 50);
            this.label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 32);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã hàng:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDong);
            this.panel4.Controls.Add(this.btnInHD);
            this.panel4.Controls.Add(this.btnXoaHD);
            this.panel4.Controls.Add(this.btnLuuHD);
            this.panel4.Controls.Add(this.btnThemHD);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(8, 766);
            this.panel4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2117, 110);
            this.panel4.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(1747, 26);
            this.btnDong.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(259, 55);
            this.btnDong.TabIndex = 0;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // btnInHD
            // 
            this.btnInHD.Location = new System.Drawing.Point(1339, 26);
            this.btnInHD.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(320, 55);
            this.btnInHD.TabIndex = 0;
            this.btnInHD.Text = "In hóa đơn";
            this.btnInHD.UseVisualStyleBackColor = true;
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.Location = new System.Drawing.Point(931, 26);
            this.btnXoaHD.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(320, 55);
            this.btnXoaHD.TabIndex = 0;
            this.btnXoaHD.Text = "Hủy hóa đơn";
            this.btnXoaHD.UseVisualStyleBackColor = true;
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.Location = new System.Drawing.Point(523, 26);
            this.btnLuuHD.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(320, 55);
            this.btnLuuHD.TabIndex = 0;
            this.btnLuuHD.Text = "Lưu hóa đơn";
            this.btnLuuHD.UseVisualStyleBackColor = true;
            this.btnLuuHD.Click += new System.EventHandler(this.btnLuuHD_Click);
            // 
            // btnThemHD
            // 
            this.btnThemHD.Location = new System.Drawing.Point(115, 26);
            this.btnThemHD.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(320, 55);
            this.btnThemHD.TabIndex = 0;
            this.btnThemHD.Text = "Thêm hóa đơn";
            this.btnThemHD.UseVisualStyleBackColor = true;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // frmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1393);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmHoaDonBan";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hóa Đơn Bán ";
            this.Load += new System.EventHandler(this.frmHoaDonBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrHoaDonBanHang)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiemHD;
        private System.Windows.Forms.ComboBox cboMaHD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.MaskedTextBox mtbDienThoaiKh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.ComboBox cboMaHang;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgrHoaDonBanHang;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Button btnLuuHD;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.ComboBox cboMaKhach;
        private System.Windows.Forms.Button btnThemKH;
        public System.Windows.Forms.TextBox txtMaHDBan;
    }
}