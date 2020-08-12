namespace WindowsFormsApp1
{
    partial class Form1
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
            this.orj_box = new System.Windows.Forms.PictureBox();
            this.orj_img = new System.Windows.Forms.TextBox();
            this.d_img = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüntüİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gritonYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negatifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siyahBeyazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.komşuPixelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toplamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkarmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geometrikUzamsalİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ölçeklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.döndürmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ötelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eğmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dikeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.yatayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrasGenişletmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logaritmaDönüşümleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kuvvetGamaDönüşümleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramGermeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramEşitlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.orj_box)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orj_box
            // 
            this.orj_box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orj_box.Location = new System.Drawing.Point(10, 63);
            this.orj_box.Name = "orj_box";
            this.orj_box.Size = new System.Drawing.Size(463, 469);
            this.orj_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.orj_box.TabIndex = 4;
            this.orj_box.TabStop = false;
            // 
            // orj_img
            // 
            this.orj_img.BackColor = System.Drawing.Color.White;
            this.orj_img.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orj_img.Enabled = false;
            this.orj_img.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.orj_img.Location = new System.Drawing.Point(143, 36);
            this.orj_img.Name = "orj_img";
            this.orj_img.ReadOnly = true;
            this.orj_img.Size = new System.Drawing.Size(100, 13);
            this.orj_img.TabIndex = 5;
            this.orj_img.Text = "Orjinal Resim";
            this.orj_img.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // d_img
            // 
            this.d_img.BackColor = System.Drawing.Color.White;
            this.d_img.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.d_img.Enabled = false;
            this.d_img.ForeColor = System.Drawing.Color.White;
            this.d_img.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.d_img.Location = new System.Drawing.Point(612, 17);
            this.d_img.Name = "d_img";
            this.d_img.ReadOnly = true;
            this.d_img.Size = new System.Drawing.Size(100, 13);
            this.d_img.TabIndex = 7;
            this.d_img.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.görüntüİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resimEkleToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // resimEkleToolStripMenuItem
            // 
            this.resimEkleToolStripMenuItem.Name = "resimEkleToolStripMenuItem";
            this.resimEkleToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.resimEkleToolStripMenuItem.Text = "Resim Ekle";
            this.resimEkleToolStripMenuItem.Click += new System.EventHandler(this.resimEkleToolStripMenuItem_Click);
            // 
            // görüntüİşlemleriToolStripMenuItem
            // 
            this.görüntüİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gritonYapToolStripMenuItem,
            this.negatifToolStripMenuItem,
            this.siyahBeyazToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.komşuPixelToolStripMenuItem,
            this.resimToolStripMenuItem,
            this.geometrikUzamsalİşlemlerToolStripMenuItem,
            this.kontrasGenişletmeToolStripMenuItem,
            this.logaritmaDönüşümleriToolStripMenuItem,
            this.kuvvetGamaDönüşümleriToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.filtrelerToolStripMenuItem});
            this.görüntüİşlemleriToolStripMenuItem.Name = "görüntüİşlemleriToolStripMenuItem";
            this.görüntüİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.görüntüİşlemleriToolStripMenuItem.Text = "Görüntü İşlemleri";
            // 
            // gritonYapToolStripMenuItem
            // 
            this.gritonYapToolStripMenuItem.Name = "gritonYapToolStripMenuItem";
            this.gritonYapToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.gritonYapToolStripMenuItem.Text = "Griton";
            this.gritonYapToolStripMenuItem.Click += new System.EventHandler(this.gritonYapToolStripMenuItem_Click);
            // 
            // negatifToolStripMenuItem
            // 
            this.negatifToolStripMenuItem.Name = "negatifToolStripMenuItem";
            this.negatifToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.negatifToolStripMenuItem.Text = "Negatif";
            this.negatifToolStripMenuItem.Click += new System.EventHandler(this.negatifToolStripMenuItem_Click);
            // 
            // siyahBeyazToolStripMenuItem
            // 
            this.siyahBeyazToolStripMenuItem.Name = "siyahBeyazToolStripMenuItem";
            this.siyahBeyazToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.siyahBeyazToolStripMenuItem.Text = "Siyah-Beyaz";
            this.siyahBeyazToolStripMenuItem.Click += new System.EventHandler(this.siyahBeyazToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // komşuPixelToolStripMenuItem
            // 
            this.komşuPixelToolStripMenuItem.Name = "komşuPixelToolStripMenuItem";
            this.komşuPixelToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.komşuPixelToolStripMenuItem.Text = "Komşu Pixel";
            this.komşuPixelToolStripMenuItem.Click += new System.EventHandler(this.komşuPixelToolStripMenuItem_Click);
            // 
            // resimToolStripMenuItem
            // 
            this.resimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toplamaToolStripMenuItem,
            this.çıkarmaToolStripMenuItem});
            this.resimToolStripMenuItem.Name = "resimToolStripMenuItem";
            this.resimToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.resimToolStripMenuItem.Text = "2. Resim";
            // 
            // toplamaToolStripMenuItem
            // 
            this.toplamaToolStripMenuItem.Name = "toplamaToolStripMenuItem";
            this.toplamaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.toplamaToolStripMenuItem.Text = "Toplama";
            this.toplamaToolStripMenuItem.Click += new System.EventHandler(this.toplamaToolStripMenuItem_Click);
            // 
            // çıkarmaToolStripMenuItem
            // 
            this.çıkarmaToolStripMenuItem.Name = "çıkarmaToolStripMenuItem";
            this.çıkarmaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.çıkarmaToolStripMenuItem.Text = "Çıkarma";
            this.çıkarmaToolStripMenuItem.Click += new System.EventHandler(this.çıkarmaToolStripMenuItem_Click);
            // 
            // geometrikUzamsalİşlemlerToolStripMenuItem
            // 
            this.geometrikUzamsalİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ölçeklemeToolStripMenuItem,
            this.döndürmeToolStripMenuItem,
            this.ötelemeToolStripMenuItem,
            this.eğmeToolStripMenuItem});
            this.geometrikUzamsalİşlemlerToolStripMenuItem.Name = "geometrikUzamsalİşlemlerToolStripMenuItem";
            this.geometrikUzamsalİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.geometrikUzamsalİşlemlerToolStripMenuItem.Text = "Geometrik Uzamsal İşlemler";
            // 
            // ölçeklemeToolStripMenuItem
            // 
            this.ölçeklemeToolStripMenuItem.Name = "ölçeklemeToolStripMenuItem";
            this.ölçeklemeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.ölçeklemeToolStripMenuItem.Text = "Ölçekleme";
            this.ölçeklemeToolStripMenuItem.Click += new System.EventHandler(this.ölçeklemeToolStripMenuItem_Click);
            // 
            // döndürmeToolStripMenuItem
            // 
            this.döndürmeToolStripMenuItem.Name = "döndürmeToolStripMenuItem";
            this.döndürmeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.döndürmeToolStripMenuItem.Text = "Döndürme";
            this.döndürmeToolStripMenuItem.Click += new System.EventHandler(this.döndürmeToolStripMenuItem_Click);
            // 
            // ötelemeToolStripMenuItem
            // 
            this.ötelemeToolStripMenuItem.Name = "ötelemeToolStripMenuItem";
            this.ötelemeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.ötelemeToolStripMenuItem.Text = "Öteleme";
            this.ötelemeToolStripMenuItem.Click += new System.EventHandler(this.ötelemeToolStripMenuItem_Click);
            // 
            // eğmeToolStripMenuItem
            // 
            this.eğmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dikeyToolStripMenuItem,
            this.yatayToolStripMenuItem});
            this.eğmeToolStripMenuItem.Name = "eğmeToolStripMenuItem";
            this.eğmeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.eğmeToolStripMenuItem.Text = "Eğme";
            // 
            // dikeyToolStripMenuItem
            // 
            this.dikeyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.dikeyToolStripMenuItem.Name = "dikeyToolStripMenuItem";
            this.dikeyToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.dikeyToolStripMenuItem.Text = "Dikey";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(96, 22);
            this.toolStripMenuItem2.Text = "%20";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(96, 22);
            this.toolStripMenuItem3.Text = "%40";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(96, 22);
            this.toolStripMenuItem4.Text = "%60";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(96, 22);
            this.toolStripMenuItem5.Text = "%80";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // yatayToolStripMenuItem
            // 
            this.yatayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
            this.yatayToolStripMenuItem.Name = "yatayToolStripMenuItem";
            this.yatayToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.yatayToolStripMenuItem.Text = "Yatay";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(96, 22);
            this.toolStripMenuItem7.Text = "%20";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(96, 22);
            this.toolStripMenuItem8.Text = "%40";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(96, 22);
            this.toolStripMenuItem9.Text = "%60";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(96, 22);
            this.toolStripMenuItem10.Text = "%80";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // kontrasGenişletmeToolStripMenuItem
            // 
            this.kontrasGenişletmeToolStripMenuItem.Name = "kontrasGenişletmeToolStripMenuItem";
            this.kontrasGenişletmeToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.kontrasGenişletmeToolStripMenuItem.Text = "Kontrast Genişletme";
            this.kontrasGenişletmeToolStripMenuItem.Click += new System.EventHandler(this.kontrasGenişletmeToolStripMenuItem_Click);
            // 
            // logaritmaDönüşümleriToolStripMenuItem
            // 
            this.logaritmaDönüşümleriToolStripMenuItem.Name = "logaritmaDönüşümleriToolStripMenuItem";
            this.logaritmaDönüşümleriToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.logaritmaDönüşümleriToolStripMenuItem.Text = "Logaritma Dönüşümleri";
            this.logaritmaDönüşümleriToolStripMenuItem.Click += new System.EventHandler(this.logaritmaDönüşümleriToolStripMenuItem_Click);
            // 
            // kuvvetGamaDönüşümleriToolStripMenuItem
            // 
            this.kuvvetGamaDönüşümleriToolStripMenuItem.Name = "kuvvetGamaDönüşümleriToolStripMenuItem";
            this.kuvvetGamaDönüşümleriToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.kuvvetGamaDönüşümleriToolStripMenuItem.Text = "Kuvvet Gama Dönüşümleri";
            this.kuvvetGamaDönüşümleriToolStripMenuItem.Click += new System.EventHandler(this.kuvvetGamaDönüşümleriToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramGermeToolStripMenuItem,
            this.histogramEşitlemeToolStripMenuItem});
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.histogramToolStripMenuItem.Text = "Histogram";
            // 
            // histogramGermeToolStripMenuItem
            // 
            this.histogramGermeToolStripMenuItem.Name = "histogramGermeToolStripMenuItem";
            this.histogramGermeToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.histogramGermeToolStripMenuItem.Text = "Histogram Germe";
            this.histogramGermeToolStripMenuItem.Click += new System.EventHandler(this.histogramGermeToolStripMenuItem_Click);
            // 
            // histogramEşitlemeToolStripMenuItem
            // 
            this.histogramEşitlemeToolStripMenuItem.Name = "histogramEşitlemeToolStripMenuItem";
            this.histogramEşitlemeToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.histogramEşitlemeToolStripMenuItem.Text = "Histogram Eşitleme";
            this.histogramEşitlemeToolStripMenuItem.Click += new System.EventHandler(this.histogramEşitlemeToolStripMenuItem_Click);
            // 
            // filtrelerToolStripMenuItem
            // 
            this.filtrelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEANToolStripMenuItem,
            this.medianToolStripMenuItem,
            this.sobelToolStripMenuItem});
            this.filtrelerToolStripMenuItem.Name = "filtrelerToolStripMenuItem";
            this.filtrelerToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.filtrelerToolStripMenuItem.Text = "Filtreler";
            // 
            // mEANToolStripMenuItem
            // 
            this.mEANToolStripMenuItem.Name = "mEANToolStripMenuItem";
            this.mEANToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.mEANToolStripMenuItem.Text = "MEAN";
            this.mEANToolStripMenuItem.Click += new System.EventHandler(this.mEANToolStripMenuItem_Click);
            // 
            // medianToolStripMenuItem
            // 
            this.medianToolStripMenuItem.Name = "medianToolStripMenuItem";
            this.medianToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.medianToolStripMenuItem.Text = "Median";
            this.medianToolStripMenuItem.Click += new System.EventHandler(this.medianToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(521, 526);
            this.Controls.Add(this.orj_box);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.d_img);
            this.Controls.Add(this.orj_img);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Görüntü İşleme   M.Serhat Yüksel";
            ((System.ComponentModel.ISupportInitialize)(this.orj_box)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox orj_img;
        private System.Windows.Forms.TextBox d_img;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resimEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görüntüİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gritonYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negatifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siyahBeyazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem komşuPixelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toplamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkarmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geometrikUzamsalİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ölçeklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem döndürmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ötelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eğmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dikeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yatayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontrasGenişletmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logaritmaDönüşümleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kuvvetGamaDönüşümleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramGermeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramEşitlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        public System.Windows.Forms.PictureBox orj_box;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
    }
}

