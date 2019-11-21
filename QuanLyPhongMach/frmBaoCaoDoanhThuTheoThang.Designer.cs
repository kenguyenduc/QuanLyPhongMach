﻿namespace QuanLyPhongMach
{
    partial class frmBaoCaoDoanhThuTheoThang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoDoanhThuTheoThang));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbxThang = new System.Windows.Forms.ComboBox();
            this.bttXemBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.numNam = new System.Windows.Forms.NumericUpDown();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.lblThongBao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblThongBao);
            this.panelControl1.Controls.Add(this.cbxThang);
            this.panelControl1.Controls.Add(this.bttXemBaoCao);
            this.panelControl1.Controls.Add(this.numNam);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(665, 139);
            this.panelControl1.TabIndex = 0;
            // 
            // cbxThang
            // 
            this.cbxThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxThang.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbxThang.FormattingEnabled = true;
            this.cbxThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbxThang.Location = new System.Drawing.Point(126, 68);
            this.cbxThang.Name = "cbxThang";
            this.cbxThang.Size = new System.Drawing.Size(121, 27);
            this.cbxThang.TabIndex = 12;
            this.cbxThang.SelectedIndexChanged += new System.EventHandler(this.cbxThang_SelectedIndexChanged);
            // 
            // bttXemBaoCao
            // 
            this.bttXemBaoCao.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.bttXemBaoCao.Appearance.Options.UseFont = true;
            this.bttXemBaoCao.ImageOptions.Image = global::QuanLyPhongMach.Properties.Resources.print_16x161;
            this.bttXemBaoCao.Location = new System.Drawing.Point(507, 68);
            this.bttXemBaoCao.Name = "bttXemBaoCao";
            this.bttXemBaoCao.Size = new System.Drawing.Size(98, 28);
            this.bttXemBaoCao.TabIndex = 11;
            this.bttXemBaoCao.Text = "In";
            this.bttXemBaoCao.Click += new System.EventHandler(this.bttXemBaoCao_Click);
            // 
            // numNam
            // 
            this.numNam.Font = new System.Drawing.Font("Tahoma", 12F);
            this.numNam.Location = new System.Drawing.Point(372, 68);
            this.numNam.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numNam.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numNam.Name = "numNam";
            this.numNam.Size = new System.Drawing.Size(76, 27);
            this.numNam.TabIndex = 10;
            this.numNam.Value = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.numNam.ValueChanged += new System.EventHandler(this.numNam_ValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(319, 70);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 19);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Năm";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(61, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 19);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Tháng";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(167, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(298, 33);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "BÁO CÁO DOANH THU";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.dgvDoanhThu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 139);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(665, 194);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Doanh thu";
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoanhThu.Location = new System.Drawing.Point(2, 26);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.ReadOnly = true;
            this.dgvDoanhThu.Size = new System.Drawing.Size(661, 166);
            this.dgvDoanhThu.TabIndex = 0;
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(205, 110);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(15, 19);
            this.lblThongBao.TabIndex = 13;
            this.lblThongBao.Text = "|";
            // 
            // frmBaoCaoDoanhThuTheoThang
            // 
            this.AcceptButton = this.bttXemBaoCao;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 333);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBaoCaoDoanhThuTheoThang";
            this.Text = "Báo cáo doanh thu theo tháng";
            this.Load += new System.EventHandler(this.frmBaoCaoDoanhThuTheoThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbxThang;
        private DevExpress.XtraEditors.SimpleButton bttXemBaoCao;
        private System.Windows.Forms.NumericUpDown numNam;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.Label lblThongBao;
    }
}