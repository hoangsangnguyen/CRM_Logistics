﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Entities
{
    public class Freight : BaseEntity
    {
        [Required]
        public string name { get; set; }
    }
}
