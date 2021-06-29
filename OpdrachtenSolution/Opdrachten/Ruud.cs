namespace Opdrachten
{
    delegate void OrderDel();

    internal class Ruud
    {
      public void Execute(OrderDel functie)
        {
            System.Console.WriteLine("Ruud doet het volgende");
            functie();
        }
    }
}