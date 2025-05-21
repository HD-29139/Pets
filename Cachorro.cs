using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pets
{
    public class Cachorro : Pet
    {
        private PorteEnum Porte;
        public Cachorro(string nome, string raca, bool vacinado, int idade, Pessoa dono, PorteEnum porte) : base(nome, raca, vacinado, idade, dono)
        {
            Porte = porte;
        }

        public override void Exibir()
        {
            Console.WriteLine("Cachorro:");
            Console.WriteLine($"Porte: {Porte}");
            base.Exibir();
            Console.WriteLine();

        }
    }
}