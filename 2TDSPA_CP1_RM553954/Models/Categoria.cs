using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2TDSPA_CP1_RM553954.Models
{
    public class Categoria
    {
        [Required]
        public int Id { get; set; }
        public string NomeCat { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
