using Characters.Warriors;
using System;


namespace OOP1
{

    
    public class EntryPoint
    {
        static void Main()
        {
            Warrior theGoodGuy = new Warrior(180, 80, "Tom");
         


            Warrior theBadGuy = new Warrior(190, 80, "RumpleStiltskin");


            Console.WriteLine(theGoodGuy.Height);
            // System.Console.WriteLine(theBadGuy.Height);

            theGoodGuy.Greetings(theBadGuy);
            theBadGuy.Greetings(theGoodGuy);

        }
    }
}
