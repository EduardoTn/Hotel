using System.ComponentModel.DataAnnotations;

namespace HotelApi.Data.Dtos
{
    public class CreateQuartoDto
    {
        [Required]
        public string NomeQuarto { get; set; }

        [Required]
        public int NumeroQuarto { get; set; }

        public long HotelPessoaJuridicaId { get; set; }
    }
}
