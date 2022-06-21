using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APBD_Test2.Entities;

namespace APBD_Test2.DTOs.Responses
{
    public class InspectionResponse
    {
        public Car Car { get; set; }
        public Mechanic mechanic { get; set; }
        public List<ServiceTypeDictInspection> serviceTypeDictInspections { get; set; }
    }
}
