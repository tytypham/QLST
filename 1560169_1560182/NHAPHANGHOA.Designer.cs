namespace _1560169_1560182
{
    partial class NHAPHANGHOA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NHAPHANGHOA));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_maSanPham = new System.Windows.Forms.TextBox();
            this.txb_tenSanPham = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_soLuong = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgv_Nhaphanghoa = new System.Windows.Forms.DataGridView();
            this.txt_donGia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_donGia = new System.Windows.Forms.TextBox();
            this.txb_donViTinh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Nhaphanghoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(97, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHÂN VIÊN PHÂN PHỐI NHẬP HÀNG HÓA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Sản Phẩm";
            // 
            // txb_maSanPham
            // 
            this.txb_maSanPham.Location = new System.Drawing.Point(188, 66);
            this.txb_maSanPham.Name = "txb_maSanPham";
            this.txb_maSanPham.Size = new System.Drawing.Size(121, 20);
            this.txb_maSanPham.TabIndex = 2;
            // 
            // txb_tenSanPham
            // 
            this.txb_tenSanPham.Location = new System.Drawing.Point(188, 115);
            this.txb_tenSanPham.Name = "txb_tenSanPham";
            this.txb_tenSanPham.Size = new System.Drawing.Size(121, 20);
            this.txb_tenSanPham.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(372, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tên Sản Phẩm ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số Lượng ";
            // 
            // txb_soLuong
            // 
            this.txb_soLuong.Location = new System.Drawing.Point(188, 155);
            this.txb_soLuong.Name = "txb_soLuong";
            this.txb_soLuong.Size = new System.Drawing.Size(121, 20);
            this.txb_soLuong.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(154, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 53);
            this.button1.TabIndex = 18;
            this.button1.Text = "THÊM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(325, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 53);
            this.button2.TabIndex = 19;
            this.button2.Text = "XÓA";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(487, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 53);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgv_Nhaphanghoa
            // 
            this.dgv_Nhaphanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Nhaphanghoa.Location = new System.Drawing.Point(3, 197);
            this.dgv_Nhaphanghoa.Name = "dgv_Nhaphanghoa";
            this.dgv_Nhaphanghoa.Size = new System.Drawing.Size(740, 150);
            this.dgv_Nhaphanghoa.TabIndex = 21;
            // 
            // txt_donGia
            // 
            this.txt_donGia.AutoSize = true;
            this.txt_donGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_donGia.Location = new System.Drawing.Point(376, 64);
            this.txt_donGia.Name = "txt_donGia";
            this.txt_donGia.Size = new System.Drawing.Size(64, 20);
            this.txt_donGia.TabIndex = 22;
            this.txt_donGia.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Đơn Vị Tính";
            // 
            // txb_donGia
            // 
            this.txb_donGia.Location = new System.Drawing.Point(487, 64);
            this.txb_donGia.Name = "txb_donGia";
            this.txb_donGia.Size = new System.Drawing.Size(100, 20);
            this.txb_donGia.TabIndex = 24;
            // 
            // txb_donViTinh
            // 
            this.txb_donViTinh.Location = new System.Drawing.Point(487, 118);
            this.txb_donViTinh.Name = "txb_donViTinh";
            this.txb_donViTinh.Size = new System.Drawing.Size(100, 20);
            this.txb_donViTinh.TabIndex = 25;
            // 
            // NHAPHANGHOA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 451);
            this.Controls.Add(this.txb_donViTinh);
            this.Controls.Add(this.txb_donGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_donGia);
            this.Controls.Add(this.dgv_Nhaphanghoa);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_soLuong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_tenSanPham);
            this.Controls.Add(this.txb_maSanPham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NHAPHANGHOA";
            this.Text = "NHAPHANGHOA";
            this.Load += new System.EventHandler(this.NHAPHANGHOA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Nhaphanghoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_maSanPham;
        private System.Windows.Forms.TextBox txb_tenSanPham;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_soLuong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgv_Nhaphanghoa;
        private System.Windows.Forms.Label txt_donGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_donGia;
        private System.Windows.Forms.TextBox txb_donViTinh;
    }
}