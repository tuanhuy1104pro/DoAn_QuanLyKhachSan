using Hotel_Application.Features;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Application
{
    public partial class TaoHoaDon : UserControl
    {
        SqlConnection conn = ConnectDB.connectstring;
        
        public TaoHoaDon()
        {
            InitializeComponent();
        }

        private void TaoHoaDon_Load(object sender, EventArgs e)
        {
            LoadCboLoaiPhong();
        }

        List<int> MaLoaiPhong = new List<int>();  
        DataSet dsLoaiPhong = new DataSet();
        SqlDataAdapter daLoaiPhong;
        public void LoadCboLoaiPhong()
        {
            conn.Open();
            daLoaiPhong = new SqlDataAdapter("Select* From LoaiPhong", conn);
            daLoaiPhong.Fill(dsLoaiPhong, "LoaiPhong");
            conn.Close();
            foreach (DataRow item in dsLoaiPhong.Tables["LoaiPhong"].Rows)
            {
                cboLoaiPhong.Items.Add(item["TenLoaiPhong"].ToString());
                MaLoaiPhong.Add(int.Parse(item["MaLoaiPhong"].ToString()));
            }
            cboLoaiPhong.SelectedIndex = 0;
           
        }

        List<int> MaPhong = new List<int>();
       
        SqlDataAdapter daPhong;
        public void LoadCboPhong(int IMaLoaiPhong)
        {
            DataSet dsPhong = new DataSet();
            MaPhong.Clear();
            conn.Open();
            daPhong = new SqlDataAdapter($"select * from Phong where ((Phong.MaLoaiPhong = {IMaLoaiPhong}) and (Phong.MaPhong not in (Select MaPhong from HoaDon))) or ((Phong.MaLoaiPhong = {IMaLoaiPhong}) and (Select  HoaDon.NgayTra from HoaDon where Phong.MaPhong = HoaDon.MaPhong and HoaDon.NgayTra <= '{NgayThue.Text}') <= '{NgayThue.Text}')", conn);
           if(daPhong == null)
            {
                cboPhong.Items.Add("Null");
                MaPhong.Add(0);
                conn.Close();
            }
            else
            {
                daPhong.Fill(dsPhong, "Phong");
                conn.Close();

                foreach (DataRow item in dsPhong.Tables["Phong"].Rows)
                {
                    cboPhong.Items.Add(item["TenPhong"].ToString());
                    MaPhong.Add(int.Parse(item["MaPhong"].ToString()));
                }
            }  
        }
        int IMaLoaiPhong;
        private void cboLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
             IMaLoaiPhong = MaLoaiPhong[cboLoaiPhong.SelectedIndex];
            //
            cboPhong.Items.Clear();
            LoadCboPhong(IMaLoaiPhong);
            cboPhong.SelectedIndex = 0;
        }

        private void NgayThue_ValueChanged(object sender, EventArgs e)
        {
            cboPhong.Items.Clear();
            LoadCboPhong(IMaLoaiPhong);
            cboPhong.SelectedIndex = 0;
        }
        int IMaPhong;
        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            IMaPhong = MaPhong[cboPhong.SelectedIndex];
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            //Kiem Tra Khac hHang
            conn.Open();
            SqlCommand cmdKH = new SqlCommand($"Select *From KhachHang where KhachHang.SoDienThoai = {txtSdt.Text} or KhachHang.Email = '{txtEmail.Text}'  ", conn);
            SqlDataReader readerKH = cmdKH.ExecuteReader();
            bool check = readerKH.Read();
            //
            if (check) { 
                int MaKH = int.Parse(readerKH["MaKhachHang"].ToString());
                readerKH.Close();
                SqlCommand cmdHoaDon = new SqlCommand($"insert into HoaDon(NgayThue,NgayTra,MaNV,MaKhachHang,MaPhong) values ('{NgayThue.Text}','{NgayTra.Text}',{DangKyDangNhap.DoiTuongNV.MaNV},{MaKH},{IMaPhong})", conn);
                cmdHoaDon.ExecuteNonQuery();
                MessageBox.Show("Da them thanh cong");
                conn.Close();
            }
            else
            {
                readerKH.Close();
                //ThemKhachHang
                cmdKH = new SqlCommand($"Insert into KhachHang(HoTen,SoDienThoai,Email) values (N'{txtHoTen.Text}','{txtSdt.Text}','{txtEmail.Text}')",conn);
                cmdKH.ExecuteNonQuery();
                //ThemKhachHang

                //TimMaKhachHang
                cmdKH = new SqlCommand($"Select *From KhachHang where KhachHang.SoDienThoai = {txtSdt.Text} or KhachHang.Email = '{txtEmail.Text}'  ", conn);
                SqlDataReader rKH = cmdKH.ExecuteReader();
                rKH.Read();
                int iMaKhachHang = int.Parse(rKH["MaKhachHang"].ToString());
                rKH.Close() ;
                //
                //Them vao hoa don
                SqlCommand cmdHoaDon = new SqlCommand($"insert into HoaDon(NgayThue,NgayTra,MaNV,MaKhachHang,MaPhong) values ('{NgayThue.Text}','{NgayTra.Text}',{DangKyDangNhap.DoiTuongNV.MaNV},{iMaKhachHang},{IMaPhong})", conn);
                cmdHoaDon.ExecuteNonQuery();
                MessageBox.Show("Da them thanh cong");

                //
                conn.Close();
            }



            
           
        }
    }
}
