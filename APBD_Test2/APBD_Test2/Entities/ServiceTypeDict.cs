using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Test2.Entities
{
    public partial class ServiceTypeDict
    {
        public int IdServiceType { get; set; }
        public string ServiceType { get; set; }
        public float Price { get; set; }
        public virtual ICollection<ServiceTypeDictInspection> ServiceTypeDictInspections { get; set; }

    }
}
