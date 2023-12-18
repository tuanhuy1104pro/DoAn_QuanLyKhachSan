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

namespace Hotel_Application.Fomr.Admin
{
    public partial class EditLoaiPhong : Form
    {
        public static EditLoaiPhong instanceEditLoaiPhong = new EditLoaiPhong();
        SqlConnection conn = ConnectDB.connectstring;
        public EditLoaiPhong()
        {
            InitializeComponent();
            instanceEditLoaiPhong = this;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand($"Select MaLoaiPhong from LoaiPhong Where TenLoaiPhong = N'{txtTenLoaiPhong.Text}'", conn);
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
                MessageBox.Show("Đã tồn tại loại phòng: " + txtTenLoaiPhong.Text);
            }
        }

        private void EditLoaiPhong_Load(object sender, EventArgs e)
        {
            txtTenLoaiPhong.Text = Phong.rowFlag["TenLoaiPhong"].ToString();
            txtGia.Text = Phong.rowFlag["Gia"].ToString();
        }
    }
}
