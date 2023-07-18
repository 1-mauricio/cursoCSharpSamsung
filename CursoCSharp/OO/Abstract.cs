using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    class Abstract
    {
        // classes abstratas nao podem ser instanciadas (classes pai que nao devem ser instanciadas)
        public abstract class Celular
        {
            public abstract string Assistente();

            public string Tocar()
            {
                return "Trim trim";
            }
        }

        public class Samsung : Celular
        {
            public override string Assistente ()
            {
                return "Olá, meu nome é bixby";
            }
        }

        public class Apple : Celular
        {
            public override string Assistente()
            {
                return "Olá, meu nome é siri";
            }
        }

        public static void Executar()
        {
            var celulares = new List<Celular>
            {
                new Apple(),
                new Samsung()
            };

            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
