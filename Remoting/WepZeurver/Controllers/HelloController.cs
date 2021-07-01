using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepZeurver.Controllers
{
    [Route("hello")]
    public class HelloController : ControllerBase
    {
        [Route("index/{nummer}")]
        [HttpGet]
        public IActionResult Index(int nummer)
        {
            return Content($"Hello: {nummer}");
        }
    }
}
