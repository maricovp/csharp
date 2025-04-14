using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio2.Modelo
{
public class Guerreiro : IAtacante
    {
        public void Atacar(Inimigo inimigo)
        {
            Console.WriteLine("Guerreiro ataca com espada!");
            inimigo.ReceberDano(15);
        }
    }
}