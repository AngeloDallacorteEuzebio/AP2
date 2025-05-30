using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaZoologico
{
    public class Mamifero : Animal
    {
        public Mamifero(string nome, int idade, double peso, string especie)
            : base(nome, idade, peso, especie)
        {
        }

        public void Amamentar() => Console.WriteLine($"{Nome} está amamentando.");
        public override void EmitirSom() => Console.WriteLine($"{Nome} está emitindo som.");
        public override void Movimentar() => Console.WriteLine($"{Nome} está se movendo.");
    }
}