using BackEndPortafolioTarjeta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEndPortafolioTarjeta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarjetaController : ControllerBase
    {
        //Coloco este atributo private y readonly
        private readonly ApplicationDbContext _context;

        //Igualo la instanciasion anterior a la nueva declarada
        public TarjetaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET api/Tarjeta/GetTarjetas
        [HttpGet]
        [Route("GetTarjetas")]
        public async Task<IActionResult> GetTarjetas()
        {
            try
            {
                var tarjetas = await _context.TarjetaCredito.ToListAsync();
                return Ok(tarjetas);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        // GET api/<TarjetaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TarjetaController>
        [HttpPost]
        [Route("PostTarjetas")]
        public async Task<IActionResult> Post([FromBody] TarjetaCredito _tarjetaEnviada)
        {
            try
            {
                _context.Add(_tarjetaEnviada);
                await _context.SaveChangesAsync();
                return Ok(_tarjetaEnviada);

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }

        // PUT api/<TarjetaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] TarjetaCredito _actTarjeta)
        {

            try
            {
                if (id != _actTarjeta.id)
                {
                    return NotFound();
                }

                _context.Update(_actTarjeta);
                await _context.SaveChangesAsync();
                return Ok( new {message = "Tarjeta Actualizada!"});

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }


        }

        // DELETE api/<TarjetaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            try
            {
                var findTarjeta = await _context.TarjetaCredito.FindAsync(id);

                if (findTarjeta == null)
                {
                    return NotFound();
                }
                _context.TarjetaCredito.Remove(findTarjeta);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Tarjeta Eliminada con exito!" });
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }


        }
    }
}
