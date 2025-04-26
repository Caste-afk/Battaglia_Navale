using System;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Reflection;
using System.Windows.Forms;


//PER NASCONDERE INFORMAZIONI BISOGNA MODIFICARE L'ATTRIBUTO TAG NON VALUE!!!!!!!!!!!😎😎😎😎😎😎😎😎😎😎

namespace project
{
    public partial class Form1 : Form
    {
        List<CNave> navi;
        int tentativi;
        int naviaffondate;
        public Form1()
        {
            InitializeComponent();
            dgv_Campo.SelectionMode = DataGridViewSelectionMode.CellSelect;
            AggiungiRighe();
            PiazzaNavi();
            tentativi = 0;
            naviaffondate = 0;
        }

        private void AggiungiRighe()
        {
            int righe = 10;
            int colonne = dgv_Campo.ColumnCount;
            int[,] matrice;

            matrice = new int[righe, colonne];

            for (int r = 0; r < righe; r++)
            {
                dgv_Campo.Rows.Add();
                for (int c = 0; c < colonne; c++)
                {
                    if (c == 0)
                    {
                        dgv_Campo.Rows[r].Cells[0].Value = r.ToString();
                    }
                    else
                    {
                        dgv_Campo.Rows[r].Cells[c].Tag = "0";
                        dgv_Campo.Rows[r].Cells[c].Value = "      ";
                        dgv_Campo.Rows[r].Cells[c].Style.BackColor = Color.LightBlue;
                    }
                }
            }
        }


        private void PiazzaNavi()
        {
            Random rnd = new Random();

            CNave Portaerei = new CNave(5, "Portaerei");
            CNave Corazzata = new CNave(4, "Corazzata");
            CNave Incrociatore = new CNave(3, "Incrociatore");
            CNave Sommergibile = new CNave(3, "Sommergibile");
            CNave[] Cacciatorpediniere = { new CNave(2, "Cacciatorpediniere1"), new CNave(2, "Cacciatorpediniere2") };
            CNave[] Sottomarini = { new CNave(1, "Sottomarini1"), new CNave(1, "Sottomarini2"), new CNave(1, "Sottomarini3"), new CNave(1, "Sottomarini4") };

            navi = new List<CNave> { Portaerei, Corazzata, Incrociatore, Sommergibile, Cacciatorpediniere[0], Cacciatorpediniere[1], Sottomarini[0], Sottomarini[1], Sottomarini[2], Sottomarini[3]};

            foreach(var nave in navi)
            {
                nave.ProvaPiazzamento(dgv_Campo);
            }

        }

        private void dgv_Campo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int yprem = e.RowIndex;
            int xprem = dgv_Campo.Columns[e.ColumnIndex].Index;
            string[] val = dgv_Campo.Rows[yprem].Cells[xprem].Tag?.ToString().Split(",");

            if (val[0] == "0")
            {
                ColoraCelle(xprem, yprem, Color.White);//iklusr gthuiosrtghuitsrhguiosrthguiosrthguosergt
            }
            else if (val[0] == "1")
            {
                if (!ControlloNaveAffondata(xprem, yprem))
                {
                    ControlloNaveColpita(xprem, yprem);
                }
            }
                tentativi++;
            lbl_tentativi.Text = $"Tentativi: {tentativi}";
            lbl_naviaffondate.Text = $"Navi affondate: {naviaffondate}";
        }

        private bool ControlloNaveAffondata(int xprem, int yprem)
        {
            string[] val = dgv_Campo.Rows[yprem].Cells[xprem].Tag.ToString().Split(",");
            
            foreach(var nave in navi)
            {
                if(nave.nome == val[1])
                {
                    if (nave.colpi == nave.dimensione)
                    {
                        nave.OccupaCelle(dgv_Campo, nave.xi, nave.yi, "AFFONDATA", Color.Red);
                        naviaffondate++;
                        ColoraCelle(xprem, yprem, Color.Red);
                        return true;
                    }
                }
            }
            return false;
        }

        private void ControlloNaveColpita(int xprem, int yprem)
        {
            string[] val = dgv_Campo.Rows[yprem].Cells[xprem].Tag.ToString().Split(",");

            foreach (var nave in navi)
            {
                if (val.Length>1 && nave.nome == val[1])
                {
                    nave.Colpita(dgv_Campo, xprem, yprem);
                    ColoraCelle(xprem, yprem, Color.Yellow);
                }
            }
        }

        private void ColoraCelle(int x, int y, Color colore)
        {
            dgv_Campo.Rows[y].Cells[x].Style.SelectionBackColor = colore;
            dgv_Campo.Rows[y].Cells[x].Style.BackColor = colore;
        }

    }
}
