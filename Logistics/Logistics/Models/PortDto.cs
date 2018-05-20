using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Models
{
    public class PortDto : BaseDto
    {
        [Required]
        public string portName { get; set; }

        public virtual NationalityDto nationality { get; set; }

        [Required]
        public Guid nationalityID { get; set; }

        public virtual ZoneDto zone { get; set; }

        public Guid zoneID { get; set; }

        [Required]
        public string localZone { get; set; }

        public virtual ModeDto mode { get; set; }

        [Required]
        public Guid modeID { get; set; }
    }
}
