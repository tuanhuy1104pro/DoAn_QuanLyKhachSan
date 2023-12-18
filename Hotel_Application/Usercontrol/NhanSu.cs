using Hotel_Application.Features;
using Hotel_Application.Features.Class;
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
    public partial class NhanSu : UserControl
    {
        static public NhanSu instanceNhanSu = new NhanSu();
        List<ChucVuClass> DoituongChucVuclass = TrangChu.doituongChucvu;
        //
        SqlConnection conn = ConnectDB.connectstring;
        SqlCommand cmd;

        //
        DataSet dataSet;
        SqlDataAdapter da;
        
        public NhanSu()
        {
            InitializeComponent();
            instanceNhanSu = this;
        }

        private void NhanSu_Load(object sender, EventArgs e)
        {
            loadBangChucVu();
            loadBangNhanVien();

        }
        //Chức Vụ//
        int SoluongdongChucvu;
        public void loadBangChucVu()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string select = "Select * From ChucVu";
            dataSet = new DataSet();
            da = new SqlDataAdapter(select,conn);
            da.Fill(dataSet, "ChucVu");
            DataColumn[] key = new DataColumn[1];
            key[0] = dataSet.Tables["ChucVu"].Columns[0];
            dataSet.Tables["ChucVu"].PrimaryKey = key;
            dgvChucVu.DataSource = dataSet.Tables["ChucVu"];
            //
            SoluongdongChucvu = dgvChucVu.RowCount;

            //
            dgvChucVu.ReadOnly = true;
            conn.Close();
        }

        private void btnAddChucVu_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
           
            SqlCommand cmd = new SqlCommand($"Select MaCV from ChucVu Where TenCV = N'{txtTenCV.Text}'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bool check = reader.Read();
            reader.Close();
            if(txtTenCV.Text.Length == 0 || txtPhuCap.Text.Length == 0)
            {
                conn.Close() ;
                MessageBox.Show("Cần phải nhập đầy đủ thông tin");
            }
            else if(ChucNang.IsAllDigits(txtPhuCap.Text) == false)
            {
                conn.Close();
                MessageBox.Show("Giá Trị Phụ cấp không hợp lệ");
            }    
            else
            {
                if (check == false)
                {
                    cmd = new SqlCommand($"insert into ChucVu(TenCV,PhuCap) values (N'{txtTenCV.Text}','{float.Parse(txtPhuCap.Text)}')", conn);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show($"Đã thêm chức vụ {txtTenCV.Text}");
                    txtTenCV.Clear();
                    txtPhuCap.Clear();
                    conn.Close();
                    dataSet.Clear();
                    loadBangChucVu();
                }
                else
                {
                    conn.Close();
                    MessageBox.Show($"Đã Tồn Tại chức vụ {txtTenCV.Text}");
                }
            }
           
                  
        }

        
        public int maCV;
        
        private void btnDeleteChucVu_Click(object sender, EventArgs e)
        {
            
                DataRow dr = dataSet.Tables["ChucVu"].Rows.Find(maCV);
                if(dr != null)
                {
                    dr.Delete();
                }    
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(dataSet, "ChucVu");
            SoluongdongChucvu--;
        }

     

        private void dgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < SoluongdongChucvu - 1)
            {
                DataGridViewRow row = this.dgvChucVu.Rows[e.RowIndex];
                maCV = int.Parse(row.Cells["MaCV"].Value.ToString());
            }
            
        }

        public static DataRow rowFlag;
        private void btnEditChucVu_Click(object sender, EventArgs e)
        {
            
                
                rowFlag = dataSet.Tables["ChucVu"].Rows.Find(maCV);
                EditChucVu edit = new EditChucVu();
                edit.Show();
                edit.FormClosing+= delegate
                {
                    
                    if(edit.DialogResult == DialogResult.OK)
                    {
                        rowFlag["TenCV"] = edit.txtTenCV.Text;
                        rowFlag["PhuCap"] = edit.txtPhuCap.Text;
                        SqlCommandBuilder cb = new SqlCommandBuilder(da);
                        da.Update(dataSet, "ChucVu");
                    }
                   
                };
        }
        //Chức Vụ//

        //Nhân Viên
        int soluongdongNhanSu;
        DataSet dsNhanvien = new DataSet();
        SqlDataAdapter daNhanVien;
        public void loadBangNhanVien()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string select = "Select * From NhanVien";

            daNhanVien = new SqlDataAdapter(select, conn);
            daNhanVien.Fill(dsNhanvien, "NhanVien");
            DataColumn[] keynv = new DataColumn[1];
            keynv[0] = dsNhanvien.Tables["NhanVien"].Columns[0];
            dsNhanvien.Tables["NhanVien"].PrimaryKey = keynv;
            dgvNhanSu.DataSource = dsNhanvien.Tables["NhanVien"];
            soluongdongNhanSu = dgvNhanSu.RowCount;
            dgvNhanSu.ReadOnly = true;
            conn.Close();
        }

        private void btnAddNhanSu_Click(object sender, EventArgs e)
        {
    
            AddNhanSu addns = new AddNhanSu();
            addns.Show();
            addns.FormClosing += delegate
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    if (addns.DialogResult == DialogResult.OK)
                    {
                        NhanVienClass nhanvien = new NhanVienClass();

                        SqlCommand cmd = new SqlCommand($"INSERT INTO  NhanVien VALUES(N'{addns.txtHoTen.Text}',{int.Parse(addns.txtSdt.Text)},'{addns.txtEmail.Text}',N'{addns.cboGioiTinh.SelectedItem.ToString()}','{addns.txtTaiKhoan.Text}','{addns.txtMatKhau.Text}','{addns.dtDoBorn.Text}','{addns.DtNgayVaoLam.Text}',{int.Parse(addns.txtMaChucVu.Text)})", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Đã thêm nhân viên");
                        conn.Close();
                    }
                    else
                    {
                        conn.Close();
                    }
                    
                }
                catch {
                    MessageBox.Show("LỖi");
                    conn.Close();
                }
            };  
        }

        private void btnReloadNhanSu_Click(object sender, EventArgs e)
        {
            loadBangNhanVien();
        }

        private void btnDeleteNhanSu_Click(object sender, EventArgs e)
        {
            DataRow dr = dsNhanvien.Tables["NhanVien"].Rows.Find(maNS);
            if (dr != null)
            {
                dr.Delete();
            }
            SqlCommandBuilder cb = new SqlCommandBuilder(daNhanVien);
            daNhanVien.Update(dsNhanvien, "NhanVien");
            soluongdongNhanSu--;
        }
        public int maNS;
        private void dgvNhanSu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < soluongdongNhanSu - 1)
            {
                DataGridViewRow row = this.dgvNhanSu.Rows[e.RowIndex];
                maNS = int.Parse(row.Cells["MaNV"].Value.ToString());
            }
        }
        public static DataRow rowFlagNhanVien;
        private void btnEditNhanSu_Click(object sender, EventArgs e)
        {
            rowFlagNhanVien = dsNhanvien.Tables["NhanVien"].Rows.Find(maNS);
            EditNhanSu edit = new EditNhanSu();
            edit.Show();
            edit.FormClosing += delegate
            {
                rowFlagNhanVien["TenNV"] = edit.txtHoTen.Text;
                rowFlagNhanVien["SDT"] = int.Parse(edit.txtSdt.Text);
                rowFlagNhanVien["EmailNV"] = edit.txtEmail.Text;
                rowFlagNhanVien["GioiTinh"] = edit.cboGioiTinh.SelectedItem.ToString();
                rowFlagNhanVien["TaiKhoan"] = edit.txtTaiKhoan.Text;
                rowFlagNhanVien["MatKhau"] = edit.txtMatKhau.Text;
                rowFlagNhanVien["NgaySinh"] = Convert.ToDateTime(edit.dtDoBorn.Text);
                rowFlagNhanVien["NgayVaoLam"] = Convert.ToDateTime(edit.DtNgayVaoLam.Text);
                rowFlagNhanVien["MaCV"] = int.Parse(edit.txtMaChucVu.Text);
                SqlCommandBuilder cb = new SqlCommandBuilder(daNhanVien);
                daNhanVien.Update(dsNhanvien, "NhanVien");
            };
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            txtTimKiem.Text = "Nhập Họ Tên Nhân Viên Hoặc SĐT";
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
        }

        private void lbTimNhanSu_Click(object sender, EventArgs e)
        {
            conn.Open();
            
            
            if (ChucNang.IsAllDigits(txtTimKiem.Text))
            {
                dsNhanvien.Clear();
                SqlDataAdapter da = new SqlDataAdapter($"select*from NhanVien\r\nwhere NhanVien.SDT ={txtTimKiem.Text}", conn);
                da.Fill(dsNhanvien, "NhanVien");
                conn.Close();
                soluongdongNhanSu = 1;
            }
            else
            {
                dsNhanvien.Clear();
                SqlDataAdapter da = new SqlDataAdapter($"select*from NhanVien\r\nwhere NhanVien.TenNV =N'{txtTimKiem.Text}'", conn);
                da.Fill(dsNhanvien, "NhanVien");
                conn.Close();
                soluongdongNhanSu = 1;
            }

        }
        //Nhân Viên
    }
}
