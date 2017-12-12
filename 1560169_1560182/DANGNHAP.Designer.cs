namespace _1560169_1560182
{
    partial class DANGNHAP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tenDangNhap = new System.Windows.Forms.TextBox();
            this.txt_matKhau = new System.Windows.Forms.TextBox();
            this.btn_dangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(43, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(46, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu ";
            // 
            // txt_tenDangNhap
            // 
            this.txt_tenDangNhap.Location = new System.Drawing.Point(229, 66);
            this.txt_tenDangNhap.Name = "txt_tenDangNhap";
            this.txt_tenDangNhap.Size = new System.Drawing.Size(205, 20);
            this.txt_tenDangNhap.TabIndex = 3;
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.Location = new System.Drawing.Point(229, 123);
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.Size = new System.Drawing.Size(205, 20);
            this.txt_matKhau.TabIndex = 4;
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.BackColor = System.Drawing.Color.Lime;
            this.btn_dangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangNhap.ForeColor = System.Drawing.Color.Black;
            this.btn_dangNhap.Location = new System.Drawing.Point(169, 208);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(179, 49);
            this.btn_dangNhap.TabIndex = 5;
            this.btn_dangNhap.Text = "Đăng Nhập";
            this.btn_dangNhap.UseVisualStyleBackColor = false;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
            // 
            // DANGNHAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 332);
            this.Controls.Add(this.btn_dangNhap);
            this.Controls.Add(this.txt_matKhau);
            this.Controls.Add(this.txt_tenDangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DANGNHAP";
            this.Text = "DANGNHAP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tenDangNhap;
        private System.Windows.Forms.TextBox txt_matKhau;
        private System.Windows.Forms.Button btn_dangNhap;
    }
}

