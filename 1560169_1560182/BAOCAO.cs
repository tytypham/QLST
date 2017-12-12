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

namespace _1560169_1560182
{
    public partial class BAOCAO : Form
    {
        public BAOCAO()
        {
            InitializeComponent();
        }

        private void BAOCAO_Load(object sender, EventArgs e)
        {
            cb_ngay.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            cb_thang.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cb_nam.Items.AddRange(new string[] { "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019" });
            DataTable tb = new DataTable();
            tb.Columns.Add("Số thứ tự",typeof(int));
            tb.Columns.Add("Mã Sản Phẩm", typeof(int));
            tb.Columns.Add("Tên sản phẩm", typeof(string));
            tb.Columns.Add("Tổng số lượng", typeof(int));
            tb.Columns.Add("Tổng doanh thu", typeof(decimal));
            tb.Columns.Add("Đơn giá", typeof(decimal));
            tb.Columns.Add("Mã Sản Pham tặng kèm", typeof(int));
            tb.Columns.Add("Đon vi tinh", typeof(string));

            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QuanLySieuThi;Integrated Security=True");
            string SqlSelect = @"Select spbd.MaSanPham, spbd.TenSanPham, spbd.DonGia, mhud.MaSanPhamTangKem, spbd.DonViTinh from SANPHAMDUOCBAN spbd,MATHANGUUDAI mhud where spbd.MaSanPham = mhud.MaMatHang and mhud.MaSanPhamTangKem = spbd.MaSanPham";
            conn.Open();
            SqlCommand cmd = new SqlCommand(SqlSelect, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            int i = 1;
            while (reader.Read())
            {
                int masp = reader.GetInt32(0);
                SqlConnection conn1 = new SqlConnection(@"Data Source=.;Initial Catalog=QuanLySieuThi;Integrated Security=True");
                string SqlSelect1 = @"Select ct.MaHoaDon ,ct.MaSanPham, count(*), sum(ct.ThanhTien) from HOADON hd,CHITIETHOADON ct where ct.MaHoaDon = hd.MaHoaDon and ct.MaSanPham = '" + masp + "' group by ct.MaHoaDon,ct.MaSanPham";
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn1);
                cmd1.CommandType = CommandType.Text;
                SqlDataReader reader1 = cmd1.ExecuteReader();
                int tongSoLuong = 0;
                decimal tongDoanhThu = 0;
                while (reader1.Read())
                {
                    tongSoLuong += reader1.GetInt32(2);
                    tongDoanhThu += reader1.GetDecimal(3);
                }
                
                tb.Rows.Add(i, reader.GetInt32(0), reader[1].ToString(), tongSoLuong, tongDoanhThu, reader.GetDecimal(2), reader.GetInt32(3), reader[4].ToString());
                
                i++;
                reader1.Close();
            }
            reader.Close();

            dgv_bcDoanhThu.DataSource = tb;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public string sqlSelect { get; set; }

        private void btn_xuat_Click(object sender, EventArgs e)
        {

           
        }

        private void btn_quayVe_Click(object sender, EventArgs e)
        {
            this.Hide();

            QUANLI main = new QUANLI();
            this.Hide();
            main.Show();
            main.FormClosed += (s, ev) => this.Close();
        }

        
    }
}
