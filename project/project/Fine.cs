using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Fine : Form
    {
        private int tentativi;
        public Fine(int tentativi)
        {
            InitializeComponent();
            this.tentativi = tentativi;
        }

        private void btn_salva_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbx_nome.Text))
            {
                string path = @"salvataggi.csv";
                using (StreamWriter sw = new StreamWriter(path, append: true))
                {
                    sw.Write($"\n{tbx_nome.Text};{tentativi}");
                }
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Inserire un nome non nullo");
            }
        }

        private void btn_Annulla_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
