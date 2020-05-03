using System;
using System.Collections.Generic;

namespace GenericTest
{

    class student : IComparable<student>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        int IComparable<student>.CompareTo(student other)
        {
            return this.Age - other.Age;
        }
    }

    class studentComparer : IComparer<student>
    {
        int IComparer<student>.Compare(student x, student y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    class Program
    {
        static T Min<T>(T first, T second) where T : IComparable<T>
        {
            if (first.CompareTo(second) <= 0)
                return first;
            else
                return second;
        }


        static void Main(string[] args)
        {
            int min = Min(5, 7); // 5
            string str_min = Min<string>("Annie", "Ann"); // Ann
            Console.WriteLine("Min is {0} and {1}.", min, str_min);

            student Annie = new student { Name = "Annie", Age = 5 };
            student Ann = new student { Name = "Ann", Age = 7 };
            student stu_min = Min(Annie, Ann); // Ann
            Console.WriteLine("Min is {0}.", stu_min.Name);

            SortedSet<student> stu_set = new SortedSet<student>(new studentComparer());
            stu_set.Add(Annie);
            stu_set.Add(Ann);
            foreach(var s in stu_set)
            {
                Console.WriteLine(s.Name);
            }
        }
    }
}
