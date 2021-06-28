using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Philips.BL
{
    public class TL : Lamp
    {
        public int StartTime { get; set; } = 100;

        // Gedrag slaan we op in methods
        public override void On()
        {
            //base.On();
            Console.WriteLine($"De TL knippert {StartTime}ms en brandt in kleur {Color} en intensiteit {Lumen} lumen");
        }
        public void Off()
        {
            Console.WriteLine("De TL is nu uit");
        }
    }
}
