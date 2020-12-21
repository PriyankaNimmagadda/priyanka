using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class employee
    {
        string empFname;
        string empLname;
        string empId;
        int empSalary;
        int BasicHRA;
        int OtherAllowences;
        int Tsalary;
        public void empDetails()
        {
            
           
            Console.WriteLine("enter the value of n:");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the values:");
            for (int i=0;i<n;i++)
            {
                Console.WriteLine("enter the emp first name");
                empFname = Console.ReadLine();
                Console.WriteLine("enter the emp last name");
                empLname = Console.ReadLine();
                Console.WriteLine("enter the emp id");
                empId = (Console.ReadLine());
                Console.WriteLine("enter the emp salary");
                empSalary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the basic HRA:");
                BasicHRA = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the other allowences");
                OtherAllowences = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("the total salary is");
                Tsalary = BasicHRA + OtherAllowences;
                
                
                
         }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(empFname);
                Console.WriteLine(empLname);
                Console.WriteLine(empId);
                Console.WriteLine(empSalary);
                Console.WriteLine(BasicHRA);
                Console.WriteLine(OtherAllowences);
                Console.WriteLine(Tsalary);
            }


        }

    }
}
