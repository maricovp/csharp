using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
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

        public void Frear(double decremento, bool puxarFreioDeMao)
        {
            velocidadeatual -= decremento;
            if(puxarFreioDeMao)
            {
                Console.WriteLine($"O carro freou até a velocidade de {velocidadeatual} km/h para não bater.");
            }
            else{
                Console.WriteLine($"O carro freou lentamente até {velocidadeatual} km/h.");
            }
        }

        public void Frear(double decremento, bool puxarFreioDeMao, bool virouVolante)
        {
            velocidadeatual -= decremento;
            if(puxarFreioDeMao && virouVolante)
            {
                Console.WriteLine($"O carro está realizando um cavalinho de pau com intensidade de frenagem {velocidadeatual}!");
            }
            else{
                Console.WriteLine($"O carro freou até {velocidadeatual} km/h.");
            }
        }
        public void AbrirPortas()
        {
            Console.WriteLine("As portas do carro estão abertas.");
        }
    
    public override void ObterDadosDoVeiculo()
        {
        Console.WriteLine($"\nDados do Carro: \n"+
        $"Marca: {GetMarca()}\n "+
        $"Ano:{Getano()}\n" +
        $"Automático: {(GetAutomatico()? "Sim": "Não")}"+
        $"Numero de Portas: {GetNumeroDePortas()}"
        );
        }
}
}