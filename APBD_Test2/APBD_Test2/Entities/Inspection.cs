using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Test2.Entities
{
    public partial class Inspection
    {
        public int IdInspection { get; set; }
        public int IdCar { get; set; }
        public virtual Car Car { get; set; }
        public int IdMechanic { get; set; }
        public virtual Mechanic Mechanic { get; set; }
        public DateTime InspectionDate { get; set; }
     

        public string Comment { get; set; }

        public virtual ICollection<ServiceTypeDictInspection> ServiceTypeDictInspections { get; set; }
    }
}
