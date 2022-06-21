using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Test2.Entities
{
    public partial class ServiceTypeDictInspection
    {
        public virtual ServiceTypeDict ServiceType { get; set; }
        public virtual Inspection Inspection { get; set; }
        public string Comments { get; set; }
    }
}
