using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebApiAspNetCore.Controllers.v2
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("2.0");
        }
    }
}
