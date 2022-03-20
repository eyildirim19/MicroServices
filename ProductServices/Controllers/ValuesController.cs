using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        string[] ogrenciler = { "Serhat", "Furkan", "Bahar", "Semiha", "Suna" };
        public ActionResult Get()
        {
            return Ok(ogrenciler);
        }
    }
}
