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
    public partial class QuanLyHoaDon : UserControl
    {
        public QuanLyHoaDon()
        {
            
            InitializeComponent();
            cboSortHoaDon.SelectedIndex = 0;
        }

        private void lbTimHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void txtMaHoaDon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaHoaDon_Click(object sender, EventArgs e)
        {
            txtMaHoaDon.Clear();
        }

        private void txtMaHoaDon_Leave(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = "Mã Hóa Đơn Hoặc Tên Khách Hàng";
        }
    }
}
