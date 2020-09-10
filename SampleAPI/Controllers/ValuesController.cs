using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SampleAPI.Controllers
{
    [Route("marketdata")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        readonly List<string> Cities = new List<string> { "Hyderabad", "Bangalore" };
        [HttpGet("v1/list")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Cities.ToArray();
        }

        [HttpGet("v1/data")]
        public ActionResult<string> Get(int id)
        {
             string request = Request.Headers["Authorization"];
           if (request !=" ")
           {
                return request;
            }
           else {
               return "Requires authorization header";
           }
        }
    }
}
