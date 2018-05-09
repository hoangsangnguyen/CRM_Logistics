using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class DepartmentDto : BaseDto
    {
        [StringLength(50)]
        public string _key { get; set; }

        [Required]
        public string name { get; set; }
    }
}
