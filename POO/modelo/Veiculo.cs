using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace POO.modelo
{

public abstract class Veiculos
{
 // Atributos
private string marca;
private string modelo;
private int ano;
protected double velocidadeatual;

         // Construtor
public Veiculos(string marca, string modelo, int ano, double velocidadeatual)
{
this.marca = marca;
this.modelo = modelo;
this.ano = ano;
this.velocidadeatual= velocidadeatual;
}
public string GetMarca()
{
    return marca;
}
public void SetMarca(string marca)
{
    this.marca = marca;
}
public string GetModelo()
{
    return modelo;
}
public void SetModelo(string modelo)
{
    this.marca = modelo;
}
public int Getano()
{
    return ano;
}
public void Setano(int ano)
{
    this.ano = ano;
}
public double Getvelocidadeatual()
{
    return velocidadeatual;
}
public void Setvelocidadeatual(string marca)
{
    this.marca = marca;
}

 // Métodos Andar e Falar
public void acelerar()
{
Console.WriteLine($"{marca} {modelo} {ano} {velocidadeatual} está acelerando.");

}
public void Freiar(){
Console.WriteLine($"{marca} {modelo} {ano} {velocidadeatual} está freiando");
}
public abstract void ObterDadosDoVeiculo();
}
}