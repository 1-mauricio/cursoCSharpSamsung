using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "notebook";
            string marca = "Dell";
            double preco = 5800.00;
            
            Console.WriteLine("O {0} da marca {1} custa {2}", 
                nome, marca, preco);
            Console.WriteLine($"A marca {marca}");
            Console.WriteLine($"1 + 1 = {1+1}");
        }
    }
}
