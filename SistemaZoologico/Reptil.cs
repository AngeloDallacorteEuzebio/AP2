using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaZoologico
{
    public class Reptil : Animal
    {
        public Reptil(string nome, int idade, double peso, string especie)
            : base(nome, idade, peso, especie) { }

        public void Rastejar() => Console.WriteLine($"{Nome} está rastejando.");

        public override void EmitirSom() => Console.WriteLine($"{Nome} está emitindo som.");
        public override void Movimentar() => Console.WriteLine($"{Nome} está se movimentando.");
    }
}
