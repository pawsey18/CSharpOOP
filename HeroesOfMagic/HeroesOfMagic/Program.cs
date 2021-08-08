using HeroesOfMagic.Heroes.Knight;
using System;
using Weapons;


namespace HeroesOfMagic
{
    class Program
    {
        static void Main(string[] args)
        {
            Sword sword = new Sword();

            Knight knight = new Knight(10, "ggg", 100, 5, "Goblin", "bulletprof");

        

            knight.Pray();
      

        }
    }
}
