using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace Ejercicio_II
{
    class Program
    {
        static void Main()
        {
            Stack<int> pila = new Stack<int>();
            Queue<string> cola = new Queue<string>();

            // Agregar elementos de prueba
            pila.Push(10);
            pila.Push(20);
            pila.Push(30);

            cola.Enqueue("A");
            cola.Enqueue("B");
            cola.Enqueue("C");

            
            if (pila.Count > 0)
            {
                int valorPila = pila.Pop();
                Console.WriteLine("Valor sacado de la pila: " + valorPila);
            }
            else
            {
                Console.WriteLine("La pila está vacía, no se puede extraer un elemento.");
            }

            
            if (cola.Count > 0)
            {
                string primerElemento = cola.Dequeue();
                Console.WriteLine("Elemento eliminado de la cola: " + primerElemento);
            }
            else
            {
                Console.WriteLine("La cola está vacía, no se puede extraer un elemento.");
            }
        }
    }
}
