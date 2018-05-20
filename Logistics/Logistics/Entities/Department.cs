using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logistics.Entities
{
    public class Department : BaseEntity
    {
        [StringLength(50)]
        public string _key { get; set; }

        [Required]
        public string name { get; set; }
    }
}
