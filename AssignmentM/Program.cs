using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentM
{
    class PrimeNumberFinder
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== PRIME NUMBER FINDER =====");
                Console.WriteLine("1. Check if a number is prime");
                Console.WriteLine("2. Find all prime numbers in a range");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice)) continue;

                switch (choice)
                {
                    case 1:
                        CheckPrimeNumber();
                        break;
                    case 2:
                        FindPrimeNumbersInRange();
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid option! Try again.");
                        break;
                }
            }
        }

        static void CheckPrimeNumber()
        {
            Console.Clear();
            Console.Write("Enter a number to check if it's prime: ");
            int num;
            if (int.TryParse(Console.ReadLine(), out num))
            {
                if (IsPrime(num))
                    Console.WriteLine($"{num} is a Prime Number.");
                else
                    Console.WriteLine($"{num} is NOT a Prime Number.");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
            Console.ReadLine();
        }

        static void FindPrimeNumbersInRange()
        {
            Console.Clear();
            Console.Write("Enter the starting number: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the ending number: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine($"Prime numbers between {start} and {end}:");
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                    Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        static bool IsPrime(int num)
        {
            if (num < 2) return false;
            if (num == 2) return true; // 2 is the only even prime number
            if (num % 2 == 0) return false;

            int sqrt = (int)Math.Sqrt(num);
            for (int i = 3; i <= sqrt; i += 2)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
