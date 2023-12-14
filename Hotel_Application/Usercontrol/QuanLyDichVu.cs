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

namespace Hotel_Application.Usercontrol
{
    public partial class QuanLyDichVu : UserControl
    {
        public static List<int> MaLoaiDV = new List<int>();

        //
        SqlConnection conn = ConnectDB.connectstring;
        SqlCommand cmd;
        public QuanLyDichVu()
        {
            InitializeComponent();
        }

        private void QuanLyDichVu_Load(object sender, EventArgs e)
        {

            LoaddatagridDichVu();
            LoadcboGoiServiceVaService();
            LoadDetailGoiService();
        }


        //Dịch Vụ
        DataSet dsDichVu = new DataSet();
        SqlDataAdapter daDV;
        int SoluongdongDichVu;
        public void LoaddatagridDichVu()
        {
            conn.Open();
            daDV = new SqlDataAdapter("Select * From DichVu", conn);
            daDV.Fill(dsDichVu, "DichVu");

            DataColumn[] keyDichVu = new DataColumn[1];
            keyDichVu[0] = dsDichVu.Tables["DichVu"].Columns["MaDichVu"];
            dsDichVu.Tables["DichVu"].PrimaryKey = keyDichVu;
            dgvDichVu.DataSource = dsDichVu.Tables["DichVu"];
            SoluongdongDichVu = dgvDichVu.RowCount;
            conn.Close();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            AddDichVu addDichVu = new AddDichVu();
            addDichVu.FormClosed += delegate
            {
                LoaddatagridDichVu();
                cboService.Items.Add(addDichVu.txtTenDichVu.Text);
            };
            addDichVu.Show();

        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            DataRow dr = dsDichVu.Tables["DichVu"].Rows.Find(MaDichVu);
            string tendichvu = dr["TenDichVu"].ToString();
            if (dr != null)
            {
                dr.Delete();
            }
            SqlCommandBuilder cb = new SqlCommandBuilder(daDV);
            daDV.Update(dsDichVu, "DichVu");
            SoluongdongDichVu--;
            MessageBox.Show($"Đã xóa dịch vụ {tendichvu}");
            QuanLyDichVu_Load(null, EventArgs.Empty);
        }
        int MaDichVu;
        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < SoluongdongDichVu - 1)
            {
                DataGridViewRow row = this.dgvDichVu.Rows[e.RowIndex];
                MaDichVu = int.Parse(row.Cells["MaDichVu"].Value.ToString());
            }
        }

        private void btnAddGoiService_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"insert into GoiDichVu (TenGoi,KhuyenMai) values ('{txtTenGoi.Text}',{float.Parse(txtKhuyenMaiGoi.Text)})", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Đã thêm gói");
                cboGoiService.Items.Add(txtTenGoi.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Đã tồn tại gói");
            }

        }

        DataSet dsService = new DataSet();
        SqlDataAdapter daService;
        DataSet dsGoiService = new DataSet();
        SqlDataAdapter daGoiService;
        public void LoadcboGoiServiceVaService()
        {
            conn.Open();
            SqlCommand cmdservice = new SqlCommand("Select*from DichVu", conn);
            SqlDataReader reader = cmdservice.ExecuteReader();
            while (reader.Read())
            {
                cboService.Items.Add(reader["TenDichVu"].ToString());
            }
            reader.Close();
            cboService.SelectedIndex = 0;
            cmdservice = new SqlCommand("Select*from GoiDichVu", conn);
            reader = cmdservice.ExecuteReader();
            while (reader.Read())
            {
                cboGoiService.Items.Add(reader["TenGoi"].ToString());
            }
            reader.Close();
            cboGoiService.SelectedIndex = 0;
            conn.Close();
        }

        private void btnAddIntoGoi_Click(object sender, EventArgs e)
        {

            conn.Open();
            string searchMaGoi = $"Select MaGoi from GoiDichVu where TenGoi = N'{cboGoiService.SelectedItem.ToString()}' ";
            SqlCommand cmdGoiservice = new SqlCommand(searchMaGoi, conn);
            SqlDataReader reader = cmdGoiservice.ExecuteReader();
            int MaGoi = 0;
            while (reader.Read())
            {
                MaGoi = int.Parse(reader["MaGoi"].ToString());
            }
            reader.Close();
            string searchMaDichVu = $"Select MaDichVu from DichVu where TenDichVu = N'{cboService.SelectedItem.ToString()}' ";
            SqlCommand cmdservice = new SqlCommand(searchMaDichVu, conn);
            SqlDataReader reader2 = cmdservice.ExecuteReader();
            int MaDichVu = 0;
            while (reader2.Read())
            {
                MaDichVu = int.Parse(reader2["MaDichVu"].ToString());
            }
            reader2.Close();
            int checkMaGoi = 0;
            SqlCommand checkmagoi = new SqlCommand($"Select MaGoi from ChiTietGoi where {MaGoi} = ChiTietGoi.MaGoi and {MaDichVu} = ChiTietGoi.MaDichVu", conn);
            SqlDataReader reader3 = checkmagoi.ExecuteReader();
            while (reader3.Read())
            {
                checkMaGoi = int.Parse(reader3["MaGoi"].ToString());
            }
            reader3.Close();
            if (checkMaGoi == 0)
            {
                string insert = $"Insert into ChiTietGoi(MaGoi,MaDichVu) Values({MaGoi},{MaDichVu})";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                dschitietgoi.Clear();
                LoadDetailGoiService();

                MessageBox.Show("Add Completed");
            }
            else
            {
                MessageBox.Show("Da ton tai dich vu trong goi");
            }

            conn.Close();
        }

        DataSet dschitietgoi = new DataSet();
        SqlDataAdapter dachitietgoi;
        int SoLuongDEtailGoi;
        public void LoadDetailGoiService()
        {
            conn.Open();
            dgvDetailGoiService.DataSource = null;

            dgvDetailGoiService.Rows.Clear();
            dachitietgoi = new SqlDataAdapter("Select ChiTietGoi.MaGoi, TenGoi,ChiTietGoi.MaDichVu, TenDichVu, GiaTien, KhuyenMai from DichVu,GoiDichVu,ChiTietGoi where DichVu.MaDichVu = ChiTietGoi.MaDichVu and GoiDichVu.MaGoi = ChiTietGoi.MaGoi ", conn);
            dachitietgoi.Fill(dschitietgoi, "ChiTietGoi");

            dgvDetailGoiService.DataSource = dschitietgoi.Tables["ChiTietGoi"];
            SoLuongDEtailGoi = dgvDetailGoiService.RowCount;
            conn.Close();
        }
        int TMaGoi;
        int TMaDichVu;
        private void dgvDetailGoiService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < SoLuongDEtailGoi - 1)
            {
                DataGridViewRow row = this.dgvDetailGoiService.Rows[e.RowIndex];
                TMaGoi = int.Parse(row.Cells["MaGoi"].Value.ToString());
                TMaDichVu = int.Parse(row.Cells["MaDichVu"].Value.ToString());
            }
        }

        private void btnDeleteIntoGoi_Click(object sender, EventArgs e)
        {
            
                conn.Open();
                SqlCommand cmd = new SqlCommand($"Delete from ChiTietGoi where MaGoi = {TMaGoi} and MaDichVu = {TMaDichVu}", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                dschitietgoi.Clear();
                LoadDetailGoiService();
           
        }

        private void btnEditGoiService_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteGoiService_Click(object sender, EventArgs e)
        {

        }




        //DỊch vụ
    }
}
