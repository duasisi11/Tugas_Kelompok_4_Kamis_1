namespace CRUD_procedure_05_08_2019
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
            this.components = new System.ComponentModel.Container();
            this.btnTampil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKode = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbTunjangan = new System.Windows.Forms.TextBox();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.kepegawaianDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kepegawaianDataSet = new CRUD_procedure_05_08_2019.kepegawaianDataSet();
            this.kepegawaianDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kepegawaianDataSet1 = new CRUD_procedure_05_08_2019.kepegawaianDataSet1();
            this.jabatanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jabatanTableAdapter = new CRUD_procedure_05_08_2019.kepegawaianDataSet1TableAdapters.jabatanTableAdapter();
            this.pegawaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pegawaiTableAdapter = new CRUD_procedure_05_08_2019.kepegawaianDataSetTableAdapters.pegawaiTableAdapter();
            this.kodejabatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namajabatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tunjanganJabatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kepegawaianDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kepegawaianDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kepegawaianDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kepegawaianDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jabatanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(135, 250);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(75, 23);
            this.btnTampil.TabIndex = 1;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.UseVisualStyleBackColor = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kode Jabatan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama Jabatan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tunjangan Jabatan";
            // 
            // tbKode
            // 
            this.tbKode.Location = new System.Drawing.Point(556, 16);
            this.tbKode.Name = "tbKode";
            this.tbKode.Size = new System.Drawing.Size(229, 20);
            this.tbKode.TabIndex = 5;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(556, 47);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(229, 20);
            this.tbNama.TabIndex = 6;
            // 
            // tbTunjangan
            // 
            this.tbTunjangan.Location = new System.Drawing.Point(556, 76);
            this.tbTunjangan.Name = "tbTunjangan";
            this.tbTunjangan.Size = new System.Drawing.Size(229, 20);
            this.tbTunjangan.TabIndex = 7;
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(475, 130);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(75, 23);
            this.btnUbah.TabIndex = 8;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(624, 130);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 9;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(475, 175);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 10;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodejabatanDataGridViewTextBoxColumn,
            this.namajabatanDataGridViewTextBoxColumn,
            this.tunjanganJabatanDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.jabatanBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(411, 207);
            this.dataGridView2.TabIndex = 11;
            // 
            // kepegawaianDataSet
            // 
            this.kepegawaianDataSet.DataSetName = "kepegawaianDataSet";
            this.kepegawaianDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kepegawaianDataSetBindingSource
            // 
            this.kepegawaianDataSetBindingSource.DataSource = this.kepegawaianDataSet;
            this.kepegawaianDataSetBindingSource.Position = 0;
            // 
            // kepegawaianDataSet1
            // 
            this.kepegawaianDataSet1.DataSetName = "kepegawaianDataSet1";
            this.kepegawaianDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jabatanBindingSource
            // 
            this.jabatanBindingSource.DataMember = "jabatan";
            this.jabatanBindingSource.DataSource = this.kepegawaianDataSet1;
            // 
            // jabatanTableAdapter
            // 
            this.jabatanTableAdapter.ClearBeforeFill = true;
            // 
            // pegawaiBindingSource
            // 
            this.pegawaiBindingSource.DataMember = "pegawai";
            this.pegawaiBindingSource.DataSource = this.kepegawaianDataSetBindingSource;
            // 
            // pegawaiTableAdapter
            // 
            this.pegawaiTableAdapter.ClearBeforeFill = true;
            // 
            // kodejabatanDataGridViewTextBoxColumn
            // 
            this.kodejabatanDataGridViewTextBoxColumn.DataPropertyName = "kode_jabatan";
            this.kodejabatanDataGridViewTextBoxColumn.HeaderText = "kode_jabatan";
            this.kodejabatanDataGridViewTextBoxColumn.Name = "kodejabatanDataGridViewTextBoxColumn";
            // 
            // namajabatanDataGridViewTextBoxColumn
            // 
            this.namajabatanDataGridViewTextBoxColumn.DataPropertyName = "Nama_jabatan";
            this.namajabatanDataGridViewTextBoxColumn.HeaderText = "Nama_jabatan";
            this.namajabatanDataGridViewTextBoxColumn.Name = "namajabatanDataGridViewTextBoxColumn";
            // 
            // tunjanganJabatanDataGridViewTextBoxColumn
            // 
            this.tunjanganJabatanDataGridViewTextBoxColumn.DataPropertyName = "Tunjangan_Jabatan";
            this.tunjanganJabatanDataGridViewTextBoxColumn.HeaderText = "Tunjangan_Jabatan";
            this.tunjanganJabatanDataGridViewTextBoxColumn.Name = "tunjanganJabatanDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 436);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.tbTunjangan);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbKode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTampil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kepegawaianDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kepegawaianDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kepegawaianDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kepegawaianDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jabatanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKode;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbTunjangan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.BindingSource kepegawaianDataSet1BindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private kepegawaianDataSet kepegawaianDataSet;
        private System.Windows.Forms.BindingSource kepegawaianDataSetBindingSource;
        private kepegawaianDataSet1 kepegawaianDataSet1;
        private System.Windows.Forms.BindingSource jabatanBindingSource;
        private kepegawaianDataSet1TableAdapters.jabatanTableAdapter jabatanTableAdapter;
        private System.Windows.Forms.BindingSource pegawaiBindingSource;
        private kepegawaianDataSetTableAdapters.pegawaiTableAdapter pegawaiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodejabatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namajabatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tunjanganJabatanDataGridViewTextBoxColumn;
    }
}

