using System;

namespace QuanLyPhongMach.DTO
{
    class ChiTietBenhNhan
    {
        #region(Các thuộc tính và phương thức khởi tạo)
        int sTT;
        int maBN;
        string tenBN;
        bool gioiTinh;
        DateTime ngaySinh;
        string diaChi;

        public ChiTietBenhNhan(int MaBN, int STT, string TenBN, bool GioiTinh, DateTime NgaySinh, string DiaChi)
        {
            maBN = MaBN;
            sTT = STT;
            tenBN = TenBN;
            gioiTinh = GioiTinh;
            ngaySinh = NgaySinh;
            diaChi = DiaChi;
        }
        
        public int STT
        {
            get { return sTT; }
            set { sTT = value; }
        }

        public int MaBN
        {
            get { return maBN; }
            set { maBN = value; }
        }

        public string TenBN
        {
            get { return tenBN; }
            set { tenBN = value; }
        }

        public bool GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        #endregion
    }
}
