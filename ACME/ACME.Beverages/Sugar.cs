using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.Beverages
{
    public class Sugar: Beverage
    {
        public override void Show()
        {
            Console.WriteLine($"{Volume}ml Sugar");
        }
    }
}
