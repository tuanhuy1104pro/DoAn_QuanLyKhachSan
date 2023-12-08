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
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            cboTenChucVu.SelectedText = dr["TenCV"].ToString();
            txtPhuCap.Text = dr["PhuCap"].ToString();

        }
    }
}
