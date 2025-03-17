using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO.modelo;

namespace POO.model
{
    public class Moto : Veiculos
    {
        private bool partidaEletrica;
        private bool protetorDeCarenagem;

        public Moto(string marca, string modelo, int ano, double velocidadeAtual, bool partidaEletrica, bool protetorDeCarenagem) : base(marca, modelo, ano, velocidadeAtual)
        {
            this.partidaEletrica = partidaEletrica;
            this.protetorDeCarenagem = protetorDeCarenagem;
        }
        public bool GetPartidaEletrica()
        {
            return partidaEletrica;
        }
        public void SetPartidaEletrica(bool partidaEletrica)
        {
            this.partidaEletrica = partidaEletrica;
        }

        public bool GetProtetorDeCarenagem()
        {
            return protetorDeCarenagem;
        }
        public void SetProtetorDeCarenagem(bool protetorDeCarenagem)
        {
            this.protetorDeCarenagem = protetorDeCarenagem;
        }

        public void Empinar()
        {
            Console.WriteLine("Empinando a moto!");
        }
        public virtual void Acelerar(double incremento)
        {
            velocidadeatual += incremento;
            Console.WriteLine($"A moto conseguiu e atingiu a velocidade de {velocidadeatual} km/h ")
        }
    }
}