using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFW.Entities
{
    public class Hobby
    {
        public int ID { get; set; }
        public string Description { get; set; }

        public ICollection<PersonHobby> People { get; set; } = new HashSet<PersonHobby>();
    }
}
