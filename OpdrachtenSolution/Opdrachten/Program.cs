using System;

namespace Opdrachten
{
    class Program
    {
        static void Main(string[] args)
        {
            Patrick p = new Patrick();
            Ruud r = new Ruud();

            r.Execute(p.Bestelling);
            r.Execute(Ontplof);
            // p.Bestelling();

            OrderDel d1 = Ontplof;
            d1();
        }

        static void Ontplof()
        {
            Console.WriteLine("Kaboooom");
        }
    }
}
