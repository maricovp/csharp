using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio9.Modelo
{
public class Personagem
    {
        public string Nome;
        public int Nivel;
        public int Experiencia;
        public int ExperienciaParaProximoNivel;

        public int Forca;
        public int Agilidade;
        public int VidaMaxima;
        public int VidaAtual;

        public Personagem(string nome)
        {
            Nome = nome;
            Nivel = 1;
            Experiencia = 0;
            ExperienciaParaProximoNivel = 100;

            Forca = 10;
            Agilidade = 5;
            VidaMaxima = 50;
            VidaAtual = VidaMaxima;
        }

        public void GanharExperiencia(int xp)
        {
            Console.WriteLine($"{Nome} ganhou {xp} de XP.");
            Experiencia += xp;

            while (Experiencia >= ExperienciaParaProximoNivel)
            {
                SubirNivel();
            }
        }

        private void SubirNivel()
        {
            Experiencia -= ExperienciaParaProximoNivel;
            Nivel++;
            ExperienciaParaProximoNivel += 50;

            // Aumenta atributos
            Forca += 5;
            Agilidade += 2;
            VidaMaxima += 20;
            VidaAtual = VidaMaxima;

            Console.WriteLine($"\n{Nome} subiu para o nível {Nivel}!");
            Console.WriteLine("Atributos aumentados:");
            Console.WriteLine($"Força: {Forca}, Agilidade: {Agilidade}, Vida: {VidaMaxima}\n");
        }

        public void MostrarStatus()
        {
            Console.WriteLine($"\n--- Status de {Nome} ---");
            Console.WriteLine($"Nível: {Nivel}");
            Console.WriteLine($"XP: {Experiencia}/{ExperienciaParaProximoNivel}");
            Console.WriteLine($"Força: {Forca}");
            Console.WriteLine($"Agilidade: {Agilidade}");
            Console.WriteLine($"Vida: {VidaAtual}/{VidaMaxima}");
            Console.WriteLine("----------------------------\n");
        }
    }
}