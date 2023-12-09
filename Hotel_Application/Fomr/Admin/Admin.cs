using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Application
{
    
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            btnNhanVien.BackColor = Color.Gray;
            btnNhanVien.ForeColor = Color.White;
            nhanSu1.Show();
            nhanSu1.BringToFront();
        }
      
       
        

        private void btnRoom_Click(object sender, EventArgs e)
        {
            //UI Feature Button
           
            btnNhanVien.BackColor = Color.Transparent;
            btnNhanVien.ForeColor = Color.Black;
            btnService.BackColor = Color.Transparent;
            btnService.ForeColor = Color.Black;
            btnHoaDon.BackColor = Color.Transparent;
            btnHoaDon.ForeColor = Color.Black;
            btnThongKe.BackColor = Color.Transparent;
            btnThongKe.ForeColor = Color.Black;

            btnRoom.BackColor = Color.Gray;
            btnRoom.ForeColor= Color.White;
            //UI Feature Button
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            //UI Feature Button
            btnRoom.BackColor = Color.Transparent;
            btnRoom.ForeColor = Color.Black;
           
            btnService.BackColor = Color.Transparent;
            btnService.ForeColor = Color.Black;
            btnHoaDon.BackColor = Color.Transparent;
            btnHoaDon.ForeColor = Color.Black;
            btnThongKe.BackColor = Color.Transparent;
            btnThongKe.ForeColor = Color.Black;

            btnNhanVien.BackColor = Color.Gray;
            btnNhanVien.ForeColor = Color.White;
            //UI Feature Button
            nhanSu1.Show();
            nhanSu1.BringToFront();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            //UI Feature Button
            btnRoom.BackColor = Color.Transparent;
            btnRoom.ForeColor = Color.Black;
            btnNhanVien.BackColor = Color.Transparent;
            btnNhanVien.ForeColor = Color.Black;
          
            btnHoaDon.BackColor = Color.Transparent;
            btnHoaDon.ForeColor = Color.Black;
            btnThongKe.BackColor = Color.Transparent;
            btnThongKe.ForeColor = Color.Black;

            btnService.BackColor = Color.Gray;
            btnService.ForeColor = Color.White;
            //UI Feature Button
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            //UI Feature Button
            btnRoom.BackColor = Color.Transparent;
            btnRoom.ForeColor = Color.Black;
            btnNhanVien.BackColor = Color.Transparent;
            btnNhanVien.ForeColor = Color.Black;
            btnService.BackColor = Color.Transparent;
            btnService.ForeColor = Color.Black;
           
            btnThongKe.BackColor = Color.Transparent;
            btnThongKe.ForeColor = Color.Black;

            btnHoaDon.BackColor = Color.Gray;
            btnHoaDon.ForeColor = Color.White;
            //UI Feature Button
            quanLyHoaDon1.Show();
            quanLyHoaDon1.BringToFront();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            //UI Feature Button
            btnRoom.BackColor = Color.Transparent;
            btnRoom.ForeColor = Color.Black;
            btnNhanVien.BackColor = Color.Transparent;
            btnNhanVien.ForeColor = Color.Black;
            btnService.BackColor = Color.Transparent;
            btnService.ForeColor = Color.Black;
            btnHoaDon.BackColor = Color.Transparent;
            btnHoaDon.ForeColor = Color.Black;
            

            btnThongKe.BackColor = Color.Gray;
            btnThongKe.ForeColor = Color.White;
            //UI Feature Button
        }

        private void btnUINhanVien_Click(object sender, EventArgs e)
        {
            NhanVien fomrNhanVien = new NhanVien();
            fomrNhanVien.Location = this.Location;
           fomrNhanVien.FormClosing += delegate { this.Close(); };
            this.Hide();
            fomrNhanVien.Show();
            
        }
    }
}
