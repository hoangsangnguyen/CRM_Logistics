using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Entities
{
    public class LclExp : BaseEntity
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


        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime eta { get; set; }

        public string bkgNumber { get; set; }

        public string mBL { get; set; }

        [ForeignKey("mMLNumberId")]
        public virtual MBLType MBLType { get; set; }

        public Nullable<Guid> mBLNumberId { get; set; } = null;

        public bool isFinish { get; set; }

        [ForeignKey("opicID")]
        public virtual Contact opic { get; set; }

        public Nullable<Guid> opicID { get; set; } = null;

        [ForeignKey("vesselId")]
        public virtual Vessel Vessel { get; set; }

        public Nullable<Guid> vesselId { get; set; } = null;

        [ForeignKey("shipmentId")]
        public virtual Shipment Shipment { get; set; }

        public Nullable<Guid> shipmentId { get; set; } = null;

        //[ForeignKey("pOLId")]
        //public virtual Port POL { get; set; }

        //public Nullable<Guid> pOLId{ get; set; } = null;

        public double GW { get; set; }
        public double CBM { get; set; }

        public int packages { get; set; }

        [ForeignKey("unitID")]
        public virtual Unit unit { get; set; }
        public Nullable<Guid> unitID { get; set; } = null;

        //[ForeignKey("co_loaderId")]
        //public virtual Carrier Co_Loader{ get; set; }

        //public Nullable<Guid> co_loaderId { get; set; } = null;

        [ForeignKey("agentId")]
        public virtual Carrier Agent { get; set; }

        public Nullable<Guid> agentId { get; set; } = null;

        [ForeignKey("commodityId")]
        public virtual Commodity Commodity { get; set; }

        public Nullable<Guid> commodityId { get; set; } = null;

        //[ForeignKey("podId")]
        //public virtual Port POD { get; set; }

        //public Nullable<Guid> podId{ get; set; } = null;

        [ForeignKey("freightId")]
        public virtual Freight Freight { get; set; }

        public Nullable<Guid> freightId { get; set; } = null;

        public string notes { get; set; }

    }
}
