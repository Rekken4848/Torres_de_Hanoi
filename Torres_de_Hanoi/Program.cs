using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int movimimetos = 4;
            Pila ini = new Pila();
            Pila aux = new Pila();
            Pila fin = new Pila();
            for(int i=movimimetos; i>0; i--)
            {
                ini.push(new Disco(i));
            }
            Hanoi prueba = new Hanoi();
            //int resultado = prueba.iterativo(movimimetos, ini, fin, aux);
            int resultado = prueba.recursivo(movimimetos, ini, fin, aux);
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit." + resultado);
            Console.ReadKey();
        }
    }
}
