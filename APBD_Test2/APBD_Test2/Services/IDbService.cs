using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APBD_Test2.Entities;
using APBD_Test2.DTOs.Responses;
using APBD_Test2.DTOs.Requests;
namespace APBD_Test2.Services
{
    public interface IDbService
    {
        public InspectionResponse GetInspectionList(int id);
        public bool ChangeCarToInspection(ChangeCarToInspectionRequest request);
    }
}
