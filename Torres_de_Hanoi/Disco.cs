using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Disco
    {
        /*TODO: 
        Decidir tipo de Valor
        public int Valor { get; set; }
        public String Valor { get; set; }
        */
        private int tam;

        public int Tam
        {
            get { return tam; }
            set { tam = value; }
        }

        public Disco(int tam)
        {
            this.Tam = tam;
        }

    }
}
