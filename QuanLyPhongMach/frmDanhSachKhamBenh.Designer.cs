namespace QuanLyPhongMach
{
    partial class frmDanhSachKhamBenh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachKhamBenh));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dtpNgayKham = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.numSLBN = new System.Windows.Forms.NumericUpDown();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dgvDSBenhNhan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSLBN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dtpNgayKham);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.numSLBN);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(757, 107);
            this.panelControl2.TabIndex = 15;
            // 
            // dtpNgayKham
            // 
            this.dtpNgayKham.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKham.Location = new System.Drawing.Point(98, 61);
            this.dtpNgayKham.Name = "dtpNgayKham";
            this.dtpNgayKham.Size = new System.Drawing.Size(199, 26);
            this.dtpNgayKham.TabIndex = 1;
            this.dtpNgayKham.ValueChanged += new System.EventHandler(this.dtpNgayKham_ValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(182, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(338, 33);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "DANH SÁCH KHÁM BỆNH";
            // 
            // numSLBN
            // 
            this.numSLBN.Font = new System.Drawing.Font("Tahoma", 12F);
            this.numSLBN.Location = new System.Drawing.Point(659, 62);
            this.numSLBN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSLBN.Name = "numSLBN";
            this.numSLBN.Size = new System.Drawing.Size(69, 27);
            this.numSLBN.TabIndex = 2;
            this.numSLBN.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numSLBN.ValueChanged += new System.EventHandler(this.numSLBN_ValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 19);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Ngày khám";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(419, 66);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(225, 19);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Số bệnh nhân tối đa trong ngày";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.dtpNgaySinh);
            this.groupControl1.Controls.Add(this.lblThongBao);
            this.groupControl1.Controls.Add(this.btnThoat);
            this.groupControl1.Controls.Add(this.rdoNu);
            this.groupControl1.Controls.Add(this.btnThem);
            this.groupControl1.Controls.Add(this.btnSua);
            this.groupControl1.Controls.Add(this.btnHuy);
            this.groupControl1.Controls.Add(this.rdoNam);
            this.groupControl1.Controls.Add(this.btnXoa);
            this.groupControl1.Controls.Add(this.txtDiaChi);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtHoTen);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 107);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(757, 213);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "Thông tin bệnh nhân";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(456, 41);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(214, 26);
            this.dtpNgaySinh.TabIndex = 4;
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(246, 132);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(14, 24);
            this.lblThongBao.TabIndex = 55;
            this.lblThongBao.Text = "|";
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = global::QuanLyPhongMach.Properties.Resources.cancel_16x16;
            this.btnThoat.Location = new System.Drawing.Point(630, 169);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 28);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rdoNu.Location = new System.Drawing.Point(199, 90);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(48, 23);
            this.rdoNu.TabIndex = 7;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = global::QuanLyPhongMach.Properties.Resources.addfile_16x16;
            this.btnThem.Location = new System.Drawing.Point(215, 169);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 28);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.Image = global::QuanLyPhongMach.Properties.Resources.pencolor_16x16;
            this.btnSua.Location = new System.Drawing.Point(485, 169);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 28);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = global::QuanLyPhongMach.Properties.Resources.clear_16x16;
            this.btnHuy.Location = new System.Drawing.Point(84, 169);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(98, 28);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Xoá trắng";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Checked = true;
            this.rdoNam.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rdoNam.Location = new System.Drawing.Point(93, 92);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(60, 23);
            this.rdoNam.TabIndex = 6;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = global::QuanLyPhongMach.Properties.Resources.deletelist_16x161;
            this.btnXoa.Location = new System.Drawing.Point(349, 169);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 28);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(456, 90);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Size = new System.Drawing.Size(214, 26);
            this.txtDiaChi.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(370, 44);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(70, 19);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Ngày sinh";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(370, 97);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 19);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Địa chỉ";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(93, 41);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtHoTen.Properties.Appearance.Options.UseFont = true;
            this.txtHoTen.Size = new System.Drawing.Size(204, 26);
            this.txtHoTen.TabIndex = 3;
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(12, 92);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 19);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Giới tính";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 44);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 19);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Họ tên";
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.dgvDSBenhNhan);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 320);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(757, 152);
            this.groupControl3.TabIndex = 17;
            this.groupControl3.Text = "Danh sách bệnh nhân";
            // 
            // dgvDSBenhNhan
            // 
            this.dgvDSBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBenhNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSBenhNhan.Location = new System.Drawing.Point(2, 26);
            this.dgvDSBenhNhan.Name = "dgvDSBenhNhan";
            this.dgvDSBenhNhan.ReadOnly = true;
            this.dgvDSBenhNhan.Size = new System.Drawing.Size(753, 124);
            this.dgvDSBenhNhan.TabIndex = 0;
            this.dgvDSBenhNhan.CurrentCellChanged += new System.EventHandler(this.dgvDSBenhNhan_CurrentCellChanged);
            // 
            // frmDanhSachKhamBenh
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 472);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDanhSachKhamBenh";
            this.Text = "Danh sách khám bệnh";
            this.Load += new System.EventHandler(this.frmDanhSachKhamBenh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSLBN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBenhNhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.NumericUpDown numSLBN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.DateTimePicker dtpNgayKham;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DataGridView dgvDSBenhNhan;
    }
}