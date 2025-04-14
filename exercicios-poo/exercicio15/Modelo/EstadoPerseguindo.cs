using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio15.Modelo
{
public class EstadoPerseguindo : IEstado
    {
        public void Executar(Inimigo inimigo)
        {
            Console.WriteLine($"{inimigo.Nome} está perseguindo o jogador!");

            if (inimigo.DistanciaParaJogador <= 1)
            {
                inimigo.TrocarEstado(new EstadoAtacando());
            }
            else if (!inimigo.JogadorVisivel)
            {
                inimigo.TrocarEstado(new EstadoPatrulha());
            }
        }
    }
}