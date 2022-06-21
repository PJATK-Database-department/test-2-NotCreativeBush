using APBD_Test2.DTOs.Requests;
using APBD_Test2.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APBD_Test2.Contexts;
namespace APBD_Test2.Services
{
    public class InspectionDbService : IDbService
    {
        InspectionDbContext context;
        public InspectionDbService(InspectionDbContext _context)
        {
            context = _context;
        }
        public bool ChangeCarToInspection(ChangeCarToInspectionRequest request)
        {
            throw new NotImplementedException();
        }

        public InspectionResponse GetInspectionList(int id)
        {
            if (context.Inspections.Where(i => i.IdInspection == id).ToList.Count() < 1)
            {
                return InspectionResponse;
            }
        }
    }
}
