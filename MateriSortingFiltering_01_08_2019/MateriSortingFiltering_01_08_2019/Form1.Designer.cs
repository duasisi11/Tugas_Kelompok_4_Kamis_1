namespace MateriSortingFiltering_01_08_2019
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbCari = new System.Windows.Forms.ComboBox();
            this.cbUrut = new System.Windows.Forms.ComboBox();
            this.cbJenis = new System.Windows.Forms.ComboBox();
            this.tbKriteria = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSeleksi = new System.Windows.Forms.Button();
            this.btnUrutkan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Berdasarkan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kriteria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Urut Berdasarkan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jenis Pengurutan";
            // 
            // cbCari
            // 
            this.cbCari.FormattingEnabled = true;
            this.cbCari.Location = new System.Drawing.Point(206, 80);
            this.cbCari.Name = "cbCari";
            this.cbCari.Size = new System.Drawing.Size(330, 21);
            this.cbCari.TabIndex = 4;
            // 
            // cbUrut
            // 
            this.cbUrut.FormattingEnabled = true;
            this.cbUrut.Location = new System.Drawing.Point(206, 161);
            this.cbUrut.Name = "cbUrut";
            this.cbUrut.Size = new System.Drawing.Size(330, 21);
            this.cbUrut.TabIndex = 5;
            // 
            // cbJenis
            // 
            this.cbJenis.FormattingEnabled = true;
            this.cbJenis.Items.AddRange(new object[] {
            "ASC",
            "DESC"});
            this.cbJenis.Location = new System.Drawing.Point(206, 199);
            this.cbJenis.Name = "cbJenis";
            this.cbJenis.Size = new System.Drawing.Size(330, 21);
            this.cbJenis.TabIndex = 6;
            // 
            // tbKriteria
            // 
            this.tbKriteria.Location = new System.Drawing.Point(206, 121);
            this.tbKriteria.Name = "tbKriteria";
            this.tbKriteria.Size = new System.Drawing.Size(330, 20);
            this.tbKriteria.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(109, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(782, 184);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnSeleksi
            // 
            this.btnSeleksi.Location = new System.Drawing.Point(600, 119);
            this.btnSeleksi.Name = "btnSeleksi";
            this.btnSeleksi.Size = new System.Drawing.Size(75, 23);
            this.btnSeleksi.TabIndex = 9;
            this.btnSeleksi.Text = "SELEKSI";
            this.btnSeleksi.UseVisualStyleBackColor = true;
            this.btnSeleksi.Click += new System.EventHandler(this.btnSeleksi_Click);
            // 
            // btnUrutkan
            // 
            this.btnUrutkan.Location = new System.Drawing.Point(600, 199);
            this.btnUrutkan.Name = "btnUrutkan";
            this.btnUrutkan.Size = new System.Drawing.Size(75, 23);
            this.btnUrutkan.TabIndex = 10;
            this.btnUrutkan.Text = "URUTKAN";
            this.btnUrutkan.UseVisualStyleBackColor = true;
            this.btnUrutkan.Click += new System.EventHandler(this.btnUrutkan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 516);
            this.Controls.Add(this.btnUrutkan);
            this.Controls.Add(this.btnSeleksi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbKriteria);
            this.Controls.Add(this.cbJenis);
            this.Controls.Add(this.cbUrut);
            this.Controls.Add(this.cbCari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCari;
        private System.Windows.Forms.ComboBox cbUrut;
        private System.Windows.Forms.ComboBox cbJenis;
        private System.Windows.Forms.TextBox tbKriteria;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSeleksi;
        private System.Windows.Forms.Button btnUrutkan;
    }
}

