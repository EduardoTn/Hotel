using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApi.Model
{
    public class HotelPessoaJuridica
    {

        [Key]
        [Required]
        public long Id { get; set; }

        [Required]
        public string NomeHotel { get; set; }

        [Required]
        public int QuantidadeQuartos { get; set; }

        [Required]
        public string EnderecoHotel { get; set; }

        [Required]
        public string Email { get; set;}

        [Required]  
        public string Telefone { get; set;}

        public virtual ICollection<Quarto>? Quartos { get; set; }
    }
}
