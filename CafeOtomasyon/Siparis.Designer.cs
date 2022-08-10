namespace CafeOtomasyon
{
    partial class Siparis
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnCorba = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSiparisVer = new System.Windows.Forms.Button();
            this.BtnHesapOde = new System.Windows.Forms.Button();
            this.LblMasaNo = new System.Windows.Forms.Label();
            this.TxtAdet = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.BtnRezerve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 101);
            this.button1.TabIndex = 0;
            this.button1.Text = "DÜRÜM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 101);
            this.button2.TabIndex = 1;
            this.button2.Text = "LAHMACUN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnCorba
            // 
            this.BtnCorba.Location = new System.Drawing.Point(52, 46);
            this.BtnCorba.Name = "BtnCorba";
            this.BtnCorba.Size = new System.Drawing.Size(168, 101);
            this.BtnCorba.TabIndex = 2;
            this.BtnCorba.Text = "ÇORBA";
            this.BtnCorba.UseVisualStyleBackColor = true;
            this.BtnCorba.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(226, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 101);
            this.button4.TabIndex = 3;
            this.button4.Text = "KEBAP";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(52, 260);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 101);
            this.button5.TabIndex = 4;
            this.button5.Text = "EK ÜRÜN";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(226, 260);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 101);
            this.button6.TabIndex = 5;
            this.button6.Text = "İÇECEKLER";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(503, 203);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(424, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 229);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menü";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(424, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 229);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sipariş";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(503, 202);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Adet : ";
            // 
            // BtnSiparisVer
            // 
            this.BtnSiparisVer.Location = new System.Drawing.Point(52, 448);
            this.BtnSiparisVer.Name = "BtnSiparisVer";
            this.BtnSiparisVer.Size = new System.Drawing.Size(168, 49);
            this.BtnSiparisVer.TabIndex = 12;
            this.BtnSiparisVer.Text = "Siparişi Ver";
            this.BtnSiparisVer.UseVisualStyleBackColor = true;
            this.BtnSiparisVer.Click += new System.EventHandler(this.BtnSiparisVer_Click);
            // 
            // BtnHesapOde
            // 
            this.BtnHesapOde.Location = new System.Drawing.Point(277, 516);
            this.BtnHesapOde.Name = "BtnHesapOde";
            this.BtnHesapOde.Size = new System.Drawing.Size(117, 48);
            this.BtnHesapOde.TabIndex = 13;
            this.BtnHesapOde.Text = "Geri";
            this.BtnHesapOde.UseVisualStyleBackColor = true;
            this.BtnHesapOde.Click += new System.EventHandler(this.button8_Click);
            // 
            // LblMasaNo
            // 
            this.LblMasaNo.AutoSize = true;
            this.LblMasaNo.Location = new System.Drawing.Point(47, 9);
            this.LblMasaNo.Name = "LblMasaNo";
            this.LblMasaNo.Size = new System.Drawing.Size(90, 29);
            this.LblMasaNo.TabIndex = 14;
            this.LblMasaNo.Text = "Masa 1";
            // 
            // TxtAdet
            // 
            this.TxtAdet.Location = new System.Drawing.Point(175, 389);
            this.TxtAdet.Name = "TxtAdet";
            this.TxtAdet.Size = new System.Drawing.Size(117, 34);
            this.TxtAdet.TabIndex = 15;
            this.TxtAdet.Text = "1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(237, 450);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 46);
            this.button3.TabIndex = 16;
            this.button3.Text = "Hesap Öde";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Location = new System.Drawing.Point(933, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 473);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adisyon";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 30);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(294, 443);
            this.dataGridView3.TabIndex = 0;
            // 
            // BtnRezerve
            // 
            this.BtnRezerve.Location = new System.Drawing.Point(55, 516);
            this.BtnRezerve.Name = "BtnRezerve";
            this.BtnRezerve.Size = new System.Drawing.Size(165, 42);
            this.BtnRezerve.TabIndex = 18;
            this.BtnRezerve.Text = "Rezerve Et";
            this.BtnRezerve.UseVisualStyleBackColor = true;
            this.BtnRezerve.Click += new System.EventHandler(this.BtnRezerve_Click);
            // 
            // Siparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 598);
            this.Controls.Add(this.BtnRezerve);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TxtAdet);
            this.Controls.Add(this.LblMasaNo);
            this.Controls.Add(this.BtnHesapOde);
            this.Controls.Add(this.BtnSiparisVer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BtnCorba);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Siparis";
            this.Text = "Siparis";
            this.Load += new System.EventHandler(this.Siparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnCorba;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSiparisVer;
        private System.Windows.Forms.Button BtnHesapOde;
        private System.Windows.Forms.TextBox TxtAdet;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button BtnRezerve;
        public System.Windows.Forms.Label LblMasaNo;
    }
}