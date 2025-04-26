using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class CNave
    {
        public int dimensione { get; set; }
        public int colpi { get; set; } = 1;
        public string nome { get; set; }
        public int xi { set;  get; }
        public int yi { set;  get; }
        public bool verso { get; set; }      //orizzontale/verticale
        

        public CNave(int dimensione, string nome)
        {
            this.dimensione = dimensione;
            this.nome = nome ;
        }

        public void ProvaPiazzamento(DataGridView dgv_campo)
        {
            Random rnd = new Random();

            int x, y;
            do
            {
                x = rnd.Next(1, 11);
                y = rnd.Next(0, 10);

            }while (!ControlloVerso(x, y, dgv_campo)) ;
            xi = x;
            yi = y;
            OccupaCelle(dgv_campo, x, y, $"1,{nome}");
        }

        private bool ControlloVerso(int x, int y, DataGridView dgv_campo)
        {
            //controllo orizzontale
            if (x + dimensione < 11)
            {
                if (ControlloAltreNavi(dgv_campo, y, x, x + dimensione - 1, true))
                {
                    verso = true;
                    return true;
                }
            }

            //verticale
            if (y + dimensione < 10)
            {
                if (ControlloAltreNavi(dgv_campo, x, y, y + dimensione - 1, false))
                {
                    verso = false;
                    return true;
                }
            }

            return false;
        }

        private bool ControlloAltreNavi(DataGridView dgv_campo, int k, int d, int df, bool ver)//k sta per il punto che non ha bisogno di fine, mentre d e df sono le coordinate dove parte e arriva, ver è il verso (orizz, vert)
        {
            int s = (df > d) ? 1 : -1;

            for (int i = d; i != df + s; i += s)
            {
                int cellX = ver ? i : k;
                int cellY = ver ? k : i;

                string[] val = dgv_campo.Rows[cellY].Cells[cellX].Tag?.ToString().Split(",");

                if (val[0] == "1")
                {
                    return false; //occupata
                }
            }
            return true;
        }

        public void OccupaCelle(DataGridView dgv_campo, int x, int y, string testo)
        {
            for (int i = 0; i < dimensione; i++)
            {
                int cx = verso ? x + i : x;
                int cy = verso ? y : y + i;

                if (cy >= 0 && cy < dgv_campo.Rows.Count && cx >= 0 && cx < dgv_campo.Columns.Count)
                {
                    dgv_campo.Rows[cy].Cells[cx].Tag = testo;
                }

            }
        }
                
    }
}
