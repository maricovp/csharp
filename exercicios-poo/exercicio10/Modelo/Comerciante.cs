using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio10.Modelo
{
public class Comerciante : IObservador
    {
        public string Nome;

        public Comerciante(string nome)
        {
            Nome = nome;
        }

        public void Atualizar(string item, double novoPreco)
        {
            Console.WriteLine($"{Nome} foi notificado: {item} agora custa {novoPreco} gold.");
        }
    }
}