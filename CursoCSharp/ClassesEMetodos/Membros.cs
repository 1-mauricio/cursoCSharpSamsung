﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Mauricio";
            sicrano.Idade = 21;

            //Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos");

            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 25;

            var apresentacaoDoFulano = fulano.Apresentar();
        }
    }
}
