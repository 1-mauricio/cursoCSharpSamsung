using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto
    {
        private string Marca;
        private string Modelo;
        private uint Cilindrada;

        public Moto(string marca, string modelo, uint cilindrada)
        {
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public Moto() { }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        // Setter para o atributo "Modelo"
        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        // Getter para o atributo "Cilindrada"
        public uint GetCilindrada()
        {
            return Cilindrada;
        }

        // Setter para o atributo "Cilindrada"
        public void SetCilindrada(uint cilindrada)
        {
            //if (cilindrada > 0)
            //{
            //    Cilindrada = cilindrada;
            //}

            // Cilindrada = Math.Abs(cilindrada);

            Cilindrada = cilindrada;
        }
    }
    class GetSet
    {
        public static void Executar()
        {
            var moto1 = new Moto("Honda", "CBR500R", 500);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            Moto moto2 = new Moto();
            moto2.SetMarca("Yamaha");
            moto2.SetModelo("YZF-R6");
            moto2.SetCilindrada(150);

            Console.WriteLine(moto2.GetMarca());
            Console.WriteLine(moto2.GetModelo());
            Console.WriteLine(moto2.GetCilindrada());
        }
    }
}
