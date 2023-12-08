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
namespace Hotel_Application
{
    public partial class NhanVien : Form
    {
        //sql
        SqlConnection conn = ConnectDB.connectstring;
        SqlCommand cmd;

        //sql

        public NhanVien()
        {
            InitializeComponent();
            btnHome.BackColor = Color.Gray;
            btnHome.ForeColor = Color.White;
            trangChu1.Show();
            trangChu1.BringToFront();
           
        }

        private void btnDangKyHoaDon_Click(object sender, EventArgs e)
        {
            ThemDichVuVaoHoaDon.BackColor = Color.Transparent;
            ThemDichVuVaoHoaDon.ForeColor = Color.Black;
            btnHome.BackColor = Color.Transparent;
            btnHome.ForeColor = Color.Black;
            btnThongKe.BackColor = Color.Transparent;
            btnThongKe.ForeColor = Color.Black;
            btnHoaDon.BackColor = Color.Transparent;
            btnHoaDon.ForeColor = Color.Black;

            
            btnDangKyHoaDon.BackColor = Color.Gray;
            btnDangKyHoaDon.ForeColor = Color.White;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //UI Feature Button
            btnDangKyHoaDon.BackColor = Color.Transparent;
            btnDangKyHoaDon.ForeColor = Color.Black;
            ThemDichVuVaoHoaDon.BackColor = Color.Transparent;
            ThemDichVuVaoHoaDon.ForeColor = Color.Black;
            btnThongKe.BackColor = Color.Transparent;
            btnThongKe.ForeColor = Color.Black;
            btnHoaDon.BackColor = Color.Transparent;
            btnHoaDon.ForeColor = Color.Black;

            btnHome.BackColor = Color.Gray;
            btnHome.ForeColor = Color.White;
            //UI Feature Button
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            //UI Feature Button
            btnDangKyHoaDon.BackColor = Color.Transparent;
            btnDangKyHoaDon.ForeColor = Color.Black;
            btnHome.BackColor = Color.Transparent;
            btnHome.ForeColor = Color.Black;
            btnThongKe.BackColor = Color.Transparent;
            btnThongKe.ForeColor = Color.Black;
            ThemDichVuVaoHoaDon.BackColor = Color.Transparent;
            ThemDichVuVaoHoaDon.ForeColor = Color.Black;

            btnHoaDon.BackColor = Color.Gray;
            btnHoaDon.ForeColor = Color.White; 
            //UI Feature Button
        }

       

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            btnDangKyHoaDon.BackColor = Color.Transparent;
            btnDangKyHoaDon.ForeColor = Color.Black;
            btnHome.BackColor = Color.Transparent;
            btnHome.ForeColor = Color.Black;
            ThemDichVuVaoHoaDon.BackColor = Color.Transparent;
            ThemDichVuVaoHoaDon.ForeColor = Color.Black;
            btnHoaDon.BackColor = Color.Transparent;
            btnHoaDon.ForeColor = Color.Black;

            btnThongKe.BackColor = Color.Gray;
            btnThongKe.ForeColor = Color.White;
        }

        private void ThemDichVuVaoHoaDon_Click(object sender, EventArgs e)
        {
            btnDangKyHoaDon.BackColor = Color.Transparent;
            btnDangKyHoaDon.ForeColor = Color.Black;
            btnHome.BackColor = Color.Transparent;
            btnHome.ForeColor = Color.Black;
            btnThongKe.BackColor = Color.Transparent;
            btnThongKe.ForeColor = Color.Black;
            btnHoaDon.BackColor = Color.Transparent;
            btnHoaDon.ForeColor = Color.Black;

            ThemDichVuVaoHoaDon.BackColor = Color.Gray;
            ThemDichVuVaoHoaDon.ForeColor = Color.White;
        }

      
    }
}
