using System;
using System.Collections.Generic;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("fulano");
            fila.Enqueue("cicrano");
            fila.Enqueue("beltrano");

            Console.WriteLine(fila.Peek()); // nao remove
            Console.WriteLine(fila.Count); //3

            Console.WriteLine(fila.Dequeue()); //remove
            Console.WriteLine(fila.Count); //2

            foreach (var elemento in fila)
            {
                Console.WriteLine(elemento);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("item");
            salada.Enqueue(true);

            Console.WriteLine(salada.Contains("item")); //true

        }
    }
}
