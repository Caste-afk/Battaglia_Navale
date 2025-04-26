using System;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Net.Http.Headers;
using System.Reflection;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using WMPLib;
using System.Runtime.InteropServices;

//0 acqua da scoprire, 1 nave da scoprire, 2 nave scoperta, 3 acqua scoperta
//PER NASCONDERE INFORMAZIONI BISOGNA MODIFICARE L'ATTRIBUTO TAG NON VALUE!!!!!!!!!!!😎😎😎😎😎😎😎😎😎😎

namespace project
{
    public partial class Form1 : Form
    {
        List<CNave> navi;
        int tentativi;
        int naviaffondate;
        WMPLib.WindowsMediaPlayer player;
        public Form1()
        {
            InitializeComponent();
            dgv_Campo.SelectionMode = DataGridViewSelectionMode.CellSelect;
            AggiungiRighe();
            PiazzaNavi();
            ImpostaSecondoDgv();
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
                        dgv_Campo.Rows[r].Cells[c].Value = "     ";
                        dgv_Campo.Rows[r].Cells[c].Style.BackColor = Color.LightBlue;
                    }
                }
            }
        }//aggiunge le righe al dgv_Campo vuoto

        private void PiazzaNavi()
        {
            Random rnd = new Random();

            ListaNavi();

            foreach (var nave in navi)
            {
                nave.ProvaPiazzamento(dgv_Campo);
            }

        }//mette randomicamente le navi

        private void dgv_Campo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int yprem = e.RowIndex;
            int xprem = dgv_Campo.Columns[e.ColumnIndex].Index;
            string[] val = dgv_Campo.Rows[yprem].Cells[xprem].Tag?.ToString().Split(",");

            if (xprem > 0 && xprem <= 11 && yprem >= 0 && yprem <= 10)
            {
                if (val[0] == "0")
                {
                    ColoraCelle(xprem, yprem, Color.White);
                    dgv_Campo.Rows[yprem].Cells[xprem].Tag = $"3";
                    suoni(0);
                    AggiornaTentativi();
                }
                else if (val[0] == "1")
                {
                    AggiornaTentativi();
                    if (!ControlloNaveAffondata(xprem, yprem))
                    {
                        ControlloNaveColpita(xprem, yprem);
                    }
                }
            }
            if (navi.Count == naviaffondate)
            {
                Fine();
            }
        }//controllo per quando viene premuta una coordinata

        private bool ControlloNaveAffondata(int xprem, int yprem)
        {
            string[] val = dgv_Campo.Rows[yprem].Cells[xprem].Tag.ToString().Split(",");

            foreach (var nave in navi)
            {
                if (nave.nome == val[1])
                {
                    if (nave.colpi == nave.dimensione)
                    {

                        for (int i = 0; i < nave.dimensione; i++)
                        {
                            int cx = nave.verso ? nave.xi + i : nave.xi;
                            int cy = nave.verso ? nave.yi : nave.yi + i;

                            if (cy >= 0 && cy < dgv_Campo.Rows.Count && cx >= 0 && cx < dgv_Campo.Columns.Count)//Se è effettivamente affondata
                            {
                                dgv_Campo.Rows[cy].Cells[cx].Tag = "Affondata";
                                suoni(2);
                                ColoraCelle(cx, cy, Color.Red);
                            }

                        }
                        naviaffondate++;
                        return true;
                    }
                }
            }
            return false;
        }//controlla se la nava è stata affondata

        private void ControlloNaveColpita(int xprem, int yprem)
        {
            string[] val = dgv_Campo.Rows[yprem].Cells[xprem].Tag.ToString().Split(",");

            foreach (var nave in navi)
            {
                if (val.Length > 1 && nave.nome == val[1])
                {
                    nave.colpi++;
                    ColoraCelle(xprem, yprem, Color.Yellow);
                    dgv_Campo.Rows[yprem].Cells[xprem].Tag = $"2,{nave.nome}";
                    suoni(1);
                }
            }
        }//controlla se la nave è stata colpita

        private void ColoraCelle(int x, int y, Color colore)
        {
            dgv_Campo.Rows[y].Cells[x].Style.SelectionBackColor = colore;
            dgv_Campo.Rows[y].Cells[x].Style.BackColor = colore;
        }//colora le celle

        private void AggiornaTentativi()
        {
            lbl_tentativi.Text = $"Tentativi: {tentativi}";
            lbl_naviaffondate.Text = $"Navi affondate: {naviaffondate}";
            tentativi++;
        }//aggiorna i tentativi e le scritte

        private void Fine()
        {
            lbl_vinto.Visible = btn_NuovaPartita.Visible = btn_Salva.Visible = true;
            suoni(3);
            for (int col = 1; col < dgv_Campo.Columns.Count; col++)
            {
                for (int row = 0; row < dgv_Campo.Rows.Count; row++)
                {
                    if (dgv_Campo.Rows[row].Cells[col].Tag?.ToString() == "0")
                    {
                        ColoraCelle(col, row, Color.White);
                    }
                }
            }

        }//imposta la pagina per i titoli finali

        private void btn_NuovaPartita_Click(object sender, EventArgs e)
        {
            tentativi = 0;
            naviaffondate = 0;
            ListaNavi();
            dgv_Campo.Rows.Clear();
            dgv_Campo.Refresh();
            AggiungiRighe();
            PiazzaNavi();
            ImpostaSecondoDgv();
            lbl_vinto.Visible = btn_NuovaPartita.Visible = btn_Salva.Visible = false;
        }//pulsante per la nuova partita e reset delle impostazioni

        private void btn_Salva_Click(object sender, EventArgs e)
        {
            using(Fine fine = new Fine(tentativi))
            {
                if (fine.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }//salva nel csv

        private void ListaNavi()
        {
            CNave Portaerei = new CNave(5, "Portaerei");
            CNave Corazzata = new CNave(4, "Corazzata");
            CNave Incrociatore = new CNave(3, "Incrociatore");
            CNave Sommergibile = new CNave(3, "Sommergibile");
            CNave[] Cacciatorpediniere = { new CNave(2, "Cacciatorpediniere1"), new CNave(2, "Cacciatorpediniere2") };
            CNave[] Sottomarini = { new CNave(1, "Sottomarini1"), new CNave(1, "Sottomarini2"), new CNave(1, "Sottomarini3"), new CNave(1, "Sottomarini4") };

            navi = new List<CNave> { Portaerei, Corazzata, Incrociatore, Sommergibile, Cacciatorpediniere[0], Cacciatorpediniere[1], Sottomarini[0], Sottomarini[1], Sottomarini[2], Sottomarini[3] };
        }//popola la lista "navi"

        private void ImpostaSecondoDgv()
        {
            dgv_partitetot.Rows.Clear();
            //leggiamo il file come prima cosa
            string path = @"salvataggi.csv";
            List<CPartite> partite= new List<CPartite> { };
            using(StreamReader sr = new StreamReader(path))
            {
                string[] righe = sr.ReadToEnd().Split("\n");
                for (int i =1; i<righe.Length; i++)
                {
                    string riga = righe[i];
                    string[] contenuti = riga.Split(";");
                    int tent = int.Parse(contenuti[1]);
                    string nome= contenuti[0];
                    CPartite partita = new CPartite(tent, nome);
                    partite.Add(partita);
                }
            }

            partite = partite.OrderBy(p => p.tentativi).ToList();
            //dopo averlo letto scriviamolo nel dgv
            int index =0;
            for (int i = 0; i < partite.Count; i++)
            {
                int rowIndex = dgv_partitetot.Rows.Add();

                dgv_partitetot.Rows[rowIndex].Cells[0].Value = i + 1;
                dgv_partitetot.Rows[rowIndex].Cells[1].Value = partite[i].nome;
                dgv_partitetot.Rows[rowIndex].Cells[2].Value = partite[i].tentativi;
            }

        }//imposto il dgv delle partite

        private void suoni(int i)
        {   
            if(player != null)
            {
                player.controls.stop();
                player= null;
            }

            player = new WMPLib.WindowsMediaPlayer();
            player.URL = ($"suoni/{i}.wav");
            player.settings.volume = 5; // Valore da 0 a 100
            player.controls.play();

        }


    }
}
