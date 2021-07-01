using System;
using System.Threading.Tasks;

namespace OnderWater
{
    public class Test
    {
        public int Getal { get; set; }
        public async Task<int> DoeIets()
        {
            int a = 10;
            Console.WriteLine("Hallo");
            return a;
        }
    }
}
