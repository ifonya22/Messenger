using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Messager : ControllerBase
    {
        // GET: api/<Messager>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "id = " + id.ToString();
        }
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }
        

    }
}