using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preparing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandController: ControllerBase
    {
       [HttpGet]
       public ActionResult<IEnumerable<string>> Get() {
            return new string[] { "this", "is", "hard", "coded" };
        }
    }
}
