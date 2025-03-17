using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
public void Acelerar(double incremento)
{
            velocidadeatual += incremento;
            Console.WriteLine($"Acelerando... Velocidade atual: {velocidadeatual}km/h");
}

        public void AbrirPortas()
        {
            Console.WriteLine("As portas do carro estão abertas.");
        }
        public void Freiar(double incremento, bool puxarFreioDeMao)
{
    velocidadeatual -= decremento;
    if(puxarFreioDeMao)
    {
        Console.WriteLine($" O carro freou até a velocidade de {velocidadeatual} Km/H para não bater");
    }
    else{
        Console.WriteLine($"O carro freou lentamente até {velocidadeatual} km/h");
    }
}
public void Frear( double decremento, bool puxarFreioDeMao, bool virouVolante)
{
    velocidadeatual -= decremento;
    if (puxarFreioDeMao && virouVolante)
    {
        Console.WriteLine($"O carro está realizando um cavalinho de pau com intensidade de frenagem{velocidadeatual}!");
    }
    else{
        Console.WriteLine($"O carro freou até {velocidadeatual} km/h");
    }
}
    }
}