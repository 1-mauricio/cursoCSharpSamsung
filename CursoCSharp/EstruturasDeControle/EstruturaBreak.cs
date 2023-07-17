using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O número que queremos é {0}", numero);

            for (int i = 1; i <= 50; i++)
            {
                if (numero == i)
                    break;
            }
        }
    }
}
