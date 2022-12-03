using HotelApi.Data.Dtos;
using HotelApi.Model;
using HotelApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuartoController : ControllerBase
    {
        private readonly IRepository<Quarto> _quartoRepository;

        public QuartoController(IRepository<Quarto> context)
        {
            _quartoRepository = context;
        }

        [HttpPost]
        public IActionResult AdicionaHotel([FromBody] CreateQuartoDto quartoDto)
        {
            Quarto quarto = new Quarto
            {
                NomeQuarto = quartoDto.NomeQuarto,
                NumeroQuarto = quartoDto.NumeroQuarto,
                HotelPessoaJuridicaId = quartoDto.HotelPessoaJuridicaId
            };

            var QuartolCreate = _quartoRepository.Create(quarto);
            if (!QuartolCreate)
            {
                return NotFound();
            }

            return CreatedAtAction(nameof(RecuperaQuartoPorId), new { Id = quarto.Id }, quarto);
        }

        [HttpGet]
        public IEnumerable<object> RecuperaHotel()
        {
            return _quartoRepository.GetAll();

        }

        [HttpGet("{id}")]
        public IActionResult RecuperaQuartoPorId(long id)
        {
            var QuartoGetId = _quartoRepository.GetIdObject(id);
            if (QuartoGetId != null)
            {
                return Ok(QuartoGetId);
            }

            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var QuartolDelete = _quartoRepository.Delete(id);
            if (!QuartolDelete)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
