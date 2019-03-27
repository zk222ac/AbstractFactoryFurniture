using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryFurniture.AbstractProduct;

namespace AbstractFactoryFurniture.ConcreteProduct
{
    class ConcreteProductB2Sofa : IAbstractSofaProductB
    {
        public int HasLegs()
        {
            return 4;
        }

        public string FamilySofa()
        {
            return "This a family sofa";
        }

        public string FunctionB(IAbstractChairProductA collaborator)
        {
            var result = collaborator.SitOn();
            return $"The result of the B2 collaborating with the {result}";

        }
    }
}
