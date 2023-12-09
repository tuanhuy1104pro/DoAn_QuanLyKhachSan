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
using Hotel_Application;
using Hotel_Application.Features;
using Hotel_Application.Features.Class;
namespace Hotel_Application
{
    public partial class TrangChu : UserControl
    {
        //Các Properties
        NhanVienClass doituongNV = DangKyDangNhap.DoiTuongNV;
        public static LuongClass doituongLuong = new LuongClass();
        public static List<ChucVuClass> doituongChucvu = new List<ChucVuClass>();
        //
        SqlConnection conn = ConnectDB.connectstring;
        SqlCommand cmd;
        public TrangChu()
        {
            InitializeComponent();
            
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            txtHoTen.Text = doituongNV.TenNV;
            txtHoTen.Enabled = false;
            txtSdt.Text = doituongNV.SDT.ToString();
            txtSdt.Enabled = false;
            txtEmail.Text = doituongNV.EmailNV;
            txtEmail.Enabled = false;
            
            if(doituongNV.GioiTinh == "Nam")
            {
                cboGioiTinh.SelectedText = "Nam";
                cboGioiTinh.Enabled = false;
            }    
            else {

                cboGioiTinh.SelectedText = "Nữ";
                cboGioiTinh.Enabled = false;
            }
            dtDoBorn.Text = doituongNV.NgaySinh.ToString();
            dtDoBorn.Enabled = false;
            //LoadComboboxChucVu
            loadComboBoxChucVu();
            //
            LoadThongTinCongViec();
            cboTenChucVu.Enabled =  false;
            txtLuongCoBan.Enabled = false;
            txtSoNgayNghi.Enabled = false;
            txtPhuCap.Enabled = false;
            DtNgayVaoLam.Enabled = false;
            //
            
        }
        public void loadComboBoxChucVu()
        {
            if(conn.State == ConnectionState.Closed) {
                conn.Open();
            }
            string select = "Select * From ChucVu";
            SqlCommand cmd = new SqlCommand(select,conn);
            SqlDataReader dr = cmd.ExecuteReader();
           while(dr.Read())
            {
                cboTenChucVu.Items.Add(dr["TenCV"].ToString());
                ChucVuClass cv = new ChucVuClass();
                cv.MaCV =Convert.ToInt32(dr["MaCV"].ToString());
                cv.TenCV = dr["TenCV"].ToString();
                cv.PhuCap = float.Parse(dr["PhuCap"].ToString());
                //Thêm vào list Chuc vụ (Static)
                doituongChucvu.Add(cv);
            }
           
            dr.Close();
            conn.Close();
        }

        public void LoadThongTinCongViec()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string select = $"Select * From ChucVu Where MaCV = '{doituongNV.MaCV}'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            cboTenChucVu.SelectedItem = dr["TenCV"].ToString();
            txtPhuCap.Text = dr["PhuCap"].ToString();
            DtNgayVaoLam.Text = doituongNV.NgayVaoLam.ToString();
            dr.Close();
            //Luong
            select = $"Select * From Luong Where MaNV = '{doituongNV.MaNV}'";
            cmd = new SqlCommand (select, conn);
            SqlDataReader dr2 = cmd.ExecuteReader();
           
            bool flag = dr2.Read();
            
            if(flag == false)
            {
                doituongLuong.MaNV = Convert.ToInt32(doituongNV.MaNV.ToString());
            }
            else
            {
                doituongLuong.MaNV = Convert.ToInt32(doituongNV.MaNV.ToString());
                doituongLuong.TienLuong = double.Parse(dr2["TienLuong"].ToString());
                doituongLuong.SoNgayNghi = Convert.ToInt32(dr2["SoNgayNghi"].ToString());
            }
            txtLuongCoBan.Text = doituongLuong.TienLuong.ToString();
            txtSoNgayNghi.Text = doituongLuong.SoNgayNghi.ToString();
            dr2.Close();
            conn.Close();
        }


        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EditProfile();
        }

        public void EditProfile()
        {
            //Open
            txtHoTen.Enabled = true;
            txtSdt.Enabled = true;
            txtEmail.Enabled = true;
            dtDoBorn.Enabled = true;
            cboGioiTinh.Enabled = true;
            btnXacNhan.Visible = true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            conn.Open();
            string updatename;
            string updatesdt;
            string updateemail;
            string updateNgaysinh;
            string updategioitinh;
            //
            updatename = $"Update NhanVien\nSet TenNV = N'{txtHoTen.Text}' where MaNV = '{doituongNV.MaNV}'";
            updatesdt = $"Update NhanVien\nSet SDT = '{txtSdt.Text}' where MaNV = '{doituongNV.MaNV}'";
            updateemail = $"Update NhanVien\nSet EmailNV = '{txtEmail.Text}' where MaNV = '{doituongNV.MaNV}'";
            updateNgaysinh = $"Update NhanVien\nSet NgaySinh = '{dtDoBorn.Text}' where MaNV = '{doituongNV.MaNV}'";
            updategioitinh = $"Update NhanVien\nSet GioiTinh = N'{cboGioiTinh.SelectedItem}' where MaNV = '{doituongNV.MaNV}'";

            cmd = new SqlCommand(updatename, conn);
            cmd.ExecuteNonQuery();

            int flag = 0;
            if (txtSdt.Text.Length <= 10)
            {
                cmd = new SqlCommand(updatesdt, conn);
                cmd.ExecuteNonQuery();
                flag = 1;
            }
            
            cmd = new SqlCommand(updateemail, conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(updateNgaysinh, conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(updategioitinh, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            if(flag == 1)
            {
                MessageBox.Show("Đã Thay Đổi Thông Tin Thành Công");
            }
            else
            {
                MessageBox.Show("Số Điện thoại phải từ 9 số trở xuống");
            }
            
            txtHoTen.Enabled = false;
            txtSdt.Enabled = false;
            txtEmail.Enabled = false;
            dtDoBorn.Enabled = false;
            cboGioiTinh.Enabled = false;
            btnXacNhan.Visible=false;
        }
    }
}
