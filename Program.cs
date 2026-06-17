using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 5;
            int b = 2;
            Console.WriteLine($"a + b = {a + b}");
            //eiei
            /*super
              eiei
            */
            string[] cars = new string[3];
            cars[0] = "Ford";
            cars[1] = "BMW";
            cars[2] = "Toyota";
            Console.WriteLine($"First car = {cars[0]}");
            Console.WriteLine($"Second car = {cars[1]}");
            Console.WriteLine($"Third car = {cars[2]}");
        }
    }
}
