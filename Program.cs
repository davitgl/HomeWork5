using System;

namespace app4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            
              if(number % 5== 0)
              {
                  Console.WriteLine("Yes");
              }else
              {
                  Console.WriteLine("No");
              }
            */


            /* 2
            Console.Write("Enter first number (X): ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter second number (Y): ");
            int y = int.Parse(Console.ReadLine());

            // Addition
            Console.WriteLine($"X + Y = {x + y}");

            // Subtraction
            if (x > y)
                Console.WriteLine($"X - Y = {x - y}");
            else
                Console.WriteLine($"Y - X = {y - x}");
            Console.WriteLine($"X * Y = {x * y}");

            // Division
            if (x == 0 || y == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            else if (x > y)
            {
                Console.WriteLine($"X / Y = {x / y}");
            }
            else
            {
                Console.WriteLine($"Y / X = {y / x}");
            }


            */

            /*   3
            Console.Write("Enter value of x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter value of y: ");
            int y = int.Parse(Console.ReadLine());

            // Swap values
            int z = x;
            x = y;
            y = z;

            Console.WriteLine($"After swapping: x = {x}, y = {y}");

            */



            /* 4
            Console.Write("Enter a number to print its multiplication table: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }

            */


            Console.Write("Enter the value of n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("The squares of even numbers from 1 to {0} are:", n);

            // Loop through numbers from 1 to n
            for (int i = 1; i <= n; i++)
            {
                // Check if the number is even
                if (i % 2 == 0)
                {
                    // Print the square of the even number
                    Console.WriteLine(i * i);
                }
            }



        }
    }
}
