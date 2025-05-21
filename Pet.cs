using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace pets
{
    public class Pet
    {
        private string Nome;
        private string Raca;
        private bool Vacinado;
        private int Idade;
        private Pessoa Dono;

        public Pet(string nome, string raca, bool vacinado, int idade, Pessoa dono)
        {
            Nome = nome;
            Raca = raca;
            Vacinado = vacinado;
            Idade = idade;
            Dono = dono;
        }

        public virtual void Exibir()
        {
            Console.WriteLine($"Pet: {Nome}");
            Console.WriteLine($"Raça: {Raca}");
            Console.WriteLine($"Vacinado: {(Vacinado ? "Sim" : "Não")}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Dono: {Dono.nome}");
        }
        
    }
}