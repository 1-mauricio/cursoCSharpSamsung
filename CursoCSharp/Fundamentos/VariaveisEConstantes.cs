using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Area é " + area);

            // Tipos internos

            bool estaChovendo = true;
            
            byte idade = 45;
            sbyte saldoDeGols = sbyte.MinValue;
            short salario = short.MaxValue;
            int menorValorInt = int.MinValue; // mais usado dos int
            uint populacaoBrasileira = 207_600_000; // int positivo 
            long menorValorLong = long.MinValue;
            ulong populacaoMundial = 8_000_000_000;
            
            float precoComputador = 1299.99f;
            double valorDeMercado = 1000000000000.00; // mais usado dos reais
            decimal distanciaEntreEstrelas = decimal.MaxValue;

            char letra = 'a';
            string texto = "dsfal";
        }
    }
}
