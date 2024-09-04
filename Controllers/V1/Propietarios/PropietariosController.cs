using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Taller.Controllers.V1.Propietarios
{
    [ApiController]
    [Route("api/[controller]")]
    public class PropietariosController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Hola mundo, aquí es mi endpoint");
        }
    }
}