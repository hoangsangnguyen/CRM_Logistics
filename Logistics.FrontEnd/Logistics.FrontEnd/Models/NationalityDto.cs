using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.FrontEnd.Models

{
    public class NationalityDto : BaseDto
    {
        [Required(ErrorMessage = "You should provide name")]
        public string name { get; set; }
    }
}
