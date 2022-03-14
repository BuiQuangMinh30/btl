
namespace BTL_QuanLyBanHang
{
    partial class frmBaoCaoQLHD
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
            this.crvQLHD = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvQLHD
            // 
            this.crvQLHD.ActiveViewIndex = -1;
            this.crvQLHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvQLHD.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvQLHD.Location = new System.Drawing.Point(46, 22);
            this.crvQLHD.Name = "crvQLHD";
            this.crvQLHD.Size = new System.Drawing.Size(1862, 787);
            this.crvQLHD.TabIndex = 0;
            // 
            // frmBaoCaoQLHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1962, 895);
            this.Controls.Add(this.crvQLHD);
            this.Name = "frmBaoCaoQLHD";
            this.Text = "frmBaoCaoQLHD";
            this.Load += new System.EventHandler(this.frmBaoCaoQLHD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvQLHD;
    }
}