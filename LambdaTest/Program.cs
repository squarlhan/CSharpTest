using System;
using System.Collections.Generic;

namespace LambdaTest
{
    class Program
    {

        public static void actionTest(Action<string> a, string s)=>a(s);

        public static int[] filterArray(int[] arr, Func<int, bool> filter)
        {
            List<int> results = new List<int>();
            foreach(var a in arr)
            {
                if (filter(a)) results.Add(a);
            }
            return results.ToArray();
        }

        public static int[] filterArray(int[] arr, Predicate<int> filter)
        {
            List<int> results = new List<int>();
            foreach (var a in arr)
            {
                if (filter(a)) results.Add(a);
            }
            return results.ToArray();
        }

        static void Main(string[] args)
        {
            Action<string> dosth = Console.WriteLine;
            dosth("Hello world!");
            actionTest(dosth, "Hello again!");

            Func<string, string> dressing = s => "********\n" + s + "\n********";
            dosth(dressing("Hello, me!"));

            var arr = new[] {1,2,3,4,5 };
            Func<int, bool> filter_f = a => a % 2 == 0;
            Predicate<int> filter_p = a => a % 2 == 0;
            var res = filterArray(arr, filter_p);
            foreach (var a in res)
            {
                dosth(a.ToString());
            }
        }
    }
}
