using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio3.Modelo
{
    public class ArmaduraFactory : ItemFactory
    {
         public override Item CriarItem()
        {
            return new Armadura();
        }
    }
}