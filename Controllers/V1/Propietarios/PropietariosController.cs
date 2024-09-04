using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Taller.Data;

namespace Taller.Controllers.V1.Propietarios
{
    [ApiController]
    [Route("api/V1/[controller]")]
    public class PropietariosController : ControllerBase
    {

        private readonly ApplicationDBContext ConexionDB;

        public PropietariosController(ApplicationDBContext connectionDB)
        {
            ConexionDB = connectionDB;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //return Ok("Hola mundo, aquí es mi endpoint");

            // Lees todos los propietarios de la base de datos.
            var PropietariosTraidosDeDB = await ConexionDB.Propietarios.ToListAsync();
            return Ok(PropietariosTraidosDeDB);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            // Busca un propietario por su id.
            var PropietarioTraidoDeDB = await ConexionDB.Propietarios.FindAsync(id);

            // Si el propietario no existe, devuelve un mensaje de error.
            if (PropietarioTraidoDeDB == null)
            {
                return NotFound($"No se encontró un propietario con id: {id}");
            }

            // Devuelve el propietario.
            return Ok(PropietarioTraidoDeDB);
        }

        [HttpGet("by-name/{name}")]
        public async Task<IActionResult> GetByName(string name)  // Nombre del propietario como parámetro.
        {
            // Busca un propietario por su nombre.
            var PropietarioTraidoDeDB = await ConexionDB.Propietarios.FirstOrDefaultAsync(p => p.Nombre.ToLower() == name.ToLower());

            // Si el propietario no existe, devuelve un mensaje de error.
            if (PropietarioTraidoDeDB == null)
            {
                return NotFound($"No se encontró un propietario con nombre: {name}");
            }

            // Devuelve el propietario.
            return Ok(PropietarioTraidoDeDB);
        }

        // Metodo que trae a todos los propietarios que empiecen con la letra J
        // [HttpGet("FindByInitial{initial}")]
    }
}