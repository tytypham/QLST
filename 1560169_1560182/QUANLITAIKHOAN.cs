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
    public partial class QUANLITAIKHOAN : Form
    {

        SqlConnection con = null;
        SqlCommand cm = null;
        DataTable tb = new DataTable();
        string connectionString = "";
        DataTable dt1 = new DataTable();
        public QUANLITAIKHOAN()
        {
            InitializeComponent();
            connectionString = @"Data Source=.;Initial Catalog=QuanLySieuThi;Integrated Security=True";
            dgv_qlNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
        }

        private void QUANLITAIKHOAN_Load(object sender, EventArgs e)
        {
            Loadquanlitaikhoan();
            cb_gioiTinh.Items.AddRange(new string[] { "Nữ","Nam" });
            cb_chucVu.Items.AddRange(new string[] {"nhân viên quản li","nhân viên thu ngân","nhân viên phân phối"});
          
        }
        void Loadquanlitaikhoan()
        {
            string nv = "select * from NHANVIEN";
            SqlDataAdapter da = new SqlDataAdapter(nv, connectionString);      
            da.Fill(dt1);
            dgv_qlNhanVien.DataSource = dt1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QUANLI main = new QUANLI();
            this.Hide();
            main.Show();
            main.FormClosed += (s, ev) => this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt1.Rows.Add(txb_maNhanVien.Text, txb_tenNhanVien.Text, txb_diaChi.Text, txb_soDienThoai.Text, txb_email.Text, cb_gioiTinh.SelectedItem, cb_chucVu.SelectedItem);
            string proc = "USP_ThemTk";
            con = new SqlConnection(connectionString);
            cm = new SqlCommand(proc, con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.Add("@temp", SqlDbType.Int);
            cm.Parameters.Add("@MaNhanVien", SqlDbType.Int);
            cm.Parameters.Add("@TenNhanVien", SqlDbType.NVarChar);
            cm.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
            cm.Parameters.Add("@SoDienThoai", SqlDbType.VarChar);

          
            cm.Parameters.Add("@email", SqlDbType.VarChar);
            cm.Parameters.Add("@GioiTinh", SqlDbType.NVarChar);
            cm.Parameters.Add("@ChucVu", SqlDbType.NVarChar);

            cm.Parameters["@MaNhanVien"].Value = txb_maNhanVien.Text;
            cm.Parameters["@TenNhanVien"].Value = txb_tenNhanVien.Text;
            cm.Parameters["@DiaChi"].Value = txb_diaChi.Text;
            cm.Parameters["@SoDienThoai"].Value = txb_soDienThoai.Text;
            
            cm.Parameters["@email"].Value = txb_email.Text;
            cm.Parameters["@GioiTinh"].Value = cb_gioiTinh.SelectedItem;
            cm.Parameters["@ChucVu"].Value = cb_chucVu.SelectedItem;
            cm.Parameters["@temp"].Value = -1;
            cm.Connection.Open();
            cm.ExecuteNonQuery();
            cm.Connection.Close();
            string temp = cm.Parameters["@temp"].Value.ToString();
            if(temp == "-1")
            {
                MessageBox.Show("Them thanh cong", "thong bao");
            }
            else
            {
                MessageBox.Show("Them that cong", "thong bao");
                Loadquanlitaikhoan();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr_dgv in dgv_qlNhanVien.SelectedRows)
            {
                DataRow dr = ((DataRowView)dr_dgv.DataBoundItem).Row;
                provider p = new provider();
                string sql = "Delete NHANVIEN where MaNhanVien='"+dr[0].ToString()+"'";
                p.ExcuteNonQuery(sql, CommandType.Text);
                dt1.Rows.Remove(dr);
                
            }
        }


        }

    }

