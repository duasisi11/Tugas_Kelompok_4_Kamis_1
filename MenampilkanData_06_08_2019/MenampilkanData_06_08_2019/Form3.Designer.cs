namespace MenampilkanData_06_08_2019
{
    partial class Form3
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
            this.tb_alamat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_libraryDataSet = new MenampilkanData_06_08_2019.db_libraryDataSet();
            this.tbl_anggotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_anggotaTableAdapter = new MenampilkanData_06_08_2019.db_libraryDataSetTableAdapters.tbl_anggotaTableAdapter();
            this.tableAdapterManager = new MenampilkanData_06_08_2019.db_libraryDataSetTableAdapters.TableAdapterManager();
            this.idanggotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_nama = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pilihanTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_anggotaBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // tb_alamat
            // 
            this.tb_alamat.Location = new System.Drawing.Point(163, 96);
            this.tb_alamat.Name = "tb_alamat";
            this.tb_alamat.Size = new System.Drawing.Size(274, 20);
            this.tb_alamat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alamat";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idanggotaDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbl_anggotaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(83, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(354, 197);
            this.dataGridView1.TabIndex = 4;
            // 
            // db_libraryDataSet
            // 
            this.db_libraryDataSet.DataSetName = "db_libraryDataSet";
            this.db_libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_anggotaBindingSource
            // 
            this.tbl_anggotaBindingSource.DataMember = "tbl_anggota";
            this.tbl_anggotaBindingSource.DataSource = this.db_libraryDataSet;
            // 
            // tbl_anggotaTableAdapter
            // 
            this.tbl_anggotaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_anggotaTableAdapter = this.tbl_anggotaTableAdapter;
            this.tableAdapterManager.tbl_bukuTableAdapter = null;
            this.tableAdapterManager.tbl_det_peminjamanTableAdapter = null;
            this.tableAdapterManager.tbl_kategoriTableAdapter = null;
            this.tableAdapterManager.tbl_peminjamanTableAdapter = null;
            this.tableAdapterManager.tbl_pengembalianTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MenampilkanData_06_08_2019.db_libraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idanggotaDataGridViewTextBoxColumn
            // 
            this.idanggotaDataGridViewTextBoxColumn.DataPropertyName = "id_anggota";
            this.idanggotaDataGridViewTextBoxColumn.HeaderText = "id_anggota";
            this.idanggotaDataGridViewTextBoxColumn.Name = "idanggotaDataGridViewTextBoxColumn";
            this.idanggotaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // cb_nama
            // 
            this.cb_nama.FormattingEnabled = true;
            this.cb_nama.Location = new System.Drawing.Point(163, 58);
            this.cb_nama.Name = "cb_nama";
            this.cb_nama.Size = new System.Drawing.Size(274, 21);
            this.cb_nama.TabIndex = 5;
            this.cb_nama.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pilihanTableToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(579, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pilihanTableToolStripMenuItem
            // 
            this.pilihanTableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bukuToolStripMenuItem});
            this.pilihanTableToolStripMenuItem.Name = "pilihanTableToolStripMenuItem";
            this.pilihanTableToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.pilihanTableToolStripMenuItem.Text = "Pilihan Table";
            // 
            // bukuToolStripMenuItem
            // 
            this.bukuToolStripMenuItem.Name = "bukuToolStripMenuItem";
            this.bukuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bukuToolStripMenuItem.Text = "Buku";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 471);
            this.Controls.Add(this.cb_nama);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_alamat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_anggotaBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_alamat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private db_libraryDataSet db_libraryDataSet;
        private System.Windows.Forms.BindingSource tbl_anggotaBindingSource;
        private db_libraryDataSetTableAdapters.tbl_anggotaTableAdapter tbl_anggotaTableAdapter;
        private db_libraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idanggotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cb_nama;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pilihanTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bukuToolStripMenuItem;
    }
}