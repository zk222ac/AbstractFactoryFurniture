using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryFurniture.AbstractFactory;
using AbstractFactoryFurniture.ConcreteFactory;

namespace AbstractFactoryFurniture.Client
{
    class Clients
    {
        public void Main()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new ModernConcreteFactory1());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new VictoriaConcreteFactory2());
        }

        public void ClientMethod(IFurnitureAbstractFactory factory)
        {
            var name = factory.GetType().Name;
            Console.WriteLine($"Current Variant:" + name);
            var productA = factory.CreateChairProductA();
            var productB = factory.CreateSofaProductB();
            Console.WriteLine(productB.HasLegs());
            Console.WriteLine(productB.FunctionB(productA));
            Console.WriteLine("...................................");
        }
    }
}
