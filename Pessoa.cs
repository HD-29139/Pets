using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pets
{
    public class Pessoa
    {
        private string Nome;
        private int Idade;
        private string Endereco;
        public List<Pet> Pets;

        public Pessoa(string nome, int idade, string endereco)
        {
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
            Pets = new List<Pet>();
        }

        public string nome
        {
            get { return Nome; }
        }
        public int idade
        {
            get { return Idade; }
        }
        public string endereco
        {
            get { return Endereco; }
        }



    }
}