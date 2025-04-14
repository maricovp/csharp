using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio1.Modelo
{
    public abstract class NPC
    {
        protected string nome;

        public NPC(string nome)
        {
        this.nome = nome;
        }

        public abstract void Mover();
        public abstract void Interagir();
    }
}