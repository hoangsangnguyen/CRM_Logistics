using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Entities
{
    public class Carrier : BaseEntity
    {
        [Required]
        public string name { get; set; }

        [Required]
        public string fullName_EN { get; set; }

        public string Contact { get; set; }

        public string Cell { get; set; }

        [ForeignKey("countryID")]
        public virtual Nationality country { get; set; }
        [Required]
        public Guid countryID { get; set; }
    }
}
