using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication6.Controllers
{
    [Produces("application/json")]
    [Route("api/Values")]
    [Authorize(ActiveAuthenticationSchemes = "Bearer", Policy = "TestUsers")]
    public class ValuesController : Controller
    {
        [HttpGet("{value}")]
        public IActionResult Get(int value)
        {
            return new ObjectResult(new { Value = value });
        }
    }
}