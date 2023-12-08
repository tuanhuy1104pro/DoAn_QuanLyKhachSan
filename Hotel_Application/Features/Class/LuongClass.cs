using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Application.Features.Class
{
    public class LuongClass
    {
        private int soNgayNghi;
        private double tienLuong;
        private int maNV;

        public int SoNgayNghi { get => soNgayNghi; set => soNgayNghi = value; }
        public double TienLuong { get => tienLuong; set => tienLuong = value; }
        public int MaNV { get => maNV; set => maNV = value; }
        public LuongClass() {
            SoNgayNghi = 0;
            tienLuong = 0f;
        }
    }
}
