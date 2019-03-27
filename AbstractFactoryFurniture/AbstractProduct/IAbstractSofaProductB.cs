using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryFurniture.AbstractProduct
{
  //Here's the the base interface of another product. All products can
  // interact with each other, but proper interaction is possible only between
  // products of the same concrete variant.
    public interface IAbstractSofaProductB
    {
        int HasLegs();
        string FamilySofa();

        // The Abstract Factory makes sure that all products it creates
        // are of the same variant and thus, compatible.
        string FunctionB(IAbstractChairProductA collaborator);
    }
}
