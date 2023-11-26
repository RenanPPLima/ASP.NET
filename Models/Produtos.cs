using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Produtos")]
    public class Produtos
    {
        [Key]
        [Column("idProduto")]
        [Display(Name = "idProduto")]
        public int idProduto { get; set; }

        [Column("dscProduto")]
        [Display(Name = "dscProduto")]
        public required string dscProduto { get; set; }

        [Column("vlrUnitario")]
        [Display(Name = "vlrUnitario")]
        public float vlrUnitario { get; set; }
    }
}
