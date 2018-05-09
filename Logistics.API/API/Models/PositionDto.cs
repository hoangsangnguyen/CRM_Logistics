using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class PositionDto : BaseDto
    {
        [Required(ErrorMessage = "You should provide name")]
        public string name { get; set; }
    }
}
