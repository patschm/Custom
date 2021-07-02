using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFW.Entities
{
    public class PersonHobby
    {
        public int PersonID { get; set; }
        public int HobbyID { get; set; }

        public Person Person { get; set; }
        public Hobby Hobby { get; set; }
    }
}
