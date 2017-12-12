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
    public partial class NHAPHANGHOA : Form
    {
        DataTable dt1 = new DataTable();
 
        SqlConnection con = null;
        SqlCommand cm = null;
        DataTable tb = new DataTable();
        string connectionString = "";
        public NHAPHANGHOA()
        {
            InitializeComponent();
            connectionString = @"Data Source=.;Initial Catalog=QuanLySieuThi;Integrated Security=True";
            dgv_Nhaphanghoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void NHAPHANGHOA_Load(object sender, EventArgs e)
        {
            LoadNHAPHANGHOA();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PHANPHOIHANGHOA main = new PHANPHOIHANGHOA();
            this.Hide();
            main.Show();
            main.FormClosed += (s, ev) => this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        void LoadNHAPHANGHOA()
        {

            string kh = "select spdb.MaSanPham,spdb.TenSanPham,spdb.DonGia,spdb.DonViTinh,mhtk.SoLuongTrongKho as HANGHOA from MATHANGTRONGKHO mhtk,SANPHAMDUOCBAN spdb where mhtk.MaMatHang =spdb.MaSanPham ";
            SqlDataAdapter da = new SqlDataAdapter(kh, connectionString);
           
            
            da.Fill(dt1);
            dgv_Nhaphanghoa.DataSource = dt1;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //provider p = new provider();
            ////string SqlSelect = "insert into HANGHOA(MaSanPham,TenSanPham, DonGia,DonViTinh,SoLuongTrongKho '("+txb_maSanPham+","+txb_tenSanPham+","+txb_donGia+","+txb_donViTinh+","+txb_soLuong+"')";

            //p.ExcuteNonQuery(SqlSelect, CommandType.Text);
            dt1.Rows.Add(txb_maSanPham.Text, txb_tenSanPham.Text, txb_donGia.Text, txb_donViTinh.Text, txb_soLuong.Text);
        //    while (rd.Read())
        //    {
        //        tb.Rows.Add(stt, rd[0].ToString(), rd[1].ToString(), rd[2].ToString());
        //        stt++;
        //    }
        //    conn.Close();
        //    dgv_kmKhachHang.DataSource = tb;
        }
        public SqlConnection _con { get; set; }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    foreach (DataGridViewRow dr_dgv in dgv_Nhaphanghoa.SelectedRows)
        //    {

        //        DataRow dr = ((DataRowView)dr_dgv.DataBoundItem).Row;
        //        provider p = new provider();
        //        p.Connect();
        //        string sql = "Delete MATHANGTRONGKHO mhtk,SANPHAMDUOCBAN spdb where mhtk.MaMatHang =spdb.MaSanPham and mhtk.MaMatHang='" + dr[0].ToString() + "'";
        //        p.ExcuteNonQuery(sql, CommandType.Text);
        //        dt1.Rows.Remove(dr);
        //        p.Disconnect();
        //    }
            
        //}
        // e có tạo nút xóa nhưng không xóa được //
    }
}
