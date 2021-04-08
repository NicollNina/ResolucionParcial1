using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecuperacionNicollNina.Models
{
    public class Product
    {
        [Key]
        [Range(1,9999, ErrorMessage = "Ingrese un número entre 1 a 9999")]
        public int ProductId { get; set; }
        [Required]
        [StringLength(30,MinimumLength =3)]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime LastBuy { get; set; }
    }
}