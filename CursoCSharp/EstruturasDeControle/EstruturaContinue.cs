using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaContinue
    {
        public static void Executar()
        {
            int intervalo = 50;
            Console.WriteLine($"Numeros pares entre 1 e {intervalo}");

            for (int i = 1; i <= intervalo; i++)
            {
                if (i % 2 == i)
                    continue;

                Console.WriteLine(i);
            }
        }
    }
}
