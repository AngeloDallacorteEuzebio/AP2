using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaZoologico
{
    public class Zelador : Funcionario, ICuidador
    {
        public Zelador(string nome, int idade)
            : base(nome, idade, "Zelador") { }

        public override void Trabalhar() => Console.WriteLine($"Zelador {Nome} está trabalhando.");

        public void CuidarHabitat(Animal animal) => Console.WriteLine($"Zelador {Nome} cuidou do habitat do animal {animal.Nome}.");

        public void CuidarHabitat(string nomeAnimal)
        {
            var animal = Program.animais.Find(a => a.Nome == nomeAnimal);
            if (animal != null)
                CuidarHabitat(animal);
            else
                Console.WriteLine($"Animal com nome {nomeAnimal} não encontrado.");
        }

        public void AlimentarAnimal(Animal animal) => Console.WriteLine($"Zelador {Nome} alimentou o animal {animal.Nome} com sucesso.");

        public void AlimentarAnimal(string nomeAnimal)
        {
            var animal = Program.animais.Find(a => a.Nome == nomeAnimal);
            if (animal != null)
                AlimentarAnimal(animal);
            else
                Console.WriteLine($"Animal com nome {nomeAnimal} não encontrado.");
        }
    }
}
