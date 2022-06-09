using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Test2.Entities
{
    public partial class Mechanic
    {
        public int IdMechanic { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Inspection> Inspections { get; set; }
    }
}
