namespace Concurrency_Data_02_08_2019
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
            this.tbIDAngg = new System.Windows.Forms.TextBox();
            this.tbIDBuku = new System.Windows.Forms.TextBox();
            this.tbKondisi = new System.Windows.Forms.TextBox();
            this.tbDurasi = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Anggota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Buku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kondisi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Durasi";
            // 
            // tbIDAngg
            // 
            this.tbIDAngg.Location = new System.Drawing.Point(156, 60);
            this.tbIDAngg.Name = "tbIDAngg";
            this.tbIDAngg.Size = new System.Drawing.Size(290, 20);
            this.tbIDAngg.TabIndex = 4;
            // 
            // tbIDBuku
            // 
            this.tbIDBuku.Location = new System.Drawing.Point(156, 91);
            this.tbIDBuku.Name = "tbIDBuku";
            this.tbIDBuku.Size = new System.Drawing.Size(290, 20);
            this.tbIDBuku.TabIndex = 5;
            // 
            // tbKondisi
            // 
            this.tbKondisi.Location = new System.Drawing.Point(156, 120);
            this.tbKondisi.Name = "tbKondisi";
            this.tbKondisi.Size = new System.Drawing.Size(290, 20);
            this.tbKondisi.TabIndex = 6;
            // 
            // tbDurasi
            // 
            this.tbDurasi.Location = new System.Drawing.Point(156, 146);
            this.tbDurasi.Name = "tbDurasi";
            this.tbDurasi.Size = new System.Drawing.Size(290, 20);
            this.tbDurasi.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(371, 193);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 271);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbDurasi);
            this.Controls.Add(this.tbKondisi);
            this.Controls.Add(this.tbIDBuku);
            this.Controls.Add(this.tbIDAngg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIDAngg;
        private System.Windows.Forms.TextBox tbIDBuku;
        private System.Windows.Forms.TextBox tbKondisi;
        private System.Windows.Forms.TextBox tbDurasi;
        private System.Windows.Forms.Button btnAdd;
    }
}

