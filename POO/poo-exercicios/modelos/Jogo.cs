using System;

namespace Adivinhacao.Modelo
{
    public class Jogo
    {
        private int numeroSecreto;
        private int tentativas;

        public Jogo()
        {
            Random random = new Random();
            numeroSecreto = random.Next(1, 101); // Número aleatório entre 1 e 100
            tentativas = 0;
        }

        public string Adivinhar(int palpite)
        {
            tentativas++;
            
            if (palpite < numeroSecreto)
            {
                return "O número é maior!";
            }
            else if (palpite > numeroSecreto)
            {
                return "O número é menor!";
            }
            else
            {
                return $"Parabéns! Você acertou em {tentativas} tentativas!";
            }
        }

        public int GetTentativas()
        {
            return tentativas;
        }

        public int GetNumeroSecreto()
        {
            return numeroSecreto;
        }
    }
}