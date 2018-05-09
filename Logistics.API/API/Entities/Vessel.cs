using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Vessel : BaseEntity
    {
        [Required]
        public string name { get; set; }
    }
}
