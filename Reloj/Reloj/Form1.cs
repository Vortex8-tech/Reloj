using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reloj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            reloj rj = new reloj();

            int centroX = this.Width / 2,
                centroY = this.Height / 2,
                mDig = (rj._tamaño * 12);

            Digito[] d = new Digito[4];

            for (int dig = 3; dig > 0; dig++)
            {
                d[dig] = new Digito(rj, centroX - mDig * dig-1, 200);
            }

            

            d[0].numero(1);
            d[1].numero(2);
            d[3].numero(3);
            d[4].numero(4);

            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime t = DateTime.Now;
            

            string h = t.Hour.ToString();
            string m = t.Minute.ToString();
            string s = t.Second.ToString();

            


            //Thread.Sleep(timer1.Interval);
            //this.Refresh();
        }
    }
}
