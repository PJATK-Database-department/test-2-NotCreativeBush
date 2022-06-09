using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APBD_Test2.Services;
using APBD_Test2.DTOs.Requests;
namespace APBD_Test2.Controllers
{
    [Route("api/inspection")]
    [ApiController]
    public class InspectionController : ControllerBase
    {
        private readonly IDbService dbService;
        public InspectionController(IDbService inspectionDbService)
        {
            dbService = inspectionDbService;
        }

        [HttpGet("{id}")]
        public IActionResult GetInspectionList(int Id)
        {
            try
            {
                return Ok(dbService.GetInspectionList(Id));
            }catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPut]
        public IActionResult ChangeCarToInspection(ChangeCarToInspectionRequest request)
        {
            bool result = dbService.ChangeCarToInspection(request);
            if (result == false)
            {
                return BadRequest("Bad Request");
            }
            return Ok("Car changed");
        }
    }
}
