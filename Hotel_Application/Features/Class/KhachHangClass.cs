using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Application.Features.Class
{
    public class KhachHangClass
    {
        private int maKhachHang;
        private string hoTen;
        private string diaChi;
        private string soDienThoai;
        private string email;
        private string taiKhoan;
        private string mauKhau;

        public int MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string Email { get => email; set => email = value; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MauKhau { get => mauKhau; set => mauKhau = value; }
        public KhachHangClass()
        {
            MaKhachHang = 0;
            HoTen = " ";
            DiaChi = " ";
            SoDienThoai= " ";
            Email = " ";
            TaiKhoan = " ";
            MauKhau = " ";
        }
    }
}
