using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.Beverages
{
    public class Composite: Beverage
    {
        private List<Beverage> _beverages = new List<Beverage>();

        public void Compose(params Beverage[] beverages )
        {
            _beverages.AddRange(beverages);
        }

        public override void Show()
        {
            foreach(var beverage in _beverages)
            {
                beverage.Show();
            }
        }
    }
}
