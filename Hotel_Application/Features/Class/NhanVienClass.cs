using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Application.Features.Class
{
    public class NhanVienClass
    {
        private int maNV;
        private string tenNV;
        private int sDT;
        private string emailNV;
        private string gioiTinh;
        private string taiKhoan;
        private string matKhau;
        private DateTime ngaySinh;
        private DateTime ngayVaoLam;
        private int maCV;
        /// <summary>
        /// 
        /// </summary>
        public int MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public int SDT { get => sDT; set => sDT = value; }
        public string EmailNV { get => emailNV; set => emailNV = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public DateTime NgayVaoLam { get => ngayVaoLam; set => ngayVaoLam = value; }
        public int MaCV { get => maCV; set => maCV = value; }

        public NhanVienClass()
        {
            MaNV = 0;
            TenNV = "";
            SDT = 0;
            EmailNV = "";
            GioiTinh = "Nam";
            TaiKhoan = "haha";
            MatKhau = "hehe";
            NgaySinh = new DateTime(2003, 04, 11);
            NgayVaoLam = new DateTime(2023, 12, 08);
        }
    }
}
