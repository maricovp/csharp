using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_interface.Modelo
{
    public abstract class Heroi
    {
    public string Nome;

    public Heroi(string nome)
    {
        Nome = nome;
    }

    public abstract void Especial();
    }
}