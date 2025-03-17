using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO.modelo;

namespace POO.model
{
    public class Carro : Veiculos
    {
        public bool automatico;
        public int numeroDePortas;

        public Carro(string marca, string modelo, int ano, double velocidadeAtual, bool automatico, int numeroDePortas) : base (marca, modelo, ano, velocidadeAtual)
        {
            this.automatico = automatico;
            this.numeroDePortas = numeroDePortas;
        }
        public bool GetAutomatico()
        {
            return automatico;
        }
        public void SetAutomatico(bool automatico)
        {
            this.automatico = automatico;
        }
        public int GetNumeroDePortas()
        {
            return numeroDePortas;
        }
        public void SetNumeroDePortas(int numeroDePortas)
        {
            this.numeroDePortas = numeroDePortas;
        }
        public void AbrirPortas()
        {
            Console.WriteLine("As portas do carro estão abertas.");
        }
    }
}