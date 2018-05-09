using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Port : BaseEntity
    {
        [Required]
        public string portName { get; set; }

        [ForeignKey("nationalityID")]
        public virtual Nationality nationality { get; set; }

        [Required]
        public Guid nationalityID { get; set; }

        [ForeignKey("zoneID")]
        public virtual Zone zone { get; set; }

        [Required]
        public Guid zoneID { get; set; }

        [Required]
        public string localZone { get; set; }

        [ForeignKey("modeID")]
        public virtual Mode mode { get; set; }

        [Required]
        public Guid modeID { get; set; }
    }
}
