using System;

namespace CSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 0, 1 };

            try
            {
                for (int i = 0; i <= array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Final!");
            }
            Console.WriteLine("Go on!");

        }
    }
}
