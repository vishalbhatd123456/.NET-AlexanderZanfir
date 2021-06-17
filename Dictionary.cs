using System;
using System.Collections.Generic;

namespace _net
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> config = new Dictionary<string, string>();

            config.Add("resolution", "1920X1080");
            config.Add("title","MyWebsite");
            config.Add("title", "abc");

            Console.WriteLine(config);

            //access the value of a setting

            Console.WriteLine(config["title"]);
            Console.WriteLine(config["resolution"]);
            

        Console.ReadLine();
            
        }
}
}
