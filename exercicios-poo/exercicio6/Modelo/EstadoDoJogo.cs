using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio6.Modelo
{
public class EstadoDoJogo
    {
        private static EstadoDoJogo instancia;

        public int NivelAtual;
        public int Pontuacao;
        public int Vidas;

        // Construtor privado = ninguém pode instanciar de fora
        private EstadoDoJogo()
        {
            NivelAtual = 1;
            Pontuacao = 0;
            Vidas = 3;
        }

        // Propriedade de acesso à instância única
        public static EstadoDoJogo Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new EstadoDoJogo();
                return instancia;
            }
        }

        public void MostrarEstado()
        {
            Console.WriteLine($"Nível: {NivelAtual} | Pontuação: {Pontuacao} | Vidas: {Vidas}");
        }

        public void AdicionarPontos(int pontos)
        {
            Pontuacao += pontos;
            Console.WriteLine($"+{pontos} pontos! Pontuação total: {Pontuacao}");
        }

        public void PerderVida()
        {
            Vidas--;
            Console.WriteLine($"Você perdeu uma vida! Vidas restantes: {Vidas}");

            if (Vidas <= 0)
            {
                Console.WriteLine("Game Over!");
            }
        }

        public void AvancarNivel()
        {
            NivelAtual++;
            Console.WriteLine($"Você avançou para o nível {NivelAtual}!");
        }
    }
}