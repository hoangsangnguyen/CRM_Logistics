using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class ExpressDto : BaseDto
    {
        public string jobID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime etd { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime eta { get; set; }

        //[ForeignKey("originPortID")]
        //public virtual Port originPort { get; set; }
        //[Required]
        //public Nullable<Guid> originPortID { get; set; }

        //[ForeignKey("destinationID")]
        //public virtual Port destination { get; set; }
        //[Required]
        //public Nullable<Guid> destinationID { get; set; }

        public string mawbNumber { get; set; }
        public string flightNumber { get; set; }

        public virtual ContactDto opic { get; set; }

        public Nullable<Guid> opicID { get; set; } = null;

        public string service { get; set; }

        public virtual CommodityDto Commodity { get; set; }

        public Nullable<Guid> commodityId { get; set; } = null;

        public int quantity { get; set; }

        public virtual UnitDto unit { get; set; }
        public Nullable<Guid> unitID { get; set; } = null;

        public double GW { get; set; }
        public double CW { get; set; }

        //[ForeignKey("carrierID")]
        //public virtual Carrier vendor { get; set; }
        //[Required]
        //public Nullable<Guid> vendorID { get; set; }

        public virtual CarrierDto carrier { get; set; }
        public Nullable<Guid> carrierID { get; set; } = null;

        public string notes { get; set; }
    }
}
