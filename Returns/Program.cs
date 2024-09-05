using System;
using System.Collections.Generic;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = AddNumbers(5, 13);
            Console.WriteLine($"Sum: {sum}");

            string greeting = GetGreeting("Hayden");
            Console.WriteLine($"Greeting: {greeting}");

            var toppings = GetFavoriteGames();
            Console.WriteLine("Favorite Games:");
            foreach (var topping in toppings)
            {
                Console.WriteLine(topping);
            }

            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }

        static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        static string GetGreeting(string name)
        {
            return $"Hello, {name}!";
        }

        static List<string> GetFavoriteGames()
        {
            return new List<string> { "Elden Ring", "Red Dead Redemption II", "Minecraft" };
        }
    }
}
