using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio3.Modelo
{
public abstract class Item
    {
        public string Nome;

        public Item(string nome)
        {
            Nome = nome;
        }

        public abstract void Usar();
    }
}