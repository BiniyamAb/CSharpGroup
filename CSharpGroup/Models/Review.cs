﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpGroup.Models
{
    public class Review
    {

        public int Id { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public int OrderId { get; set; }

        public Order Order { get; set; }

    }
}
