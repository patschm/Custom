using System;

namespace ACME.Beverages
{
    public class Aardbei: Beverage
    {
        public override void Show()
        {
            Console.WriteLine($"{Volume}ml Aardbei");
        }
    }
}