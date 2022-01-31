using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*--------------------------

- If we declare a property as readonly then it's value can be initialized at the time of declaration or inside the constructor of the same class.
- The reasignment can not be done anywhere else. 
- We can add items to that property, but reasignement is not possible.

 ---------------------------*/

namespace Readonly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            var order = new Order { OrderId = 1, NumberOfOrders = 3, OrderItemName = "Pencil" };
            //person.orders = order; //This will result in error
            person.orders.Add(new Order { OrderId = 1, NumberOfOrders = 3, OrderItemName = "Pencil" });
            person.PromotePerson(person.orders);
            Console.ReadKey();
        }
    }
}
