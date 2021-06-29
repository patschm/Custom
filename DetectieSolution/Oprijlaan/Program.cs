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

            //lus.Connect(h);
            //lus.Connect(tl);
            //lus.Connect(kuil);

            lus.Detecting += h.Open;
            lus.Detecting += tl.Aan;
            lus.Detecting += kuil.OpenDoor;

            lus.Detect();

        }
    }
}
