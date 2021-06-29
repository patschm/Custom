using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeRadio
{

    delegate void OntvangstMethode(string bericht);

    class RadioStation
    {
        public event OntvangstMethode subscribers;

        public void Broadcast()
        {
            subscribers?.Invoke("Hallo luisteraars");
        }
    }
}
