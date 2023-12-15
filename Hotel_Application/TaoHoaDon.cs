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
            daPhong = new SqlDataAdapter($"Select* From Phong where MaLoaiPhong = {IMaLoaiPhong} ", conn);
            daPhong.Fill(dsPhong, "Phong");
            conn.Close();
           
            foreach (DataRow item in dsPhong.Tables["Phong"].Rows)
            {
                cboPhong.Items.Add(item["TenPhong"].ToString());
                MaPhong.Add(int.Parse(item["MaPhong"].ToString()));
            }
        }
       
        private void cboLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int IMaLoaiPhong = MaLoaiPhong[cboLoaiPhong.SelectedIndex];
            //
            cboPhong.Items.Clear();
            LoadCboPhong(IMaLoaiPhong);
            cboPhong.SelectedIndex = 0;
        }
    }
}
