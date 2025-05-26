using System.Diagnostics;
using APIJugador.Models;
using Entidades;
using Microsoft.AspNetCore.Mvc;

namespace APIJugador.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class JugadorController : ControllerBase
    {
        // GET: api/<JugadorController>
        [HttpGet]
        public IActionResult Get()
        {
            IActionResult salida;
            List<ClsJugador> listadoCompleto = new List<ClsJugador>();
            try
            {
                listadoCompleto = Bl.ClsListadoJugadorBl.obtenerListadoJugadorCompletoBl();
                if (listadoCompleto.Count() == 0)
                {
                    salida = NoContent();
                }
                else
                {
                    salida = Ok(listadoCompleto);
                }
            }
            catch
            {
                salida = BadRequest();
            }
            return salida;

        }


        // POST api/<JugadorController>
        [HttpPost]
        public IActionResult Post([FromBody] ClsJugador jugador)
        {
            IActionResult salida;
            int filasAfectadas = 0;
            try
            {

                filasAfectadas = Bl.ClsManejadoraBl.insertarJugadorBl(jugador);

                if (filasAfectadas == 0)
                {
                    salida = BadRequest("No se pudo insertar el jugador.");
                }
                else
                {
                    salida = Ok("jugador insertado correctamente.");
                }
            }
            catch (Exception ex)
            {
                salida = BadRequest($"Error al insertar: {ex.Message}");
            }

            return salida;
        }
    }
}
