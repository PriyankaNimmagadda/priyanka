using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Employee1 : Employee
    {
        public void empdetails()
        {
            Console.WriteLine("enter the first name" );
            Fname = Console.ReadLine();
            Console.WriteLine("enter the last name");
            Lname = Console.ReadLine();
            Console.WriteLine("enter salary");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the employee id");
            Id= Console.ReadLine();
            Console.WriteLine(Fname);
            Console.WriteLine(Lname);
            Console.WriteLine(salary);
            Console.WriteLine(Id);




        }
    }
}
