using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyPhongMach.DAO;
using DevExpress.XtraReports.UI;

namespace QuanLyPhongMach
{
    public partial class frmBaoCaoDoanhThuTheoThang : DevExpress.XtraEditors.XtraForm
    {
        public frmBaoCaoDoanhThuTheoThang()
        {
            InitializeComponent();
        }

        private void frmBaoCaoDoanhThuTheoThang_Load(object sender, EventArgs e)
        {
            LoadData();
            lblThongBao.Text = "";
        }

        int thang = DateTime.Now.Month;
        int nam = DateTime.Now.Year;
        
        public void LoadData()
        {

            cbxThang.Text = thang.ToString();
            numNam.Value = nam;
            dgvDoanhThu.DataSource = BaoCaoDoanhThu.LayDuLieu(thang, nam);

            dgvDoanhThu.Columns["NgayKham"].HeaderText = "Ngày";
            dgvDoanhThu.Columns["SoBN"].HeaderText = "Số bệnh nhân";
            dgvDoanhThu.Columns["DoanhThu"].HeaderText = "Doanh thu";

            dgvDoanhThu.Columns["NgayKham"].Width = 200;
            dgvDoanhThu.Columns["SoBN"].Width = 150;
            dgvDoanhThu.Columns["DoanhThu"].Width = 200;
        }

        private void cbxThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            thang = int.Parse(cbxThang.Text);
            LoadData();
        }

        private void numNam_ValueChanged(object sender, EventArgs e)
        {
            nam = (int)numNam.Value;
            LoadData();
        }

        private void bttXemBaoCao_Click(object sender, EventArgs e)
        {
            cbxThang.Text = thang.ToString();
            numNam.Value = nam;
            if (nam <= DateTime.Now.Year)
            {
                if (thang <= DateTime.Now.Month)
                {
                    rptBaoCaoDoanhThuTheoThang report = new rptBaoCaoDoanhThuTheoThang();
                    report.DataSource = BaoCaoDoanhThu.LayDuLieu(thang, nam);
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