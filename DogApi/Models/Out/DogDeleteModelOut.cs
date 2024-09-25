﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Out
{
    public class DogDeleteModelOut
    {
        public string Breed { get; set; }
        public string Description { get; set; }
        public bool Hypoalergenic { get; set; }

        public DogDeleteModelOut() { }

        public DogDeleteModelOut(Dog dog) 
        {
            Breed = dog.Breed;
            Description = dog.Description;
            Hypoalergenic = dog.Hypoalergenic;
        }
    }
}
