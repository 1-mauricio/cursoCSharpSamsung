using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;

            Console.WriteLine($"Nota inválida? {nota > 10.0}");
            Console.WriteLine($"Nota inválida? {nota < 0.0}");
            Console.WriteLine($"Nota perfeita? {nota == 10.0}");
            Console.WriteLine($"Tem como melhorar? {nota != 10.0}");
            Console.WriteLine($"Passou por media? {nota >= notaDeCorte}");
            Console.WriteLine($"Recuperacao? {nota < notaDeCorte}");
            Console.WriteLine($"Reprovado? {nota <= 3.0}");
        }
    }
}
