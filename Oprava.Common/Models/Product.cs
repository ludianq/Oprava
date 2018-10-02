
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oprava.Common.Models
{
    //aqui estan los modelos de la base de datos
    using System;
    using System.ComponentModel.DataAnnotations;
    public  class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Names { get; set; }
        [Required]
        public string Contact { get; set; }
        [Required]
        public string Profesion { get; set; }

        public Decimal Price { get; set; }

        public bool IsAvailable { get; set; }

        public DateTime PublishOn { get; set; }

    }
}
