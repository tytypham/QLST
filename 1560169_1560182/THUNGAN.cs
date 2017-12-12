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
    public partial class THUNGAN : Form
    {
        SqlConnection _con = null;
        SqlCommand cm = null;
        DataTable dt1 = new DataTable();
        string connectionString = "";
        public THUNGAN()
        {
            InitializeComponent();
            connectionString = @"Data Source=.;Initial Catalog=QuanLySieuThi;Integrated Security=True";
            dgv_ctHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void THUNGAN_Load(object sender, EventArgs e)
        {
            Loadthungan();

        }
        void Loadthungan()
        {
            string kh = "select * from CHITIETHOADON";
            SqlDataAdapter da = new SqlDataAdapter(kh, connectionString);
            dt1.Clear();
            da.Fill(dt1);
            dgv_ctHoaDon.DataSource = dt1;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DANGNHAP main = new DANGNHAP();
            this.Hide();
            main.Show();
            main.FormClosed += (s, ev) => this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DANGNHAP main = new DANGNHAP();
            main.Show();
            main.FormClosed += (s, ev) => this.Close();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            dt1.Rows.Add(txb_maHoaDon.Text, txb_maSanPham.Text, txb_soTienGiam.Text, txb_thanhTien.Text);
            string proc = "USP_ThemHD";
            _con = new SqlConnection(connectionString);
            cm = new SqlCommand(proc, _con);
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add("@MaHoaDon", SqlDbType.Int);
            cm.Parameters.Add("@MaSanPham", SqlDbType.Int);
            cm.Parameters.Add("@SoTienGiam", SqlDbType.Decimal);
            cm.Parameters.Add("@ThanhTien", SqlDbType.Decimal);
            cm.Parameters.Add("@temp", SqlDbType.Int).Direction = ParameterDirection.Output;

            cm.Parameters["@MaHoaDon"].Value = txb_maHoaDon.Text ;
            cm.Parameters["@MaSanPham"].Value = txb_maSanPham.Text;
            cm.Parameters["@SoTienGiam"].Value = txb_soTienGiam.Text;
            cm.Parameters["@ThanhTien"].Value = txb_thanhTien.Text;

            cm.Parameters["@temp"].Value = -1;
            cm.Connection.Open();
            cm.ExecuteNonQuery();
            cm.Connection.Close();
            string temp = cm.Parameters["@temp"].Value.ToString();
            if (temp == "-1")
            {
                MessageBox.Show("Them thanh cong", "thong bao");
            }
            else
            {
                MessageBox.Show("Them that bai", "thong bao");
                Loadthungan();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dgv_ctHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr_dgv in dgv_ctHoaDon.SelectedRows)
            {

                DataRow dr = ((DataRowView)dr_dgv.DataBoundItem).Row;
                provider p = new provider();
                p.Connect();
                string sql = "Delete CHITIETHOADON where MaHoaDon='" + dr[0].ToString() + "'";
                p.ExcuteNonQuery(sql, CommandType.Text);
                dt1.Rows.Remove(dr);
                p.Disconnect();
            }
        }

    
    }
}
