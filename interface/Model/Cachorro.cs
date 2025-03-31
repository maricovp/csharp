using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Interface.Interface;
using Interface.Model;
using Interface.Model.Interface;


namespace Interface.Modelo
{
public class  Cachorro : IAnimal
{
public void EmitirSom(){
Console.WriteLine("Latindo...");
}
public void Mover(){
Console.WriteLine("Caminhando...");
}
}
}