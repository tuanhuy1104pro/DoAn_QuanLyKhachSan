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
    public partial class AddDichVu : Form
    {
        public static List<int> MaLoaiDV = new List<int>();
        //
        SqlConnection conn = ConnectDB.connectstring;
        SqlCommand cmd;
        public AddDichVu()
        {
            InitializeComponent();

        }

        //ComboBoxLoaiDichVu
        DataSet dsLoaiDichVu = new DataSet();
        SqlDataAdapter daLoaiDV;
        public void LoadComboboxLoaiDichVu()
        {
            conn.Open();
            daLoaiDV = new SqlDataAdapter("Select * From LoaiDichVu", conn);
            daLoaiDV.Fill(dsLoaiDichVu, "DichVu");
            foreach (DataRow dr in dsLoaiDichVu.Tables["DichVu"].Rows)
            {
                cboLoaiService.Items.Add(dr["TenLoaiDichVu"].ToString());
                int i = int.Parse(dr["MaLoaiDichVu"].ToString());
                MaLoaiDV.Add(i);
            }
            cboLoaiService.SelectedIndex = 0;
            conn.Close();
        }

        private void AddDichVu_Load(object sender, EventArgs e)
        {
            LoadComboboxLoaiDichVu();
        }

        DataSet dsDichVu = new DataSet();
        SqlDataAdapter daDichVu;
        private void btnCreateService_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (ChucNang.IsAllDigits(txtGiaTien.Text) == false)
                {
                    this.DialogResult = DialogResult.Cancel;
                    conn.Close();
                    MessageBox.Show("Giá Tiền Không Hợp Lệ");
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    int maloaidichvu = MaLoaiDV[cboLoaiService.SelectedIndex];
                    SqlCommand cmd = new SqlCommand($"Insert into DichVu(TenDichVu,GiaTien,MaLoaiDichVu) values ('{txtTenDichVu.Text}',{txtGiaTien.Text},{maloaidichvu})", conn);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    this.Close();
                }
                //
            }
            catch (Exception)
            {
                this.DialogResult = DialogResult.Cancel;
                MessageBox.Show("Đã tồn tại Dịch vụ");
                conn.Close();
                
            }
         
        }
        //ComboBoxLoaiDichVu
    }
}
