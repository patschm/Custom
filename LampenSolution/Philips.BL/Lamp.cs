using System;

namespace Philips.BL
{
    public class Lamp
    {
        // Eigenschappen. Slaan we op in fields
        private int _lumen = 200;

        // Properties

        // Auto generating property. Genereert zijn eigen field
        public string Color { get; set; }
       

        public int Lumen
        {
            get
            {
                return _lumen;
            }
            set
            {
                if (value >= 0 && value < 1000)
                {
                    _lumen = value;
                }
            }
        }

        // Gedrag slaan we op in methods
        public virtual void On()
        {
            Console.WriteLine($"De lamp brandt in kleur {Color} en intensiteit {Lumen} lumen");
        }
        public void Off()
        {
            Console.WriteLine("De lamp is nu uit");
        }

        // Constructors.. Gebruik je om fields een initiele waarde te geven
        public Lamp(string color, int lumen)
        {
            Color = color;
            Lumen = lumen;
        }
        public Lamp()
        {

        }
    }
}
