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
    // Concrete Factories produce a family of products that belong to a single
    // variant. The factory guarantees that resulting products are compatible.
    // Note that signatures of the Concrete Factory's methods return an abstract
    // product, while inside the method a concrete product is instantiated.
    public class ModernConcreteFactory1 : IFurnitureAbstractFactory
    {
        public IAbstractChairProductA CreateChairProductA()
        {
            return  new ConcreteProductA1Chair();
        }

        public IAbstractSofaProductB CreateSofaProductB()
        {
           return new ConcreteProductB1Sofa();
        }
    }
}
