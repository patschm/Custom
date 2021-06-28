using System;
using ACME.Beverages;

namespace ACME.UI.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage cap1 = new Cappuccino();
            cap1.Show();

            var lm = new LatteMacchiato();
            lm.Show();

            var ca = new CapAardbei();
            ca.Show();
        }
    }
}
