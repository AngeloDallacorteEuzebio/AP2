using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaZoologico
{
    public class Veterinario : Funcionario, ITratamentoAnimal
    {
        public Veterinario(string nome, int idade)
            : base(nome, idade, "Veterinário") { }

        public override void Trabalhar() => Console.WriteLine($"Veterinário {Nome} está trabalhando.");

        public void RealizarTratamento(Animal animal) => Console.WriteLine($"Veterinário {Nome} realizou tratamento no animal {animal.Nome}.");

        public void RealizarTratamento(string nomeAnimal)
        {
            var animal = Program.animais.Find(a => a.Nome == nomeAnimal);
            if (animal != null)
                RealizarTratamento(animal);
            else
                Console.WriteLine($"Animal com nome {nomeAnimal} não encontrado.");
        }

        public void ConsultarAnimal(Animal animal) => Console.WriteLine($"Veterinário {Nome} consultou o animal {animal.Nome} com sucesso.");

        public void ConsultarAnimal(string nomeAnimal)
        {
            var animal = Program.animais.Find(a => a.Nome == nomeAnimal);
            if (animal != null)
                ConsultarAnimal(animal);
            else
                Console.WriteLine($"Animal com nome {nomeAnimal} não encontrado.");
        }
    }
}
