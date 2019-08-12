namespace Report_Buku_09_08_2019
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
            this.idkategori1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namakategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSlibraryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dS_library = new Report_Buku_09_08_2019.DS_library();
            this.dSlibraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tbl_kategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_kategoriTableAdapter = new Report_Buku_09_08_2019.DS_libraryTableAdapters.tbl_kategoriTableAdapter();
            this.tableAdapterManager = new Report_Buku_09_08_2019.DS_libraryTableAdapters.TableAdapterManager();
            this.tbl_bukuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_bukuTableAdapter = new Report_Buku_09_08_2019.DS_libraryTableAdapters.tbl_bukuTableAdapter();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSlibraryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_library)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSlibraryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_kategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_bukuBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.idkategoriDataGridViewTextBoxColumn,
            this.idkategori1DataGridViewTextBoxColumn,
            this.namakategoriDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "tbl_buku";
            this.dataGridView1.DataSource = this.dSlibraryBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(941, 307);
            this.dataGridView1.TabIndex = 0;
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
            // idkategori1DataGridViewTextBoxColumn
            // 
            this.idkategori1DataGridViewTextBoxColumn.DataPropertyName = "id_kategori1";
            this.idkategori1DataGridViewTextBoxColumn.HeaderText = "id_kategori1";
            this.idkategori1DataGridViewTextBoxColumn.Name = "idkategori1DataGridViewTextBoxColumn";
            this.idkategori1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namakategoriDataGridViewTextBoxColumn
            // 
            this.namakategoriDataGridViewTextBoxColumn.DataPropertyName = "nama_kategori";
            this.namakategoriDataGridViewTextBoxColumn.HeaderText = "nama_kategori";
            this.namakategoriDataGridViewTextBoxColumn.Name = "namakategoriDataGridViewTextBoxColumn";
            // 
            // dSlibraryBindingSource1
            // 
            this.dSlibraryBindingSource1.DataSource = this.dS_library;
            this.dSlibraryBindingSource1.Position = 0;
            // 
            // dS_library
            // 
            this.dS_library.DataSetName = "DS_library";
            this.dS_library.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSlibraryBindingSource
            // 
            this.dSlibraryBindingSource.DataSource = this.dS_library;
            this.dSlibraryBindingSource.Position = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbl_kategoriBindingSource
            // 
            this.tbl_kategoriBindingSource.DataMember = "tbl_kategori";
            this.tbl_kategoriBindingSource.DataSource = this.dS_library;
            // 
            // tbl_kategoriTableAdapter
            // 
            this.tbl_kategoriTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_kategoriTableAdapter = this.tbl_kategoriTableAdapter;
            this.tableAdapterManager.UpdateOrder = Report_Buku_09_08_2019.DS_libraryTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_bukuBindingSource
            // 
            this.tbl_bukuBindingSource.DataMember = "tbl_buku";
            this.tbl_bukuBindingSource.DataSource = this.dS_library;
            // 
            // tbl_bukuTableAdapter
            // 
            this.tbl_bukuTableAdapter.ClearBeforeFill = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(109, 17);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Help ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 359);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSlibraryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_library)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSlibraryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_kategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_bukuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private DS_library dS_library;
        private System.Windows.Forms.BindingSource tbl_kategoriBindingSource;
        private DS_libraryTableAdapters.tbl_kategoriTableAdapter tbl_kategoriTableAdapter;
        private DS_libraryTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tbl_bukuBindingSource;
        private DS_libraryTableAdapters.tbl_bukuTableAdapter tbl_bukuTableAdapter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idkategori1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namakategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dSlibraryBindingSource;
        private System.Windows.Forms.BindingSource dSlibraryBindingSource1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

