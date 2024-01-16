using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek_1_815
{
    public partial class Form1 : Form
    {
        List<Bitmap> resimler = new List<Bitmap>();
        int sayac = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            resimler.Add(Properties.Resources.vodafonepark);
            resimler.Add(Properties.Resources.direk);
            resimler.Add(Properties.Resources.indir);
            resimler.Add(Properties.Resources.messi_2);
            resimler.Add(Properties.Resources.talisca2);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            sayac = sayac % resimler.Count;
            pictureBox1.Image = resimler[sayac];

            
        }
    }
}
