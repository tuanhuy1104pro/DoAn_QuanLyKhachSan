using Hotel_Application.Features;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        SqlConnection conn = ConnectDB.connectstring;
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
            conn.Open();
            SqlCommand cmd = new SqlCommand($"Select * from ChucVu where MaCV = {txtMaChucVu.Text} ", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            bool check = dr.Read();
            dr.Close();
            if (check) { 
                conn.Close();
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else {
                conn.Close();
                DialogResult = DialogResult.Cancel;
                MessageBox.Show("Không tồn tại chức vụ");

            }
           
          
        }
    }
}
