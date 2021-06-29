using System;

namespace Vullis
{
    class Program
    {
        static UnmanRes m1 = new UnmanRes();
        static UnmanRes m2 = new UnmanRes();
        static void Main(string[] args)
        {
            UnmanRes m4 = new UnmanRes();
            try
            {
                m4.Open();
            }
            finally
            {
                m4.Dispose();
            }

            using (m1)
            {
                m1.Open();
                m1 = null;
            }


            using (UnmanRes m3 = new UnmanRes())
            {
                m3.Open();
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            m2.Open();
        }
    }
}
