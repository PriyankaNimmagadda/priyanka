using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class swap
    {
        public void  swap1()
        {
            int a = 10, b=20;
            swap2( a, b);
            
        }
        public void swap2( int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a + " " + b);


        }
    }
}
