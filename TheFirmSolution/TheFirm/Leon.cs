using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    class Leon: Werknemer
    {
        public override void Werkt()
        {
            Programmeert();
        }
        public void Programmeert()
        {
            Console.WriteLine("Leon vindt fouten");
        }
    }
}
