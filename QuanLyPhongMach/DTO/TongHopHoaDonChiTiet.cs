using System;

namespace QuanLyPhongMach.DTO
{
    class TongHopHoaDonChiTiet
    {
        #region(Các thuộc tính và phương thức khởi tạo)

        string tenBN;
        DateTime ngayKham;
        string trieuChung;
        string loaiBenh;
        int tienKham;
        int tienThuoc;

        public TongHopHoaDonChiTiet()
        { }
        public TongHopHoaDonChiTiet(string TenBN, DateTime NgayKham, string TrieuChung, string LoaiBenh, int TienKham, int TienThuoc)
        {
            tenBN = TenBN;
            ngayKham = NgayKham;
            trieuChung = TrieuChung;
            loaiBenh = LoaiBenh;
            tienKham = TienKham;
            tienThuoc = TienThuoc;
        }

        public string TenBN
        {
            get { return tenBN; }
            set { tenBN = value; }
        }

        public DateTime NgayKham
        {
            get { return ngayKham; }
            set { ngayKham = value; }
        }

        public int TienKham
        {
            get { return tienKham; }
            set { tienKham = value; }
        }

        public int TienThuoc
        {
            get { return tienThuoc; }
            set { tienThuoc = value; }
        }

        public string LoaiBenh
        {
            get { return loaiBenh; }
            set { loaiBenh = value; }
        }

        public string TrieuChung
        {
            get { return trieuChung; }
            set { trieuChung = value; }
        }
        #endregion
    }
}
