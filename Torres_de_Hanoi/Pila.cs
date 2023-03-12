using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        /*private int size;
        public int Size
        {
            get { return size; }
            set { size = value; }
        }*/

        /* TODO: Elegir tipo de Top
        public int Top { get; set; }
        public String Top { get; set; }        
        */
        /* TODO: Elegir tipo de Elementos
        public Disco[] Elementos { get; set; }
        public List<Disco> Elementos { get; set; }
        */
        private List<Disco> elementos;
        public List<Disco> Elementos
        {
            get { return elementos; }
            set { elementos = value; }
        }

        /* TODO: Implementar métodos */
        public Pila()
        {
            this.elementos = new List<Disco>();
        }

        /*public Pila(List<Disco> elementos)
        {
            this.Elementos = elementos;
        }*/

        public void push(Disco d)
        {
            elementos.Add(d);
        }

        public void pop()
        {
            elementos.RemoveAt(elementos.Count()-1);
        }                

        public bool isEmpty()
        {
            if(elementos.Count() <= 0)
            {
                return false;
            }
            return true;
        }

        public Disco top()
        {
            if(this.isEmpty())
            {
                return elementos.Last();
            }
            return new Disco(0);
        }
    }
}
