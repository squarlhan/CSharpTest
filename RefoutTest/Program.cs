using System;

namespace RefoutTest
{
    class Program
    {
        public static void changeNames(ref string name, out string oldname)
        {
            oldname = name;
            name = "Pesho";
        }


        static void Main(string[] args)
        {
            string name = "Alice";
            string oldname = "";
            changeNames(ref name, out oldname);
            Console.WriteLine("{0}'s former name is {1}.", name, oldname);
        }
    }
}
