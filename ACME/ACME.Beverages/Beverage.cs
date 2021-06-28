using System;

namespace ACME.Beverages
{
    public abstract class Beverage
    {
        private int volume;
        public int Volume
        {
            get 
            { 
                return volume; 
            }
            set 
            { 
                if (value >= 0)
                    volume = value; 
            }
        }

        public abstract void Show();

    }
}
