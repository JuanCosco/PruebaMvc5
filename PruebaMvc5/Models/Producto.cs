using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace PruebaMvc5.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [DataType(DataType.Currency)]
        public decimal Precio { get; set; }

        public int Stock { get; set; }
    }
}