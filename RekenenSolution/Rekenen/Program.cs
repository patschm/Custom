using System;

namespace Rekenen
{
    class Program
    {
        static void Main(string[] args)
        {
            MadScientist m1 = new MadScientist();
            WillemKlein wk = new WillemKlein();

            //wk.Bereken(m1.Add, 1,2);
            //wk.Bereken(m1.Subtract, 2,3);

            int x = 10;
            MathDel d1 = m1.Add;
            d1 = d1 + m1.Subtract + m1.Add;// - m1.Add - m1.Subtract;
            d1 += m1.Add;
            d1 -= m1.Subtract;

            foreach(var item in d1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }


            int result = d1(1, 2);

            Console.WriteLine(result);
        }
    }
}
