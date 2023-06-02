using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Model
{
    public class Shoes
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Size { get; set; }

        public int ShoesTypeId { get; set; }
        public ShoesType ShoesTypes { get; set; }
    }
}
