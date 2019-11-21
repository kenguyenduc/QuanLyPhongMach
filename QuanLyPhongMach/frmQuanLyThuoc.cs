using System;
using System.Drawing;
using QuanLyPhongMach.DAO;

namespace QuanLyPhongMach
{
    public partial class frmQuanLyThuoc : DevExpress.XtraEditors.XtraForm
    {
        public frmQuanLyThuoc()
        {
            InitializeComponent();
        }

        private void frmQuanLyThuoc_Load(object sender, EventArgs e)
        {
            lblThongBao.Text = "";
            LoadData();
        }

        void LoadData()
        {

            dgvDSThuoc.DataSource = Thuoc.LayThuoc();
            dgvDSThuoc.Columns[0].Visible = false;
            dgvDSThuoc.Columns["TenThuoc"].HeaderText = "Tên thuốc";
            dgvDSThuoc.Columns["DonVi"].HeaderText = "Đơn vị";
            dgvDSThuoc.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvDSThuoc.Columns[1].Width = 350;
            dgvDSThuoc.Columns[2].Width = 100;
            dgvDSThuoc.Columns[3].Width = 100;

            if (dgvDSThuoc.RowCount < 1)
            {
                btnSua.Enabled = false;
            }
            else
            {
                btnSua.Enabled = true;
            }

            lblThongBao.Text = "";
        }


        void XoaTextbox()
        {
            cbxDonVi.Text = "";
            txtTenThuoc.Text = "";
            numDonGia.Value = numDonGia.Minimum;
            txtTenThuoc.Focus();
            lblThongBao.Text = "";
        }

        #region SỰ KIỆN CỦA CÁC BUTTON
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenThuoc.Text.Trim() != "")
                {

                    string TenThuoc = txtTenThuoc.Text;
                    string DonVi = cbxDonVi.Text;
                    int DonGia = (int)numDonGia.Value;
                    if (Thuoc.TimThuoc(TenThuoc, DonGia) == 0)
                    {
                        Thuoc.ThemThuoc(TenThuoc, DonVi, DonGia);
                        LoadData();

                        lblThongBao.ForeColor = Color.Green;
                        lblThongBao.Text = "Thêm mới thành công!";
                    }
                    else
                    {
                        XoaTextbox();
                    }

                }
                else
                {
                    lblThongBao.Text = "Bạn chưa nhập tên thuốc";
                    txtTenThuoc.Focus();
                }

            }
            catch
            {
                lblThongBao.Text = "Thêm bị lỗi";
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int MaThuoc = (int)dgvDSThuoc["MaThuoc", dgvDSThuoc.CurrentCell.RowIndex].Value;
                string TenThuoc = txtTenThuoc.Text;
                string DonVi = cbxDonVi.Text;
                int DonGia = (int)numDonGia.Value;
                if (TenThuoc.Trim() != "")
                {
                    Thuoc.CapNhatThuoc(MaThuoc, TenThuoc, DonVi, DonGia);
                    LoadData();

                    lblThongBao.ForeColor = Color.Green;
                    lblThongBao.Text = "Đã cập nhập!";
                }
                else
                {
                    lblThongBao.Text = "Bạn chưa nhập tên thuốc";
                    txtTenThuoc.Focus();
                }
            }
            catch
            {
                lblThongBao.Text = "Dữ liệu không hợp lệ";
                txtTenThuoc.Focus();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            XoaTextbox();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void dgvDSThuoc_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                int a = dgvDSThuoc.CurrentCell.RowIndex;
                txtTenThuoc.Text = dgvDSThuoc["TenThuoc", a].Value.ToString();
                cbxDonVi.Text = dgvDSThuoc["DonVi", a].Value.ToString();
                numDonGia.Value = decimal.Parse(dgvDSThuoc["DonGia", a].Value.ToString());
            }
            catch
            {
            }
        }
    }
}