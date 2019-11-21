using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyPhongMach.DAO;

namespace QuanLyPhongMach
{
    public partial class frmDanhSachBenhNhan : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSachBenhNhan()
        {
            InitializeComponent();
        }

        private void frmDanhSachBenhNhan_Load(object sender, EventArgs e)
        {
            lblThongBao.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text != "")
            {
                try
                {
                    dgvDSBenhNhan.DataSource = PhieuKham.DSKhamBenh(txtHoTen.Text);
                    if (dgvDSBenhNhan.RowCount != 0)
                    {
                        dgvDSBenhNhan.Columns["STT"].HeaderText = "STT";
                        dgvDSBenhNhan.Columns["HoTen"].HeaderText = "Họ & Tên";
                        dgvDSBenhNhan.Columns["NgayKham"].HeaderText = "Ngày khám";
                        dgvDSBenhNhan.Columns["LoaiBenh"].HeaderText = "Loại bệnh";
                        dgvDSBenhNhan.Columns["TrieuChung"].HeaderText = "Triệu chứng";

                        dgvDSBenhNhan.Columns["STT"].Width = 50;
                        dgvDSBenhNhan.Columns["HoTen"].Width = 150;
                        dgvDSBenhNhan.Columns["NgayKham"].Width = 150;
                        dgvDSBenhNhan.Columns["LoaiBenh"].Width = 200;
                        dgvDSBenhNhan.Columns["TrieuChung"].Width = 350;
                    }
                    else
                    {
                        lblThongBao.ForeColor = Color.Red;
                        lblThongBao.Text = "Không tìm thấy kết quả nào!";
                    }
                }
                catch
                {
                    MessageBox.Show("Tìm kiếm dữ liệu bị lỗi");
                }
            }
            else
            {
                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Text = "Điền tên bệnh nhân";
                txtHoTen.Focus();
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            dgvDSBenhNhan.DataSource = PhieuKham.DSKhamBenh(txtHoTen.Text);

            dgvDSBenhNhan.Columns["STT"].HeaderText = "STT";
            dgvDSBenhNhan.Columns["HoTen"].HeaderText = "Họ & Tên";
            dgvDSBenhNhan.Columns["NgayKham"].HeaderText = "Ngày khám";
            dgvDSBenhNhan.Columns["LoaiBenh"].HeaderText = "Loại bệnh";
            dgvDSBenhNhan.Columns["TrieuChung"].HeaderText = "Triệu chứng";

            dgvDSBenhNhan.Columns["STT"].Width = 50;
            dgvDSBenhNhan.Columns["HoTen"].Width = 150;
            dgvDSBenhNhan.Columns["NgayKham"].Width = 150;
            dgvDSBenhNhan.Columns["LoaiBenh"].Width = 200;
            dgvDSBenhNhan.Columns["TrieuChung"].Width = 350;
        }
        public string Search(string name)
        {
            if (name != "")
            {
                if (PhieuKham.DSKhamBenh(name).Count() != 0)
                    return "successed";
                else
                    return "failed";
            }
            else
                return "failed";
        }
    }
}