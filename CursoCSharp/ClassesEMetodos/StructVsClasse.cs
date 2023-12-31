﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public struct SPonto
    {
        public int X;
        public int Y;
    }

    public class CPonto
    {
        public int X;
        public int Y;
    }

    class StructVsClasse
    {
        public static void Executar()
        {
            SPonto ponto1 = new SPonto { X = 1, Y = 3};
            SPonto copiaPonto1 = ponto1; // Atribuicao por valor
            ponto1.X = 3;

            Console.WriteLine("ponto 1 X: {0}", ponto1.X); // 3
            Console.WriteLine("copia ponto 1 X: {0}", copiaPonto1.X); // 1

            CPonto ponto2 = new CPonto { X = 1, Y = 3 };
            CPonto copiaPonto2 = ponto2; // Atribuicao por referencia
            ponto2.X = 4;

            Console.WriteLine("ponto 2 X: {0}", ponto2.X); // 4
            Console.WriteLine("copia ponto 2 X: {0}", copiaPonto2.X); // 4
        }
    }
}
