using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Entities
{
    public class AirExp : BaseEntity
    {
        [Required]
        public string JobID { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "MM/dd/yyyy", ApplyFormatInEditMode = true)]
        public DateTime created { get; set; }

        public string service { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime etd { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "MM/dd/yyyy", ApplyFormatInEditMode = true)]
        public DateTime eta { get; set; }

        [ForeignKey("commodityId")]
        public virtual Commodity Commodity { get; set; }

        public Nullable<Guid> commodityId { get; set; } = null;

        public string mawbNumber { get; set; }

        [ForeignKey("typeOfBill")]
        public virtual TypeOfBill TypeOfBill { get; set; }

        public Nullable<Guid> typeOfBillId { get; set; } = null;

        public string flightNumber { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime flyDate { get; set; }

        [ForeignKey("opicID")]
        public virtual Contact opic { get; set; }

        public Nullable<Guid> opicID { get; set; } = null;

        [ForeignKey("shipmentID")]
        public virtual Shipment shipment { get; set; }
        public Nullable<Guid> shipmentID { get; set; } = null;

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

        [ForeignKey("unitID")]
        public virtual Unit unit { get; set; }
        public Nullable<Guid> unitID { get; set; } = null;

        [ForeignKey("paymentID")]
        public virtual Payment payment { get; set; }
        public Nullable<Guid> paymentID { get; set; } = null;

        [Required]
        public bool isFinish { get; set; }

        [ForeignKey("carrierID")]
        public virtual Carrier carrier { get; set; }
        public Nullable<Guid> carrierID { get; set; } = null;

        //public virtual Carrier agent { get; set; }
        //[Required]
        //public string agentID { get; set; }

        //[ForeignKey("destinationID")]
        //public virtual Port destination { get; set; }
        //[Required]
        //public string destinationID { get; set; }

        [Required]
        public string notes { get; set; }

    }
}
