namespace QuanLyPhongMach
{
    partial class frmThemToaThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemToaThuoc));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.cbxThuoc = new System.Windows.Forms.ComboBox();
            this.cbxDonVi = new System.Windows.Forms.ComboBox();
            this.txtCachDung = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(49, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(248, 33);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "THÊM TOA THUỐC";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(16, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tên thuốc";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(16, 107);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 19);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Đơn vị";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(16, 190);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 19);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Cách dùng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(113, 147);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Properties.Appearance.Options.UseFont = true;
            this.txtSoLuong.Size = new System.Drawing.Size(222, 26);
            this.txtSoLuong.TabIndex = 3;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(16, 150);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(64, 19);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Số lượng";
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = global::QuanLyPhongMach.Properties.Resources.cancel_16x163;
            this.btnThoat.Location = new System.Drawing.Point(221, 267);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 28);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = global::QuanLyPhongMach.Properties.Resources.addfile_16x162;
            this.btnThem.Location = new System.Drawing.Point(28, 267);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 28);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.BackColor = System.Drawing.SystemColors.Control;
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(112, 223);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(14, 20);
            this.lblThongBao.TabIndex = 49;
            this.lblThongBao.Text = "|";
            // 
            // cbxThuoc
            // 
            this.cbxThuoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxThuoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxThuoc.BackColor = System.Drawing.Color.White;
            this.cbxThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxThuoc.ForeColor = System.Drawing.Color.Black;
            this.cbxThuoc.FormattingEnabled = true;
            this.cbxThuoc.Items.AddRange(new object[] {
            "Levothyroxine",
            "Memantine",
            "Donepezil",
            "Zolpidem",
            "Vitamin A",
            "Vitamin D",
            "Vitamin C",
            "Vitamin E",
            "Potassium"});
            this.cbxThuoc.Location = new System.Drawing.Point(113, 62);
            this.cbxThuoc.Name = "cbxThuoc";
            this.cbxThuoc.Size = new System.Drawing.Size(222, 28);
            this.cbxThuoc.TabIndex = 1;
            this.cbxThuoc.SelectedIndexChanged += new System.EventHandler(this.cbxThuoc_SelectedIndexChanged);
            // 
            // cbxDonVi
            // 
            this.cbxDonVi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxDonVi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxDonVi.BackColor = System.Drawing.Color.White;
            this.cbxDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDonVi.ForeColor = System.Drawing.Color.Black;
            this.cbxDonVi.FormattingEnabled = true;
            this.cbxDonVi.Items.AddRange(new object[] {
            "Viên",
            "Chai"});
            this.cbxDonVi.Location = new System.Drawing.Point(113, 104);
            this.cbxDonVi.Name = "cbxDonVi";
            this.cbxDonVi.Size = new System.Drawing.Size(222, 28);
            this.cbxDonVi.TabIndex = 2;
            // 
            // txtCachDung
            // 
            this.txtCachDung.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCachDung.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtCachDung.BackColor = System.Drawing.Color.White;
            this.txtCachDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCachDung.ForeColor = System.Drawing.Color.Black;
            this.txtCachDung.FormattingEnabled = true;
            this.txtCachDung.Items.AddRange(new object[] {
            "Sáng 1 viên, chiều 1viên sau khi ăn",
            "Sáng 2 viên, chiều 1 viên sau khi ăn",
            "Tối 2 viên sau khi ăn",
            "Sáng trưa chiều mỗi buổi 1 viên sau khi ăn"});
            this.txtCachDung.Location = new System.Drawing.Point(113, 184);
            this.txtCachDung.Name = "txtCachDung";
            this.txtCachDung.Size = new System.Drawing.Size(222, 28);
            this.txtCachDung.TabIndex = 4;
            // 
            // frmThemToaThuoc
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 307);
            this.Controls.Add(this.txtCachDung);
            this.Controls.Add(this.cbxDonVi);
            this.Controls.Add(this.cbxThuoc);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThemToaThuoc";
            this.Text = "Thêm toa thuốc";
            this.Load += new System.EventHandler(this.frmThemToaThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.ComboBox cbxThuoc;
        private System.Windows.Forms.ComboBox cbxDonVi;
        private System.Windows.Forms.ComboBox txtCachDung;
    }
}