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
    class reloj
    {
        private Form fm;
        private bool guias;
        private int tamaño;

        public reloj()
        {
            this.fm = Form1.ActiveForm;
            this.guias = false;
            this.tamaño = 8;
        }
        public reloj(Form f, bool g, int t)
        {
            this.fm = f;
            this.guias = g;
            this.tamaño = t;
        }

        public int _tamaño { get { return this.tamaño; } }
        public bool _guias { get { return this.guias; } }
        public Form _fm { get { return this.fm; } }

        public void puntos(int x)
        {
            linea(x, 180, x + 10, 180, 20, Color.FromArgb(0, 0, 0));
            linea(x, 220, x + 10, 220, 20, Color.FromArgb(0, 0, 0));
        }

        public void digito(Digito dg, int a, int b, int c, int d, int e, int f, int g)
        {
            int tam = this.tamaño * 10, x = dg._Dx - (tam / 2), y = dg._Dy - tam,
                x2 = x + tam, y2 = y + tam, y3 = y + (tam * 2),
                tamRect = tam / 20,
                gr = tamRect * 4, inc = 8;

            if (this.guias == true) posRects(x, y, tam, tamRect, Color.FromArgb(255, 0, 0));

            if (a == 1) linea(x + tamRect + inc, y, x2 - tamRect + inc, y, gr, dg.cl);//a

            if (b == 1) linea(x2 + inc, y + tamRect, x2, y2 - tamRect, gr, dg.cl);//b
            if (c == 1) linea(x2, y2 + tamRect, x2 - inc, y3 - tamRect, gr, dg.cl);//c

            if (d == 1) linea(x + tamRect - inc, y3, x2 - tamRect - inc, y3, gr, dg.cl);//d

            if (e == 1) linea(x - inc, y3 - tamRect, x, y2 + tamRect, gr, dg.cl);//e
            if (f == 1) linea(x, y2 - tamRect, x + inc, y + tamRect, gr, dg.cl);//f

            if (g == 1) linea(x + tamRect, y2, x2 - tamRect, y2, gr, dg.cl);//g
        }

        private void posRects(int x, int y, int tam, int tamRect, Color color)
        {
            int x2 = x + tam,
                y2 = y + tam,
                y3 = y + (tam * 2),
                g = tamRect / 2, inc = 8;

            Graphics obj = fm.CreateGraphics();
            Pen lapiz = new Pen(color);

            rectangulo(x - tamRect + inc, y - tamRect, x + tamRect + inc, y + tamRect, g, Color.FromArgb(255, 0, 0));
            rectangulo(x2 - tamRect + inc, y - tamRect, x2 + tamRect + inc, y + tamRect, g, Color.FromArgb(255, 0, 0));

            rectangulo(x - tamRect, y2 - tamRect, x + tamRect, y2 + tamRect, g, Color.FromArgb(255, 0, 0));
            rectangulo(x2 - tamRect, y2 - tamRect, x2 + tamRect, y2 + tamRect, g, Color.FromArgb(255, 0, 0));

            rectangulo(x - tamRect - inc, y3 - tamRect, x + tamRect - inc, y3 + tamRect, g, Color.FromArgb(255, 0, 0));
            rectangulo(x2 - tamRect - inc, y3 - tamRect, x2 + tamRect - inc, y3 + tamRect, g, Color.FromArgb(255, 0, 0));
        }

        private void rectangulo(int x, int y, int x2, int y2, int grosor, Color color)
        {
            Graphics obj = fm.CreateGraphics();
            Pen lapiz = new Pen(color);
            lapiz.Width = grosor / 2;

            obj.DrawLine(lapiz, x, y, x2, y);
            obj.DrawLine(lapiz, x2, y, x2, y2);
            obj.DrawLine(lapiz, x, y, x, y2);
            obj.DrawLine(lapiz, x, y2, x2, y2);
        }
        public void linea(int x, int y, int x2, int y2, int grosor, Color color)
        {
            Graphics obj = fm.CreateGraphics();
            Pen lapiz = new Pen(color);
            lapiz.Width = grosor / 2;

            obj.DrawLine(lapiz, x, y, x2, y2);
        }

    }
}
