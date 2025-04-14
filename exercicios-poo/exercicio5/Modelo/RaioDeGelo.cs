using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio5.Modelo
{
public class RaioDeGelo : Habilidade
    {
        public RaioDeGelo() : base("Raio de Gelo", 8, 18) {}

        public override void Executar()
        {
            Console.WriteLine($"Você dispara um {Nome} causando {Dano} de dano e congelando o inimigo!");
        }
    }
}