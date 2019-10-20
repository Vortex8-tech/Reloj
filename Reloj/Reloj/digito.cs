using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reloj
{
    class Digito
    {
        public int numDig = 0;
        private int Dx, Dy;
        public Color cl;

        reloj rj;

        public Digito(reloj _rj, int x, int y, Color c)
        {
            this.rj = _rj;

            this.Dx = x;
            this.Dy = y;
            this.cl = c;
        }
        public Digito(reloj _rj, int x, int y)
        {
            this.rj = _rj;
            
            this.Dx = x;
            this.Dy = y;
            this.cl = Color.FromArgb(0, 0, 0);
        }
        public Digito(reloj _rj)
        {
            this.rj = _rj;

            this.Dx = rj._fm.Width / 2;
            this.Dy = rj._fm.Height / 2;
            this.cl = Color.FromArgb(0, 0, 0);
        }

        public int _Dx { get { return Dx; } }
        public int _Dy { get { return Dy; } }

        //--------------------------------------------------------------------------------
        public void numero(int num)
        {
            switch (num)
            {
                case 0: rj.digito(this, 1, 1, 1, 1, 1, 1, 0); break;
                case 1: rj.digito(this, 0, 1, 1, 0, 0, 0, 0); break;
                case 2: rj.digito(this, 1, 1, 0, 1, 1, 0, 1); break;
                case 3: rj.digito(this, 1, 1, 1, 1, 0, 0, 1); break;
                case 4: rj.digito(this, 0, 1, 1, 0, 0, 1, 1); break;
                case 5: rj.digito(this, 1, 0, 1, 1, 0, 1, 1); break;
                case 6: rj.digito(this, 1, 0, 1, 1, 1, 1, 1); break;
                case 7: rj.digito(this, 1, 1, 1, 0, 0, 0, 0); break;
                case 8: rj.digito(this, 1, 1, 1, 1, 1, 1, 1); break;
                case 9: rj.digito(this, 1, 1, 1, 1, 0, 1, 1); break;
            }
        }
        public void color(Color c)
        {
            this.cl = c;
        }
    }
}


