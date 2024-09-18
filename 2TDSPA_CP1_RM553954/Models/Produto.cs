using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2TDSPA_CP1_RM553954.Models
{
    public class Produto
    {
        [Required]
        public int Id { get; set; }
        public string NomeProd { get; set; }
        public decimal PrecoProd { get; set; }
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
    }
}
