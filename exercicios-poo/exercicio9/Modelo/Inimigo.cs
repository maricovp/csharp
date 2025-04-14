using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio9.Modelo
{
public class Inimigo
    {
        public string Nome;
        public int ExperienciaRecompensa;

        public Inimigo(string nome, int xp)
        {
            Nome = nome;
            ExperienciaRecompensa = xp;
        }

        public void DerrotadoPor(Personagem p)
        {
            Console.WriteLine($"\n{p.Nome} derrotou {Nome}!");
            p.GanharExperiencia(ExperienciaRecompensa);
        }
    }
}