namespace QuanLyPhongMach
{
    partial class frmHoaDonThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDonThanhToan));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTienKham = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTienThuoc = new DevExpress.XtraEditors.TextEdit();
            this.ckbSuDungThuoc = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtSum = new DevExpress.XtraEditors.TextEdit();
            this.dtpNgayKham = new System.Windows.Forms.DateTimePicker();
            this.btnInHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.lblThongBao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienKham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienThuoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbSuDungThuoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(237, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(324, 33);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "HOÁ ĐƠN THANH TOÁN";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(115, 95);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtHoTen.Properties.Appearance.Options.UseFont = true;
            this.txtHoTen.Size = new System.Drawing.Size(199, 26);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 98);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Họ tên";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(18, 133);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 19);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Tiền khám";
            // 
            // txtTienKham
            // 
            this.txtTienKham.Location = new System.Drawing.Point(115, 130);
            this.txtTienKham.Name = "txtTienKham";
            this.txtTienKham.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTienKham.Properties.Appearance.Options.UseFont = true;
            this.txtTienKham.Size = new System.Drawing.Size(199, 26);
            this.txtTienKham.TabIndex = 2;
            this.txtTienKham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTien_KeyPress);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(365, 98);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(80, 19);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Ngày khám";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(365, 133);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(75, 19);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Tiền thuốc";
            // 
            // txtTienThuoc
            // 
            this.txtTienThuoc.Location = new System.Drawing.Point(462, 130);
            this.txtTienThuoc.Name = "txtTienThuoc";
            this.txtTienThuoc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTienThuoc.Properties.Appearance.Options.UseFont = true;
            this.txtTienThuoc.Size = new System.Drawing.Size(199, 26);
            this.txtTienThuoc.TabIndex = 4;
            this.txtTienThuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTien_KeyPress);
            // 
            // ckbSuDungThuoc
            // 
            this.ckbSuDungThuoc.EditValue = true;
            this.ckbSuDungThuoc.Location = new System.Drawing.Point(115, 51);
            this.ckbSuDungThuoc.Name = "ckbSuDungThuoc";
            this.ckbSuDungThuoc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ckbSuDungThuoc.Properties.Appearance.Options.UseFont = true;
            this.ckbSuDungThuoc.Properties.Caption = "Có sử dụng thuốc";
            this.ckbSuDungThuoc.Size = new System.Drawing.Size(199, 23);
            this.ckbSuDungThuoc.TabIndex = 2;
            this.ckbSuDungThuoc.CheckedChanged += new System.EventHandler(this.ckbSuDungThuoc_CheckedChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(227, 187);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(68, 19);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Tổng tiền";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(307, 184);
            this.txtSum.Name = "txtSum";
            this.txtSum.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtSum.Properties.Appearance.Options.UseFont = true;
            this.txtSum.Properties.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(133, 26);
            this.txtSum.TabIndex = 1;
            // 
            // dtpNgayKham
            // 
            this.dtpNgayKham.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKham.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dtpNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKham.Location = new System.Drawing.Point(462, 96);
            this.dtpNgayKham.Name = "dtpNgayKham";
            this.dtpNgayKham.Size = new System.Drawing.Size(199, 27);
            this.dtpNgayKham.TabIndex = 3;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnInHoaDon.Appearance.Options.UseFont = true;
            this.btnInHoaDon.ImageOptions.Image = global::QuanLyPhongMach.Properties.Resources.print_16x16;
            this.btnInHoaDon.Location = new System.Drawing.Point(476, 248);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(116, 28);
            this.btnInHoaDon.TabIndex = 7;
            this.btnInHoaDon.Text = "In hoá đơn";
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = global::QuanLyPhongMach.Properties.Resources.cancel_16x162;
            this.btnThoat.Location = new System.Drawing.Point(307, 248);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 28);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.Image = global::QuanLyPhongMach.Properties.Resources.save_16x16;
            this.btnLuu.Location = new System.Drawing.Point(115, 248);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(98, 28);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(199, 218);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(11, 18);
            this.lblThongBao.TabIndex = 29;
            this.lblThongBao.Text = "|";
            // 
            // frmHoaDonThanhToan
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 292);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.dtpNgayKham);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.ckbSuDungThuoc);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txtTienThuoc);
            this.Controls.Add(this.txtTienKham);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHoaDonThanhToan";
            this.Text = "Hoá đơn thanh toán";
            this.Load += new System.EventHandler(this.frmHoaDonThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienKham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienThuoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbSuDungThuoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTienKham;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtTienThuoc;
        private DevExpress.XtraEditors.CheckEdit ckbSuDungThuoc;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtSum;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnInHoaDon;
        private System.Windows.Forms.DateTimePicker dtpNgayKham;
        private System.Windows.Forms.Label lblThongBao;
    }
}