using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class FclExp : BaseEntity
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
        public DateTime etd { get; set; }

        public string bkgNumber { get; set; }
        public string mBL { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime eta { get; set; }
        public string poNumber { get; set; }

        [ForeignKey("mMLNumberId")]
        public virtual MBLType MBLType { get; set; }

        public Nullable<Guid> mBLNumberId { get; set; } = null;

        [ForeignKey("vesselId")]
        public virtual Vessel Vessel { get; set; }

        public Nullable<Guid> vesselId { get; set; } = null;

        [ForeignKey("shipmentId")]
        public virtual Shipment Shipment { get; set; }

        public Nullable<Guid> shipmentId { get; set; } = null;

        //[ForeignKey("pOLId")]
        //public virtual Port POL { get; set; }

        //public Nullable<Guid> pOLId{ get; set; } = null;

        [ForeignKey("freightId")]
        public virtual Freight Freight { get; set; }

        public Nullable<Guid> freightId { get; set; } = null;

        [ForeignKey("opicID")]
        public virtual Contact opic { get; set; }

        public Nullable<Guid> opicID { get; set; } = null;

        public bool isFinish { get; set; }

        //[ForeignKey("sLinesId")]
        //public virtual Carrier SLines { get; set; }

        //public Nullable<Guid> sLinesId { get; set; } = null;

        [ForeignKey("agentId")]
        public virtual Carrier Agent { get; set; }

        public Nullable<Guid> agentId { get; set; } = null;

        [ForeignKey("commodityId")]
        public virtual Commodity Commodity { get; set; }

        public Nullable<Guid> commodityId { get; set; } = null;

        //[ForeignKey("podId")]
        //public virtual Port POD { get; set; }

        //public Nullable<Guid> podId{ get; set; } = null;

        public string Service { get; set; }
        public double GW { get; set; }
        public double CBM { get; set; }
        public string notes  { get; set; }
    }
}
