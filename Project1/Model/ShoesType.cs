﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Model
{
    public class ShoesType
    {
       public int Id { get; set; }
       public ICollection<Shoes>Shoes { get; set; }

    } 
}
