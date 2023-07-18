﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero += 1000;
        }

        public static void AlterarOut(out int numero1, out int numero2)
        {
            numero1 = 0;
            numero2 = 0;
            numero1 += 15;
            numero1 += 30;
        }

        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a); //1003

            AlterarOut(out int b, out int c);
            Console.WriteLine($"{b} {c}"); // 15 30
        }
    }
}
