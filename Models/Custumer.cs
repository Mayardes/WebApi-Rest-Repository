﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi_rest_repository.Models
{
    public class Custumer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Product Product { get; set; }
    }
}
