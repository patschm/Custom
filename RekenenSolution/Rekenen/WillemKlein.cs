using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenen
{
    public delegate int MathDel(int a, int b);

    class WillemKlein
    {
        public void Bereken(MathDel calc, int aa, int bb)
        {
            Console.WriteLine("Willem Klein gaat nu rekenen");
            int result = calc(aa, bb);


            Console.WriteLine($"Willem roept: Het antwoord is {result}");
        }
    }
}
