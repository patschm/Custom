using IEEE;
using System;

namespace DoomsdayPreppers
{
    public class Valkuil: IDetectable
    {
        public void Activate()
        {
            OpenDoor();
        }

        public void OpenDoor()
        {
            Console.WriteLine("De valkuil opent");
        }
    }
}
