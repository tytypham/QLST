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
    public partial class QUANLIHANGHOA : Form
    {
        SqlConnection con = null;
        SqlCommand cm = null;
        DataTable tb = new DataTable();
        string connectionString = "";

        public QUANLIHANGHOA()
        {
            InitializeComponent();
            connectionString = @"Data Source=.;Initial Catalog=QuanLySieuThi;Integrated Security=True";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QUANLI main = new QUANLI();
            this.Hide();
            main.Show();
            main.FormClosed += (s, ev) => this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QUANLIHANGHOA_Load(object sender, EventArgs e)
        {
            LoadQuanLiHangHoa();

        }
        void LoadQuanLiHangHoa()
        {
            string kh = "select spdb.MaSanPham,spdb.TenSanPham,spdb.DonGia,spdb.DonViTinh,mhtq.ThoiGianNhap from SANPHAMDUOCBAN spdb,MATHANGTRONGKHO mhtk,MATHANGTAIQUAY mhtq where mhtk.MaMatHang = spdb.MaSanPham and spdb.MaSanPham = mhtq.MaMatHang";
            SqlDataAdapter da = new SqlDataAdapter(kh, connectionString);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            dgv_qlHangHoa.DataSource = dt1;
        }
    }
}
