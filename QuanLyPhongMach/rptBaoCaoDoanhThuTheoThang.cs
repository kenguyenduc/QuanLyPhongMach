using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyPhongMach
{
    public partial class rptBaoCaoDoanhThuTheoThang : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBaoCaoDoanhThuTheoThang()
        {
            InitializeComponent();
        }
        public void BinData()
        {
            //lblNgay.DataBindings.Add("Text", DataSource, "ngaysinh").FormatString = "{0:dd/MM/yyyy}"
            lblStt.DataBindings.Add("Text", DataSource, "stt");
            lblNgayKham.DataBindings.Add("Text", DataSource, "NgayKham");
            lblSoBenhNhan.DataBindings.Add("Text", DataSource, "SoBN");
            lblDoanhThu.DataBindings.Add("Text", DataSource, "DoanhThu");

            //int day = DateTime.Now.Day;
            //int month = DateTime.Now.Month;
            //int year = DateTime.Now.Year;
            //lblThang.Text = "" + day + "/" + month + "/" + year;
        }
    }
}
