using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Hotel_Application.Features;
using Hotel_Application.Features.Class;
namespace Hotel_Application
{
    public partial class DangKyDangNhap : Form
    {
       
       public static NhanVienClass DoiTuongNV = new NhanVienClass();
       SqlConnection conn = ConnectDB.connectstring;
       SqlCommand cmd;
        public DangKyDangNhap()
        {
            InitializeComponent();
            
        }

        private void llbFindPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.Location = this.Location;   
            
            quenMatKhau.FormClosing += delegate { this.Show(); };
            this.Hide();
            quenMatKhau.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Khi la Admin
            if(txtUsername.Text == "admin" && txtPassword.Text == "sa")
            {
                Admin ad = new Admin();
                ad.FormClosing += delegate {
                    txtUsername.Clear();
                    txtPassword.Clear();
                    this.Show();
                };
                this.Hide();
               
                ad.Show();
            }
            else //Khi la Nhan Vien
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string select = $"select count(*) as flag from NhanVien\r\nwhere TaiKhoan = '{txtUsername.Text}' and MatKhau = '{txtPassword.Text}'\r\n ";

               

               cmd = new SqlCommand(select, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                string i = dr["flag"].ToString();
                dr.Close();
                //select2
                if (i == "1")
                {
                    string select2 = $"select *  from NhanVien\r\nwhere TaiKhoan = '{txtUsername.Text}' and MatKhau = '{txtPassword.Text}'";
                    cmd = new SqlCommand(select2, conn);
                    SqlDataReader dr2 = cmd.ExecuteReader();
                    dr2.Read();

                    //Luu doi tuong login
                    DoiTuongNV.MaNV = Convert.ToInt32(dr2["MaNV"].ToString());
                    DoiTuongNV.TenNV = dr2["TenNV"].ToString();
                    DoiTuongNV.MaCV = Convert.ToInt32(dr2["MaCV"].ToString());
                    DoiTuongNV.SDT = Convert.ToInt32(dr2["SDT"].ToString());
                    DoiTuongNV.EmailNV = dr2["EmailNV"].ToString();
                    DoiTuongNV.GioiTinh = dr2["GioiTinh"].ToString();
                    DoiTuongNV.TaiKhoan = dr2["TaiKhoan"].ToString();
                    DoiTuongNV.MatKhau = dr2["MatKhau"].ToString();
                    DoiTuongNV.NgaySinh = Convert.ToDateTime(dr2["NgaySinh"].ToString());
                    DoiTuongNV.NgayVaoLam = Convert.ToDateTime(dr2["NgayVaoLam"].ToString());
                    //Luu doi tuong login

                    dr2.Close();
                    NhanVien nvform = new NhanVien();
                    nvform.FormClosing += delegate { 
                        txtUsername.Clear();
                        txtPassword.Clear();
                        this.Show(); 
                    };
                    this.Hide();
                    nvform.Show();

                }
                else
                {
                    MessageBox.Show("Sai tai Khoan hoac mat khau");
                }
                
                
                conn.Close();
            }
        }
    }
}
