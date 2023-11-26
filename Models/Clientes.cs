using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Clientes")]
    public class Clientes
    {
        [Key]
        [Column("idCliente")]
        [Display(Name = "idCliente")]
        public int idCliente { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Column("Cidade")]
        [Display(Name = "Cidade")]
        public string cidade { get; set; }
    }
}
