using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSProto.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ContentResult result = new ContentResult { Content = "Test", ContentType = "json", StatusCode = 200 };
            return result;
        }
    }
}
