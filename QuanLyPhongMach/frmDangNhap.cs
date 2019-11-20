using QuanLyPhongMach.DAO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyPhongMach
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        static DuLieu dl = new DuLieu();
        public frmDangNhap()
        {
            InitializeComponent();
            lblThongBao.Text = "";
        }
        #region BỎ KÍ TỰ THỪA
        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }
        #endregion

        #region SỰ KIỆN CÁC BUTTON
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = dl.Connect();
            string sql = "select MaND, TenDangNhap,ChucVu from NguoiDung where TenDangNhap = '" + txtTenDangNhap.Text + "' and MatKhau = '" + txtMatKhau.Text + "'";
            DataTable dt = NguoiDung.GetDataTable(conn, sql);
            if (txtMatKhau.Text != "" && txtTenDangNhap.Text != "")
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        PhanQuyenNguoiDung.TenDangNhap = dr["TenDangNhap"].ToString();
                        PhanQuyenNguoiDung.ChucVu = dr["ChucVu"].ToString();
                        frmMain f = new frmMain();
                        f.OnOff(this.ParentForm);
                        this.Close();
                    }
                }
                else
                {
                    txtTenDangNhap.Text = "";
                    txtMatKhau.Text = "";
                    txtTenDangNhap.Focus();
                    lblThongBao.Text = "Tên tài khoản hoặc mật khẩu không chính xác";
                }
            }
            else
            {
                txtTenDangNhap.Text = "";
                txtMatKhau.Text = "";
                txtTenDangNhap.Focus();
                lblThongBao.Text = "Vui lòng nhập đầy đủ thông tin!";
            }

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            lblThongBao.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmServerName obj = new frmServerName();
            obj.ShowDialog();
        }

        #region UNIT TEST
        public string Login(string name, string pass)
        {
            if (name != "" && pass != "")
            {
                SqlConnection conn = dl.Connect();
                string sql = "select MaND, TenDangNhap,ChucVu from NguoiDung where TenDangNhap = '" + name + "' and MatKhau = '" + pass + "'";
                DataTable dt = NguoiDung.GetDataTable(conn, sql);
                if (dt.Rows.Count > 0)
                {
                    return "successed";
                }
                else
                {
                    return "failed";
                }
            }
            else
            {
                return "failed";

            }
        }
        #endregion
    }
}