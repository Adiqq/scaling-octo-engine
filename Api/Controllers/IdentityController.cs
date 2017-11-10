using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("final/[controller]")]
    [Authorize]
    public class IdentityController : Controller
    {
            [HttpGet]
            public IActionResult Get()
            {
                return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
            }
       
    }
}