using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryFurniture.AbstractFactory;
using AbstractFactoryFurniture.AbstractProduct;
using AbstractFactoryFurniture.ConcreteProduct;

namespace AbstractFactoryFurniture.ConcreteFactory
{
    // Each Concrete Factory has a corresponding product variant.
    public class VictoriaConcreteFactory2 : IFurnitureAbstractFactory
    {
        public IAbstractChairProductA CreateChairProductA()
        {
           return new ConcreteProductA2Chair();
        }

        public IAbstractSofaProductB CreateSofaProductB()
        {
           return new ConcreteProductB2Sofa();
        }
    }
}
