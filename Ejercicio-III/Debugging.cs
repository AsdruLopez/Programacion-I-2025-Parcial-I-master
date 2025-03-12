using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Diagnostics;

namespace Ejercicio_III
{
    class Program
    {
        static void Main()
        {
            int[] numeros = { 10, 20, 30, 40, 50 };
            int resultado = 0;
            int divisor = 2; 

            
            Console.WriteLine("Último número en la lista: " + numeros[numeros.Length - 1]);

            
            for (int i = 0; i < numeros.Length; i++)
            {
                if (divisor != 0) 
                {
                    resultado += numeros[i] / divisor;
                }
                else
                {
                    Console.WriteLine($"Error: División por cero en la posición {i}");
                }
            }

            Debug.WriteLine("Resultado después del bucle: " + resultado);
            Console.WriteLine("Proceso finalizado.");
        }
    }
}

