using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.FrontEnd.Models
{
    public class AirExpDto : BaseDto
    {
        [Required]
        public string JobID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime created { get; set; }

        public string service { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime etd { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime eta { get; set; }


        public virtual CommodityDto Commodity { get; set; }

        public Nullable<Guid> commodityId { get; set; } = null;

        public string mawbNumber { get; set; }

        public virtual TypeOfBillDto TypeOfBill { get; set; }

        public Nullable<Guid> typeOfBillId { get; set; } = null;

        public string flightNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime flyDate { get; set; }

        public virtual ContactDto opic { get; set; }

        public Nullable<Guid> opicID { get; set; } = null;

        public virtual ShipmentDto shipment { get; set; }
        public Nullable<Guid> shipmentID { get; set; } = null;

        public bool isFinish { get; set; }

        //[ForeignKey("originPortID")]
        //public virtual Port originPort { get; set; }
        //[Required]
        //public string originPortID { get; set; }

        //[ForeignKey("transitPortID")]
        //public virtual Port transitPort{ get; set; }
        //[Required]
        //public string transitPortID { get; set; }

        [Required]
        public int quantity { get; set; }

        public virtual UnitDto unit { get; set; }
        public Nullable<Guid> unitID { get; set; } = null;

        public virtual PaymentDto payment { get; set; }
        public Nullable<Guid> paymentID { get; set; } = null;

        public virtual CarrierDto carrier { get; set; }
        public Nullable<Guid> carrierID { get; set; } = null;

        //public virtual Carrier agent { get; set; }
        //[Required]
        //public string agentID { get; set; }

        //[ForeignKey("destinationID")]
        //public virtual Port destination { get; set; }
        //[Required]
        //public string destinationID { get; set; }
        public string notes { get; set; }

    }
}
