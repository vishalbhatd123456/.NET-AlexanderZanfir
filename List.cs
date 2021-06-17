using System;
using System.Collections.Generic;

namespace _net
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> customers = new List<string>();
            customers.Add("kim");
            customers.Add("John");
            customers.Add("Tim");

            Console.Write(customers.Count);

             Console.WriteLine();

            foreach(var customer in customers){
                Console.WriteLine(customer);
            }

            Console.WriteLine(customers[1]);

        Console.ReadLine();
            
        }
}
}
