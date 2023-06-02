using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Model
{
    public class ShoesDbContext:DbContext
    {
        public ShoesDbContext(): base ("ShoesContext")
        {

        }
        DbSet<Shoes> Shoes { get; set; }
        DbSet<ShoesType> ShoesType { get; set; }
    }
}
