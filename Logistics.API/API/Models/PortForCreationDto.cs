using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class PortForCreationDto : BaseDto
    {
        [Required]
        public string portName { get; set; }

        [Required]
        public Guid nationalityID { get; set; }

        public Guid zoneID { get; set; }

        [Required]
        public string localZone { get; set; }

        [Required]
        public Guid modeID { get; set; }
    }
}
