using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp2
{
    class ArrayListPractice
    {
        public void arrayprac()
        {
            var mylist = new ArrayList();
            //Console.WriteLine("please enter how many u need to enter");
            //int n = Convert.ToInt32(Console.ReadLine());

            mylist.Add("tollplus");
            mylist.Add("india");
            mylist.Add("pvt");
            mylist.Add("ltd");

            //Console.WriteLine("Enter the elemnets:");


            //for (var i = 0; i <= n; i++)
            //{ 


            //    mylist.Add(Console.ReadLine());
            //}




            //for(var i=0; i<=n; i++)
            //{
            //    Console.WriteLine("the elements are "+mylist[i]);
            //}



            Console.WriteLine("the number of elements in the array list is " +mylist.Count);
            Console.WriteLine("the number of elements in the array list is " + mylist.Capacity);
            //mylist.Insert(4, "is");
            //mylist.Insert(5, "my");
            //mylist.Insert(6, "company");
            //mylist.Insert(2, "priyanka");

            Console.WriteLine("after inserting " + mylist);
              
        }
    }
}
