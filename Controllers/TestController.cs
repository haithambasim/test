using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace testapp.Controllers
{
    public class TestInput
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // POST api/<TestController>
        [HttpPost]
        [Consumes("application/x-www-form-urlencoded")]
        public TestInput Post([FromForm] TestInput value)
        {
            return value;
        }
    }
}
