using Hotel_Application.Features.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Hotel_Application.Features;
using System.Xml;
namespace Hotel_Application
{
    public partial class QuanLyHoaDon : UserControl
    {
        
        SqlConnection conn = ConnectDB.connectstring;
        SqlCommand cmd;
        public QuanLyHoaDon()
        {
            
            InitializeComponent();
           
          
        }


        
        private void txtMaHoaDon_Click(object sender, EventArgs e)
        {
            txtMaHoaDon.Clear();
        }

        private void txtMaHoaDon_Leave(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = "Mã Hóa Đơn Hoặc Tên Khách Hàng";
        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            conn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select * from HoaDon", conn);
            da.Fill(ds,"HoaDon");
            dgvHoaDon.DataSource = ds.Tables["HoaDon"];


            conn.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select * from HoaDon", conn);
            da.Fill(ds, "HoaDon");
            dgvHoaDon.DataSource = ds.Tables["HoaDon"];


            conn.Close();
        }
        private void lbTimHoaDon_Click(object sender, EventArgs e)
        {
            conn.Open();
            KhachHangClass doituongkhachhang = new KhachHangClass();
            DataSet ds = new DataSet();
            if(IsAllDigits(txtMaHoaDon.Text))
            {

                SqlDataAdapter da = new SqlDataAdapter($"select*from HoaDon\r\nwhere HoaDon.MaHoaDon ='{txtMaHoaDon.Text}'", conn);
                da.Fill(ds, "A");
                dgvHoaDon.DataSource = ds.Tables["A"];

            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter($"select*from HoaDon\r\nwhere MaKhachHang in (\r\nselect MaKhachHang from KhachHang\r\nwhere KhachHang.HoTen = N'{txtMaHoaDon.Text}'\r\n)", conn);
                da.Fill(ds, "A");
                dgvHoaDon.DataSource = ds.Tables["A"];
            }    
            conn.Close();
        }
        public bool IsAllDigits(string input)
        {
            return input.All(char.IsDigit);
        }

    }
}
