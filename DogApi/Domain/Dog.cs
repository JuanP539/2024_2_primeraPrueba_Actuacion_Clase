﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Dog
    {
        public int Id { get; set; }
        public string Breed { get; set; }
        public string Description { get; set; }
        public bool Hypoalergenic { get; set; }

        public Dog() { }
    }
}
