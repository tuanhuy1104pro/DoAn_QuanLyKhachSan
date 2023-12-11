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
    public partial class AddNhanSu : Form
    {
        SqlConnection conn = ConnectDB.connectstring;
        SqlCommand cmd;
        public AddNhanSu()
        {
            InitializeComponent();
            cboGioiTinh.SelectedIndex = 0;
            
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
           
           
            if (txtHoTen.Text.Length == 0 || txtEmail.Text.Length == 0 || txtTaiKhoan.Text.Length == 0 || txtMatKhau.Text.Length == 0 || txtSdt.Text.Length == 0)
            {
              
                 MessageBox.Show("Vui lòng điền đầy đủ");
                
                this.DialogResult = DialogResult.Cancel;
                
            }
            else
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand($"Select *from ChucVu where MaCV = {txtMaChucVu.Text}", conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                bool flag = rdr.Read();
                if(flag == false)
                {
                    MessageBox.Show("Không có chức vụ để thêm");
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    rdr.Close();
                    conn.Close();
                    cmd.Dispose();
                    this.Close();
                }
              
            }
           
        }

        private void AddNhanSu_Load(object sender, EventArgs e)
        {

          
        }
        

    }
}
