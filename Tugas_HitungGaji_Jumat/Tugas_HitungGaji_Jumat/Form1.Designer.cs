namespace Tugas_HitungGaji_Jumat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_gapok = new System.Windows.Forms.TextBox();
            this.tb_transport = new System.Windows.Forms.TextBox();
            this.tb_makan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_bpjs = new System.Windows.Forms.TextBox();
            this.tb_pph21 = new System.Windows.Forms.TextBox();
            this.tb_gajibersih = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_single = new System.Windows.Forms.RadioButton();
            this.rb_menikah = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tb_income = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.tb_income);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_gajibersih);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(31, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 289);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_makan);
            this.groupBox1.Controls.Add(this.tb_transport);
            this.groupBox1.Controls.Add(this.tb_gapok);
            this.groupBox1.Location = new System.Drawing.Point(20, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Income";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.tb_pph21);
            this.groupBox2.Controls.Add(this.tb_bpjs);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(286, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 192);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pajak";
            // 
            // tb_gapok
            // 
            this.tb_gapok.Location = new System.Drawing.Point(120, 33);
            this.tb_gapok.Name = "tb_gapok";
            this.tb_gapok.Size = new System.Drawing.Size(100, 20);
            this.tb_gapok.TabIndex = 0;
            // 
            // tb_transport
            // 
            this.tb_transport.Location = new System.Drawing.Point(120, 73);
            this.tb_transport.Name = "tb_transport";
            this.tb_transport.Size = new System.Drawing.Size(100, 20);
            this.tb_transport.TabIndex = 1;
            // 
            // tb_makan
            // 
            this.tb_makan.Location = new System.Drawing.Point(120, 114);
            this.tb_makan.Name = "tb_makan";
            this.tb_makan.Size = new System.Drawing.Size(100, 20);
            this.tb_makan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gaji Pokok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Transportasi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Makan";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "HITUNG";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "BBJS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "PPH21";
            // 
            // tb_bpjs
            // 
            this.tb_bpjs.Location = new System.Drawing.Point(94, 32);
            this.tb_bpjs.Name = "tb_bpjs";
            this.tb_bpjs.Size = new System.Drawing.Size(100, 20);
            this.tb_bpjs.TabIndex = 2;
            // 
            // tb_pph21
            // 
            this.tb_pph21.Location = new System.Drawing.Point(94, 65);
            this.tb_pph21.Name = "tb_pph21";
            this.tb_pph21.Size = new System.Drawing.Size(100, 20);
            this.tb_pph21.TabIndex = 3;
            // 
            // tb_gajibersih
            // 
            this.tb_gajibersih.Location = new System.Drawing.Point(392, 224);
            this.tb_gajibersih.Name = "tb_gajibersih";
            this.tb_gajibersih.Size = new System.Drawing.Size(100, 20);
            this.tb_gajibersih.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Gaji Bersih";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_menikah);
            this.groupBox3.Controls.Add(this.rb_single);
            this.groupBox3.Location = new System.Drawing.Point(20, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 68);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // rb_single
            // 
            this.rb_single.AutoSize = true;
            this.rb_single.Location = new System.Drawing.Point(30, 35);
            this.rb_single.Name = "rb_single";
            this.rb_single.Size = new System.Drawing.Size(54, 17);
            this.rb_single.TabIndex = 0;
            this.rb_single.TabStop = true;
            this.rb_single.Text = "Single";
            this.rb_single.UseVisualStyleBackColor = true;
            // 
            // rb_menikah
            // 
            this.rb_menikah.AutoSize = true;
            this.rb_menikah.Location = new System.Drawing.Point(120, 35);
            this.rb_menikah.Name = "rb_menikah";
            this.rb_menikah.Size = new System.Drawing.Size(66, 17);
            this.rb_menikah.TabIndex = 1;
            this.rb_menikah.TabStop = true;
            this.rb_menikah.Text = "Menikah";
            this.rb_menikah.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(490, 335);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // tb_income
            // 
            this.tb_income.Location = new System.Drawing.Point(156, 231);
            this.tb_income.Name = "tb_income";
            this.tb_income.Size = new System.Drawing.Size(100, 20);
            this.tb_income.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 364);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_gajibersih;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_menikah;
        private System.Windows.Forms.RadioButton rb_single;
        private System.Windows.Forms.TextBox tb_pph21;
        private System.Windows.Forms.TextBox tb_bpjs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_makan;
        private System.Windows.Forms.TextBox tb_transport;
        private System.Windows.Forms.TextBox tb_gapok;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox tb_income;
    }
}

