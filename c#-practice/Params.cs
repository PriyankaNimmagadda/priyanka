using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp2
{
    class Params
    {
        public void string1(params string[] array)
        {
            //int sum = 0;
            //foreach(int i in numbers)
            //{
            //    sum +=i; 
            //}
            //return sum;
            //for(int i=0;i<array.Length;i++)
            //{
            //    array[i]=Console.ReadLine();
            //}
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        
     }       
}
