using BackEndPortafolioTarjeta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using TarjetaCredito.Application.Services;
using TarjetaCredito.Domain.DomainObject;
using TarjetaCredito.Infrastructure;
using TarjetaCredito.Infrastructure.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEndPortafolioTarjeta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarjetaController : ControllerBase
    {
        

        UserCreditCardServices CreateCreditCardService()
        {
            UserCreditCardDbContext _context = new UserCreditCardDbContext();         // Obtengo el Contexto para acceder a la Base de Datos
            UserCreditCardRepository _repo = new UserCreditCardRepository(_context);  // Intancio el Repositorio con el Contexto, Aca estan los Casos de Uso
            UserCreditCardServices _services = new UserCreditCardServices(_repo);     // Intancio el Servicio con el repositorio el cual quiero trabajar en este Controller
            return _services;
        }


        // GET api/Tarjeta/GetTarjetas
        [HttpGet]
        [Route("GetTarjetas")]
        public async Task<IActionResult> GetTarjetas()
        {
            try
            {
                var _service = CreateCreditCardService();
                return Ok(_service.List());

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        // GET api/<TarjetaController>/5
        [HttpGet("{_id}")]
        public ActionResult<UserCreditCard> Get(int _id)
        {
            var _service = CreateCreditCardService();
            return Ok(_service.GetbyID(_id));
        }

        // POST api/<TarjetaController>
        [HttpPost]
        [Route("PostTarjetas")]
        public async Task<IActionResult> Post([FromBody] UserCreditCard _creditCard)
        {
            try
            {
                var _service = CreateCreditCardService();
                return Ok(_service.Add(_creditCard));

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }

        // PUT api/<TarjetaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UserCreditCard _actTarjeta)
        {

            try
            {
                var _service = CreateCreditCardService();
                //_actTarjeta.Id = id;
                _service.Edit(_actTarjeta);
                return Ok("Tarjeta con Id: " + _actTarjeta.Id + "Modificada Satisfactoriamente");

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
                var _service = CreateCreditCardService();
                _service.Delete(id);
                return Ok(new { message = "Tarjeta Eliminada con exito!" });
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }


        }
    }
}
