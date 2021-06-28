using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.Beverages
{
    public class LatteMacchiato : Composite
    {
        public override void Show()
        {
            Console.WriteLine("Latte Macchiato");
            base.Show();
        }
        public LatteMacchiato()
        {
            Compose(
                    new Milk { Volume = 66 }, 
                    new Coffee { Volume = 34 } 
                );
        }
    }
}
