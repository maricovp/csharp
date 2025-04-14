using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio8.Modelo
{
public class ArmaduraDeCouro : IArmadura
    {
        public string Nome => "Armadura de Couro";
        public int DefesaBonus => 5;
    }
}