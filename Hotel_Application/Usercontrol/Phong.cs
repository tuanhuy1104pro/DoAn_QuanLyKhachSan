using Hotel_Application.Features;
using Hotel_Application.Features.Class;
using Hotel_Application.Fomr.Admin;
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
    public partial class Phong : UserControl
    {
        static public Phong instanceNhanSu = new Phong();
        SqlConnection conn = ConnectDB.connectstring;
        SqlCommand cmd;

        //
        DataSet dataSet;
        SqlDataAdapter da;
        public Phong()
        {
            InitializeComponent();
        }
        int SoluongdongLoaiPhong;
        private void Phong_Load(object sender, EventArgs e)
        {
            loadBangLoaiPhong();
            loadBangPhong();
        }
        public void loadBangLoaiPhong()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string select = "Select * From LoaiPhong";
            dataSet = new DataSet();
            da = new SqlDataAdapter(select, conn);
            da.Fill(dataSet, "LoaiPhong");
            DataColumn[] key = new DataColumn[1];
            key[0] = dataSet.Tables["LoaiPhong"].Columns[0];
            dataSet.Tables["LoaiPhong"].PrimaryKey = key;
            dgvLoaiPhong.DataSource = dataSet.Tables["LoaiPhong"];
            //
            SoluongdongLoaiPhong = dgvLoaiPhong.RowCount;

            //
            dgvLoaiPhong.ReadOnly = true;
            conn.Close();
        }

        private void btnAddKindRoom_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand($"Select MaLoaiPhong from LoaiPhong Where TenLoaiPhong = N'{txtTenLoaiPhong.Text}'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bool check = reader.Read();
            reader.Close();
            if (txtTenLoaiPhong.Text.Length == 0 || txtGiaLoaiPhong.Text.Length == 0)
            {
                conn.Close();
                MessageBox.Show("Cần phải nhập đầy đủ thông tin");
            }
            else if (ChucNang.IsAllDigits(txtGiaLoaiPhong.Text) == false)
            {
                conn.Close();
                MessageBox.Show("Giá tiền không hợp lệ");
            }
            else
            {
                if (check == false)
                {
                    cmd = new SqlCommand($"insert into LoaiPhong(TenLoaiPhong,Gia) values (N'{txtTenLoaiPhong.Text}','{float.Parse(txtGiaLoaiPhong.Text)}')", conn);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show($"Đã thêm loại phòng {txtTenLoaiPhong.Text}");
                    txtTenLoaiPhong.Clear();
                    txtGiaLoaiPhong.Clear();
                    conn.Close();
                    dataSet.Clear();
                    loadBangLoaiPhong();
                }
                else
                {
                    conn.Close();
                    MessageBox.Show($"Đã Tồn Tại loại phòng {txtTenLoaiPhong.Text}");
                }
            }
        }
        public int maLoaiPhong;
        private void btnXoaLoaiPhong_Click(object sender, EventArgs e)
        {
            DataRow dr = dataSet.Tables["LoaiPhong"].Rows.Find(maLoaiPhong);
            if (dr != null)
            {
                dr.Delete();
            }
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(dataSet, "LoaiPhong");
            SoluongdongLoaiPhong--;
        }
        public static DataRow rowFlag;

        private void btnSuaLoaiPhong_Click(object sender, EventArgs e)
        {
            rowFlag = dataSet.Tables["LoaiPhong"].Rows.Find(maLoaiPhong);
            EditLoaiPhong edit = new EditLoaiPhong();
            edit.Show();
            edit.FormClosing += delegate
            {
                rowFlag["TenLoaiPhong"] = edit.txtTenLoaiPhong.Text;
                rowFlag["Gia"] = edit.txtGia.Text;
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(dataSet, "LoaiPhong");
            };
        }

        private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < SoluongdongLoaiPhong - 1)
            {
                DataGridViewRow row = this.dgvLoaiPhong.Rows[e.RowIndex];
                maLoaiPhong = int.Parse(row.Cells["MaLoaiPhong"].Value.ToString());
            }
        }
        int soluongdongPhong;
        DataSet dsPhong = new DataSet();
        SqlDataAdapter daPhong;
        int SoluongdongPhong;
        public void loadBangPhong()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string select = "Select * From Phong";
            dsPhong = new DataSet();
            daPhong = new SqlDataAdapter(select, conn);
            daPhong.Fill(dsPhong, "Phong");
            DataColumn[] key = new DataColumn[1];
            key[0] = dsPhong.Tables["Phong"].Columns[0];
            dsPhong.Tables["Phong"].PrimaryKey = key;
            dgvPhong.DataSource = dsPhong.Tables["Phong"];
            //
            SoluongdongPhong = dgvPhong.RowCount;

            //
            dgvPhong.ReadOnly = true;
            conn.Close();
        }

        private void btnAddPhong_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand($"Select MaPhong from Phong Where TenPhong = N'{txtTenPhong.Text}'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bool check = reader.Read();
            reader.Close();
            if (txtTenPhong.Text.Length == 0 || txtLoaiPhong.Text.Length == 0)
            {
                conn.Close();
                MessageBox.Show("Cần phải nhập đầy đủ thông tin");
            }
            else if (ChucNang.IsAllDigits(txtLoaiPhong.Text) == false)
            {
                conn.Close();
                MessageBox.Show("Loại phòng không hợp lệ");
            }
            else
            {
                if (check == false)
                {
                    cmd = new SqlCommand($"insert into Phong(TenPhong,MaLoaiPhong) values (N'{txtTenPhong.Text}','{int.Parse(txtLoaiPhong.Text)}')", conn);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show($"Đã thêm phòng {txtTenPhong.Text}");
                    txtTenPhong.Clear();
                    txtLoaiPhong.Clear();
                    conn.Close();
                    dsPhong.Clear();
                    loadBangPhong();
                }
                else
                {
                    conn.Close();
                    MessageBox.Show($"Đã Tồn Tại phòng {txtTenPhong.Text}");
                }
            }
        }
        int maPhong;

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            DataRow dr = dsPhong.Tables["Phong"].Rows.Find(maPhong);
            if (dr != null)
            {
                dr.Delete();
            }
            SqlCommandBuilder cb = new SqlCommandBuilder(daPhong);
            daPhong.Update(dsPhong, "Phong");
            SoluongdongPhong--;
        }
    }
}
