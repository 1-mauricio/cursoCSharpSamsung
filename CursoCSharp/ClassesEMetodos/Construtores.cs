using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Construtores
    {
        class Carro
        {
            public string Modelo;
            public string Fabricante;
            public int Ano;

            public Carro(string modelo, string fabricante, int ano)
            {
                Modelo = modelo;
                Fabricante = fabricante;
                this.Ano = ano;
            }

            public Carro() {} // construtor padrao
        }
        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "321";
            carro1.Ano = 2017;
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            var carro2 = new Carro("Ka", "232", 2019);
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            var carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "uno",
                Ano = 2019
            };

            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");

        }
    }
}
