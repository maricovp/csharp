using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio10.Modelo
{
    
public interface IObservador
    {
        void Atualizar(string item, double novoPreco);
    }
}