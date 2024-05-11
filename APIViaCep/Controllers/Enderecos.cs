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

        [Column("Cep")]
        [Display(Name = "Cep")]
        public string Cep { get; set; }

        [Column("Logradouro")]
        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }

        [Column("Complemento")]
        [Display(Name = "Complemento")]
        public string? Complemento { get; set; }

        [Column("Bairro")]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Column("Cidade")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Column("Uf")]
        [Display(Name = "Uf")]
        public string Uf { get; set; }


        [Column("Numero")]
        [Display(Name = "Numero")]
        public string Numero { get; set; }


    }

}
