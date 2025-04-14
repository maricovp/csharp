using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio5.Modelo
{
public abstract class Habilidade
    {
        public string Nome;
        public int CustoDeMana;
        public int Dano;

        public Habilidade(string nome, int custoDeMana, int dano)
        {
            Nome = nome;
            CustoDeMana = custoDeMana;
            Dano = dano;
        }

        public abstract void Executar();
    }
}