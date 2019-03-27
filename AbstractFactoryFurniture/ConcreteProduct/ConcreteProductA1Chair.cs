using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryFurniture.AbstractProduct;

namespace AbstractFactoryFurniture.ConcreteProduct
{
    // Concrete Products are created by corresponding Concrete Factories.
    class ConcreteProductA1Chair : IAbstractChairProductA
    {
        public int HasLegs()
        {
            return 4;
        }

        public string SitOn()
        {
            return "only single person can sit on the chair";
        }
    }
}
