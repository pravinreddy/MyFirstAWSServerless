using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstAWSServerless.Services;

namespace MyFirstAWSServerless.Controllers
{
    [Route("home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ITestService _testService;

        public HomeController(ITestService testService)
        {
            _testService = testService;
        }

        [HttpGet]
        [Route("test")]
        public IActionResult Test()
        {
            var result = _testService.GetTestResponse();
            return Ok(result);
        }
    }
}
