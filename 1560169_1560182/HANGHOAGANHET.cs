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
    public partial class HANGHOAGANHET : Form
    {
        SqlConnection con = null;
        SqlCommand cm = null;
        DataTable tb = new DataTable();
        string connectionString = "";

        public HANGHOAGANHET()
        {
           
            InitializeComponent();
            connectionString = @"Data Source=.;Initial Catalog=QuanLySieuThi;Integrated Security=True";
           

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PHANPHOIHANGHOA main = new PHANPHOIHANGHOA();
            this.Hide();
            main.Show();
            main.FormClosed += (s, ev) => this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HANGHOAGANHET_Load(object sender, EventArgs e)
        {
            LoadHangHoaGanHet();
        }
        void LoadHangHoaGanHet()
    {
        string kh = "select * from SANPHAMDUOCBAN";
        SqlDataAdapter da = new SqlDataAdapter(kh, connectionString);
        DataTable dt1 = new DataTable();
        da.Fill(dt1);
        dgv_hhGanHet.DataSource = dt1;
    }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
