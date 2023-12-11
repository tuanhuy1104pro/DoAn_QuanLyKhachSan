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


        //DỊch vụ
    }
}
