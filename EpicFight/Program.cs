using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero, villain;
            string heroWeapon, villainWeapon;

            hero = RandomHero();
            heroWeapon = RandomWeapon();
            villain = RandomVillain();
            villainWeapon = RandomWeapon();
            Console.WriteLine($"{hero} will fight {villain}");
            Console.WriteLine($"{hero} will fight with {heroWeapon}.");
            Console.WriteLine($"{villain} will fight with {villainWeapon}.");
        }

        private static int RandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static string RandomHero()
        {
            string[] heroes = { "Batman", "SpongeBob", "Spiderman", "Caroly" };
            return heroes[RandomIndex(heroes)];            
        }

        private static string RandomVillain()
        {
            string[] villain = { "Suss", "Vadim", "TalongiPoiss", "Elise", "Sirley" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, villain.Length);

            string randomVillain = villain[randomIndex];
            return randomVillain;
        }

        private static string RandomWeapon()
        {
            string[] weapon = { "Gun","Knife","Boxing Glove" };
            return weapon[RandomIndex(weapon)];
        }
    }
}
