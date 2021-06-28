using System;

namespace TheFirm
{
    class Program
    {
        static void Main(string[] args)
        {
            ACME comp = new ACME();
            Ruud ruud = new Ruud();
            Leon l1 = new Leon();
            Sjoerd s = new Sjoerd();
            Bokito b = new Bokito();

            comp.Hire(ruud);
            comp.Hire(l1);
            comp.Hire(s);
            comp.Hire(b);

            comp.Stoomfluit();

       
        }
    }
}
