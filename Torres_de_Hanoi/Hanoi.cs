using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            if(a.top().Tam > b.top().Tam)
            {
                b.push(a.top());
                a.pop();
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int movimientos = 0;
            if(n%2 != 0)
            {
                while (fin.Elementos.Count != n)
                {
                    mover_disco(ini, fin);
                    movimientos++;
                    mover_disco(ini, aux);
                    movimientos++;
                    mover_disco(aux, fin);
                    movimientos++;
                }
            }
            else
            {
                while (fin.Elementos.Count != n)
                {
                    mover_disco(ini, aux);
                    movimientos++;
                    mover_disco(ini, fin);
                    movimientos++;
                    mover_disco(aux, fin);
                    movimientos++;
                }
            }
            return movimientos;
        }

    }
}
