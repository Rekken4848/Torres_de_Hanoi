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
            if(a.top().Tam > b.top().Tam || a.top().Tam > 0)
            {
                b.push(a.top());
                a.pop();
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int movimientos = 0;
            Console.WriteLine("Situación inicial.");
            String iniText = "Torre INI: ";

            if (n%2 != 0)
            {
                while (fin.Elementos.Count != n)
                {
                    mover_disco(ini, fin);
                    movimientos++;
                    mover_disco(ini, aux);
                    movimientos++;
                    mover_disco(aux, fin);
                    movimientos++;
                    Console.WriteLine("Hola." + movimientos);
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
                    Console.WriteLine("Adios." + movimientos);
                }
            }
            return movimientos;
        }

    }

    public void Estado(Pila ini, Pila fin, Pila aux)
    {
        String iniText = "Torre INI: ";

        if (ini.isEmpty())
        {
            for(int i=0; i<ini.Elementos.Count; i++)
            {
                if(i == ini.Elementos.Count - 1)
                {
                    iniText = iniText + ini.Elementos[i];
                }
                else
                {
                    iniText = iniText + ini.Elementos[i] + ", ";
                }
            }
        }

        String auxText = "Torre AUX: ";

        if (ini.isEmpty())
        {
            for (int i = 0; i < ini.Elementos.Count; i++)
            {
                if (i == ini.Elementos.Count - 1)
                {
                    iniText = iniText + ini.Elementos[i];
                }
                else
                {
                    iniText = iniText + ini.Elementos[i] + ", ";
                }
            }
        }

        String finText = "Torre FIN: ";

        if (ini.isEmpty())
        {
            for (int i = 0; i < ini.Elementos.Count; i++)
            {
                if (i == ini.Elementos.Count - 1)
                {
                    iniText = iniText + ini.Elementos[i];
                }
                else
                {
                    iniText = iniText + ini.Elementos[i] + ", ";
                }
            }
        }

    }
}
