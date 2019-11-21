using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyPhongMach
{
    public partial class rptBaoCaoSuDungThuoc : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBaoCaoSuDungThuoc()
        {
            InitializeComponent();
        }
        public void BinData()
        {
            lblStt.DataBindings.Add("Text", DataSource, "STT");
            lblTenThuoc.DataBindings.Add("Text", DataSource, "TenThuoc");
            lblDonViTinh.DataBindings.Add("Text", DataSource, "DonVi");
            lblSoLuong.DataBindings.Add("Text", DataSource, "TongSoLuong");
            lblSoLanDung.DataBindings.Add("Text", DataSource, "SoLanDung");
        }
    }
}
