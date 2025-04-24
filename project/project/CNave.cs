using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class CNave
    {
        public int dimensione { get; set; }
        public int xi { get; set; }
        public int xf { get; set; }
        public int yi { get; set; }
        public int yf { get; set; }
        public bool verso { get; set; }  //true = orizzontale, false = verticale

        public CNave(int dimensione, int xi, int yi, int xf, int yf, bool verso )
        {
            this.dimensione = dimensione;
            this.xi = xi;
            this.yi = yi;
            this.xf = xf;
            this.yf = yf;
            this.verso = verso;
        }

    }
}
