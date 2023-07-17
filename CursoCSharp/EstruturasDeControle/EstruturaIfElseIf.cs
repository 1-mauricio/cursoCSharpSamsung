using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
   

            Console.Write("Digite a nota do aluno: ");
            Double.TryParse(Console.ReadLine(), out double nota);

            if (nota >= 9.0)
            {
                Console.WriteLine("Quadro de honra");
            } 
            else if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado");
            }
            else if (nota >= 5.0)
            {
                Console.WriteLine("Recuperacao");
            }
            else
            {
                Console.WriteLine("Foi de base");
            }
        }
    }
}
