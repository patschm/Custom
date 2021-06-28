using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    class Bokito: IContract
    {
        public void Werken()
        {
            Werkt();
        }

        public void Werkt()
        {
            Console.WriteLine("Bokito peert hier en daar wat mensen in elkaar");
        }
    }
}
