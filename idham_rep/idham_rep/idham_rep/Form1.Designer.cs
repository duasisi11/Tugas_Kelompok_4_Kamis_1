namespace idham_rep
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
            this.dSBaruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSBaru = new idham_rep.DSBaru();
            this.button1 = new System.Windows.Forms.Button();
            this.tbl_kategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_kategoriTableAdapter = new idham_rep.DSBaruTableAdapters.tbl_kategoriTableAdapter();
            this.tableAdapterManager = new idham_rep.DSBaruTableAdapters.TableAdapterManager();
            this.tbl_bukuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_bukuTableAdapter = new idham_rep.DSBaruTableAdapters.tbl_bukuTableAdapter();
            this.namakategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkategori1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.norakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmlhalamanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pengarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penerbitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.judulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dSBaruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBaru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_kategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_bukuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dSBaruBindingSource
            // 
            this.dSBaruBindingSource.DataSource = this.dSBaru;
            this.dSBaruBindingSource.Position = 0;
            // 
            // dSBaru
            // 
            this.dSBaru.DataSetName = "DSBaru";
            this.dSBaru.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbl_kategoriBindingSource
            // 
            this.tbl_kategoriBindingSource.DataMember = "tbl_kategori";
            this.tbl_kategoriBindingSource.DataSource = this.dSBaru;
            // 
            // tbl_kategoriTableAdapter
            // 
            this.tbl_kategoriTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_kategoriTableAdapter = this.tbl_kategoriTableAdapter;
            this.tableAdapterManager.UpdateOrder = idham_rep.DSBaruTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_bukuBindingSource
            // 
            this.tbl_bukuBindingSource.DataMember = "tbl_buku";
            this.tbl_bukuBindingSource.DataSource = this.dSBaru;
            // 
            // tbl_bukuTableAdapter
            // 
            this.tbl_bukuTableAdapter.ClearBeforeFill = true;
            // 
            // namakategoriDataGridViewTextBoxColumn
            // 
            this.namakategoriDataGridViewTextBoxColumn.DataPropertyName = "nama_kategori";
            this.namakategoriDataGridViewTextBoxColumn.HeaderText = "nama_kategori";
            this.namakategoriDataGridViewTextBoxColumn.Name = "namakategoriDataGridViewTextBoxColumn";
            // 
            // idkategori1DataGridViewTextBoxColumn
            // 
            this.idkategori1DataGridViewTextBoxColumn.DataPropertyName = "id_kategori1";
            this.idkategori1DataGridViewTextBoxColumn.HeaderText = "id_kategori1";
            this.idkategori1DataGridViewTextBoxColumn.Name = "idkategori1DataGridViewTextBoxColumn";
            this.idkategori1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idkategoriDataGridViewTextBoxColumn
            // 
            this.idkategoriDataGridViewTextBoxColumn.DataPropertyName = "id_kategori";
            this.idkategoriDataGridViewTextBoxColumn.HeaderText = "id_kategori";
            this.idkategoriDataGridViewTextBoxColumn.Name = "idkategoriDataGridViewTextBoxColumn";
            // 
            // norakDataGridViewTextBoxColumn
            // 
            this.norakDataGridViewTextBoxColumn.DataPropertyName = "no_rak";
            this.norakDataGridViewTextBoxColumn.HeaderText = "no_rak";
            this.norakDataGridViewTextBoxColumn.Name = "norakDataGridViewTextBoxColumn";
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "stok";
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            // 
            // tahunDataGridViewTextBoxColumn
            // 
            this.tahunDataGridViewTextBoxColumn.DataPropertyName = "tahun";
            this.tahunDataGridViewTextBoxColumn.HeaderText = "tahun";
            this.tahunDataGridViewTextBoxColumn.Name = "tahunDataGridViewTextBoxColumn";
            // 
            // jmlhalamanDataGridViewTextBoxColumn
            // 
            this.jmlhalamanDataGridViewTextBoxColumn.DataPropertyName = "jml_halaman";
            this.jmlhalamanDataGridViewTextBoxColumn.HeaderText = "jml_halaman";
            this.jmlhalamanDataGridViewTextBoxColumn.Name = "jmlhalamanDataGridViewTextBoxColumn";
            // 
            // pengarangDataGridViewTextBoxColumn
            // 
            this.pengarangDataGridViewTextBoxColumn.DataPropertyName = "pengarang";
            this.pengarangDataGridViewTextBoxColumn.HeaderText = "pengarang";
            this.pengarangDataGridViewTextBoxColumn.Name = "pengarangDataGridViewTextBoxColumn";
            // 
            // penerbitDataGridViewTextBoxColumn
            // 
            this.penerbitDataGridViewTextBoxColumn.DataPropertyName = "penerbit";
            this.penerbitDataGridViewTextBoxColumn.HeaderText = "penerbit";
            this.penerbitDataGridViewTextBoxColumn.Name = "penerbitDataGridViewTextBoxColumn";
            // 
            // judulDataGridViewTextBoxColumn
            // 
            this.judulDataGridViewTextBoxColumn.DataPropertyName = "judul";
            this.judulDataGridViewTextBoxColumn.HeaderText = "judul";
            this.judulDataGridViewTextBoxColumn.Name = "judulDataGridViewTextBoxColumn";
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "isbn";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            // 
            // idbukuDataGridViewTextBoxColumn
            // 
            this.idbukuDataGridViewTextBoxColumn.DataPropertyName = "id_buku";
            this.idbukuDataGridViewTextBoxColumn.HeaderText = "id_buku";
            this.idbukuDataGridViewTextBoxColumn.Name = "idbukuDataGridViewTextBoxColumn";
            this.idbukuDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.dataGridView1.DataSource = this.dSBaruBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 187);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSBaruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBaru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_kategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_bukuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private DSBaru dSBaru;
        private System.Windows.Forms.BindingSource tbl_kategoriBindingSource;
        private DSBaruTableAdapters.tbl_kategoriTableAdapter tbl_kategoriTableAdapter;
        private DSBaruTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tbl_bukuBindingSource;
        private DSBaruTableAdapters.tbl_bukuTableAdapter tbl_bukuTableAdapter;
        private System.Windows.Forms.BindingSource dSBaruBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn namakategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkategori1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn norakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmlhalamanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pengarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penerbitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn judulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbukuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

