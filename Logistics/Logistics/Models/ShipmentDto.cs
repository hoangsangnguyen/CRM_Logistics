﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Models
{
    public class ShipmentDto : BaseDto
    {
        [Required]
        public string name { get; set; }
    }
}
