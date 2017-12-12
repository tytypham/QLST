namespace _1560169_1560182
{
    partial class QUANLIHANGHOA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QUANLIHANGHOA));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_qlHangHoa = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(107, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHÂN VIÊN QUẢN LÍ HÀNG HÓA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(155, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "TẤT CẢ SẢN PHẨM TẠI SIÊU THỊ\r\n";
            // 
            // dgv_qlHangHoa
            // 
            this.dgv_qlHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qlHangHoa.Location = new System.Drawing.Point(47, 130);
            this.dgv_qlHangHoa.Name = "dgv_qlHangHoa";
            this.dgv_qlHangHoa.Size = new System.Drawing.Size(548, 196);
            this.dgv_qlHangHoa.TabIndex = 4;
            this.dgv_qlHangHoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(271, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 40);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // QUANLIHANGHOA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 452);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgv_qlHangHoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QUANLIHANGHOA";
            this.Text = "QUANLIHANGHOA";
            this.Load += new System.EventHandler(this.QUANLIHANGHOA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_qlHangHoa;
        private System.Windows.Forms.Button button3;
    }
}