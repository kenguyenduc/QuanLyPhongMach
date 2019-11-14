using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyPhongMach
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public void SkinDefault()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Valentine";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SkinDefault();
        }

        private void btnBenhNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool _IsActive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                if (form.GetType() == typeof(frmDanhSachKhamBenh))
                {
                    form.Activate();
                    _IsActive = true;
                }
            }
            if (!_IsActive)
            {
                frmDanhSachKhamBenh frm = new frmDanhSachKhamBenh();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnPhieuKham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool _IsActive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                if (form.GetType() == typeof(frmPhieuKhamBenh))
                {
                    form.Activate();
                    _IsActive = true;
                }
            }
            if (!_IsActive)
            {
                frmPhieuKhamBenh frm = new frmPhieuKhamBenh();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
