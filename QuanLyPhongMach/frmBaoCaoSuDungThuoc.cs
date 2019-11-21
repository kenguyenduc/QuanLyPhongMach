using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyPhongMach.DAO;
using DevExpress.XtraReports.UI;

namespace QuanLyPhongMach
{
    public partial class frmBaoCaoSuDungThuoc : DevExpress.XtraEditors.XtraForm
    {
        public frmBaoCaoSuDungThuoc()
        {
            InitializeComponent();
        }

        private void frmBaoCaoSuDungThuoc_Load(object sender, EventArgs e)
        {
            LoatData();
            lblThongBao.Text = "";
        }

        //Thang, nam mặc định khi load lên form là tháng, năm hiện tại
        int thang = DateTime.Now.Month;
        int nam = DateTime.Now.Year;

        //Hàm LoadData để load lại dữ liệu khi có sự thay đổi
        public void LoatData()
        {
            cbxThang.Text = thang.ToString();
            numNam.Value = nam;
            dgvDSThuoc.DataSource = BaoCaoThuoc.LayDuLieu(thang, nam);

            dgvDSThuoc.Columns["TenThuoc"].HeaderText = "Thuốc";
            dgvDSThuoc.Columns["DonVi"].HeaderText = "Đơn vị tính";
            dgvDSThuoc.Columns["TongSoLuong"].HeaderText = "Số lượng";
            dgvDSThuoc.Columns["SoLanDung"].HeaderText = "Số lần dùng";

            dgvDSThuoc.Columns["TenThuoc"].Width = 200;
            dgvDSThuoc.Columns["DonVi"].Width = 80;
            dgvDSThuoc.Columns["TongSoLuong"].Width = 200;
            dgvDSThuoc.Columns["SoLanDung"].Width = 200;
        }

        private void cbxThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            thang = int.Parse(cbxThang.Text);
            LoatData();
        }

        private void numNam_ValueChanged(object sender, EventArgs e)
        {
            nam = (int)numNam.Value;
            LoatData();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            cbxThang.Text = thang.ToString();
            numNam.Value = nam;


            if (nam <= DateTime.Now.Year)
            {
                if (thang <= DateTime.Now.Month)
                {
                    rptBaoCaoSuDungThuoc report = new rptBaoCaoSuDungThuoc();
                    report.DataSource = BaoCaoThuoc.LayDuLieu(thang, nam);
                    report.BinData();
                    ReportPrintTool tool = new ReportPrintTool(report);
                    report.ShowPreviewDialog();
                }
                else
                {
                    lblThongBao.ForeColor = Color.Red;
                    lblThongBao.Text = "Tháng không tồn tại";
                }
            }
            else
            {

                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Text = "Năm không tồn tại";
                numNam.Focus();
            }
        }

        #region UNIT TEST
        public string Report(int month, int year)
        {
            if (year <= DateTime.Now.Year)
            {
                if (month <= DateTime.Now.Month)
                {
                    return "successed";
                }
                else
                    return "failed";
            }
            else
                return "failed";
        }
        #endregion

        private void numNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsNumber(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }
    }
}