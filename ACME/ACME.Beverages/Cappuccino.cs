using System;

namespace ACME.Beverages
{
    public class Cappuccino: Composite
    {
        public override void Show()
        {
            Console.WriteLine("Cappuccino");
            base.Show();
        }
        public Cappuccino()
        {
            Compose(new Milk { Volume = 50 }, new Coffee { Volume = 50 });
        }
    }
}
