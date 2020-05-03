using System;

namespace MyException
{
    class Program
    {
        class MyOwenException : Exception
        {
            public MyOwenException(String msg)
            {
                Console.WriteLine("This is from myowen exception!");
            }
        }

        static void exceptiontest()
        {
            throw new MyOwenException("my");
        }

        static void Main(string[] args)
        {
            try
            {
                exceptiontest();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
