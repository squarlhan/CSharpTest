using System;
using System.Text;

namespace StringTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "china";
            string s2 = "china";

            String s3 = new String(new char[] { 'c', 'h', 'i', 'n', 'a' });
            String s4 = new String(new char[] { 'c', 'h', 'i', 'n', 'a' });

            Console.WriteLine(s1 == s2);    //True 
            Console.WriteLine(s1.Equals(s2));   //True
            Console.WriteLine(Object.ReferenceEquals(s1, s2));  //True
            Console.WriteLine("--------------------------");

            Console.WriteLine(s3 == s4);    //True  微软对它进行优化，String s1 = new String(new char[] { 'c', 'h', 'i', 'n', 'a' });相当于string s1 = "china";所以上面s1 == s3就为True了。
            Console.WriteLine(s3.Equals(s4));   //True
            Console.WriteLine(Object.ReferenceEquals(s3, s4));  //False
            Console.WriteLine("--------------------------");

            Console.WriteLine(s1 == s3);    //True
            Console.WriteLine(s1.Equals(s3));   //True
            Console.WriteLine(Object.ReferenceEquals(s1, s3));  //False
            Console.WriteLine("---------StringBuilder-----------------");

            StringBuilder sb1 = new StringBuilder("china");
            StringBuilder sb2 = new StringBuilder("china");
            Console.WriteLine(sb1 == sb2);      //False
            Console.WriteLine(sb1.Equals(sb2)); //True
            Console.WriteLine(Object.ReferenceEquals(sb1, sb2));    //False

        }
    }
}
