using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*--------------------------

- A delegate is a type safe function pointer, i.e. delegate points to a function that when you refer the delegate, the function will be invoked.
- We can assign functions to a delegate which matches the signature.
- Delegates are useful in implementing callbacks

 ---------------------------*/

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RenderTheApplication obj = new RenderTheApplication();
            obj.ThisMethodRunsVeryLong(PrintSquare);
            Console.ReadKey();
        }

        public static void PrintSquare(int i)
        {
            Console.WriteLine(Math.Pow(i, 2));
        }
    }

    public class RenderTheApplication
    {
        public delegate void delDisplayMessage(int i);
        public void ThisMethodRunsVeryLong(delDisplayMessage callbackMethod)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                callbackMethod(i);
            }
        }
    }
}
