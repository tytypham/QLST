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
    public partial class PHANPHOIHANGHOA : Form
    {
        public PHANPHOIHANGHOA()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PHANPHOIHANGHOA_Load(object sender, EventArgs e)
        {

        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DANGNHAP main = new DANGNHAP();
            main.Show();
            main.FormClosed += (s, ev) => this.Close();
        }

        private void btn_hhGanHet_Click(object sender, EventArgs e)
        {
            HANGHOAGANHET main = new HANGHOAGANHET();
            this.Hide();
            main.Show();
            main.FormClosed += (s, ev) => this.Close();
        }

        private void btn_hhTrenQuay_Click(object sender, EventArgs e)
        {
            HANGHOATRENQUAY main = new HANGHOATRENQUAY();
            this.Hide();
            main.Show();
            main.FormClosed += (s, ev) => this.Close();
        }

        private void btn_hhTrongKho_Click(object sender, EventArgs e)
        {
            HANGHOATRONGKHO main = new HANGHOATRONGKHO();
            this.Hide();
            main.Show();
            main.FormClosed += (s, ev) => this.Close();
        }

        private void btn_nhapHangHoa_Click(object sender, EventArgs e)
        {
            NHAPHANGHOA main = new NHAPHANGHOA();
            this.Hide();
            main.Show();
            main.FormClosed += (s, ev) => this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            DANGNHAP main = new DANGNHAP();
            this.Hide();
            main.Show();
            main.FormClosed += (s, ev) => this.Close();
        }

       
    }
}
