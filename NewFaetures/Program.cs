using System;
using System.Text;

namespace NewFaetures
{
    public static class StringExtention
    {
        public static string toPascalCase(this string str, bool flag)
        {
            string[] strs = str.Split(' ');
            StringBuilder temp = new StringBuilder();
            foreach(var s in strs)
            {
                if(flag)
                {
                    string t = s.ToLower();
                    temp.Append(t.Substring(0, 1).ToUpper());
                    temp.Append(t.Substring(1));
                    temp.Append(" ");
                }
                else
                {
                    return str;
                }
            }

            return temp.ToString().Substring(0, temp.Length-1);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var names = new[]
            {
                new {firstName = "Xiaoming", lastName = "Wang" },
                new {firstName = "Xiaoming", lastName = "Wang" },
                new {firstName = "Daming", lastName = "Yang" }
            };

            foreach(var n in names)
            {
                Console.WriteLine(n.GetHashCode());
                Console.WriteLine(n.firstName);
            }

            Console.WriteLine(names[0].Equals(names[1]));
            Console.WriteLine(names[0].Equals(names[2]));
            Console.WriteLine(names[0] == names[1]);
            Console.WriteLine(names[0] == names[2]);

            var str = "monkey chicken duck pig bull";
            Console.WriteLine(str);
            Console.WriteLine(str.toPascalCase(true));
        }
    }
}
