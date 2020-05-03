using System;

namespace IteratorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrimeCollection pc = new PrimeCollection(2, 10000000);
            Prime pc = new Prime(2, 10000000);
            foreach (var p in pc)
            {
                Console.WriteLine(p);
            }
            
        }
    }
}
