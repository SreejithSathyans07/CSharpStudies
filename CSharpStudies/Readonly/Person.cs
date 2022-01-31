using System.Collections.Generic;

namespace Readonly
{
    public class Person
    {
        public int Id;
        public string Name;
        public readonly List<Order> orders = new List<Order>(); //This will restrict the reasignment on this property

        public void PromotePerson(List<Order> orders)
        {
            if (orders.Count >= 1)
            {
                System.Console.WriteLine("The person has been promoted");
            }
            else
            {
                System.Console.WriteLine("Unable to promote");
            }
        }
    }
}
