using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oprava.Domain.Models
{
    using System.Data.Entity;
    public  class DataContext : DbContext
    {

        //Constructor de la base de datos
        public DataContext() : base("DefaultConnection")
        {
                
        }

        public System.Data.Entity.DbSet<Oprava.Common.Models.Product> Products { get; set; }
    }
}
