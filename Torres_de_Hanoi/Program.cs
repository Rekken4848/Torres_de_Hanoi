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
            Console.WriteLine("Bienvenido al chachijuego de Hanoi.");
            Console.WriteLine("¿Cuántos discos chavalote?");
            String numero = Console.ReadLine();
            int movimimetos = Convert.ToInt32(numero);
            Pila ini = new Pila();
            Pila aux = new Pila();
            Pila fin = new Pila();
            for(int i=movimimetos; i>0; i--)
            {
                ini.push(new Disco(i));
            }
            Console.WriteLine("¿Eres más de iterativo I o de recursivo R?");
            String modo = Console.ReadLine();
            Hanoi prueba = new Hanoi();
            int resultado = 0;
            if (modo.ToUpper() == "I")
            {
                resultado = prueba.iterativo(movimimetos, ini, fin, aux);
            }
            else if (modo.ToUpper() == "R")
            {
                resultado = prueba.recursivo(movimimetos, ini, fin, aux);
            }
            
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit." + resultado);
            Console.ReadKey();
        }
    }
}
