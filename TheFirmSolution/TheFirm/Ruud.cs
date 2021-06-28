using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    class Ruud: Werknemer, IContract
    {
        public override void Werkt()
        {
            Assemblert();
        }
        public void Assemblert()
        {
            Console.WriteLine("Ruud programmeert nu in assembler");
        }

        public void Werken()
        {
            Assemblert();
        }
    }
}
