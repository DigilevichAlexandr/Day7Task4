using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[] { "petya", "galya", "katya", "yura" };
            Console.WriteLine(BinerySearch<String>.IfExist(array,"petya"));
            Console.WriteLine(BinerySearch<String>.IfExist(array, "nepetya"));
            Console.Read();
        }
    }
}
