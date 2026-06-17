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
            //Arrays

            List<int> numbers = new List<int>();
            numbers.Add(67);
            numbers.Add(123);
            numbers.Add(456);
            Console.WriteLine($"First number = {numbers[0]}");
            Console.WriteLine($"Second number = {numbers[1]}");
            Console.WriteLine($"Third number = {numbers[2]}");
            numbers.Remove(123);
            Console.WriteLine($"After removing 123, Second number = {numbers[1]}");
            numbers[0] = numbers[0] + numbers[1];
            Console.WriteLine($"First number = {numbers[0]}");
            //Lists (Dynamic Arrays)

            Dictionary<string, float> product = new Dictionary<string, float>();
            product["Apple"] = 0.99f;
            product["Banana"] = 0.59f;
            product["Orange"] = 0.79f;
            Console.WriteLine($"Price of Apple = {product["Apple"]}");
            Console.WriteLine($"Price of Banana = {product["Banana"]}");
            Console.WriteLine($"Price of Orange = {product["Orange"]}");
            //Dictionaries (Key-Value Pairs)

            if (a > b) Console.WriteLine("Alright");

            if (product.Count > 10)
            {
                Console.WriteLine("Products are available.");
            }
            else
            {
                Console.WriteLine("No products available.");
            }

            int age = 15;
            if (age >= 18) Console.WriteLine("You are an adults.");
            else if (age >= 13) Console.WriteLine("You are a teenager.");
            else Console.WriteLine("You are a child.");
            //if-else Conditional Statements

            char grade = 'A';
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                    Console.WriteLine("Good");
                    break;
                case 'C':
                    Console.WriteLine("Average");
                    break;
                case 'D':
                    Console.WriteLine("Passed");
                    break;
                case 'F':
                    Console.WriteLine("Failed");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
            //switch Condition

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"For Loop Counts: {i}");
            }
            //For Loop Condition

            bool isTrue = true;
            int counter = 0;
            while (isTrue)
            {
                Console.WriteLine($"Eternity{counter + 1}");
                if (counter == 10)
                {
                    isTrue = false;
                }
                counter++;
            }
            //While Loop Condition

            foreach (string car in cars)
            {
                Console.WriteLine($"Car: {cars}");
            }
            //Foreach Condition
        }
    }
}
