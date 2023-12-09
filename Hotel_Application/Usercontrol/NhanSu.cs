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
            SoluongdongChucvu = dgvChucVu.RowCount;
            dgvChucVu.ReadOnly = true;
            conn.Close();
        }

        private void btnAddChucVu_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand($"insert into ChucVu(TenCV,PhuCap) values (N'{txtTenCV.Text}','{float.Parse(txtPhuCap.Text)}')", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show($"Đã thêm chức vụ {txtTenCV.Text}");
            txtTenCV.Clear();
            txtPhuCap.Clear();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadBangChucVu();
        }
        //
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
            int i = 0;
            
                rowFlag = dataSet.Tables["ChucVu"].Rows.Find(maCV);
                EditChucVu edit = new EditChucVu();
                edit.Show();
                edit.FormClosing+= delegate
                {
                    rowFlag["TenCV"] = edit.txtTenCV.Text;
                    rowFlag["PhuCap"] = edit.txtPhuCap.Text;
                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    da.Update(dataSet, "ChucVu");
                };
        }
        //Chức Vụ//

        //Nhân Viên
        int soluongdongNhanSu;
        public void loadBangNhanVien()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string select = "Select * From NhanVien";
            dataSet = new DataSet();
            da = new SqlDataAdapter(select, conn);
            da.Fill(dataSet, "NhanVien");
            DataColumn[] key = new DataColumn[1];
            key[0] = dataSet.Tables["NhanVien"].Columns[0];
            dataSet.Tables["NhanVien"].PrimaryKey = key;
            dgvNhanSu.DataSource = dataSet.Tables["NhanVien"];
            soluongdongNhanSu = dgvNhanSu.RowCount;
            dgvNhanSu.ReadOnly = true;
            conn.Close();
        }

        private void btnAddNhanSu_Click(object sender, EventArgs e)
        {

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand($"insert into ChucVu(TenCV,PhuCap) values (N'{txtTenCV.Text}','{float.Parse(txtPhuCap.Text)}')", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show($"Đã thêm chức vụ {txtTenCV.Text}");
            txtTenCV.Clear();
            txtPhuCap.Clear();
        }
        //Nhân Viên
    }
}
