namespace CRUD_procedure_05_08_2019
{
    partial class pegawai
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempatlhrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgllhrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendidikanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jnskelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodegapokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmlanakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pegawaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kepegawaianDataSet = new CRUD_procedure_05_08_2019.kepegawaianDataSet();
            this.btnTampil = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.tbNIP = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.jabatanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jabatanTableAdapter = new CRUD_procedure_05_08_2019.kepegawaianDataSetTableAdapters.jabatanTableAdapter();
            this.pegawaiTableAdapter = new CRUD_procedure_05_08_2019.kepegawaianDataSetTableAdapters.pegawaiTableAdapter();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.tbKota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTmpLhr = new System.Windows.Forms.TextBox();
            this.tbGapok = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAgama = new System.Windows.Forms.TextBox();
            this.tbjklmn = new System.Windows.Forms.TextBox();
            this.tbPend = new System.Windows.Forms.TextBox();
            this.tbJmlAnak = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.dtpTglLhr = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kepegawaianDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jabatanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nipDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.kotaDataGridViewTextBoxColumn,
            this.tempatlhrDataGridViewTextBoxColumn,
            this.tgllhrDataGridViewTextBoxColumn,
            this.pendidikanDataGridViewTextBoxColumn,
            this.jnskelaminDataGridViewTextBoxColumn,
            this.agamaDataGridViewTextBoxColumn,
            this.kodegapokDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.jmlanakDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pegawaiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(939, 233);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nipDataGridViewTextBoxColumn
            // 
            this.nipDataGridViewTextBoxColumn.DataPropertyName = "nip";
            this.nipDataGridViewTextBoxColumn.HeaderText = "nip";
            this.nipDataGridViewTextBoxColumn.Name = "nipDataGridViewTextBoxColumn";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // kotaDataGridViewTextBoxColumn
            // 
            this.kotaDataGridViewTextBoxColumn.DataPropertyName = "kota";
            this.kotaDataGridViewTextBoxColumn.HeaderText = "kota";
            this.kotaDataGridViewTextBoxColumn.Name = "kotaDataGridViewTextBoxColumn";
            // 
            // tempatlhrDataGridViewTextBoxColumn
            // 
            this.tempatlhrDataGridViewTextBoxColumn.DataPropertyName = "tempat_lhr";
            this.tempatlhrDataGridViewTextBoxColumn.HeaderText = "tempat_lhr";
            this.tempatlhrDataGridViewTextBoxColumn.Name = "tempatlhrDataGridViewTextBoxColumn";
            // 
            // tgllhrDataGridViewTextBoxColumn
            // 
            this.tgllhrDataGridViewTextBoxColumn.DataPropertyName = "tgl_lhr";
            this.tgllhrDataGridViewTextBoxColumn.HeaderText = "tgl_lhr";
            this.tgllhrDataGridViewTextBoxColumn.Name = "tgllhrDataGridViewTextBoxColumn";
            // 
            // pendidikanDataGridViewTextBoxColumn
            // 
            this.pendidikanDataGridViewTextBoxColumn.DataPropertyName = "pendidikan";
            this.pendidikanDataGridViewTextBoxColumn.HeaderText = "pendidikan";
            this.pendidikanDataGridViewTextBoxColumn.Name = "pendidikanDataGridViewTextBoxColumn";
            // 
            // jnskelaminDataGridViewTextBoxColumn
            // 
            this.jnskelaminDataGridViewTextBoxColumn.DataPropertyName = "jns_kelamin";
            this.jnskelaminDataGridViewTextBoxColumn.HeaderText = "jns_kelamin";
            this.jnskelaminDataGridViewTextBoxColumn.Name = "jnskelaminDataGridViewTextBoxColumn";
            // 
            // agamaDataGridViewTextBoxColumn
            // 
            this.agamaDataGridViewTextBoxColumn.DataPropertyName = "agama";
            this.agamaDataGridViewTextBoxColumn.HeaderText = "agama";
            this.agamaDataGridViewTextBoxColumn.Name = "agamaDataGridViewTextBoxColumn";
            // 
            // kodegapokDataGridViewTextBoxColumn
            // 
            this.kodegapokDataGridViewTextBoxColumn.DataPropertyName = "kode_gapok";
            this.kodegapokDataGridViewTextBoxColumn.HeaderText = "kode_gapok";
            this.kodegapokDataGridViewTextBoxColumn.Name = "kodegapokDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // jmlanakDataGridViewTextBoxColumn
            // 
            this.jmlanakDataGridViewTextBoxColumn.DataPropertyName = "jml_anak";
            this.jmlanakDataGridViewTextBoxColumn.HeaderText = "jml_anak";
            this.jmlanakDataGridViewTextBoxColumn.Name = "jmlanakDataGridViewTextBoxColumn";
            // 
            // pegawaiBindingSource
            // 
            this.pegawaiBindingSource.DataMember = "pegawai";
            this.pegawaiBindingSource.DataSource = this.kepegawaianDataSet;
            // 
            // kepegawaianDataSet
            // 
            this.kepegawaianDataSet.DataSetName = "kepegawaianDataSet";
            this.kepegawaianDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(771, 349);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(75, 23);
            this.btnTampil.TabIndex = 1;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.UseVisualStyleBackColor = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(877, 349);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 2;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(768, 399);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(75, 23);
            this.btnUbah.TabIndex = 3;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(877, 399);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 4;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // tbNIP
            // 
            this.tbNIP.Location = new System.Drawing.Point(115, 264);
            this.tbNIP.Name = "tbNIP";
            this.tbNIP.Size = new System.Drawing.Size(205, 20);
            this.tbNIP.TabIndex = 5;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(115, 302);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(205, 20);
            this.tbNama.TabIndex = 6;
            // 
            // jabatanBindingSource
            // 
            this.jabatanBindingSource.DataMember = "jabatan";
            this.jabatanBindingSource.DataSource = this.kepegawaianDataSet;
            // 
            // jabatanTableAdapter
            // 
            this.jabatanTableAdapter.ClearBeforeFill = true;
            // 
            // pegawaiTableAdapter
            // 
            this.pegawaiTableAdapter.ClearBeforeFill = true;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(115, 337);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(205, 20);
            this.tbAlamat.TabIndex = 7;
            // 
            // tbKota
            // 
            this.tbKota.Location = new System.Drawing.Point(115, 371);
            this.tbKota.Name = "tbKota";
            this.tbKota.Size = new System.Drawing.Size(205, 20);
            this.tbKota.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "NIP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tempat Lahir";
            // 
            // tbTmpLhr
            // 
            this.tbTmpLhr.Location = new System.Drawing.Point(115, 408);
            this.tbTmpLhr.Name = "tbTmpLhr";
            this.tbTmpLhr.Size = new System.Drawing.Size(205, 20);
            this.tbTmpLhr.TabIndex = 14;
            // 
            // tbGapok
            // 
            this.tbGapok.Location = new System.Drawing.Point(447, 408);
            this.tbGapok.Name = "tbGapok";
            this.tbGapok.Size = new System.Drawing.Size(205, 20);
            this.tbGapok.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Kode Gapok";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Agama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Jenis Kelamin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(359, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Pendidikan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(359, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tanggal Lahir";
            // 
            // tbAgama
            // 
            this.tbAgama.Location = new System.Drawing.Point(447, 371);
            this.tbAgama.Name = "tbAgama";
            this.tbAgama.Size = new System.Drawing.Size(205, 20);
            this.tbAgama.TabIndex = 18;
            // 
            // tbjklmn
            // 
            this.tbjklmn.Location = new System.Drawing.Point(447, 337);
            this.tbjklmn.Name = "tbjklmn";
            this.tbjklmn.Size = new System.Drawing.Size(205, 20);
            this.tbjklmn.TabIndex = 17;
            // 
            // tbPend
            // 
            this.tbPend.Location = new System.Drawing.Point(447, 302);
            this.tbPend.Name = "tbPend";
            this.tbPend.Size = new System.Drawing.Size(205, 20);
            this.tbPend.TabIndex = 16;
            // 
            // tbJmlAnak
            // 
            this.tbJmlAnak.Location = new System.Drawing.Point(768, 297);
            this.tbJmlAnak.Name = "tbJmlAnak";
            this.tbJmlAnak.Size = new System.Drawing.Size(205, 20);
            this.tbJmlAnak.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(680, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Jumlah Anak";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(680, 260);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Status";
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(768, 260);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(205, 20);
            this.tbStatus.TabIndex = 25;
            // 
            // dtpTglLhr
            // 
            this.dtpTglLhr.Location = new System.Drawing.Point(447, 264);
            this.dtpTglLhr.Name = "dtpTglLhr";
            this.dtpTglLhr.Size = new System.Drawing.Size(205, 20);
            this.dtpTglLhr.TabIndex = 29;
            // 
            // pegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 438);
            this.Controls.Add(this.dtpTglLhr);
            this.Controls.Add(this.tbJmlAnak);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.tbGapok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbAgama);
            this.Controls.Add(this.tbjklmn);
            this.Controls.Add(this.tbPend);
            this.Controls.Add(this.tbTmpLhr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKota);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbNIP);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.dataGridView1);
            this.Name = "pegawai";
            this.Text = "pegawai";
            this.Load += new System.EventHandler(this.pegawai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kepegawaianDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jabatanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.TextBox tbNIP;
        private System.Windows.Forms.TextBox tbNama;
        private kepegawaianDataSet kepegawaianDataSet;
        private System.Windows.Forms.BindingSource jabatanBindingSource;
        private kepegawaianDataSetTableAdapters.jabatanTableAdapter jabatanTableAdapter;
        private System.Windows.Forms.BindingSource pegawaiBindingSource;
        private kepegawaianDataSetTableAdapters.pegawaiTableAdapter pegawaiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempatlhrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgllhrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendidikanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jnskelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodegapokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmlanakDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.TextBox tbKota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTmpLhr;
        private System.Windows.Forms.TextBox tbGapok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAgama;
        private System.Windows.Forms.TextBox tbjklmn;
        private System.Windows.Forms.TextBox tbPend;
        private System.Windows.Forms.TextBox tbJmlAnak;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.DateTimePicker dtpTglLhr;
    }
}