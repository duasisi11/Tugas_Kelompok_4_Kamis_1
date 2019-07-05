namespace HariJumat3
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
            this.nasgor = new System.Windows.Forms.CheckBox();
            this.sotoayam = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.es_teh = new System.Windows.Forms.CheckBox();
            this.es_kopi = new System.Windows.Forms.CheckBox();
            this.es_jeruk = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minuman_textbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Makanan";
            // 
            // nasgor
            // 
            this.nasgor.AutoSize = true;
            this.nasgor.Location = new System.Drawing.Point(25, 71);
            this.nasgor.Name = "nasgor";
            this.nasgor.Size = new System.Drawing.Size(85, 17);
            this.nasgor.TabIndex = 1;
            this.nasgor.Text = "Nasi Goreng";
            this.nasgor.UseVisualStyleBackColor = true;
            // 
            // sotoayam
            // 
            this.sotoayam.AutoSize = true;
            this.sotoayam.Location = new System.Drawing.Point(153, 71);
            this.sotoayam.Name = "sotoayam";
            this.sotoayam.Size = new System.Drawing.Size(77, 17);
            this.sotoayam.TabIndex = 2;
            this.sotoayam.Text = "Soto Ayam";
            this.sotoayam.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Harga";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Bayar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // es_teh
            // 
            this.es_teh.AutoSize = true;
            this.es_teh.Location = new System.Drawing.Point(41, 30);
            this.es_teh.Name = "es_teh";
            this.es_teh.Size = new System.Drawing.Size(60, 17);
            this.es_teh.TabIndex = 6;
            this.es_teh.Text = "Es Teh";
            this.es_teh.UseVisualStyleBackColor = true;
            this.es_teh.CheckedChanged += new System.EventHandler(this.es_teh_CheckedChanged);
            // 
            // es_kopi
            // 
            this.es_kopi.AutoSize = true;
            this.es_kopi.Location = new System.Drawing.Point(41, 53);
            this.es_kopi.Name = "es_kopi";
            this.es_kopi.Size = new System.Drawing.Size(62, 17);
            this.es_kopi.TabIndex = 7;
            this.es_kopi.Text = "Es Kopi";
            this.es_kopi.UseVisualStyleBackColor = true;
            this.es_kopi.CheckedChanged += new System.EventHandler(this.es_kopi_CheckedChanged);
            // 
            // es_jeruk
            // 
            this.es_jeruk.AutoSize = true;
            this.es_jeruk.Location = new System.Drawing.Point(41, 76);
            this.es_jeruk.Name = "es_jeruk";
            this.es_jeruk.Size = new System.Drawing.Size(67, 17);
            this.es_jeruk.TabIndex = 8;
            this.es_jeruk.Text = "Es Jeruk";
            this.es_jeruk.UseVisualStyleBackColor = true;
            this.es_jeruk.CheckedChanged += new System.EventHandler(this.es_jeruk_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Harga Minuman";
            // 
            // minuman_textbox
            // 
            this.minuman_textbox.Location = new System.Drawing.Point(510, 155);
            this.minuman_textbox.Name = "minuman_textbox";
            this.minuman_textbox.Size = new System.Drawing.Size(100, 20);
            this.minuman_textbox.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.es_teh);
            this.groupBox1.Controls.Add(this.es_kopi);
            this.groupBox1.Controls.Add(this.es_jeruk);
            this.groupBox1.Location = new System.Drawing.Point(410, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Minuman";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(725, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.minuman_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sotoayam);
            this.Controls.Add(this.nasgor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox nasgor;
        private System.Windows.Forms.CheckBox sotoayam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox es_teh;
        private System.Windows.Forms.CheckBox es_kopi;
        private System.Windows.Forms.CheckBox es_jeruk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox minuman_textbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
    }
}

