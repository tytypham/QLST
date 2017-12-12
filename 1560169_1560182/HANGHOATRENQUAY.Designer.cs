namespace _1560169_1560182
{
    partial class HANGHOATRENQUAY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HANGHOATRENQUAY));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgv_hhTrenQuay = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hhTrenQuay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(138, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ HÀNG HÓA TRÊN QUẦY";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 3;
            // 
            // dgv_hhTrenQuay
            // 
            this.dgv_hhTrenQuay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hhTrenQuay.Location = new System.Drawing.Point(42, 123);
            this.dgv_hhTrenQuay.Name = "dgv_hhTrenQuay";
            this.dgv_hhTrenQuay.Size = new System.Drawing.Size(533, 150);
            this.dgv_hhTrenQuay.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(294, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 48);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(38, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khu Vực";
            // 
            // HANGHOATRENQUAY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 451);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_hhTrenQuay);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HANGHOATRENQUAY";
            this.Text = "HANGHOATRENQUAY";
            this.Load += new System.EventHandler(this.HANGHOATRENQUAY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hhTrenQuay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgv_hhTrenQuay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}