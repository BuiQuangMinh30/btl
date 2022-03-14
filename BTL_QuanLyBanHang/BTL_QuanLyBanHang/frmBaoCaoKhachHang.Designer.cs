
namespace BTL_QuanLyBanHang
{
    partial class frmBaoCaoKhachHang
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
            this.crvKhachHang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnTimTxt = new System.Windows.Forms.Button();
            this.cbTenKhach = new System.Windows.Forms.ComboBox();
            this.btnTimKh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.crvKhachHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1571, 874);
            this.panel1.TabIndex = 5;
            // 
            // crvKhachHang
            // 
            this.crvKhachHang.ActiveViewIndex = -1;
            this.crvKhachHang.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.crvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvKhachHang.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.crvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvKhachHang.Location = new System.Drawing.Point(0, 0);
            this.crvKhachHang.Name = "crvKhachHang";
            this.crvKhachHang.Size = new System.Drawing.Size(1571, 874);
            this.crvKhachHang.TabIndex = 1;
            this.crvKhachHang.ToolPanelWidth = 400;
            this.crvKhachHang.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtSDT);
            this.panel2.Controls.Add(this.btnTimTxt);
            this.panel2.Controls.Add(this.cbTenKhach);
            this.panel2.Controls.Add(this.btnTimKh);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtMaKH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1571, 144);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "hoặc SDT";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(172, 88);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(297, 38);
            this.txtSDT.TabIndex = 10;
            // 
            // btnTimTxt
            // 
            this.btnTimTxt.Location = new System.Drawing.Point(497, 27);
            this.btnTimTxt.Name = "btnTimTxt";
            this.btnTimTxt.Size = new System.Drawing.Size(142, 102);
            this.btnTimTxt.TabIndex = 9;
            this.btnTimTxt.Text = "Tìm";
            this.btnTimTxt.UseVisualStyleBackColor = true;
            this.btnTimTxt.Click += new System.EventHandler(this.btnTimTxt_Click);
            // 
            // cbTenKhach
            // 
            this.cbTenKhach.FormattingEnabled = true;
            this.cbTenKhach.Location = new System.Drawing.Point(830, 27);
            this.cbTenKhach.Name = "cbTenKhach";
            this.cbTenKhach.Size = new System.Drawing.Size(310, 39);
            this.cbTenKhach.TabIndex = 8;
            // 
            // btnTimKh
            // 
            this.btnTimKh.Location = new System.Drawing.Point(1160, 27);
            this.btnTimKh.Name = "btnTimKh";
            this.btnTimKh.Size = new System.Drawing.Size(142, 93);
            this.btnTimKh.TabIndex = 7;
            this.btnTimKh.Text = "Tìm";
            this.btnTimKh.UseVisualStyleBackColor = true;
            this.btnTimKh.Click += new System.EventHandler(this.btnTimKh_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm mã";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(172, 27);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(297, 38);
            this.txtMaKH.TabIndex = 5;
            this.txtMaKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            // 
            // frmBaoCaoKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1571, 874);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBaoCaoKhachHang";
            this.Text = "frmBaoCaoKhachHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaoCaoKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvKhachHang;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbTenKhach;
        private System.Windows.Forms.Button btnTimKh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnTimTxt;
    }
}