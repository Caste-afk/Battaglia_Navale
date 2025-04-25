using System;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;


//PER NASCONDERE INFORMAZIONI BISOGNA MODIFICARE L'ATTRIBUTO TAG NON VALUE!!!!!!!!!!!😎😎😎😎😎😎😎😎😎😎

namespace project
{
    public partial class Form1 : Form
    {
        List<CNave> navi;
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

        private void dgv_Campo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int yprem = e.RowIndex;
            int xprem = dgv_Campo.Columns[e.ColumnIndex].Index;
            if (dgv_Campo.Rows[yprem].Cells[xprem].Value?.ToString() == "0")
            {
                MessageBox.Show($"Hai mancato! x = {xprem}; y= {yprem}");
            }
            else
            {
                MessageBox.Show("Hai preso!");
                if(!ControlloNaveAffondata(xprem, yprem))
                {
                    dgv_Campo.Rows[yprem].Cells[xprem].Value = 2;
                }
            }
        }

        private bool ControlloNaveAffondata(int xprem, int yprem)
        {
            string[] val = dgv_Campo.Rows[yprem].Cells[xprem].Value.ToString().Split(",");
            
            foreach(var nave in navi)
            {
                if(nave.nome == val[1])
                {
                    nave.colpi++;
                    nave.Affondata(dgv_Campo, xprem, yprem);
                    MessageBox.Show($"{nave.colpi}");
                    return true;
                }
            }
            return false;
        }

    }
}
