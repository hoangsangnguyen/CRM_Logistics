﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.FrontEnd.Models

{
    public class CarrierForCreationDto : BaseDto
    {
        [Required(ErrorMessage = "You should provide name")]
        public string name { get; set; }

        [Required(ErrorMessage = "You should provide full English name")]
        public string fullName_EN { get; set; }

        public string Contact { get; set; }

        public string Cell { get; set; }

        public Guid countryID { get; set; }
    }
}
