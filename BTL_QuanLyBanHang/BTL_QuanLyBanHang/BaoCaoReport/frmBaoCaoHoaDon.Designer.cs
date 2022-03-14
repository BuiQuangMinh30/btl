
namespace BTL_QuanLyBanHang.BaoCaoReport
{
    partial class frmBaoCaoHoaDon
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.crvHDKhachHang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cbListKh = new System.Windows.Forms.ComboBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIn);
            this.panel1.Controls.Add(this.cbListKh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 117);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.crvHDKhachHang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1363, 594);
            this.panel2.TabIndex = 1;
            // 
            // crvHDKhachHang
            // 
            this.crvHDKhachHang.ActiveViewIndex = -1;
            this.crvHDKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvHDKhachHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvHDKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvHDKhachHang.Location = new System.Drawing.Point(0, 0);
            this.crvHDKhachHang.Name = "crvHDKhachHang";
            this.crvHDKhachHang.Size = new System.Drawing.Size(1363, 594);
            this.crvHDKhachHang.TabIndex = 0;
            // 
            // cbListKh
            // 
            this.cbListKh.FormattingEnabled = true;
            this.cbListKh.Location = new System.Drawing.Point(91, 24);
            this.cbListKh.Name = "cbListKh";
            this.cbListKh.Size = new System.Drawing.Size(340, 39);
            this.cbListKh.TabIndex = 0;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(484, 24);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(162, 55);
            this.btnIn.TabIndex = 1;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frmBaoCaoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 711);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBaoCaoHoaDon";
            this.Text = "frmBaoCaoHoaDon";
            this.Load += new System.EventHandler(this.frmBaoCaoHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvHDKhachHang;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.ComboBox cbListKh;
    }
}