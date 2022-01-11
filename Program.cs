using System;

namespace Count
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create classes
            Clock clock = new Clock();
            for (int i = 1; i <= 3640; i++)
            {
                clock.Tick();
            }
            Console.WriteLine($"{clock.Time}, The time is enough");
        }
    }
}
