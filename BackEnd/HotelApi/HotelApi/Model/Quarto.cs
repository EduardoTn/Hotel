using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApi.Model
{
    public class Quarto
    {
        [Key]
        [Required]
        public long Id { get; set; }

        [Required]
        public string NomeQuarto { get; set; }

        [Required]  
        public int NumeroQuarto { get; set; }

        public long HotelPessoaJuridicaId { get; set; }

        [ForeignKey(nameof(HotelPessoaJuridicaId))]
        public virtual HotelPessoaJuridica? HotelPessoaJuridica { get; set; }
    }
}
