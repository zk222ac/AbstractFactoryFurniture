using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryFurniture.AbstractProduct;

namespace AbstractFactoryFurniture.ConcreteProduct
{
    class ConcreteProductB1Sofa : IAbstractSofaProductB
    {
        public int HasLegs()
        {
            return 4;
        }

        public string FamilySofa()
        {
            return "2 to 3 person can sit on this sofa";
        }


        // The variant, Product B1, is only able to work correctly with the
        // variant, Product A1. Nevertheless, it accepts any instance of
        // IChairProductA as an argument.
        public string FunctionB(IAbstractChairProductA collaborator)
        {
            var result = collaborator.SitOn();
            return $"The result of the B1 collaborating with the {result}";

        }

    }
}
