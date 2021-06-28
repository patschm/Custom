using System;
using Philips.BL;

namespace ACME.LampApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Big bang
            Lamp lm1 = new Lamp();
            lm1.Color = "red";
            lm1.Lumen = 200;

            lm1.On();

            var lm2 = new Lamp("green", -300);
            //lm2._color = "green";
            //lm2._lumen = 200;

            lm2.On();

            lm1.Off();

            var lm3 = new Lamp { Lumen = -500 };
            //lm3.SetLumen(-500);
            lm3.On();


            Lamp tl1 = new TL { Color = "red", StartTime = 400 };
            tl1.On();

            // Verdiepen
            //((TL)tl1).StartTime = 700;

            // Big crunch
        }
    }
}
