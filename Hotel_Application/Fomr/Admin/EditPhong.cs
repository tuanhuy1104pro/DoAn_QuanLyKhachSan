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
    public partial class EditPhong : Form
    {
        public static EditPhong instanceEditPhong = new EditPhong();
        SqlConnection conn = ConnectDB.connectstring;
        public EditPhong()
        {
            InitializeComponent();
            instanceEditPhong = this;
        }

        private void EditPhong_Load(object sender, EventArgs e)
        {
            txtTenPhong.Text = Phong.rowFlagPhong["TenPhong"].ToString();
            txtLoaiPhong.Text = Phong.rowFlagPhong["MaLoaiPhong"].ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand($"Select MaPhong from Phong Where TenPhong = N'{txtTenPhong.Text}'", conn);
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
                MessageBox.Show("Đã tồn tại phòng: " + txtTenPhong.Text);
            }
        }
    }
}
