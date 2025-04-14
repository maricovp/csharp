using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio10.Modelo
{
    public interface ISujeito
    {
         void AdicionarObservador(IObservador observador);
        void RemoverObservador(IObservador observador);
        void NotificarObservadores(string item, double novoPreco);
    }
}