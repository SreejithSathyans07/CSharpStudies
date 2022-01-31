using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department
{
    public class DepartmentsSecretCode
    {
        private string SecretCode { get; set; }

        internal string GetSecretCode(string depId)
        {
            return "DPT-X-QA-8976";
        }
    }
    public class DepartmentData
    {
        public string GetDepartmentSecretCode()
        {
            var dept = new DepartmentsSecretCode();
            Console.WriteLine("Enter Username : ");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Password : ");
            string password = Console.ReadLine();

            string secretKey = "";
            if (userName == "admin" && password == "admin")
            {
                secretKey = dept.GetSecretCode("dep-x-QA");
            }
            else
            {
               secretKey = "Not authorized";
            }
            return secretKey;
        }
    }
}
