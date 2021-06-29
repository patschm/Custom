using IEEE;
using System;
using System.Collections.Generic;

namespace Braka
{
    public class DetectieLus
    {
        private List<IDetectable> devices = new List<IDetectable>();

        public void Connect(IDetectable device)
        {
            devices.Add(device);
        }
        public void Detect()
        {
            Console.WriteLine("De detectielus ziet iets");

            // Aangesloten devices worden geactiveerd
            foreach (IDetectable device in devices)
            {
                device.Activate();
            }
            // Alternatief
            //for (int i = 0; i < devices.Count; i++)
            //{
            //    devices[i].Activate();
            //}
           
        }
    }
}
