using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Vendas")]
    public class Vendas
    {
        [Key]
        [Column("idVenda")]
        [Display(Name ="idVenda")]
        public int idVenda { get; set; }

        [Column("idCliente")]
        [Display(Name = "idCliente")]
        public int idCliente {  get; set; }

        [Column("idProduto")]
        [Display(Name = "idProduto")]
        public int idProduto {  get; set; }

        [Column("qtdVenda")]
        [Display(Name = "qtdVenda")]
        public int qtdVenda { get; set; }

        [Column("vlrUnitarioVenda")]
        [Display(Name = "vlrUnitarioVenda")]
        public decimal vlrUnitarioVenda { get; set; }

        [Column("dthVenda")]
        [Display(Name = "dthVenda")]
        public DateTime dthVenda { get; set; }

    }
}
