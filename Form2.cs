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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
 
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void resmiKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {

            }
            String imgPath = fbd.SelectedPath;
            String img_name = this.Text;
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Save(imgPath + "\\"+ img_name +".jpg", ImageFormat.Jpeg);
            }
        }
    }
}
