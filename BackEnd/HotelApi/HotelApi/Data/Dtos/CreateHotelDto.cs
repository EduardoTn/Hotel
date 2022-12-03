using HotelApi.Model;
using System.ComponentModel.DataAnnotations;

namespace HotelApi.Data.Dtos
{
    public class CreateHotelDto
    {

        [Required]
        public string NomeHotel { get; set; }

        [Required]
        public int QuantidadeQuartos { get; set; }

        [Required]
        public string EnderecoHotel { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Telefone { get; set; }

    }
}
