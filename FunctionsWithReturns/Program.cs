using System;

namespace FunctionsWithReturns
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] foods = { "ice cream", "chiken wings", "french fries", "burger", "salad" };
            string[] drinks = { "coca-cola", "fanta", "sprite", "water" };
            string[] movies = { "Truth or Dare", "Hunted Hill House", "You", "365 days" };
            // DisplayRandomFromArray(foods);
            // DisplayRandomFromArray(drinks);
            string randomSnack = PickRandomFromArray(foods);
            string randomDrink = PickRandomFromArray(drinks);
            string randomMovies = PickRandomFromArray(movies);

            Console.WriteLine($"Computer pick {randomSnack}, {randomDrink} and {randomMovies} for night");
        }

        private static string PickRandomFromArray(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            string randomElement = someArray[randomIndex];

            return randomElement;

        }

        private static void DisplayRandomFromArray(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            Console.WriteLine($"computer has chosen {someArray[randomIndex]}");
        }


    }
}
