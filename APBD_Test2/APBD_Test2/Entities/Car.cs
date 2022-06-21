using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace APBD_Test2.Entities
{
    public partial class Car
    {
        
        
        public int IdCar { get; set; }
        public string Name { get; set; }
        public int ProductionYear { get; set; }

        public virtual ICollection<Inspection> Inspections { get; set; }
    }
}
