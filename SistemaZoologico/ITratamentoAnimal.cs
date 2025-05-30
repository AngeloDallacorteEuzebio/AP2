using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaZoologico
{
    public interface ITratamentoAnimal
    {
        void RealizarTratamento(Animal animal);
}

    public interface ICuidador
{
    void CuidarHabitat(Animal animal);
}
}
