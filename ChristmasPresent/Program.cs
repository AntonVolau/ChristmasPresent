using System;
using ChristmasPresent.Implementation;

namespace ChristmasPresent
{
    class Program
    {
        static void Main()
        {
            Sweet candy = new Candy();
            Present<Sweet> kek = new Present<Sweet>();
            kek.AddSweet(candy);
        }
    }
}
