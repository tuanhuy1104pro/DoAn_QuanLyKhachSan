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
    public partial class EditChucVu : Form
    {
        public static EditChucVu instanceEditChucVu = new EditChucVu();
        SqlConnection conn = ConnectDB.connectstring;
        public EditChucVu()
        {
            InitializeComponent();
            instanceEditChucVu = this;
        }

        private void EditChucVu_Load(object sender, EventArgs e)
        {
           txtTenCV.Text = NhanSu.rowFlag["TenCV"].ToString();
            txtPhuCap.Text = NhanSu.rowFlag["PhuCap"].ToString();
        }

        private void btnEditChucVu_Click(object sender, EventArgs e)
        {

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand($"Select MaCV from ChucVu Where TenCV = N'{txtTenCV.Text}'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bool check = reader.Read();
            reader.Close();
            if (check == false)
            {
                conn.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã tồn tại chức vụ: " + txtTenCV.Text);
            }
           
        }
    }
}
