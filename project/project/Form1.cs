using System.Configuration;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AggiungiRighe();
            PiazzaNavi();
        }

        private void AggiungiRighe()
        {
            int righe = 10;
            int colonne = dgv_Campo.ColumnCount;
            int[,] matrice;

            int index = 0;
            matrice = new int[righe, colonne];

            for (int r = 0; r < righe; r++)
            {
                dgv_Campo.Rows.Add();
                for (int c = 0; c < colonne; c++)
                {
                    if (c == 0)
                    {
                        dgv_Campo.Rows[r].Cells[0].Value = index;
                    }
                    else
                    {
                        dgv_Campo.Rows[r].Cells[c].Value = 0;
                    }
                }

                index++;
            }
        }

        private void dgv_Campo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Campo.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                MessageBox.Show($"Pulsante cliccato nella riga {e.RowIndex}, {dgv_Campo.Columns[e.ColumnIndex].Index}");
            }
        }


        private void PiazzaNavi()
        {
            Random rnd = new Random();

            CNave Portaerei = new CNave(5, 0, 0, 0, 0, true);
            CNave Corazzata = new CNave(4, 0, 0, 0, 0, true);
            CNave Incrociatore = new CNave(3, 0, 0, 0, 0, true);
            CNave Sommergibile = new CNave(3, 0, 0, 0, 0, true);
            CNave[] Cacciatorpediniere = { new CNave(2, 0, 0, 0, 0, true), new CNave(2, 0, 0, 0, 0, true) };
            CNave[] Sottomarini = { new CNave(1, 0, 0, 0, 0, true), new CNave(1, 0, 0, 0, 0, true), new CNave(1, 0, 0, 0, 0, true), new CNave(1, 0, 0, 0, 0, true) };

            List<CNave> navi = new List<CNave> { Portaerei, Corazzata, Incrociatore, Sommergibile, Cacciatorpediniere[0], Cacciatorpediniere[1], Sottomarini[0], Sottomarini[1], Sottomarini[2], Sottomarini[3]};

            for(int i =0; i< navi.Count; i++)
            {
                bool piazzato = false;
                int tentativiMassimi = 100;  // Massimo 100 tentativi per nave
                int tentativi = 0;

                while (!piazzato && tentativi < tentativiMassimi)
                {
                    tentativi++;  // Incrementa il contatore
                    int x = rnd.Next(0, 10);
                    int y = rnd.Next(0, 10);
                    piazzato = ControlloPiazzamenti(x, y, navi[i]);

                    if (tentativi >= tentativiMassimi)
                    {
                        MessageBox.Show("Impossibile piazzare la nave " + i);
                        break;  // Esce dal ciclo while
                    }
                }

                if (navi[i].xi >= navi[i].xf)
                {
                    for(int j = navi[i].xi; j >= navi[i].xf; j--)
                    {
                        dgv_Campo.Rows[navi[i].yi].Cells[j].Value = "1";
                        dgv_Campo.Rows[navi[i].yi].Cells[j].Style.BackColor = Color.Green;
                    }
                }
                else
                {
                    for (int j = navi[i].xi; j <= navi[i].xf; j++)
                    {
                        dgv_Campo.Rows[navi[i].yi].Cells[j].Style.BackColor = Color.Green;
                        dgv_Campo.Rows[navi[i].yi].Cells[j].Value = 1;
                    }
                }
                
            }
        }

        private bool ControlloPiazzamenti(int x, int y, CNave nave)
        {
            // Controlla se la cella iniziale è libera
            if (dgv_Campo.Rows[y].Cells[x].Value?.ToString() != "0")
                return false;

            // Prova prima a destra, poi a sinistra
            bool piazzato = ControlloOrizzontale(x, y, nave, true);
            if (!piazzato)
                piazzato = ControlloOrizzontale(x, y, nave, false);

            if (piazzato)
            {
                nave.xi = x;
                nave.yi = nave.yf = y;
                nave.xf = nave.verso ? x + nave.dimensione - 1 : x - nave.dimensione + 1;
            }

            return piazzato;
        }

        private bool ControlloOrizzontale(int x, int y, CNave nave, bool verso)
        {
            int dimensioneNave = nave.dimensione;
            int colonneTotali = dgv_Campo.ColumnCount;

            // Controlla se la nave esce dai bordi
            if (verso) // Destra
            {
                if (x + dimensioneNave > colonneTotali)
                    return false;
            }
            else // Sinistra
            {
                if (x - dimensioneNave < 0)
                    return false;
            }

            // Controlla se tutte le celle sono libere
            for (int i = 0; i < dimensioneNave; i++)
            {
                int cellX = verso ? x + i : x - i;
                int cellY = y;

                if (dgv_Campo.Rows[cellY].Cells[cellX].Value?.ToString() != "0")
                    return false;
            }

            return true;
        }

    }
}
