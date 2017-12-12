using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1560169_1560182
{
    public partial class QUANLI : Form
    {
        public QUANLI()
        {
            InitializeComponent();
        }

        

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DANGNHAP main = new DANGNHAP();
            main.Show();
            main.FormClosed += (s, ev) => this.Close();
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_qlHangHoa_Click(object sender, EventArgs e)
        {
            QUANLIHANGHOA main = new QUANLIHANGHOA();
            this.Hide();
            main.Show();
            main.FormClosed += (s, ev) => this.Close();
        }

        private void btn_baoCao_Click(object sender, EventArgs e)
        {
            BAOCAO main = new BAOCAO();
            this.Hide();
            main.Show();
            main.FormClosed += (s, ev) => this.Close();
        }

        private void btn_khuyenMai_Click(object sender, EventArgs e)
        {
            KHUYENMAI main = new KHUYENMAI();
            this.Hide();
            main.Show();
            main.FormClosed += (s, ev) => this.Close();
        }

        private void btn_qlTaiKhoan_Click(object sender, EventArgs e)
        {
            QUANLITAIKHOAN main = new QUANLITAIKHOAN();
            this.Hide();
            main.Show();
            main.FormClosed += (s, ev) => this.Close();
        }

        private void btn_quiDinh_Click(object sender, EventArgs e)
        {
            QUIDINH main = new QUIDINH();
            this.Hide();
            main.Show();
            main.FormClosed += (s, ev) => this.Close();
        }

        private void btn_quayVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            DANGNHAP main = new DANGNHAP();
           
            main.Show();
            main.FormClosed += (s, ev) => this.Close();
        }
    }
}
