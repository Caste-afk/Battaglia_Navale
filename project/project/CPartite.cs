using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class CPartite
    {
        public int tentativi{ get; set; }
        public string nome { get; set; }

        public CPartite(int tentativi, string nome)
        {
            this.tentativi = tentativi;
            this.nome = nome;
        }
    }
}
