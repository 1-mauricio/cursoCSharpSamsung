using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Dependente 
    {
        public string Nome;
        public int Idade;
    }

    class ValorVsReferencia
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}"); // 3 3

            numero++;
            Console.WriteLine($"{numero} {copiaNumero}"); // 4 3

            Dependente dep = new Dependente
            {
                Nome = "Beto",
                Idade = 20
            };

            Dependente copiaDep = dep; // copia por referencia

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}"); // Beto Beto
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}"); // 20 20

            dep.Nome = "Ricardo";
            dep.Idade = 21;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}"); // Ricardo Ricardo
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}"); // 21 21
        }
    }
}
