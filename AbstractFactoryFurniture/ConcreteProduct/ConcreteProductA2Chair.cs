using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryFurniture.AbstractProduct;

namespace AbstractFactoryFurniture.ConcreteProduct
{
    class ConcreteProductA2Chair : IAbstractChairProductA
    {
        public int HasLegs()
        {
            return 4;
        }

        public string SitOn()
        {
            return "can sit only one person";
        }
    }
}
