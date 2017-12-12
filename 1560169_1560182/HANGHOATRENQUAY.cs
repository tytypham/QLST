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
    public partial class HANGHOATRENQUAY : Form
    {
        SqlConnection con = null;
        SqlCommand cm = null;
        DataTable tb = new DataTable();
        string connectionString = "";
        public HANGHOATRENQUAY()
        {
            InitializeComponent();
            connectionString = @"Data Source=.;Initial Catalog=QuanLySieuThi;Integrated Security=True";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PHANPHOIHANGHOA main = new PHANPHOIHANGHOA();
            this.Hide();
            main.Show();
            main.FormClosed += (s, ev) => this.Close();
        }

        private void HANGHOATRENQUAY_Load(object sender, EventArgs e)
        {
            LoadHANGHOATRENQUAY();

        }
        void LoadHANGHOATRENQUAY ()
        {
            string kh = "select * from MATHANGTAIQUAY";
            SqlDataAdapter da = new SqlDataAdapter(kh, connectionString);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            dgv_hhTrenQuay.DataSource = dt1;
        }
    }
}
