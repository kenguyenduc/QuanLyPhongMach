namespace QuanLyPhongMach
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMKCu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMKMoi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNhapLaiMK = new DevExpress.XtraEditors.TextEdit();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.lblThongBao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKCu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapLaiMK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mật khẩu cũ";
            // 
            // txtMKCu
            // 
            this.txtMKCu.Location = new System.Drawing.Point(205, 20);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtMKCu.Properties.Appearance.Options.UseFont = true;
            this.txtMKCu.Size = new System.Drawing.Size(220, 26);
            this.txtMKCu.TabIndex = 1;
            this.txtMKCu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(96, 19);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Mật khẩu mới";
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Location = new System.Drawing.Point(205, 61);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtMKMoi.Properties.Appearance.Options.UseFont = true;
            this.txtMKMoi.Size = new System.Drawing.Size(220, 26);
            this.txtMKMoi.TabIndex = 2;
            this.txtMKMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 111);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(161, 19);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Nhập lại mật khẩu mới";
            // 
            // txtNhapLaiMK
            // 
            this.txtNhapLaiMK.Location = new System.Drawing.Point(205, 108);
            this.txtNhapLaiMK.Name = "txtNhapLaiMK";
            this.txtNhapLaiMK.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtNhapLaiMK.Properties.Appearance.Options.UseFont = true;
            this.txtNhapLaiMK.Size = new System.Drawing.Size(220, 26);
            this.txtNhapLaiMK.TabIndex = 3;
            this.txtNhapLaiMK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Location = new System.Drawing.Point(75, 183);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(98, 28);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(282, 183);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 28);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(93, 149);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(15, 19);
            this.lblThongBao.TabIndex = 11;
            this.lblThongBao.Text = "|";
            // 
            // frmDoiMatKhau
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 232);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtNhapLaiMK);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtMKCu);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMKCu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapLaiMK.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMKCu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtMKMoi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtNhapLaiMK;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.Label lblThongBao;
    }
}