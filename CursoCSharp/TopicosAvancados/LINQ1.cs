using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }

    class LINQ1
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno { Nome = "Alice", Idade = 18, Nota = 9.5 },
                new Aluno { Nome = "Bob", Idade = 19, Nota = 8.7 },
                new Aluno { Nome = "Charlie", Idade = 20, Nota = 7.2 },
                new Aluno { Nome = "Diana", Idade = 21, Nota = 6.5 },
                new Aluno { Nome = "Eve", Idade = 22, Nota = 8.9 },
                new Aluno { Nome = "Frank", Idade = 20, Nota = 6.8 },
                new Aluno { Nome = "Grace", Idade = 19, Nota = 9.1 }
            };

            Console.WriteLine("== Aprovados ==");
            var aprovados = alunos.Where(a => a.Nota >= 7).OrderByDescending(a => a.Nota);

            foreach (var aluno in aprovados)
            {
                Console.WriteLine($"{aluno.Nome} {aluno.Nota}");
            }

            Console.WriteLine("\n== Chamada ==");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            
            foreach (var aluno in aprovados)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n== Aprovados (por idade) ==");
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;

            foreach(var aluno in alunosAprovados)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
