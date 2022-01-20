using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DemoValidatorCustom.Shared.Models;

namespace DemoValidatorCustom.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        readonly List<string> useNameList = new();

        public StudentController()
        {
            useNameList.Add("ankit");
            useNameList.Add("Chi");
            useNameList.Add("Hanh");
        }

        [HttpPost]
        public IActionResult Post(StudentRegistration registrationData)
        {
            if (useNameList.Contains(registrationData.Username.ToLower()))
            {
                ModelState.AddModelError(nameof(registrationData.Username), "This user name is not availble.");
                return BadRequest(ModelState);
            }
            else
            {
                return Ok(ModelState);
            }
        }
    }
}
