using Braka;
using DoomsdayPreppers;
using Heras;
using Philips;
using System;

namespace Oprijlaan
{
    class Program
    {
        static void Main(string[] args)
        {
            Hek h = new Hek();
            DetectieLus lus = new DetectieLus();
            Lamp tl = new Lamp();
            Valkuil kuil = new Valkuil();


            lus.Detect();

        }
    }
}
