using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio7.Modelo
{
public abstract class Missao
    {
        public string Titulo;
        public string Descricao;
        public bool Concluida;

        public Missao(string titulo, string descricao)
        {
            Titulo = titulo;
            Descricao = descricao;
            Concluida = false;
        }

        public abstract void Executar();

        public void MarcarComoConcluida()
        {
            Concluida = true;
            Console.WriteLine($"Missão \"{Titulo}\" concluída!");
        }
    }
}