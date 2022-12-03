using HotelApi.Data;
using HotelApi.Data.Dtos;
using HotelApi.Model;
using HotelApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HotelApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HotelController : ControllerBase
    {

        private readonly IRepository<HotelPessoaJuridica> _hotelRepository;

        public HotelController(IRepository<HotelPessoaJuridica> context)
        {
            _hotelRepository = context;
        }

        [HttpPost]
        public IActionResult AdicionaHotel([FromBody] CreateHotelDto createHotelDto)
        {
            HotelPessoaJuridica hotelPessoaJuridica = new HotelPessoaJuridica
            {
                NomeHotel = createHotelDto.NomeHotel,
                QuantidadeQuartos = createHotelDto.QuantidadeQuartos,
                EnderecoHotel = createHotelDto.EnderecoHotel,
                Email = createHotelDto.Email,
                Telefone = createHotelDto.Telefone
            };

            var HotelCreate = _hotelRepository.Create(hotelPessoaJuridica);
            if (!HotelCreate)
            {
                return NotFound();
            }

            return CreatedAtAction(nameof(RecuperaHotelPorId), new { Id = hotelPessoaJuridica.Id }, hotelPessoaJuridica);
        }

        [HttpGet]
        public IEnumerable<object> RecuperaHotel()
        {
            return _hotelRepository.GetAll();

        }

        [HttpGet("{id}")]
        public IActionResult RecuperaHotelPorId(long id) 
        {
            var HotelGetId = _hotelRepository.GetIdObject(id);
            if(HotelGetId != null)
            {
                return Ok(HotelGetId);
            }

            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id) 
        {
            var hotelDelete = _hotelRepository.Delete(id);
            if (!hotelDelete)
            {
                return NotFound();
            }

            return NoContent();         
        }
    }
}
