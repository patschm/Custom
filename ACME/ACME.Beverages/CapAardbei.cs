using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.Beverages
{
    public class CapAardbei : Cappuccino
    {
        public override void Show()
        {
            base.Show();
            
        }
        public CapAardbei()
        {
            Console.WriteLine("Plus aarbei");
            Compose(new Aardbei { Volume = 20 });
        }
    }
}
