using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio8.Modelo
{
public class ArmaduraDeFerro : IArmadura
    {
        public string Nome => "Armadura de Ferro";
        public int DefesaBonus => 10;
    }
}