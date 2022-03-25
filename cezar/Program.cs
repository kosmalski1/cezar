// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cezar

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj fraze");
            foreach (var c in Console.ReadLine())
            {
                Console.Write(Convert.ToChar((c - 'a' + 3) % ('z' - 'a' + 3) + 'a'));
            }
            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
