namespace CafeOtomasyon
{
    partial class HesapOdeme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hesapDT = new System.Windows.Forms.DataGridView();
            this.CmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnHesapGetir = new System.Windows.Forms.Button();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hesapDT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hesapDT);
            this.groupBox1.Location = new System.Drawing.Point(32, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesap";
            // 
            // hesapDT
            // 
            this.hesapDT.AllowUserToAddRows = false;
            this.hesapDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hesapDT.Location = new System.Drawing.Point(0, 33);
            this.hesapDT.Name = "hesapDT";
            this.hesapDT.RowHeadersWidth = 51;
            this.hesapDT.RowTemplate.Height = 24;
            this.hesapDT.Size = new System.Drawing.Size(541, 281);
            this.hesapDT.TabIndex = 0;
            this.hesapDT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CmbOdemeTuru
            // 
            this.CmbOdemeTuru.FormattingEnabled = true;
            this.CmbOdemeTuru.Location = new System.Drawing.Point(622, 121);
            this.CmbOdemeTuru.Name = "CmbOdemeTuru";
            this.CmbOdemeTuru.Size = new System.Drawing.Size(193, 37);
            this.CmbOdemeTuru.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(633, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ödeme Türü :";
            // 
            // BtnHesapGetir
            // 
            this.BtnHesapGetir.Location = new System.Drawing.Point(622, 213);
            this.BtnHesapGetir.Name = "BtnHesapGetir";
            this.BtnHesapGetir.Size = new System.Drawing.Size(193, 52);
            this.BtnHesapGetir.TabIndex = 3;
            this.BtnHesapGetir.Text = "Hesabı Getir";
            this.BtnHesapGetir.UseVisualStyleBackColor = true;
            this.BtnHesapGetir.Click += new System.EventHandler(this.BtnHesapGetir_Click);
            // 
            // BtnGeri
            // 
            this.BtnGeri.Location = new System.Drawing.Point(622, 300);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(187, 52);
            this.BtnGeri.TabIndex = 4;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.UseVisualStyleBackColor = true;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Öde";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HesapOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.BtnHesapGetir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbOdemeTuru);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HesapOdeme";
            this.Text = "HesapOdeme";
            this.Load += new System.EventHandler(this.HesapOdeme_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hesapDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView hesapDT;
        private System.Windows.Forms.ComboBox CmbOdemeTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnHesapGetir;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Button button1;
    }
}