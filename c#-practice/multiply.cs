using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class multiply
    {
         public void multiplication()
        {
            int result = mul(10, 20);
            Console.WriteLine(result);
        }

        private int mul(int v1, int v2)
        {
            return v1 * v2;
        }
    }
}
