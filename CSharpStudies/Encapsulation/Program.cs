using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Person
    {
        public Person(DateTime birthDate)
        {
            this.BirthDate = birthDate; 
        }
        public DateTime BirthDate { get;  private set; } //This ensures that the birthdate can only be set from the constructor.
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1980, 1, 1));
            Console.WriteLine(person.BirthDate);
            Console.ReadKey();
        }
    }
}
