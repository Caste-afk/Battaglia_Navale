using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            int x = 10;
            InitializeComponent();
            ImpostaTabella(x, 10, "dgv_campo1");
            ImpostaTabella(x+490, 10, "dgv_campo2");
        }

        private void ImpostaTabella(int x, int y, string nome)
        {
            DataGridView campo = new DataGridView
            {
                Name = nome,
                Location = new System.Drawing.Point(x, y),
                Size = new System.Drawing.Size(480, 400),
                RowHeadersVisible = false,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToResizeColumns = false,
                AllowUserToResizeRows = false,
                AllowUserToDeleteRows = false,
                

        };

            this.Controls.Add(campo);

            campo.ColumnCount = 11;
            campo.RowCount = 10;


            for (int i = 0; i < campo.ColumnCount; i++)
            {
                campo.Columns[i].Name = $"{i}";
                campo.Columns[i].Width = 40;
            }

            string[] alfabeto = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J"};
            for(int i =0; i<campo.RowCount; i++)
            {
                campo.Rows[i].Height = 40;
                campo.Rows[i].Cells[0].Value = alfabeto[i];
            }

            for (int i =1; i<campo.ColumnCount; i++)
            {
                for (int j=0; j<campo.RowCount; j++)
                {
                    campo.Rows[i].Cells[j].ValueType = Button();
                }
            }

        }

        private void AggiungiPulsante(DataGridView campo)
        {

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "PulsanteColonna";
            buttonColumn.HeaderText = "Pulsanti";
            buttonColumn.Text = "Clicca";
            buttonColumn.UseColumnTextForButtonValue = true;  // Aggiunge un pulsante predefinito in ogni cella
            campo.Columns.Add(buttonColumn);
        }

    }
}