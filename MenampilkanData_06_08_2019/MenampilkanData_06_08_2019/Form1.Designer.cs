namespace MenampilkanData_06_08_2019
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbJudul = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.tbKategori = new System.Windows.Forms.TextBox();
            this.tbPenulis = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idbukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.judulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penerbitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pengarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmlhalamanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.norakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblbukuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_libraryDataSet = new MenampilkanData_06_08_2019.db_libraryDataSet();
            this.tbl_bukuTableAdapter = new MenampilkanData_06_08_2019.db_libraryDataSetTableAdapters.tbl_bukuTableAdapter();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbukuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_libraryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Judul";
            // 
            // cbJudul
            // 
            this.cbJudul.FormattingEnabled = true;
            this.cbJudul.Location = new System.Drawing.Point(328, 57);
            this.cbJudul.Name = "cbJudul";
            this.cbJudul.Size = new System.Drawing.Size(327, 21);
            this.cbJudul.TabIndex = 1;
            this.cbJudul.SelectedIndexChanged += new System.EventHandler(this.cbJudul_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Penulis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kategori";
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(328, 102);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(327, 20);
            this.tbISBN.TabIndex = 7;
            // 
            // tbKategori
            // 
            this.tbKategori.Location = new System.Drawing.Point(328, 186);
            this.tbKategori.Name = "tbKategori";
            this.tbKategori.Size = new System.Drawing.Size(327, 20);
            this.tbKategori.TabIndex = 8;
            // 
            // tbPenulis
            // 
            this.tbPenulis.Location = new System.Drawing.Point(328, 142);
            this.tbPenulis.Name = "tbPenulis";
            this.tbPenulis.Size = new System.Drawing.Size(327, 20);
            this.tbPenulis.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbukuDataGridViewTextBoxColumn,
            this.isbnDataGridViewTextBoxColumn,
            this.judulDataGridViewTextBoxColumn,
            this.penerbitDataGridViewTextBoxColumn,
            this.pengarangDataGridViewTextBoxColumn,
            this.jmlhalamanDataGridViewTextBoxColumn,
            this.tahunDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.norakDataGridViewTextBoxColumn,
            this.idkategoriDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblbukuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 312);
            this.dataGridView1.TabIndex = 10;
            // 
            // idbukuDataGridViewTextBoxColumn
            // 
            this.idbukuDataGridViewTextBoxColumn.DataPropertyName = "id_buku";
            this.idbukuDataGridViewTextBoxColumn.HeaderText = "id_buku";
            this.idbukuDataGridViewTextBoxColumn.Name = "idbukuDataGridViewTextBoxColumn";
            this.idbukuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "isbn";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            // 
            // judulDataGridViewTextBoxColumn
            // 
            this.judulDataGridViewTextBoxColumn.DataPropertyName = "judul";
            this.judulDataGridViewTextBoxColumn.HeaderText = "judul";
            this.judulDataGridViewTextBoxColumn.Name = "judulDataGridViewTextBoxColumn";
            // 
            // penerbitDataGridViewTextBoxColumn
            // 
            this.penerbitDataGridViewTextBoxColumn.DataPropertyName = "penerbit";
            this.penerbitDataGridViewTextBoxColumn.HeaderText = "penerbit";
            this.penerbitDataGridViewTextBoxColumn.Name = "penerbitDataGridViewTextBoxColumn";
            // 
            // pengarangDataGridViewTextBoxColumn
            // 
            this.pengarangDataGridViewTextBoxColumn.DataPropertyName = "pengarang";
            this.pengarangDataGridViewTextBoxColumn.HeaderText = "pengarang";
            this.pengarangDataGridViewTextBoxColumn.Name = "pengarangDataGridViewTextBoxColumn";
            // 
            // jmlhalamanDataGridViewTextBoxColumn
            // 
            this.jmlhalamanDataGridViewTextBoxColumn.DataPropertyName = "jml_halaman";
            this.jmlhalamanDataGridViewTextBoxColumn.HeaderText = "jml_halaman";
            this.jmlhalamanDataGridViewTextBoxColumn.Name = "jmlhalamanDataGridViewTextBoxColumn";
            // 
            // tahunDataGridViewTextBoxColumn
            // 
            this.tahunDataGridViewTextBoxColumn.DataPropertyName = "tahun";
            this.tahunDataGridViewTextBoxColumn.HeaderText = "tahun";
            this.tahunDataGridViewTextBoxColumn.Name = "tahunDataGridViewTextBoxColumn";
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "stok";
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            // 
            // norakDataGridViewTextBoxColumn
            // 
            this.norakDataGridViewTextBoxColumn.DataPropertyName = "no_rak";
            this.norakDataGridViewTextBoxColumn.HeaderText = "no_rak";
            this.norakDataGridViewTextBoxColumn.Name = "norakDataGridViewTextBoxColumn";
            // 
            // idkategoriDataGridViewTextBoxColumn
            // 
            this.idkategoriDataGridViewTextBoxColumn.DataPropertyName = "id_kategori";
            this.idkategoriDataGridViewTextBoxColumn.HeaderText = "id_kategori";
            this.idkategoriDataGridViewTextBoxColumn.Name = "idkategoriDataGridViewTextBoxColumn";
            // 
            // tblbukuBindingSource
            // 
            this.tblbukuBindingSource.DataMember = "tbl_buku";
            this.tblbukuBindingSource.DataSource = this.db_libraryDataSet;
            // 
            // db_libraryDataSet
            // 
            this.db_libraryDataSet.DataSetName = "db_libraryDataSet";
            this.db_libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_bukuTableAdapter
            // 
            this.tbl_bukuTableAdapter.ClearBeforeFill = true;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(705, 186);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 11;
            this.btnReport.Text = "Report All";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 553);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbPenulis);
            this.Controls.Add(this.tbKategori);
            this.Controls.Add(this.tbISBN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbJudul);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Menampilkan Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbukuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_libraryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbJudul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.TextBox tbKategori;
        private System.Windows.Forms.TextBox tbPenulis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private db_libraryDataSet db_libraryDataSet;
        private System.Windows.Forms.BindingSource tblbukuBindingSource;
        private db_libraryDataSetTableAdapters.tbl_bukuTableAdapter tbl_bukuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbukuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn judulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penerbitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pengarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmlhalamanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn norakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnReport;
    }
}

