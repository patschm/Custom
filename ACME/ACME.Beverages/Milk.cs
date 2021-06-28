using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.Beverages
{
    public class Milk: Beverage
    {
        public override void Show()
        {
            Console.WriteLine($"{Volume}ml Milk");
        }
    }
}
