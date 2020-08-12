using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Bitmap griYap(Bitmap bmp)
        {
            try
            {
                for (int i = 0; i < bmp.Height - 1; i++)
                {
                    for (int j = 0; j < bmp.Width; j++)
                    {
                        int deger = (bmp.GetPixel(j, i).R + bmp.GetPixel(j, i).B + bmp.GetPixel(j, i).G) / 3; // RGB değerler toplanıp 3'e bölünüyor
                        Color color = Color.FromArgb(deger, deger, deger);
                        bmp.SetPixel(j, i, color);
                    }
                }
                return bmp;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Hata!");
                return null;
            }

        }
        private Bitmap siyahB(Bitmap image)
        {

            try
            {
                griYap(image);

                int temp;
                int level = 127;
                Color color;

                for (int i = 0; i < image.Height ; i++)
                {
                    for (int j = 0; j < image.Width ; j++)
                    {
                        temp = image.GetPixel(j, i).B;
                        if (temp < level) //level değerinin altında kalanlara siyah atanıyor
                        {
                            color = Color.FromArgb(0, 0, 0);
                            image.SetPixel(j, i, color);
                        }
                        else
                        {
                            color = Color.FromArgb(255, 255, 255); //Beyaz atanıyor
                            image.SetPixel(j, i, color);
                        }
                    }

                }
                return image;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Image Operations");
                return null;
            }
        }
        public Bitmap kontrast(Bitmap image)
        {
            int sinir = Convert.ToInt32(Interaction.InputBox("Lütfen kontrast sınırını giriniz.(0-255)", "Kontrast"));
            try
            {
                griYap(image);

                int temp;
                Color color;

                for (int i = 0; i < image.Height ; i++)
                {
                    for (int j = 0; j < image.Width ; j++)
                    {
                        temp = image.GetPixel(j, i).B;
                        if (temp < sinir) // Sınırın altında kalan değerler 0'a eşitleniyor.
                        {
                            color = Color.FromArgb(0, 0, 0);
                            image.SetPixel(j, i, color);
                        }
                        else
                        {
                            color = Color.FromArgb(255, 255, 255);
                            image.SetPixel(j, i, color);
                        }
                    }

                }
                return image;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Image Operations");
                return null;
            }
        }
        public Bitmap logaritma(Bitmap image)
        {
            int r,s1;
            Color col;
            double s;
            Bitmap last = new Bitmap(image.Width,image.Height);
            double c = Convert.ToDouble(Interaction.InputBox("Lütfen c değerini giriniz.", "Logaritma Dönüşümü"));
            for(int i = 1; i < image.Width; i++)
            {
                for (int j = 1; j < image.Height; j++)
                {
                    r = image.GetPixel(i, j).R;
                    s = c * Math.Log10(r + 1);
                    s1 = Convert.ToInt32(s);
                    col = Color.FromArgb(s1,s1,s1);
                    last.SetPixel(i, j, col);
                }
            }
            return last;
        }
        public Bitmap kuvvetg(Bitmap image)
        {
            int r, s1;
            Color col;
            double s;
            Bitmap last = new Bitmap(image.Width, image.Height);
            double gama = Convert.ToDouble(Interaction.InputBox("Lütfen gama değerini giriniz.", "Gama Dönüşümü"));
            for (int i = 1; i < image.Width; i++)
            {
                for (int j = 1; j < image.Height; j++)
                {
                    r = image.GetPixel(i, j).R;
                    s = 1 * Math.Pow(r, gama);
                    s1 = Convert.ToInt32(s);
                    col = Color.FromArgb(s1, s1, s1);
                    last.SetPixel(i, j, col);
                }
            }
            return last;
        }
        private Bitmap Negatif(Bitmap image)
        {

            try
            {
                Bitmap last = new Bitmap(image.Width, image.Height);
                Color first_color, second_color;
                int r, g, b;
                for (int i = 0; i < image.Width - 1; i++)
                {
                    for (int j = 0; j < image.Height - 1; j++)
                    {
                        first_color = image.GetPixel(i, j);
                        r = 255 - first_color.R; //Pixellerin değeri 255 ten çıkarılıp tekrar aynı pixele atanıyor.
                        g = 255 - first_color.G;
                        b = 255 - first_color.B;
                        second_color = Color.FromArgb(r, g, b);
                        last.SetPixel(i, j, second_color);
                    }

                }
                return last;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Image Operations");
                return null;
            }
        }
        private Bitmap Oteleme(Bitmap image)
        {
            int cx, cy;
            cx= Convert.ToInt32(Interaction.InputBox("Lütfen satır sayısını giriniz.", "Satır Sayısı"));
            cy= Convert.ToInt32(Interaction.InputBox("Lütfen sütun sayısını giriniz.", "Sütun Sayısı"));
            
            var A = new int[,] { { 1, 0, 0}, { 0, 1, 0 }, { cx, cy, 1 } };
            int[] B= new int[3];
            int[] C = new int[3];
            try
            {
                Bitmap last = new Bitmap(image.Width+cx, image.Height+cy);
                
                for (int i = 0; i < image.Width - 1; i++)
                {
                    for (int j = 0; j < image.Height - 1; j++)
                    {
                        B[0] = i;
                        B[1] = j;
                        B[2] = 1;
                        for (int z = 0; z < 3; z++)
                        {
                            int toplam = 0;

                            for (int k = 0; k < 3; k++)
                            {
                                toplam += A[k, z] * B[k];
                            }
                            C[z] = toplam;
                        }
                        int x = C[0];
                        int y = C[1];
                        Console.WriteLine(x);
                        Console.WriteLine(y);
                        Color son_renk = image.GetPixel(i,j);
                        last.SetPixel(x, y, son_renk);
                    }

                }
                return last;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Image Operations");
                return null;
            }
        }
        private Bitmap Dondur(Bitmap image)//Eksik
        {
            int derece;
            derece = Convert.ToInt32(Interaction.InputBox("Lütfen dereceyi giriniz.", "Döndürme"));
            derece = Convert.ToInt32(Math.PI * derece / 180d);
            var A = new double[,] { { Math.Cos(derece), -1*Math.Sin(derece),0}, { Math.Sin(derece), Math.Cos(derece),0}, {0,0,1 } };
            double[] B = new double[3];
            double[] C = new double[3];
            int oldWidth = image.Width;
            int oldHeight = image.Height;
            int newWidth;
            int newHeight;
            double cos = Math.Abs(Math.Cos(derece));
            double sin = Math.Abs(Math.Sin(derece));
            newWidth = (int)Math.Round(oldWidth * cos + oldHeight * sin);
            newHeight = (int)Math.Round(oldWidth * sin + oldHeight * cos);
            try
            {

             Bitmap last = new Bitmap(newWidth,newHeight);

                    

                for (int i = 0; i < image.Width - 1; i++)
                {
                    for (int j = 0; j < image.Height - 1; j++)
                    {
                        B[0] = i;
                        B[1] = j;
                        B[2] = 1; //image.GetPixel(i,j).R
                        for (int z = 0; z < 3; z++)
                        {
                            double toplam = 0;

                            for (int k = 0; k < 3; k++)
                            {
                                toplam += A[k, z] * B[k];
                            }
                            C[z] = toplam;
                        }
                        double x = C[0];
                        double y = C[1];
                        Console.WriteLine(x);
                        Console.WriteLine(y);
                        if (x < 0)
                        {
                            x = x * -1;
                        }
                        if (y < 0)
                        {
                            y = y * -1;
                        }
                        Color son_renk = image.GetPixel(i, j);
                        last.SetPixel(Convert.ToInt32(x), Convert.ToInt32(y), son_renk);
                    }

                }
                return last;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Image Operations");
                return null;
            }
        } 
        private Bitmap Olcekle(Bitmap image)
        {
            double kat = Convert.ToDouble(Interaction.InputBox("Lütfen kaç kat ölçeklemek istediğinizi giriniz.", "Ölçekleme"));
            double toplam;
            
            var A = new double[,] { { kat, 0, 0 }, { 0, kat, 0 }, { 0, 0, 1 } };//Ölçekleme matrisi
            int[] B = new int[3];
            int[] C = new int[3];
            try
            {
                int w = Convert.ToInt32(image.Width * (kat));
                int h = Convert.ToInt32(image.Height * kat);
                Bitmap last = new Bitmap( w+1, h+1);

                for (int i = 0; i < image.Width - 1; i++)
                {
                    for (int j = 0; j < image.Height - 1; j++)
                    {
                        B[0] = i;
                        B[1] = j;
                        B[2] = 1;
                        for (int z = 0; z < 3; z++)
                        {
                            toplam = 0;

                            for (int k = 0; k < 3; k++)
                            {
                                toplam += A[k, z] * B[k];
                            }
                            C[z] = Convert.ToInt32(toplam);
                        }
                        int x = C[0];
                        int y = C[1];
                        Console.WriteLine(x);
                        Console.WriteLine(y);
                        Color son_renk = image.GetPixel(i, j);
                        last.SetPixel(x, y, son_renk);
                        
                    }

                }
                return last;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Image Operations");
                return null;
            }
        }
        public Bitmap zoomIn(Bitmap image)
        {
            int w = (image.Width - 1) * 2; //2x zoom için genişlik ve yükseklik 2 ile çarpılıyor.
            int h = (image.Height - 1) * 2;
            int k = 1;
            int l = 1;
            Bitmap img = new Bitmap(w, h);
            for (int i = 1; i < w - 1; i += 2)
            {
                l = 1;
                for (int j = 1; j < h - 1; j += 2)
                {


                    img.SetPixel(i, j, image.GetPixel(k, l));
                    img.SetPixel(i, j + 1, image.GetPixel(k, l));
                    img.SetPixel(i + 1, j, image.GetPixel(k, l));
                    img.SetPixel(i + 1, j + 1, image.GetPixel(k, l));

                    l = l + 1;

                }
                k = k + 1;
            }

            return img;
        }
        public Bitmap zoomOut(Bitmap image)
        {
            int w = Convert.ToInt32((image.Width - 1) * 0.5);//2x zoom out için genişlik ve yükseklik 1/2 ile çarpılıyor.
            int h = Convert.ToInt32((image.Height - 1) * 0.5);
            int k = 1;
            int l = 1;
            Bitmap img = new Bitmap(w, h);
            for (int i = 1; i < w - 1; i++)
            {
                l = 1;
                for (int j = 1; j < h - 1; j++)
                {

                    img.SetPixel(i, j, image.GetPixel(k, l));
                    l = l + 2;
                }
                k = k + 2;
            }

            return img;
        }
        private Bitmap EgmeD(Bitmap image, double egm)//Dikey Eğme Fonksiyonu
        {
            int w, h;
            double egm2, toplam;
            var A = new double[,] { { 1, 0, 0 }, { egm, 1, 0 }, { 0, 0, 1 } };//Dikey eğme matrisi
            int[] B = new int[3];
            int[] C = new int[3];

            egm2 = 1+egm;

            w = Convert.ToInt32(image.Width * (egm2));
            h = image.Height;
            try
            {
                Bitmap last = new Bitmap(w+1,h+1);

                for (int i = 0; i < image.Width-2; i++)
                {
                    for (int j = 0; j < image.Height-2; j++)
                    {
                        B[0] = i;
                        B[1] = j;
                        B[2] = 1;
                        for (int z = 0; z < 3; z++)
                        {
                            toplam = 0;

                            for (int k = 0; k < 3; k++)
                            {
                                toplam += A[k, z] * B[k];
                            }
                            C[z] = Convert.ToInt32(toplam);
                        }
                        Console.WriteLine(last.Height);
                        int x = C[0];
                        int y = C[1];
                        Color son_renk = image.GetPixel(i, j);
                        last.SetPixel(x, y, son_renk);

                    }

                }
                return last;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Image Operations");
                return null;
            }
        }
        private Bitmap EgmeY(Bitmap image,double egm)//Yatay Eğme Fonksiyonu
        {
            int w, h;
            var A = new double[,] { { 1, egm, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };//Yatay eğme matrisi
            int[] B = new int[3];
            int[] C = new int[3];
            egm = 1 + egm;


            w = image.Width;
            h = Convert.ToInt32(image.Height * (egm));
            try
            {
                Bitmap last = new Bitmap(w + 1, h + 1);

                for (int i = 0; i < image.Width - 2; i++)
                {
                    for (int j = 0; j < image.Height - 2; j++)
                    {
                        B[0] = i;
                        B[1] = j;
                        B[2] = 1;
                        for (int z = 0; z < 3; z++)
                        {
                            double toplam = 0;

                            for (int k = 0; k < 3; k++)
                            {
                                toplam += A[k, z] * B[k];
                            }
                            C[z] = Convert.ToInt32(toplam);
                        }
                        Console.WriteLine(last.Height);
                        int x = C[0];
                        int y = C[1];
                        Console.WriteLine(x);
                        Console.WriteLine(y);
                        Color son_renk = image.GetPixel(i, j);
                        last.SetPixel(x, y, son_renk);

                    }

                }
                return last;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Image Operations");
                return null;
            }
        }
        public void komsu(Bitmap image)
        {
            try
            {
                String x, y, w, h;
                w = Convert.ToString(image.Width - 2);
                h = Convert.ToString(image.Height - 2);
                x = Interaction.InputBox("Lütfen x'i giriniz." + "(1 ile " + h + " arasında)", "X");
                y = Interaction.InputBox("Lütfen y'i giriniz." + "(1 ile " + w + " arasında)", "Y");
                int x1 = Convert.ToInt32(x);
                int y1 = Convert.ToInt32(y);

                Form2 frm2 = new Form2();
                frm2.textBox1.Text = x + " , " + y;
                if (y1 == 1)
                {
                    frm2.textBox2.Text = "X";
                }
                else
                {
                    frm2.textBox2.Text = Convert.ToString(image.GetPixel(x1, y1 - 1).R) + " , " + Convert.ToString(image.GetPixel(x1, y1 - 1).G) + " , " + Convert.ToString(image.GetPixel(x1, y1 - 1).B);
                }
                if (x1 == 1)
                {
                    frm2.textBox3.Text = "X";
                }
                else
                {
                    frm2.textBox3.Text = Convert.ToString(image.GetPixel(x1 - 1, y1).R) + " , " + Convert.ToString(image.GetPixel(x1 - 1, y1).G) + " , " + Convert.ToString(image.GetPixel(x1 - 1, y1).B);
                }
                if (y1 == image.Width)
                {
                    frm2.textBox4.Text = "X";
                }
                else
                {
                    frm2.textBox4.Text = Convert.ToString(image.GetPixel(x1, y1 + 1).R) + " , " + Convert.ToString(image.GetPixel(x1, y1 + 1).G) + " , " + Convert.ToString(image.GetPixel(x1, y1 + 1).B);
                }
                if (x1 == image.Height)
                {
                    frm2.textBox5.Text = "X";
                }
                else
                {
                    frm2.textBox5.Text = Convert.ToString(image.GetPixel(x1 + 1, y1).R) + " , " + Convert.ToString(image.GetPixel(x1 + 1, y1).G) + " , " + Convert.ToString(image.GetPixel(x1 + 1, y1).B);
                }

                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen verilen aralıkta değer giriniz!");
            }
            
        }
        public Bitmap topla(Bitmap image)
        {
            Color toplam;
            int son_w, son_h, r, g, b;
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Title = "2.Resmi Seç";
            dosya.Filter = "Resim dosyaları|*.jpg;*.jpeg;*.bmp;*.png";
            dosya.Multiselect = false;
            if (dosya.ShowDialog() == DialogResult.OK)
            {

            }
            Bitmap image2 = new Bitmap(dosya.FileName);
            if (image.Width >= image2.Width)
            {
                son_w = image.Width;
            }
            else
            {
                son_w = image2.Width;
            }
            if (image.Height >= image2.Height)
            {
                son_h = image.Height;
            }
            else
            {
                son_h = image2.Height;
            }
            Bitmap last = new Bitmap(son_w, son_h);
            for(int i = 1; i < son_w-1; i++)
            {
                for (int j = 1; j < son_h-1; j++)
                {
                    if(i>=image.Width || j >= image.Height)
                    {
                        r =image2.GetPixel(i, j).R;
                        g =image2.GetPixel(i, j).G;
                        b =image2.GetPixel(i, j).B;
                        toplam = Color.FromArgb(r, g, b);
                    }else if(i >= image2.Width || j >= image2.Height)
                    {
                        r = image.GetPixel(i, j).R ;
                        g = image.GetPixel(i, j).G ;
                        b = image.GetPixel(i, j).B ;
                        toplam = Color.FromArgb(r, g, b);
                    }
                    else
                    {
                        r = (image.GetPixel(i, j).R + image2.GetPixel(i, j).R) ;
                        if (r > 255)
                            r = 255;
                        g = (image.GetPixel(i, j).G + image2.GetPixel(i, j).G) ;
                        if (g > 255)
                            g = 255;
                        b = (image.GetPixel(i, j).B + image2.GetPixel(i, j).B) ;
                        if (b > 255)
                            b = 255;
                        toplam = Color.FromArgb(r, g, b);
                    }
                    
                    last.SetPixel(i, j,toplam);
                }
            }
            return last;
        }
        public Bitmap cikar(Bitmap image)
        {
            Color sonuc;
            int son_w, son_h, r, g, b;
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Title = "2.Resmi Seç";
            dosya.Filter = "Resim dosyaları|*.jpg;*.jpeg;*.bmp;*.png";
            dosya.Multiselect = false;
            if (dosya.ShowDialog() == DialogResult.OK)
            {

            }
            Bitmap image2 = new Bitmap(dosya.FileName);
            if (image.Width >= image2.Width)
            {
                son_w = image.Width;
            }
            else
            {
                son_w = image2.Width;
            }
            if (image.Height >= image2.Height)
            {
                son_h = image.Height;
            }
            else
            {
                son_h = image2.Height;
            }
            Bitmap last = new Bitmap(son_w, son_h);
            for (int i = 1; i < son_w - 1; i++)
            {
                for (int j = 1; j < son_h - 1; j++)
                {
                    if (i >= image.Width || j >= image.Height)
                    {
                        r = image2.GetPixel(i, j).R;
                        g = image2.GetPixel(i, j).G;
                        b = image2.GetPixel(i, j).B;
                        sonuc = Color.FromArgb(r, g, b);
                    }
                    else if (i >= image2.Width || j >= image2.Height)
                    {
                        r = image.GetPixel(i, j).R;
                        g = image.GetPixel(i, j).G;
                        b = image.GetPixel(i, j).B;
                        sonuc = Color.FromArgb(r, g, b);
                    }
                    else
                    {
                        r = (image.GetPixel(i, j).R - image2.GetPixel(i, j).R);
                        if (r < 0)
                            r = 0;
                        g = (image.GetPixel(i, j).G - image2.GetPixel(i, j).G);
                        if (g < 0)
                            g = 0;
                        b = (image.GetPixel(i, j).B - image2.GetPixel(i, j).B);
                        if (b < 0)
                            b = 0;
                        sonuc = Color.FromArgb(r, g, b);
                    }

                    last.SetPixel(i, j, sonuc);
                }
            }
            return last;
        }
        public Bitmap histogramEsitleme(Bitmap KaynakResim)
        {
            Bitmap renderedImage = KaynakResim;

            uint pixels = (uint)renderedImage.Height * (uint)renderedImage.Width;
            decimal Const = 255 / (decimal)pixels;

            int x, y, R, G, B;


            int[] HistogramRed2 = new int[256];
            int[] HistogramGreen2 = new int[256];
            int[] HistogramBlue2 = new int[256];


            for (var i = 0; i < renderedImage.Width; i++)
            {
                for (var j = 0; j < renderedImage.Height; j++)
                {
                    var piksel = renderedImage.GetPixel(i, j);

                    HistogramRed2[(int)piksel.R]++;
                    HistogramGreen2[(int)piksel.G]++;
                    HistogramBlue2[(int)piksel.B]++;

                }
            }

            int[] cdfR = HistogramRed2;
            int[] cdfG = HistogramGreen2;
            int[] cdfB = HistogramBlue2;

            for (int r = 1; r <= 255; r++)
            {
                cdfR[r] = cdfR[r] + cdfR[r - 1];
                cdfG[r] = cdfG[r] + cdfG[r - 1];
                cdfB[r] = cdfB[r] + cdfB[r - 1];
            }

            for (y = 0; y < renderedImage.Height; y++)
            {
                for (x = 0; x < renderedImage.Width; x++)
                {
                    Color pixelColor = renderedImage.GetPixel(x, y);

                    R = (int)((decimal)cdfR[pixelColor.R] * Const);
                    G = (int)((decimal)cdfG[pixelColor.G] * Const);
                    B = (int)((decimal)cdfB[pixelColor.B] * Const);

                    Color newColor = Color.FromArgb(R, G, B);
                    renderedImage.SetPixel(x, y, newColor);
                }
            }
            return renderedImage;
        }
        public Bitmap histogramGerme(Bitmap image)
        {
            int[] histogram = new int[256];
            int gmax = 255;
            int gmin = 0;
            int c = 0;
            int d=0;
            int w = image.Width;
            int h = image.Height;

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {

                    Color renk = image.GetPixel(j, i);

                    int griDeger = (renk.R + renk.G + renk.B) / 3;
                    // 0-255 pikselin adeti
                    for (int m = 0; m < histogram.Length; m++)
                    {
                        if (griDeger == m)
                        {
                            histogram[m] = histogram[m] + 1;
                        }
                    }

                }
            }
            for (int z = 0; z < histogram.Length; z++)
            {
                if (histogram[z] != 0)
                { c = z; break; }
            }
            // En büyük piksel
            for (int z = 254; z >= 0; z--)
            {
                if (histogram[z] != 0)
                { d = z; break; }
            }

            Bitmap last = new Bitmap(w, h);

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {

                    Color renk = image.GetPixel(j, i);

                    int pgirdi = (renk.R + renk.G + renk.B) / 3;
                    //Histogram Germe
                    int pcikti = Convert.ToInt32((pgirdi - c) * ((gmax - gmin) / (d - c)) + gmin);

                    Color griRenk = Color.FromArgb(pcikti, pcikti, pcikti);
                    last.SetPixel(j, i, griRenk);
                }
            }
            return last;
        }
        public Bitmap meanf(Bitmap image)
        {

            Color c;
            float sum = 0;
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    c = image.GetPixel(i, j);
                    byte gray = (byte)(.333 * c.R + .333 * c.G + .333 * c.B);
                    image.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }
            Bitmap temp = new Bitmap(image);
            for (int i = 0; i <= image.Width - 3; i++)
                for (int j = 0; j <= image.Height - 3; j++)
                {
                    for (int x = i; x <= i + 2; x++)
                        for (int y = j; y <= j + 2; y++)
                        {
                            c = image.GetPixel(x, y);
                            sum = sum + c.R;
                        }
                    int color = (int)Math.Round(sum / 9, 10);
                    temp.SetPixel(i + 1, j + 1, Color.FromArgb(color, color, color));
                    sum = 0;
                }
            return temp;
        }
        public Bitmap MedianFiltering(Bitmap bm)
        {
            List<byte> termsList = new List<byte>();

            byte[,] image = new byte[bm.Width, bm.Height];


            for (int i = 0; i < bm.Width; i++)
            {
                for (int j = 0; j < bm.Height; j++)
                {
                    var c = bm.GetPixel(i, j);
                    byte gray = (byte)(.333 * c.R + .333 * c.G + .333 * c.B);
                    image[i, j] = gray;
                }
            }

            //Median Filtresi
            for (int i = 0; i <= bm.Width - 3; i++)
                for (int j = 0; j <= bm.Height - 3; j++)
                {
                    for (int x = i; x <= i + 2; x++)
                        for (int y = j; y <= j + 2; y++)
                        {
                            termsList.Add(image[x, y]);
                        }
                    byte[] terms = termsList.ToArray();
                    termsList.Clear();
                    Array.Sort<byte>(terms);
                    Array.Reverse(terms);
                    byte color = terms[4];
                    bm.SetPixel(i + 1, j + 1, Color.FromArgb(color, color, color));
                }
            return bm;
        }
        public Bitmap sobelEdge(Bitmap image)
        {
            Bitmap b = image;
            Bitmap bb = image;
            int width = b.Width;
            int height = b.Height;
            int[,] gx = new int[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            int[,] gy = new int[,] { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };

            int[,] allPixR = new int[width, height];
            int[,] allPixG = new int[width, height];
            int[,] allPixB = new int[width, height];

            int limit = 128 * 128;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    allPixR[i, j] = b.GetPixel(i, j).R;
                    allPixG[i, j] = b.GetPixel(i, j).G;
                    allPixB[i, j] = b.GetPixel(i, j).B;
                }
            }

            int new_rx = 0, new_ry = 0;
            int new_gx = 0, new_gy = 0;
            int new_bx = 0, new_by = 0;
            int rc, gc, bc;
            for (int i = 1; i < b.Width - 1; i++)
            {
                for (int j = 1; j < b.Height - 1; j++)
                {

                    new_rx = 0;
                    new_ry = 0;
                    new_gx = 0;
                    new_gy = 0;
                    new_bx = 0;
                    new_by = 0;
                    rc = 0;
                    gc = 0;
                    bc = 0;

                    for (int wi = -1; wi < 2; wi++)
                    {
                        for (int hw = -1; hw < 2; hw++)
                        {
                            rc = allPixR[i + hw, j + wi];
                            new_rx += gx[wi + 1, hw + 1] * rc;
                            new_ry += gy[wi + 1, hw + 1] * rc;

                            gc = allPixG[i + hw, j + wi];
                            new_gx += gx[wi + 1, hw + 1] * gc;
                            new_gy += gy[wi + 1, hw + 1] * gc;

                            bc = allPixB[i + hw, j + wi];
                            new_bx += gx[wi + 1, hw + 1] * bc;
                            new_by += gy[wi + 1, hw + 1] * bc;
                        }
                    }
                    if (new_rx * new_rx + new_ry * new_ry > limit || new_gx * new_gx + new_gy * new_gy > limit || new_bx * new_bx + new_by * new_by > limit)
                        bb.SetPixel(i, j, Color.Black);

                    //bb.SetPixel (i, j, Color.FromArgb(allPixR[i,j],allPixG[i,j],allPixB[i,j]));
                    else
                        bb.SetPixel(i, j, Color.Transparent);
                }
            }
            return bb;

        }


        private void resimEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.orj_box.Image = null;
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Title = "Resim Ekle";
            dosya.Filter = "Resim dosyaları|*.jpg;*.jpeg;*.bmp;*.png";
            dosya.Multiselect = false;
            if (dosya.ShowDialog() == DialogResult.OK)
            {
                this.orj_box.ImageLocation = dosya.FileName;
            }
            
        }

        private void gritonYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = griYap(img);
                frm2.Text = "Griton Resim";
                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim seçili değil!");
            }
            
        }

        private void negatifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = Negatif(img);
                frm2.Text = "Negatif Resim";
                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim seçili değil!");
            }
        }

        private void siyahBeyazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = siyahB(img);
                frm2.Text = "Siyah Beyaz Resim";
                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim seçili değil!");
            }
        }

        private void ötelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = Oteleme(img);
                frm2.Text = "Ötelenmiş Resim";
                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim seçili değil!");
            }
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)//Zoom In
        {

                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = zoomIn(img);
                frm2.Text = "2x Zoom Resim";
                frm2.Show();

        }

        private void komşuPixelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(orj_box.Image);
            
            komsu(img);
        }

        private void histogramEşitlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = histogramEsitleme(img);
                frm2.Text = "Histogram Eşitleme";
                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim seçili değil!");
            }
        }

        private void toplamaToolStripMenuItem_Click(object sender, EventArgs e)//Toplama
        {
            try
            {
                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = topla(img);
                frm2.Text = "Toplanmış Resim";
                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim seçili değil!");
            }
        }

        private void çıkarmaToolStripMenuItem_Click(object sender, EventArgs e)//Çıkarma
        {
            try
            {
                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = cikar(img);
                frm2.Text = "Çıkarılmış Resim";
                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim seçili değil!");
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)//%20 Dikey Eğim
        {
            try
            {
                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = EgmeD(img, 0.2);
                frm2.Text = "%20 Eğim ile Resim";
                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim seçili değil!");
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)//%40 Dikey Eğim
        {
            try
            {
                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = EgmeD(img, 0.4);
                frm2.Text = "%40 Eğim ile Resim";
                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim seçili değil!");
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)//%60 Dikey Eğim
        {
            try
            {
                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = EgmeD(img, 0.6);
                frm2.Text = "%60 Eğim ile Resim";
                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim seçili değil!");
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e) //%80 Dikey Eğim
        {
            try
            {
                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = EgmeD(img, 0.8);
                frm2.Text = "%80 Eğim ile Resim";
                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim seçili değil!");
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)//%20 Yatay Eğim
        {
            try
            {
                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = EgmeY(img, 0.2);
                frm2.Text = "%20 Eğim ile Resim";
                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim seçili değil!");
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)//%40 Yatay Eğim
        {
            try
            {
                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = EgmeY(img, 0.4);
                frm2.Text = "%40 Eğim ile Resim";
                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim seçili değil!");
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)//%60 Yatay Eğim
        {
            try
            {
                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = EgmeY(img, 0.6);
                frm2.Text = "%60 Eğim ile Resim";
                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim seçili değil!");
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)//%80 Yatay Eğim
        {
            try
            {
                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = EgmeY(img, 0.8);
                frm2.Text = "%80 Eğim ile Resim";
                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim seçili değil!");
            }
        }

        private void ölçeklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = Olcekle(img);
                frm2.Text = "Ölçekleme";
                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim seçili değil!");
            }
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = zoomOut(img);
                frm2.Text = "Zoom Out Resim";
                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim seçili değil!");
            }
        }

        private void kontrasGenişletmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = kontrast(img);
                frm2.Text = "Kontrast Resim";
                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim seçili değil!");
            }
        }

        private void logaritmaDönüşümleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = logaritma(img);
                frm2.Text = "Logaritma Resim";
                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim seçili değil!");
            }
        }

        private void kuvvetGamaDönüşümleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = kuvvetg(img);
                frm2.Text = "Kuvvet-Gama Resim";
                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim seçili değil!");
            }
        }

        private void histogramGermeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = histogramGerme(img);
                frm2.Text = "Histogram Germe";
                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim seçili değil!");
            }
        }

        private void mEANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = meanf(img);
                frm2.Text = "MEAN Filtresi";
                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim seçili değil!");
            }
        }

        private void medianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = MedianFiltering(img);
                frm2.Text = "Median Filtresi";
                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim seçili değil!");
            }
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = sobelEdge(img);
                frm2.Text = "Sobel Filtresi";
                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim seçili değil!");
            }
        }


        private void döndürmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap img = new Bitmap(orj_box.Image);
                Form2 frm2 = new Form2();
                frm2.pictureBox1.Image = Dondur(img);
                frm2.Text = "Döndürme";
                frm2.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim seçili değil!");
            }
        }
    }
}
