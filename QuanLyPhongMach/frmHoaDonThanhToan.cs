using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyPhongMach.DAO;
using QuanLyPhongMach.DTO;
using DevExpress.XtraReports.UI;

namespace QuanLyPhongMach
{
    public partial class frmHoaDonThanhToan : DevExpress.XtraEditors.XtraForm
    {
        public frmHoaDonThanhToan()
        {
            InitializeComponent();
        }

        int tienThuoc;

        #region RÀNG BUỘC CÁC KÍ TỰ TRONG Ô TEXTBOX
        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void txtTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }
        #endregion

        // Load dữ liệu
        public void LoadData()
        {
            ChiTietHoaDon dh = HoaDon.LayHoaDon(frmPhieuKhamBenh.MaPK);
            txtHoTen.Text = dh.TenBN;
            txtTienKham.Text = dh.TienKham.ToString();
            txtTienThuoc.Text = dh.TienThuoc.ToString();

            if (ckbSuDungThuoc.Checked == true)
            {
                txtSum.Text = (Convert.ToInt32(txtTienThuoc.Text) + Convert.ToInt32(txtTienKham.Text)).ToString();
            }
            else
                txtSum.Text = Convert.ToInt32(txtTienKham.Text).ToString();
        }

        private void frmHoaDonThanhToan_Load(object sender, EventArgs e)
        {
            lblThongBao.Text = "";
            LoadData();
            tienThuoc = int.Parse(txtTienThuoc.Text.ToString());
            if (Convert.ToInt32(txtTienThuoc.Text) == 0)
            {
                ckbSuDungThuoc.Checked = false;
            }
        }

        // kiểm tra sử dụng thuốc
        private void ckbSuDungThuoc_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSuDungThuoc.Checked == true)
            {
                txtTienThuoc.Text = tienThuoc.ToString();
                txtSum.Text = (Convert.ToInt32(txtTienThuoc.Text) + Convert.ToInt32(txtTienKham.Text)).ToString();
            }
            else
            {
                txtTienThuoc.Text = "0";
                txtSum.Text = Convert.ToInt32(txtTienKham.Text).ToString();
            }
        }

        #region SỰ KIỆN CÁC BUTTON
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text != null)
            {
                try
                {
                    HoaDon.CapNhapHoaDon(frmPhieuKhamBenh.MaPK, int.Parse(txtTienThuoc.Text), int.Parse(txtTienKham.Text));

                    if (ckbSuDungThuoc.Checked == true)
                        txtSum.Text = (Convert.ToInt32(txtTienThuoc.Text) + Convert.ToInt32(txtTienKham.Text)).ToString();
                    else
                        txtSum.Text = Convert.ToInt32(txtTienKham.Text).ToString();

                    lblThongBao.ForeColor = Color.Green;
                    lblThongBao.Text = "Cập nhập hoá đơn thành công";
                    btnThoat.Focus();
                }
                catch
                {
                    lblThongBao.Text = "Dữ liệu nhập vào không hợp lệ";
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                rptHoaDonThanhToan report = new rptHoaDonThanhToan();
                string TrieuChung;
                string LoaiBenh;
                PhieuKham.LayDuLieu(frmPhieuKhamBenh.MaPK, out LoaiBenh, out TrieuChung);
                TongHopHoaDonChiTiet tongHopHoaDonChiTiet = new TongHopHoaDonChiTiet(HoaDon.LayHoaDon(frmPhieuKhamBenh.MaPK).TenBN, HoaDon.LayHoaDon(frmPhieuKhamBenh.MaPK).NgayKham, TrieuChung, LoaiBenh, HoaDon.LayHoaDon(frmPhieuKhamBenh.MaPK).TienKham, HoaDon.LayHoaDon(frmPhieuKhamBenh.MaPK).TienThuoc);
                report.DataSource = tongHopHoaDonChiTiet;
                report.BinData();
                ReportPrintTool tool = new ReportPrintTool(report);
                report.ShowPreviewDialog();
            }
            catch
            {
                lblThongBao.Text = "Không thể in hoá đơn";
            }
        }
        #endregion
    }
}