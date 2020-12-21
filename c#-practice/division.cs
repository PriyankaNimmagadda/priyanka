using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class division
    {
        public void div()
        {
            
            float result = divide(10, 20);
            Console.WriteLine(result);
        }

        private float divide(float v1, float v2)
        {
            return v1/v2;
        }
    }
}
