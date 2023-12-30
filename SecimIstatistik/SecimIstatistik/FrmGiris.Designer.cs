namespace SecimIstatistik
{
    partial class FrmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtIlceAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.btnGrafik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "İLÇE AD:";
            // 
            // txtIlceAd
            // 
            this.txtIlceAd.Location = new System.Drawing.Point(153, 109);
            this.txtIlceAd.Name = "txtIlceAd";
            this.txtIlceAd.Size = new System.Drawing.Size(324, 38);
            this.txtIlceAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(557, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "VERİ TABANLI GRAFİK SEÇİM SİSTEMİ";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(153, 207);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(324, 38);
            this.txtA.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "A PARTİ:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(153, 273);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(324, 38);
            this.txtB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "B PARTİ:";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(153, 401);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(324, 38);
            this.txtD.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "C PARTİ:";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(151, 341);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(324, 38);
            this.txtC.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "D PARTİ:";
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(153, 463);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(324, 38);
            this.txtE.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "E PARTİ:";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.LightGray;
            this.btnGiris.Location = new System.Drawing.Point(52, 507);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(424, 55);
            this.btnGiris.TabIndex = 13;
            this.btnGiris.Text = "OY GİRİŞİ YAP";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCıkıs.ForeColor = System.Drawing.Color.Black;
            this.btnCıkıs.Location = new System.Drawing.Point(258, 568);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(219, 63);
            this.btnCıkıs.TabIndex = 14;
            this.btnCıkıs.Text = "ÇIKIŞ YAP";
            this.btnCıkıs.UseVisualStyleBackColor = false;
            // 
            // btnGrafik
            // 
            this.btnGrafik.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGrafik.Location = new System.Drawing.Point(52, 568);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(198, 63);
            this.btnGrafik.TabIndex = 15;
            this.btnGrafik.Text = "GRAFİKLER";
            this.btnGrafik.UseVisualStyleBackColor = false;
            this.btnGrafik.Click += new System.EventHandler(this.btnGrafik_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(589, 658);
            this.Controls.Add(this.btnGrafik);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIlceAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veri Tabanlı Grafik Seçim Sistemi";
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIlceAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.Button btnGrafik;
    }
}

