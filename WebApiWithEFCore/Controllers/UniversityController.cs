using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithEFCore.Infrastructure;
using WebApiWithEFCore.Model;
using WebApiWithEFCore.Services;

namespace WebApiWithEFCore.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UniversityController : ControllerBase
    {
        private readonly StudentContext studentContext;

        public UniversityController(StudentContext studentContext)
        {
            this.studentContext = studentContext;
        }
        [HttpPost]
        public IActionResult SaveUniversity(University university)
        {
            try
            {
                var Response = new UniversityService(studentContext).SaveUniversity(university);
                if (Response)
                {
                    return Ok("University Saved!!!");
                }
                return NoContent();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


        public IActionResult GetUniversities()
        {
            try
            {
                var Data = new UniversityService(studentContext).GetUniversities();
                if (Data != null)
                {
                    return Ok(Data);
                }
                return NotFound();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
