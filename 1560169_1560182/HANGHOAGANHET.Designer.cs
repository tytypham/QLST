namespace _1560169_1560182
{
    partial class HANGHOAGANHET
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HANGHOAGANHET));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_hhGanHet = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hhGanHet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(88, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHÂN VIÊN PHÂN PHỐI HÀNG HÓA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(134, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh Sách Thống Kê Hàng Hóa Gần Hết ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgv_hhGanHet
            // 
            this.dgv_hhGanHet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hhGanHet.Location = new System.Drawing.Point(76, 116);
            this.dgv_hhGanHet.Name = "dgv_hhGanHet";
            this.dgv_hhGanHet.Size = new System.Drawing.Size(446, 150);
            this.dgv_hhGanHet.TabIndex = 2;
            this.dgv_hhGanHet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(265, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 63);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // HANGHOAGANHET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 451);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgv_hhGanHet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HANGHOAGANHET";
            this.Text = "HANGHOAGANHET";
            this.Load += new System.EventHandler(this.HANGHOAGANHET_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hhGanHet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_hhGanHet;
        private System.Windows.Forms.Button button3;
    }
}