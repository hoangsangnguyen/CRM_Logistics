﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class AirImpForCreationDto : BaseDto
    {
        public string jobID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime created { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime eta { get; set; }

        public string mawbNumber { get; set; }

        public string flightNumber { get; set; }


        public Nullable<Guid> commodityId { get; set; } = null;

        public Nullable<Guid> shipmentID { get; set; } = null;

        public bool isFinish { get; set; }


        public Nullable<Guid> opicID { get; set; } = null;

        public string service { get; set; }

        //[ForeignKey("aOLID")]
        //public virtual Port AOL { get; set; }
        //[Required]
        //public string aOLID { get; set; }

        //[ForeignKey("deliveryID")]
        //public virtual Port Delivery { get; set; }
        //[Required]
        //public string deliveryID { get; set; }

        public int quantity { get; set; }

        public Nullable<Guid> unitID { get; set; } = null;

        public double GW { get; set; }
        public double CW { get; set; }

        //[ForeignKey("airlineID")]
        //public virtual Carrier Airlines{ get; set; }
        //public Nullable<Guid> airlineID { get; set; } = null;

        public Nullable<Guid> agentID { get; set; } = null;

        //[ForeignKey("aODID")]
        //public virtual Port AOD { get; set; }
        //[Required]
        //public Nullable<Guid> aODID { get; set; }

        public string Routing { get; set; }
        public string SCN { get; set; }
        public string notes { get; set; }
    }
}
