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
            if (a.isEmpty() && b.isEmpty())
            {
                Console.WriteLine("Camavinga"+ a.top().Tam+ b.top().Tam);
                if (a.top().Tam < b.top().Tam)
                {
                    b.push(a.top());
                    a.pop();
                }
                else if (a.top().Tam > b.top().Tam)
                {
                    a.push(b.top());
                    b.pop();
                }
            }
            else if (a.isEmpty() && !b.isEmpty())
            {
                b.push(a.top());
                a.pop();
            }
            else if (!a.isEmpty() && b.isEmpty())
            {
                a.push(b.top());
                b.pop();
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int movimientos = 0;
            Console.WriteLine("Situación inicial");
            estado(ini, fin, aux);

            if (n%2 != 0)
            {
                while (fin.Elementos.Count != n)
                {
                    if (fin.Elementos.Count != n)
                    {
                        mover_disco(ini, fin);
                        movimientos++;
                        Console.WriteLine("Situación tras el movimiento " + movimientos);
                        estado(ini, fin, aux);
                    }
                    if (fin.Elementos.Count != n)
                    {
                        mover_disco(ini, aux);
                        movimientos++;
                        Console.WriteLine("Situación tras el movimiento " + movimientos);
                        estado(ini, fin, aux);
                    }
                    if (fin.Elementos.Count != n)
                    {
                        mover_disco(aux, fin);
                        movimientos++;
                        Console.WriteLine("Situación tras el movimiento " + movimientos);
                        estado(ini, fin, aux);
                    }
                    Console.WriteLine("Impar." + movimientos);
                }
            }
            else
            {
                while (fin.Elementos.Count != n)
                {
                    if (fin.Elementos.Count != n)
                    {
                        mover_disco(ini, aux);
                        movimientos++;
                        Console.WriteLine("Situación tras el movimiento " + movimientos);
                        estado(ini, fin, aux);
                    }
                    if (fin.Elementos.Count != n)
                    {
                        mover_disco(ini, fin);
                        movimientos++;
                        Console.WriteLine("Situación tras el movimiento " + movimientos);
                        estado(ini, fin, aux);
                    }
                    if (fin.Elementos.Count != n)
                    {
                        mover_disco(aux, fin);
                        movimientos++;
                        Console.WriteLine("Situación tras el movimiento " + movimientos);
                        estado(ini, fin, aux);
                    }
                    Console.WriteLine("Par." + movimientos);
                }
            }
            return movimientos;
        }

        public int recursivo(int n, Pila ini, Pila fin, Pila aux)
        {
            int m = 0;
            Console.WriteLine("Situación inicial");
            estado(ini, fin, aux);

            if (n == 1)
            {
                mover_disco(ini, fin);
                m++;
                Console.WriteLine("Situación tras el movimiento " + m);
                estado(ini, fin, aux);
            }
            else
            {
                recursivo(n - 1, ini, aux, fin);
                mover_disco(ini, fin);
                m++;
                Console.WriteLine("Situación tras el movimiento " + m);
                estado(ini, fin, aux);
                recursivo(n - 1, aux, fin, ini);
            }

            return m;
        }

        public void estado(Pila ini, Pila fin, Pila aux)
        {
            String iniText = "Torre INI: ";

            if (ini.isEmpty())
            {
                for (int i = 0; i < ini.Elementos.Count; i++)
                {
                    if (i == ini.Elementos.Count - 1)
                    {
                        iniText = iniText + ini.Elementos[i].Tam;
                    }
                    else
                    {
                        iniText = iniText + ini.Elementos[i].Tam + ", ";
                    }
                }
            }

            String auxText = "Torre AUX: ";

            if (aux.isEmpty())
            {
                for (int j = 0; j < aux.Elementos.Count; j++)
                {
                    if (j == aux.Elementos.Count - 1)
                    {
                        auxText = auxText + aux.Elementos[j].Tam;
                    }
                    else
                    {
                        auxText = auxText + aux.Elementos[j].Tam + ", ";
                    }
                }
            }

            String finText = "Torre FIN: ";

            if (fin.isEmpty())
            {
                for (int k = 0; k < fin.Elementos.Count; k++)
                {
                    if (k == fin.Elementos.Count - 1)
                    {
                        finText = finText + fin.Elementos[k].Tam;
                    }
                    else
                    {
                        finText = finText + fin.Elementos[k].Tam + ", ";
                    }
                }
            }

            Console.WriteLine(iniText);
            Console.WriteLine(auxText);
            Console.WriteLine(finText);
        }
    }
}
