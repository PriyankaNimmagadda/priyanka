 using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
    {
        class EmployeeData
        {
            private List<EmployeeDetails> employeeDetails;
            public void list()
            {
                employeeDetails = new List<EmployeeDetails>();
                EmployeeDetails employee1 = new EmployeeDetails();
                Console.WriteLine("enter 1st employee  details");
                Console.WriteLine("Enter employee number");
                employee1.empNo = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter employee name");
                employee1.empName = Console.ReadLine();
                Console.WriteLine("enter employee department");
                employee1.deptName = Console.ReadLine();
                Console.WriteLine("enter employee salary");
                employee1.salary = int.Parse(Console.ReadLine());


                EmployeeDetails employee2 = new EmployeeDetails();
                Console.WriteLine("enter 2nd employee  details");
                Console.WriteLine("Enter employee number");
                employee2.empNo = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter employee name");
                employee2.empName = Console.ReadLine();
                Console.WriteLine("enter employee department");
                employee2.deptName = Console.ReadLine();
                Console.WriteLine("enter employee salary");
                employee2.salary = int.Parse(Console.ReadLine());

                EmployeeDetails employee3 = new EmployeeDetails();
                Console.WriteLine("enter 3rd employee  details");
                Console.WriteLine("Enter employee number");
                employee3.empNo = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter employee name");
                employee3.empName = Console.ReadLine();
                Console.WriteLine("enter employee department");
                employee3.deptName = Console.ReadLine();
                Console.WriteLine("enter employee salary");
                employee3.salary = int.Parse(Console.ReadLine());

                EmployeeDetails employee4 = new EmployeeDetails();
                Console.WriteLine("enter 4th employee  details");
                Console.WriteLine("Enter employee number");
                employee4.empNo = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter employee name");
                employee4.empName = Console.ReadLine();
                Console.WriteLine("enter employee department");
                employee4.deptName = Console.ReadLine();
                Console.WriteLine("enter employee salary");
                employee4.salary = int.Parse(Console.ReadLine());

                EmployeeDetails employee5 = new EmployeeDetails();
                Console.WriteLine("enter 5th employee  details");
                Console.WriteLine("Enter employee number");
                employee5.empNo = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter employee name");
                employee5.empName = Console.ReadLine();
                Console.WriteLine("enter employee department");
                employee5.deptName = Console.ReadLine();
                Console.WriteLine("enter employee salary");
                employee5.salary = int.Parse(Console.ReadLine());

                employeeDetails.Add(employee1);
                employeeDetails.Add(employee2);
                employeeDetails.Add(employee3);
                employeeDetails.Add(employee4);
                employeeDetails.Add(employee5);
                Console.WriteLine("=============================================================================");
                foreach (var details in employeeDetails)
                {

                    Console.WriteLine($" \n {details.empName} details are\n \n employee name: {details.empName} \n employee number: {details.empNo} \n employee department: {details.deptName}\n employee salary: {details.salary}");

                }

                Console.WriteLine("===============================================================================");
            }
        }
    }

}
}
