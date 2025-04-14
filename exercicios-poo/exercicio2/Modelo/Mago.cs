using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio2.Modelo
{
public class Mago : IAtacante
    {
        public void Atacar(Inimigo inimigo)
        {
            Console.WriteLine("Mago lança uma bola de fogo!");
            inimigo.ReceberDano(20);
        }
    }   
}