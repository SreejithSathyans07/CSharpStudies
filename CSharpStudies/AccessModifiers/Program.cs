using Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double BasicPay { get; set; }
        public bool ClientAppreciation { get; set; }
        public Employee(int id, string name, double basicPay, bool clientAppreciation)
        {
            this.Id = id;
            this.Name = name;
            this.BasicPay = basicPay;
            this.ClientAppreciation = clientAppreciation;
        }
        public double CalculateNetPay(Employee emp)
        {
            double rating = Rating(emp.BasicPay, emp.ClientAppreciation);
            return BasicPay + rating;
        }
        /*rating calculation is extremely confidential operation. No one should be able to access it outside this class. 
         So we can make it as a private method*/
        private double Rating(double bpay, bool appreciation) 
        {
            Console.WriteLine("Enter the manager rating (0-5) : ");
            int managerRating = Convert.ToInt32(Console.ReadLine());
            if (appreciation)
            {
                return bpay * (((double)managerRating * 2) / 100);
            }
            else
            {
                return bpay * 0.01;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee(12, "Sreejith", 1000, true);
            var emp2 = new Employee(13, "Arun", 800, false);
            double netPay = emp.CalculateNetPay(emp);
            Console.WriteLine("Net pay : {0}", netPay);

            //If we declare Rating method as public, the below two lines will work
            //double ArunRating = emp2.Rating(emp2.BasicPay, emp2.ClientAppreciation);
            //Console.WriteLine("Arun's Net pay : {0}", ArunRating);


            var dept = new DepartmentData();
            var deptSecret = new DepartmentsSecretCode();

            /*If the GetSecretCode method was public, then below line of code will work. So the code will be revealed with out validation.
             This method should be executed only through strict validation*/
            //string secret = deptSecret.GetSecretCode("dep-x-QA");

            string secret = dept.GetDepartmentSecretCode();

            Console.WriteLine("Secret is {0}", secret);

            Console.ReadKey();
        }
    }
}
