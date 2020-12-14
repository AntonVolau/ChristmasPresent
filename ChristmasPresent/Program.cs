using System;
using System.Collections.Generic;
using ChristmasPresent.Implementation;

namespace ChristmasPresent
{
    class Program
    {
        static void Main()
        {
            Present<Sweet> presentBox = new Present<Sweet>()
            {
                Name = "Surprise",
                MaxVolume = 4.00m
            };
            Sweet candy = new Candy();
            presentBox.AddSweets(candy);
            presentBox.AddSweets(new Chokolate());
            presentBox.AddSweets(new Lolipop());
            presentBox.AddSweets(new ChokolateEgg(), 3);

            presentBox.AscendingSortByWeight();
            Console.WriteLine($" Weight of present box = {presentBox.Weight} kg");
            Console.WriteLine($" Total number of sweets in present box = {presentBox.NumberOfSweets}");
            Console.WriteLine($" List of all sweets in present box from light to heavy:");
            foreach (Sweet yummy in presentBox)
            {
                Console.WriteLine(yummy.Name);
            }
            Console.WriteLine("Sweets in present box with sugar substace between 0.1 and 0.11:");
            List<Sweet> candyesSugar = presentBox.FindCandyesBySugarSubstance(0.1m, 0.11m);

            foreach (Sweet candycan in candyesSugar)
            {
                Console.WriteLine(candycan.Name);
            }

            Console.ReadKey();
            
        }
    }
}
