using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio2.Modelo
{
public class Arqueiro : IAtacante
    {
        public void Atacar(Inimigo inimigo)
        {
            Console.WriteLine("Arqueiro dispara uma flecha!");
            inimigo.ReceberDano(10);
        }
    }
}