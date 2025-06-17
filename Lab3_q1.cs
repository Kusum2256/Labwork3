using System;

namespace Labwork
{
    internal class Lab3_q1
    {
        delegate void MyDelegate();

        static void ShowMessage1()
        {
            Console.WriteLine("Hello from method 1");
        }

        static void ShowMessage2()
        {
            Console.WriteLine("Hello from method 2");
        }

        static void Main(string[] args)
        {
            MyDelegate d = ShowMessage1;
            d += ShowMessage2;
            d();
        }
    }
}

