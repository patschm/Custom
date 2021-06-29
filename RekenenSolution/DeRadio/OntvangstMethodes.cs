using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeRadio
{
    class OntvangstMethodes
    {
        public static void ViaEther(string bericht)
        {
            Console.WriteLine($"Via ether ontvangen: {bericht}");
        }
        public static void ViaMail(string bericht)
        {
            Console.WriteLine($"Via mail ontvangen: {bericht}");
        }
        public static void ViaKabel(string bericht)
        {
            Console.WriteLine($"Via kabel ontvangen: {bericht}");
        }
        public static void ViaSMS(string bericht)
        {
            Console.WriteLine($"Via SMS ontvangen: {bericht}");
        }
        public static void ViaPostduif(string bericht)
        {
            Console.WriteLine($"Via postduif ontvangen: {bericht}");
        }
    }
}
