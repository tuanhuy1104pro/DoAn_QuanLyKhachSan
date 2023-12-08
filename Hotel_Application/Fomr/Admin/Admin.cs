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
            btnHome.BackColor = Color.Gray;
            btnHome.ForeColor = Color.White;
            
           
        }
      
       
        

        private void btnHome_Click(object sender, EventArgs e)
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
            btnThongKe.BackColor = Color.Transparent;
            btnThongKe.ForeColor = Color.Black;

            btnHome.BackColor = Color.Gray;
            btnHome.ForeColor = Color.White;
            //UI Feature Button
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            //UI Feature Button
            btnHome.BackColor = Color.Transparent;
            btnHome.ForeColor = Color.Black;
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
            btnHome.BackColor = Color.Transparent;
            btnHome.ForeColor = Color.Black;
            btnService.BackColor = Color.Transparent;
            btnService.ForeColor = Color.Black;
            btnHoaDon.BackColor = Color.Transparent;
            btnHoaDon.ForeColor = Color.Black;
            btnThongKe.BackColor = Color.Transparent;
            btnThongKe.ForeColor = Color.Black;

            btnNhanVien.BackColor = Color.Gray;
            btnNhanVien.ForeColor = Color.White;
            //UI Feature Button
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            //UI Feature Button
            btnRoom.BackColor = Color.Transparent;
            btnRoom.ForeColor = Color.Black;
            btnNhanVien.BackColor = Color.Transparent;
            btnNhanVien.ForeColor = Color.Black;
            btnHome.BackColor = Color.Transparent;
            btnHome.ForeColor = Color.Black;
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
            btnHome.BackColor = Color.Transparent;
            btnHome.ForeColor = Color.Black;
            btnThongKe.BackColor = Color.Transparent;
            btnThongKe.ForeColor = Color.Black;

            btnHoaDon.BackColor = Color.Gray;
            btnHoaDon.ForeColor = Color.White;
            //UI Feature Button
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
            btnHome.BackColor = Color.Transparent;
            btnHome.ForeColor = Color.Black;

            btnThongKe.BackColor = Color.Gray;
            btnThongKe.ForeColor = Color.White;
            //UI Feature Button
        }
    }
}
