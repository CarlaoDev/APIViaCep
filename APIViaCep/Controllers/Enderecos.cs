using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIViaCep.Controllers
{
    [Table("Enderecos")]
    public class Enderecos
    {
        [Column("Id")]
        [Display(Name="Codigo" )]
        public int Id {  get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }

}
