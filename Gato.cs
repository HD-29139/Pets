using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pets
{
    public class Gato : Pet
    {
        public Gato(string nome, string raca, bool vacinado, int idade, Pessoa dono) : base(nome, raca, vacinado, idade, dono)
        {
        }


        public override void Exibir()
        {
            Console.WriteLine("Gato:");
            base.Exibir();
            Console.WriteLine();
        }
    }
}