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
            this.components = new System.ComponentModel.Container();
            this.btnCetak = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_jumlah = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_tanggal = new System.Windows.Forms.DateTimePicker();
            this.cb_kd_barang = new System.Windows.Forms.ComboBox();
            this.cb_kd_pelanggan = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodetransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodebarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodepelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tokonuriskandarDataSet = new tokonuriskandar.tokonuriskandarDataSet();
            this.transaksiTableAdapter = new tokonuriskandar.tokonuriskandarDataSetTableAdapters.transaksiTableAdapter();
            this.tableAdapterManager = new tokonuriskandar.tokonuriskandarDataSetTableAdapters.TableAdapterManager();
            this.btn_tampil = new System.Windows.Forms.Button();
            this.btn_report_all = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokonuriskandarDataSet)).BeginInit();
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
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
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
            // tb_jumlah
            // 
            this.tb_jumlah.Location = new System.Drawing.Point(158, 131);
            this.tb_jumlah.Name = "tb_jumlah";
            this.tb_jumlah.Size = new System.Drawing.Size(274, 20);
            this.tb_jumlah.TabIndex = 42;
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
            // cb_kd_pelanggan
            // 
            this.cb_kd_pelanggan.FormattingEnabled = true;
            this.cb_kd_pelanggan.Location = new System.Drawing.Point(158, 101);
            this.cb_kd_pelanggan.Name = "cb_kd_pelanggan";
            this.cb_kd_pelanggan.Size = new System.Drawing.Size(274, 21);
            this.cb_kd_pelanggan.TabIndex = 55;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodetransaksiDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn,
            this.kodebarangDataGridViewTextBoxColumn,
            this.kodepelangganDataGridViewTextBoxColumn,
            this.jumlahDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transaksiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 56;
            // 
            // kodetransaksiDataGridViewTextBoxColumn
            // 
            this.kodetransaksiDataGridViewTextBoxColumn.DataPropertyName = "kode_transaksi";
            this.kodetransaksiDataGridViewTextBoxColumn.HeaderText = "kode_transaksi";
            this.kodetransaksiDataGridViewTextBoxColumn.Name = "kodetransaksiDataGridViewTextBoxColumn";
            // 
            // tanggalDataGridViewTextBoxColumn
            // 
            this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "tanggal";
            this.tanggalDataGridViewTextBoxColumn.HeaderText = "tanggal";
            this.tanggalDataGridViewTextBoxColumn.Name = "tanggalDataGridViewTextBoxColumn";
            // 
            // kodebarangDataGridViewTextBoxColumn
            // 
            this.kodebarangDataGridViewTextBoxColumn.DataPropertyName = "kode_barang";
            this.kodebarangDataGridViewTextBoxColumn.HeaderText = "kode_barang";
            this.kodebarangDataGridViewTextBoxColumn.Name = "kodebarangDataGridViewTextBoxColumn";
            // 
            // kodepelangganDataGridViewTextBoxColumn
            // 
            this.kodepelangganDataGridViewTextBoxColumn.DataPropertyName = "kode_pelanggan";
            this.kodepelangganDataGridViewTextBoxColumn.HeaderText = "kode_pelanggan";
            this.kodepelangganDataGridViewTextBoxColumn.Name = "kodepelangganDataGridViewTextBoxColumn";
            // 
            // jumlahDataGridViewTextBoxColumn
            // 
            this.jumlahDataGridViewTextBoxColumn.DataPropertyName = "jumlah";
            this.jumlahDataGridViewTextBoxColumn.HeaderText = "jumlah";
            this.jumlahDataGridViewTextBoxColumn.Name = "jumlahDataGridViewTextBoxColumn";
            // 
            // transaksiBindingSource
            // 
            this.transaksiBindingSource.DataMember = "transaksi";
            this.transaksiBindingSource.DataSource = this.tokonuriskandarDataSet;
            // 
            // tokonuriskandarDataSet
            // 
            this.tokonuriskandarDataSet.DataSetName = "tokonuriskandarDataSet";
            this.tokonuriskandarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transaksiTableAdapter
            // 
            this.transaksiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.barangTableAdapter = null;
            this.tableAdapterManager.pelangganTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.transaksiTableAdapter = this.transaksiTableAdapter;
            this.tableAdapterManager.UpdateOrder = tokonuriskandar.tokonuriskandarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btn_tampil
            // 
            this.btn_tampil.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_tampil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_tampil.Location = new System.Drawing.Point(453, 90);
            this.btn_tampil.Name = "btn_tampil";
            this.btn_tampil.Size = new System.Drawing.Size(124, 23);
            this.btn_tampil.TabIndex = 58;
            this.btn_tampil.Text = "Refresh Tampil ";
            this.btn_tampil.UseVisualStyleBackColor = false;
            this.btn_tampil.Click += new System.EventHandler(this.btn_tampil_Click);
            // 
            // btn_report_all
            // 
            this.btn_report_all.Location = new System.Drawing.Point(454, 120);
            this.btn_report_all.Name = "btn_report_all";
            this.btn_report_all.Size = new System.Drawing.Size(123, 23);
            this.btn_report_all.TabIndex = 59;
            this.btn_report_all.Text = "Report All";
            this.btn_report_all.UseVisualStyleBackColor = true;
            this.btn_report_all.Click += new System.EventHandler(this.btn_report_all_Click);
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 386);
            this.Controls.Add(this.btn_report_all);
            this.Controls.Add(this.btn_tampil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_kd_pelanggan);
            this.Controls.Add(this.cb_kd_barang);
            this.Controls.Add(this.dtp_tanggal);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_jumlah);
            this.Controls.Add(this.label1);
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            this.Load += new System.EventHandler(this.FormTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokonuriskandarDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_jumlah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_tanggal;
        private System.Windows.Forms.ComboBox cb_kd_barang;
        private System.Windows.Forms.ComboBox cb_kd_pelanggan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private tokonuriskandarDataSet tokonuriskandarDataSet;
        private System.Windows.Forms.BindingSource transaksiBindingSource;
        private tokonuriskandarDataSetTableAdapters.transaksiTableAdapter transaksiTableAdapter;
        private tokonuriskandarDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodetransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodebarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodepelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_tampil;
        private System.Windows.Forms.Button btn_report_all;
    }
}