using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    class Werknemer: Persoon, IContract
    {
        public void Werken()
        {
            Werkt();
        }

        public virtual void Werkt()
        {

        }
    }
}
