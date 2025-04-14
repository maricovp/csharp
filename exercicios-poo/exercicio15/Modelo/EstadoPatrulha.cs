using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio15.Modelo
{
public class EstadoPatrulha : IEstado
    {
        public void Executar(Inimigo inimigo)
        {
            Console.WriteLine($"{inimigo.Nome} está patrulhando...");

            if (inimigo.JogadorVisivel)
            {
                inimigo.TrocarEstado(new EstadoPerseguindo());
            }
        }
    }
}