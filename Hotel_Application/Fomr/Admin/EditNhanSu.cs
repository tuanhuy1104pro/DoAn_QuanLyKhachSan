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
    public partial class EditNhanSu : Form
    {
        DataRow rowFlag = NhanSu.rowFlagNhanVien;
        public EditNhanSu()
        {
            InitializeComponent();
            
        }

        private void EditNhanSu_Load(object sender, EventArgs e)
        {
            
            txtHoTen.Text = rowFlag["TenNV"].ToString();
            txtSdt.Text = rowFlag["SDT"].ToString();
            txtEmail.Text = rowFlag["EmailNV"].ToString();
            cboGioiTinh.SelectedText = rowFlag["GioiTinh"].ToString() ;
            txtTaiKhoan.Text = rowFlag["TaiKhoan"].ToString();
            txtMatKhau.Text = rowFlag["MatKhau"].ToString();
            dtDoBorn.Text = rowFlag["NgaySinh"].ToString();
            DtNgayVaoLam.Text = rowFlag["NgayVaoLam"].ToString();
            txtMaChucVu.Text = rowFlag["MaCV"].ToString();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
