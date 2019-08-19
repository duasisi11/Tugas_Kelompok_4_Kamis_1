namespace tokonuriskandar
{
    partial class FormTransaksi
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
            this.btnCetak = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_tanggal = new System.Windows.Forms.DateTimePicker();
            this.cb_kd_barang = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCetak
            // 
            this.btnCetak.Location = new System.Drawing.Point(454, 61);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(123, 23);
            this.btnCetak.TabIndex = 50;
            this.btnCetak.Text = "Cetak Semua Data";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(453, 31);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(124, 23);
            this.btnTambah.TabIndex = 49;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Kode Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Jumlah";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Kode Pelanggan";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tanggal";
            // 
            // dtp_tanggal
            // 
            this.dtp_tanggal.Location = new System.Drawing.Point(158, 30);
            this.dtp_tanggal.Name = "dtp_tanggal";
            this.dtp_tanggal.Size = new System.Drawing.Size(274, 20);
            this.dtp_tanggal.TabIndex = 53;
            // 
            // cb_kd_barang
            // 
            this.cb_kd_barang.FormattingEnabled = true;
            this.cb_kd_barang.Location = new System.Drawing.Point(158, 63);
            this.cb_kd_barang.Name = "cb_kd_barang";
            this.cb_kd_barang.Size = new System.Drawing.Size(274, 21);
            this.cb_kd_barang.TabIndex = 54;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(158, 101);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(274, 21);
            this.comboBox2.TabIndex = 55;
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 386);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cb_kd_barang);
            this.Controls.Add(this.dtp_tanggal);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_tanggal;
        private System.Windows.Forms.ComboBox cb_kd_barang;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}