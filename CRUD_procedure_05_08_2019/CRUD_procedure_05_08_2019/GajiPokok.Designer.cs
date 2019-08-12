namespace CRUD_procedure_05_08_2019
{
    partial class GajiPokok
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
            this.kodeGapokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeJabatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeGolonganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gajipokokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gajipokokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kepegawaianDataSet = new CRUD_procedure_05_08_2019.kepegawaianDataSet();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnTampil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGapok = new System.Windows.Forms.TextBox();
            this.tbKdGapok = new System.Windows.Forms.TextBox();
            this.gaji_pokokTableAdapter = new CRUD_procedure_05_08_2019.kepegawaianDataSetTableAdapters.gaji_pokokTableAdapter();
            this.cbKdJab = new System.Windows.Forms.ComboBox();
            this.cbKdGol = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gajipokokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kepegawaianDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeGapokDataGridViewTextBoxColumn,
            this.kodeJabatanDataGridViewTextBoxColumn,
            this.kodeGolonganDataGridViewTextBoxColumn,
            this.gajipokokDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gajipokokBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(503, 218);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kodeGapokDataGridViewTextBoxColumn
            // 
            this.kodeGapokDataGridViewTextBoxColumn.DataPropertyName = "Kode_Gapok";
            this.kodeGapokDataGridViewTextBoxColumn.HeaderText = "Kode_Gapok";
            this.kodeGapokDataGridViewTextBoxColumn.Name = "kodeGapokDataGridViewTextBoxColumn";
            // 
            // kodeJabatanDataGridViewTextBoxColumn
            // 
            this.kodeJabatanDataGridViewTextBoxColumn.DataPropertyName = "Kode_Jabatan";
            this.kodeJabatanDataGridViewTextBoxColumn.HeaderText = "Kode_Jabatan";
            this.kodeJabatanDataGridViewTextBoxColumn.Name = "kodeJabatanDataGridViewTextBoxColumn";
            // 
            // kodeGolonganDataGridViewTextBoxColumn
            // 
            this.kodeGolonganDataGridViewTextBoxColumn.DataPropertyName = "Kode_Golongan";
            this.kodeGolonganDataGridViewTextBoxColumn.HeaderText = "Kode_Golongan";
            this.kodeGolonganDataGridViewTextBoxColumn.Name = "kodeGolonganDataGridViewTextBoxColumn";
            // 
            // gajipokokDataGridViewTextBoxColumn
            // 
            this.gajipokokDataGridViewTextBoxColumn.DataPropertyName = "gaji_pokok";
            this.gajipokokDataGridViewTextBoxColumn.HeaderText = "gaji_pokok";
            this.gajipokokDataGridViewTextBoxColumn.Name = "gajipokokDataGridViewTextBoxColumn";
            // 
            // gajipokokBindingSource
            // 
            this.gajipokokBindingSource.DataMember = "gaji_pokok";
            this.gajipokokBindingSource.DataSource = this.kepegawaianDataSet;
            // 
            // kepegawaianDataSet
            // 
            this.kepegawaianDataSet.DataSetName = "kepegawaianDataSet";
            this.kepegawaianDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(451, 312);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 8;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(345, 312);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(75, 23);
            this.btnUbah.TabIndex = 7;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(451, 262);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 6;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(345, 262);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(75, 23);
            this.btnTampil.TabIndex = 5;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.UseVisualStyleBackColor = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Gaji Pokok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Kode Golongan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kode Jabatan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kode Gapok";
            // 
            // tbGapok
            // 
            this.tbGapok.Location = new System.Drawing.Point(109, 343);
            this.tbGapok.Name = "tbGapok";
            this.tbGapok.Size = new System.Drawing.Size(205, 20);
            this.tbGapok.TabIndex = 16;
            // 
            // tbKdGapok
            // 
            this.tbKdGapok.Location = new System.Drawing.Point(109, 236);
            this.tbKdGapok.Name = "tbKdGapok";
            this.tbKdGapok.Size = new System.Drawing.Size(205, 20);
            this.tbKdGapok.TabIndex = 13;
            // 
            // gaji_pokokTableAdapter
            // 
            this.gaji_pokokTableAdapter.ClearBeforeFill = true;
            // 
            // cbKdJab
            // 
            this.cbKdJab.FormattingEnabled = true;
            this.cbKdJab.Location = new System.Drawing.Point(109, 277);
            this.cbKdJab.Name = "cbKdJab";
            this.cbKdJab.Size = new System.Drawing.Size(205, 21);
            this.cbKdJab.TabIndex = 21;
            // 
            // cbKdGol
            // 
            this.cbKdGol.FormattingEnabled = true;
            this.cbKdGol.Location = new System.Drawing.Point(109, 312);
            this.cbKdGol.Name = "cbKdGol";
            this.cbKdGol.Size = new System.Drawing.Size(205, 21);
            this.cbKdGol.TabIndex = 22;
            // 
            // GajiPokok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 371);
            this.Controls.Add(this.cbKdGol);
            this.Controls.Add(this.cbKdJab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGapok);
            this.Controls.Add(this.tbKdGapok);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GajiPokok";
            this.Text = "GajiPokok";
            this.Load += new System.EventHandler(this.GajiPokok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gajipokokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kepegawaianDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGapok;
        private System.Windows.Forms.TextBox tbKdGapok;
        private kepegawaianDataSet kepegawaianDataSet;
        private System.Windows.Forms.BindingSource gajipokokBindingSource;
        private kepegawaianDataSetTableAdapters.gaji_pokokTableAdapter gaji_pokokTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeGapokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeJabatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeGolonganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gajipokokDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbKdJab;
        private System.Windows.Forms.ComboBox cbKdGol;
    }
}