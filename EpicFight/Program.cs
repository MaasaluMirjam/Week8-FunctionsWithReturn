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
            int heroHP = GenerateHP(hero);
            int villainHP = GenerateHP(villain);

            Console.WriteLine($"{hero}({heroHP}HP) will fight {villain} ({villainHP}HP)");
            Console.WriteLine($"{hero} will fight with {heroWeapon}.");
            Console.WriteLine($"{villain} will fight with {villainWeapon}.");

            while (heroHP > 0 && villainHP > 0)
            {
                heroHP = heroHP - Hit(villain, hero, villainWeapon);
                villainHP = villainHP - Hit(hero, villain, heroWeapon);
            }

            if (heroHP <= 0)
            {
                Console.WriteLine("Dark side wins!");
            }
            else
            {
                Console.WriteLine($"{hero} saved the day!");
            }

        }

        private static int Hit(string characterOne, string characterTwo, string weapon )
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, weapon.Length / 2);
            Console.WriteLine($"{characterOne} hit {strike}.");          

            if (strike == weapon.Length /2 - 1)
            {
                Console.WriteLine($"Awesome! {characterOne} made a critical hit");
            }
            else if (strike == 0)
            {
                Console.WriteLine($"{characterTwo} dodged the attack!");
            }

            return strike;
        }

        private static int GenerateHP(string someCharacter)
        {
            Random rnd = new Random();
            return rnd.Next(someCharacter.Length, someCharacter.Length + 10);
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
            string[] weapon = { "Gun","Knife","Boxing Glove", "magic wand" };
            return weapon[RandomIndex(weapon)];
        }
    }
}
