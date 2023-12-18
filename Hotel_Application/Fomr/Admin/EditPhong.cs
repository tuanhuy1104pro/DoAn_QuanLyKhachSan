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
            
            SqlCommand cmd2 = new SqlCommand($"Select * from LoaiPhong where MaLoaiPhong = {txtLoaiPhong.Text} ", conn);
            SqlDataReader dr = cmd2.ExecuteReader();
            bool check2 = dr.Read();
            dr.Close();
            if ((check == false  || txtTenPhong.Text == Phong.rowFlagPhong["TenPhong"].ToString()) && check2 == true)
            {
                this.DialogResult = DialogResult.OK;
                conn.Close();
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                conn.Close();
                MessageBox.Show("Lỗi: " + txtTenPhong.Text);
            }
        }
    }
}
