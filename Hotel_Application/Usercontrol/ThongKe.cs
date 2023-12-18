using Hotel_Application.Features;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Application.Usercontrol
{
    public partial class ThongKe : UserControl
    {
        SqlConnection conn = ConnectDB.connectstring;
        SqlCommand cmd;
        DataSet dataSet;
        SqlDataAdapter da;
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            cboSearch.SelectedIndex = 0;
        }

        private void cboSearch_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboSearch.SelectedIndex == 0)
            {
                conn.Open();
                string select = "SELECT KhachHang.MaKhachHang, KhachHang.Hoten, KhachHang.DiaChi, KhachHang.SoDienThoai, KhachHang.Email, HoaDon.NgayThue, HoaDon.NgayTra,HoaDon.TongTien from KhachHang inner join HoaDon on KhachHang.MaKhachHang = HoaDon.MaKhachHang";
                dataSet = new DataSet();
                da = new SqlDataAdapter(select, conn);
                da.Fill(dataSet, "KhachHang");
                dataGridView1.DataSource = dataSet.Tables["KhachHang"];
                conn.Close();
            }
            if (cboSearch.SelectedIndex == 1)
            {
                conn.Open();
                string select = "SELECT KhachHang.MaKhachHang, KhachHang.Hoten, KhachHang.DiaChi, KhachHang.SoDienThoai, KhachHang.Email, HoaDon.NgayThue, HoaDon.NgayTra,HoaDon.TongTien from KhachHang inner join HoaDon on KhachHang.MaKhachHang = HoaDon.MaKhachHang where NgayTra is null";
                dataSet = new DataSet();
                da = new SqlDataAdapter(select, conn);
                da.Fill(dataSet, "KhachHang");
                dataGridView1.DataSource = dataSet.Tables["KhachHang"];
                conn.Close();
            }
            if (cboSearch.SelectedIndex == 2)
            {
                conn.Open();
                string select = "SELECT KhachHang.MaKhachHang, KhachHang.Hoten, KhachHang.DiaChi, KhachHang.SoDienThoai, KhachHang.Email, HoaDon.NgayThue, HoaDon.NgayTra,HoaDon.TongTien from KhachHang inner join HoaDon on KhachHang.MaKhachHang = HoaDon.MaKhachHang where NgayTra is not null";
                dataSet = new DataSet();
                da = new SqlDataAdapter(select, conn);
                da.Fill(dataSet, "KhachHang");
                dataGridView1.DataSource = dataSet.Tables["KhachHang"];
                conn.Close();
            }
        }
    }
}
