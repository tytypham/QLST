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
    public partial class DANGNHAP : Form
    {
        public DANGNHAP()
        {
            InitializeComponent();
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QuanLySieuThi;Integrated Security=True");
            string sqlSelect = @"select nv.ChucVu
                                from NHANVIEN nv, TAIKHOANNHANVIEN  tk
                                where nv.MaNhanVien = tk.MaNhanVien and tk.TenDangNhap ='" + txt_tenDangNhap.Text + "' and tk.MatKhau = '" + txt_matKhau.Text +"'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read () == true)
            {
                if (reader[0].ToString() == "Nhân viên quản lí")
                {
                    QUANLI main = new QUANLI();
                    this.Hide();
                    main.Show();
                    main.FormClosed += (s, ev) => this.Close();

                }
                else if (reader[0].ToString() == "Nhân viên phân phối")
                {
                    PHANPHOIHANGHOA main = new PHANPHOIHANGHOA();
                    this.Hide();
                    main.Show();
                    main.FormClosed += (s, ev) => this.Close();

                }
                else
                {
                    THUNGAN main = new THUNGAN();
                    this.Hide();
                    main.Show();
                    main.FormClosed += (s, ev) => this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Ban dang nhap chua thanh cong ");
                txt_tenDangNhap.Text = "";
                txt_matKhau.Text = "";
                txt_tenDangNhap.Focus();
            }

        }
    }
}
