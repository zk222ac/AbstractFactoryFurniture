using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryFurniture.Client;

namespace AbstractFactoryFurniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Client.Clients client = new Clients();
            client.Main();
            Console.ReadKey();
        }
    }
}
