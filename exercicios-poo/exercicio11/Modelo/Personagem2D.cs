using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio11.Modelo
{
public class Personagem2D
    {
        public float PosicaoX { get; private set; } = 0;
        public float PosicaoY { get; private set; } = 0;

        public float VelocidadeY { get; private set; } = 0;
        public bool EstaNoChao => PosicaoY <= 0;

        private const float GRAVIDADE = -9.8f;
        private const float FORCA_PULO = 5.0f;
        private const float DELTA_TEMPO = 0.1f;
        private const float VELOCIDADE_ANDAR = 2.0f;

        public void AndarEsquerda()
            {
                PosicaoX -= VELOCIDADE_ANDAR;
                Console.WriteLine("Andou para a esquerda");
            }

            public void AndarDireita()
            {
                PosicaoX += VELOCIDADE_ANDAR;
                Console.WriteLine("Andou para a direita");
            }

        public void Pular()
            {
                if (EstaNoChao)
                {
                    VelocidadeY = FORCA_PULO;
                    Console.WriteLine("Pulou!");
                }
                else
                {
                    Console.WriteLine("Não pode pular no ar!");
                }
            }

        public void AtualizarFisica()
            {
                if (!EstaNoChao || VelocidadeY > 0)
                {
                    VelocidadeY += GRAVIDADE * DELTA_TEMPO;
                    PosicaoY += VelocidadeY * DELTA_TEMPO;

                    if (PosicaoY < 0)
                    {
                        PosicaoY = 0;
                        VelocidadeY = 0;
                    }
                }
            }

        public void MostrarStatus()
        {
            Console.WriteLine($"Posição: ({PosicaoX}, {PosicaoY:F2}) | Velocidade Y: {VelocidadeY:F2}");
        }
    }    
}