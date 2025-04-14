using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio2.Modelo
{
public class Inimigo
    {
        public string Nome;
        public int Vida;

        public Inimigo(string nome, int vida)
        {
            Nome = nome;
            Vida = vida;
        }

        public void ReceberDano(int dano)
        {
            Vida -= dano;
            Console.WriteLine($"{Nome} recebeu {dano} de dano! Vida restante: {Vida}");
        }

        public bool EstaVivo()
        {
            return Vida > 0;
        }
    }

    
}