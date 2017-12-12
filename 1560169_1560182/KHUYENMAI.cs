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
    public partial class KHUYENMAI : Form
    {
        SqlConnection _con = null;
        SqlCommand cm = null;
        DataTable dt1 = new DataTable();
        string connectionString = "";
        public KHUYENMAI()
        {
            InitializeComponent();
            connectionString = @"Data Source=.;Initial Catalog=QuanLySieuThi;Integrated Security=True";
            dgv_kmKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        
        private void KHUYENMAI_Load(object sender, EventArgs e)
        {
            
            /*tb.Columns.Add("Số thứ tự", typeof(int));
            tb.Columns.Add("Loại Ưu Đãi", typeof(string));
            tb.Columns.Add("Điểm Tích Lũy", typeof(string));
            tb.Columns.Add("Tỉ lệ Ưu Đãi", typeof(string));

            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QuanLySieuThi;Integrated Security=True");
            string SqlSelect = @"Select LoaiUuDai, DiemTichLuyCanThiet, PhanTramUuDai from MUCUUDAIKHACHHANG";
            conn.Open();
            SqlCommand cmd = new SqlCommand(SqlSelect, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            int stt = 1;
            while(rd.Read()){
                tb.Rows.Add(stt, rd[0].ToString(), rd[1].ToString(), rd[2].ToString());
                stt++;
            }
            conn.Close();
            dgv_kmKhachHang.DataSource = tb;
             * */

            LoadKH();
          //  LoadKMMH();
            
        }
        
        void LoadKH()
        {
            string kh = "select * from KHACHHANG";
            SqlDataAdapter da = new SqlDataAdapter(kh, connectionString);
            dt1.Clear();
            da.Fill(dt1);
            dgv_kmKhachHang.DataSource = dt1;
            
        }
        //void LoadKMMH()
        //{
        //    string mh = "select * from MATHANG";
        //    SqlDataAdapter da = new SqlDataAdapter(mh, connectionString);
        //    dt1.Clear();
        //    da.Fill(dt1);
        //    dgv_kmKhachHang.DataSource = dt1;
        //}


       

        

        private void button4_Click(object sender, EventArgs e)
        {
            QUANLI main = new QUANLI();
            this.Hide();
            main.Show();
            main.FormClosed += (s, ev) => this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            QUANLI main = new QUANLI();
            this.Hide();
            main.Show();
            main.FormClosed += (s, ev) => this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr_dgv in dgv_kmKhachHang.SelectedRows)
            {
                
                DataRow dr = ((DataRowView)dr_dgv.DataBoundItem).Row;
                provider p = new provider();
                p.Connect();
                string sql = "Delete KHACHHANG where MaKhachHang='" + dr[0].ToString() + "'";
                p.ExcuteNonQuery(sql, CommandType.Text);
                dt1.Rows.Remove(dr);
                p.Disconnect();
                ////try
                ////{
                ////    foreach(DataGridViewRow dgv_row in dgv_kmKhachHang.SelectedRows){
                ////        DataRow dr = ((DataRowView)dgv_row.DataBoundItem).Row;

                ////        string sql = "delete MUCUUDAIKHACHHANG where LoaiUuDai = '" + dr[1].ToString();

                ////        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QuanLySieuThi;Integrated Security=True");

                ////        conn.Open();
                ////        SqlCommand cmd = new SqlCommand(sql, conn);
                ////        cmd.CommandType = CommandType.Text;
                ////        cmd.ExecuteNonQuery();


                ////    }

            }
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            QUANLI main = new QUANLI();
            this.Hide();
            main.Show();
            main.FormClosed += (s, ev) => this.Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            QUANLI main = new QUANLI();
            this.Hide();
            main.Show();
            main.FormClosed += (s, ev) => this.Close();
        }

        


        private void btn_them_Click(object sender, EventArgs e)
        {
            string proc = "USP_ThemKH";
            _con = new SqlConnection(connectionString);
            cm = new SqlCommand(proc, _con);
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add("@MaKhachHang", SqlDbType.Int);
            cm.Parameters.Add("@TenKhachHang", SqlDbType.NVarChar);
            cm.Parameters.Add("@SoDienThoai", SqlDbType.VarChar);
            cm.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
            cm.Parameters.Add("@DiemTichLuy", SqlDbType.Float);
            cm.Parameters.Add("@temp", SqlDbType.Int).Direction = ParameterDirection.Output;

            cm.Parameters["@MaKhachHang"].Value = txb_maKhachHang.Text;
            cm.Parameters["@TenKhachHang"].Value = txb_tenKhachHang.Text;
            cm.Parameters["@SoDienThoai"].Value = txb_soDienThoai.Text;
            cm.Parameters["@DiaChi"].Value = txb_diaChi.Text;
            cm.Parameters["@DiemTichLuy"].Value = txb_diemTichLuy.Text;

            cm.Parameters["@temp"].Value = -1;
            cm.Connection.Open();
            cm.ExecuteNonQuery();
            cm.Connection.Close();
            string temp = cm.Parameters["@temp"].Value.ToString();
            if(temp == "-1")
            {
                MessageBox.Show("Them that bai", "thong bao");
            }
            else
            {
                MessageBox.Show("Them thanh cong", "thong bao");
                LoadKH();
            }
        }





        public SqlDbType S { get; set; }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr_dgv in dgv_kmKhachHang.SelectedRows)
            {

                DataRow dr = ((DataRowView)dr_dgv.DataBoundItem).Row;
                
                dr[0] = txb_maKhachHang.Text;
                dr[1] = txb_tenKhachHang.Text;
                dr[2] = txb_soDienThoai.Text;
                dr[3] = txb_diaChi.Text;
                dr[4] = txb_diemTichLuy.Text;               
                provider p = new provider();
                p.Connect();
                string sql = "update KHACHHANG set MaKhachHang='" + txb_maKhachHang.Text + "',TenKhachHang ='" + txb_tenKhachHang.Text + "',SoDienThoai=" + txb_soDienThoai.Text + ",DiaChi='" + txb_diaChi.Text + "',DiemTichLuy=" + txb_diemTichLuy.Text +  "where MaKhachHang='"+dgv_kmKhachHang.Rows[dgv_kmKhachHang.CurrentCell.RowIndex].Cells[0].Value.ToString()+"'";
                    //"where MaKhachHang='" + txb_maKhachHang.Text+ "'";
                p.ExcuteNonQuery(sql, CommandType.Text);              
                p.Disconnect();
            }
        }

        private void dgv_kmKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        


    }

    }

