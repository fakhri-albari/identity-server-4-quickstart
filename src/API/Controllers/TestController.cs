using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("test")]
    [Authorize("TestScope")]
    public class TestController: ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Nice Brooo";
        }
    }
}