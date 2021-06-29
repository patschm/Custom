using System;

namespace RefGen
{
    class Program
    {
        static void Main(string[] args)
        {
            Point<int> p1 = new Point<int> { X = 10, Y = 20 };
            //Console.WriteLine(p1);
            DoeIets(p1);
            //Console.WriteLine(p1);

            Point<int> p2 = new Point<int> { X = 100, Y = 200 };
            double a = 10;
            double b = 20;
            Console.WriteLine($"a={a}, b={b}");
            Swap(ref a, ref b);
            Console.WriteLine($"a={a}, b={b}");

        }

        static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        static void Swap(ref long a, ref long b)
        {
            long tmp = a;
            a = b;
            b = tmp;
        }
        static void Swap(ref float a, ref float b)
        {
            float tmp = a;
            a = b;
            b = tmp;
        }
        static void Swap<Bla>(ref Bla a, ref Bla b) where Bla: struct, IFormattable
        {
            Bla tmp = a;
            a = b;
            b = tmp;
        }

        private static void DoeIets(Point<int> pxxxx)
        {
            pxxxx.X = 100;
            pxxxx.Y = 200;
        }
    }
}
