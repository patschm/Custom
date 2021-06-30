using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vullis
{
    public class UnmanRes : IDisposable
    {
        private static bool isOpen = false;

        public void Open()
        {
            if (!isOpen)
            {
                Console.WriteLine("Geopend");
                isOpen = true;
            }
            else
            {
                Console.WriteLine("Helaas. In gebruik");
            }
        }
        public void Close()
        {
            isOpen = false;
            Console.WriteLine("Resource vrij gegeven");
        }

        public void Dispose()
        {
            Close();
            GC.SuppressFinalize(this);
        }

        ~UnmanRes()
        {
            Close();
            
        }
    }
}
