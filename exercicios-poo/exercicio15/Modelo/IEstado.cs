using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio15.Modelo
{
    public interface IEstado
    {
         void Executar(Inimigo inimigo);
    }
}