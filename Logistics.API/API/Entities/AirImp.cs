using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AirImp : BaseEntity
    {
        [Required]
        public string jobID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime created { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime eta { get; set; }

        public string mawbNumber { get; set; }

        public string flightNumber { get; set; }


        [ForeignKey("commodityId")]
        public virtual Commodity Commodity { get; set; }

        public Nullable<Guid> commodityId { get; set; } = null;

        [ForeignKey("shipmentID")]
        public virtual Shipment shipment { get; set; }
        public Nullable<Guid> shipmentID { get; set; } = null;

        public bool isFinish { get; set; }

        [ForeignKey("opicID")]
        public virtual Contact opic { get; set; }

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

        [Required]
        public int quantity { get; set; }

        [ForeignKey("unitID")]
        public virtual Unit unit { get; set; }
        public Nullable<Guid> unitID { get; set; } = null;

        public double GW { get; set; }
        public double CW { get; set; }

        //[ForeignKey("airlineID")]
        //public virtual Carrier Airlines{ get; set; }
        //public Nullable<Guid> airlineID { get; set; } = null;

        [ForeignKey("agentID")]
        public virtual Carrier agent { get; set; }
        [Required]
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
