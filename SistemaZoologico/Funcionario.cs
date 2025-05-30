using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaZoologico
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cargo { get; set; }

        protected Funcionario(string nome, int idade, string cargo)
        {
            Nome = nome;
            Idade = idade;
            Cargo = cargo;
        }

        public abstract void Trabalhar();
    }
}
