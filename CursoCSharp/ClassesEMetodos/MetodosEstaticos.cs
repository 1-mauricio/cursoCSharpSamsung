using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class MetodosEstaticos
    {
        public class CalculadoraEstatica
        {
            // Metodo de Instancia

            public int Somar(int a, int b)
            {
                return a + b;
            }

            // Metodo de classe ou estatico
            public static int Multiplicar(int a, int b)
            {
                return a * b;
            }
            
        }
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(5, 5);
            Console.WriteLine(resultado);

            var calc = new CalculadoraEstatica();
            //Console.WriteLine(calc.Multiplicar(5,5)); // erro
        }
    }
}
