// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
namespace dictionary
{
    class Example
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Harry");
            d.Add(2, "Sally");
            d.Add(3, "Clarke");
            d.Add(4, "James");
            d.Add(5, "Emma");
            d.Add(6, "Susan");
            Console.WriteLine("Dictionary elements are as follows:");
            foreach (KeyValuePair<int, string> i in d)
            {
                Console.WriteLine("Key: {0}     Value: {1}", i.Key, i.Value);
            }
        }
    }
}