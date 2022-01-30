using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*--------------------------

- Boxing: Conversion of a value type in to reference type. It is implicit conversion.
- Unboxing: Conversion of reference type in to value type. It should be manually done by the developer. It is explicit conversion.

 ---------------------------*/

namespace BoxingAndUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int boxingInt = 2000;
            Object objBox = boxingInt;
            Console.WriteLine(objBox);

            Object objUnbox = 1000;
            int unboxingInt = Convert.ToInt32(objUnbox);
            Console.WriteLine(unboxingInt);

            Console.ReadKey();
        }
    }
}
