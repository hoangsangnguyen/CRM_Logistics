using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Models
{
    public class PaymentDto : BaseDto
    {
        [Required(ErrorMessage ="You should provide payment")]
        public string name { get; set; }
    }
}
