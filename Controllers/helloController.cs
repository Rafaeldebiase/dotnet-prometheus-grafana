using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace prometheusPoc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public string GetHello()
        {
            return "koeeeeeeee";
        }

        [HttpGet("hello")]
        public string GetHelloHello()
        {
            return "iaaaaaaaaaaaaaaaaa";
        }
    }
}