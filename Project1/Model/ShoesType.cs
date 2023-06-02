using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Model
{
    public class ShoesType
    {
       int Id { get; set; }
        ICollection<Shoes>Shoes { get; set; }

    } 
}
