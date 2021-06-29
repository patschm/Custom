using System;

namespace EvolutieTheorieDerDelegates
{
    delegate int MathDel(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            int result = Add(1, 2);

            // Framework 1.0/1.1
            MathDel m1 = new MathDel(Add);
            result = m1(2, 3);

            // Framework 2.0
            MathDel m2 = Add;
            result = m2(3, 4);

            MathDel m3 = delegate (int a, int b)
            {
                return a + b;
            };
            result = m3(4, 5);

            // Framwork 3.0/3.5
            MathDel m4 =  (a,  b) => a + b;
            result = m4(5, 6);

            // Procedures
            Action<string> a1 = (s) => Console.WriteLine(s);
            a1("Hallo");

            // Functions
            Func<int> f1 = () => 42;
            Func<int, int, int> f2 = (a, b) => a - b;

            result = f2(6, 7);
            a1(f1().ToString());
            Console.WriteLine( result);
        }


        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
