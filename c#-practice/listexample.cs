using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class listexample
    {
        public void Main(string[] args)
        {
           

                var cities = new List<string>();
                cities.Add("New York");
                cities.Add("London");
                cities.Add("Mumbai");
                cities.Add("Chicago");
                Console.WriteLine("cities :  " + cities.Count);
            }


            //List<int> li = new List<int>(5);
            //for (int i = 0; i < li.Count; i++)
            //{
            //    int li[i] = li.Add(int.Parse(Console.ReadLine()));
            //}


        }
    }
}

