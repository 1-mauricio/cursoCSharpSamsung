using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.Write("Avalie meu atendimento com nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Pessimo");
                    break;
                case 1:
                    Console.WriteLine("Ruim");
                    break;
                case 2:
                    Console.WriteLine("Regular");
                    break;
                case 3:
                    Console.WriteLine("Bom");
                    break;
                case 4:
                    Console.WriteLine("Otimo");
                    break;
                case 5:
                    Console.WriteLine("Excelente");
                    break;
                default:
                    Console.WriteLine("Nota invalida");
                    break;
            }
        }
    }
}
