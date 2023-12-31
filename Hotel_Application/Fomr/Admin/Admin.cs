﻿using System;
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
            btnTK.BackColor = Color.Transparent;
            btnTK.ForeColor = Color.Black;

            btnRoom.BackColor = Color.Gray;
            btnRoom.ForeColor= Color.White;
            //UI Feature Button
            phong1.Show();
            phong1.BringToFront();
            
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
            btnTK.BackColor = Color.Transparent;
            btnTK.ForeColor = Color.Black;

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
            btnTK.BackColor = Color.Transparent;
            btnTK.ForeColor = Color.Black;

            btnService.BackColor = Color.Gray;
            btnService.ForeColor = Color.White;
            //UI Feature Button
            quanLyDichVu1.Show();
            quanLyDichVu1.BringToFront() ;
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

            btnTK.BackColor = Color.Transparent;
            btnTK.ForeColor = Color.Black;

            btnHoaDon.BackColor = Color.Gray;
            btnHoaDon.ForeColor = Color.White;
            //UI Feature Button
            quanLyHoaDon1.Show();
            quanLyHoaDon1.BringToFront();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            btnRoom.BackColor = Color.Transparent;
            btnRoom.ForeColor = Color.Black;
            btnNhanVien.BackColor = Color.Transparent;
            btnNhanVien.ForeColor = Color.Black;
            btnService.BackColor = Color.Transparent;
            btnService.ForeColor = Color.Black;
            btnHoaDon.BackColor = Color.Transparent;
            btnHoaDon.ForeColor = Color.Black;


            btnTK.BackColor = Color.Gray;
            btnTK.ForeColor = Color.White;

            //
            thongKe1.Show();
            thongKe1.BringToFront();
            //
        }
    }
}
