using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    class ACME
    {
        private List<IContract> employees = new List<IContract>();

        public void Hire(IContract wn)
        {
            employees.Add(wn);
        }
        public void Stoomfluit()
        {
            Console.WriteLine("ACME gaat produceren");
            foreach (IContract employee in employees)
            {
                employee.Werken();
            }
        }
    }
}
