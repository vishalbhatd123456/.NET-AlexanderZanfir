using System;
using System.Collections.Generic;

namespace _net
{
    class Program
    {
        static void Main(string[] args)
        {
            bool canIVote = true;
            string randString = "This is a string";
            Console.WriteLine("String Length is : {0}", randString.Length);
            Console.WriteLine("String contains:{0}", randString.Contains("is"));
            Console.WriteLine("Remove string : {0}",randString.Remove(0,6));
            Console.WriteLine("Insert String: {0}", randString.Insert(10, "short"));
            Console.WriteLine("Compare A to B:{0}", string.Compare("A","B",StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Remove whitespacess:{0}",randString.Trim());
            Console.WriteLine("Convert to uppercase : {0}",randString.ToUpper());
            Console.WriteLine("Convert to Lower case : {0}", randString.ToLower());
        Console.ReadLine();
            
        }
}
}
