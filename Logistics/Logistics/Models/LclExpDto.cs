﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Models
{
    public class LclExpDto : BaseDto
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

        public virtual MBLTypeDto MBLType { get; set; }

        public Nullable<Guid> mBLNumberId { get; set; } = null;

        public bool isFinish { get; set; }

        public virtual ContactDto opic { get; set; }

        public Nullable<Guid> opicID { get; set; } = null;

        public virtual VesselDto Vessel { get; set; }

        public Nullable<Guid> vesselId { get; set; } = null;

        public virtual ShipmentDto Shipment { get; set; }

        public Nullable<Guid> shipmentId { get; set; } = null;

        //[ForeignKey("pOLId")]
        //public virtual Port POL { get; set; }

        //public Nullable<Guid> pOLId{ get; set; } = null;

        public double GW { get; set; }
        public double CBM { get; set; }

        public int packages { get; set; }

        public virtual UnitDto unit { get; set; }
        public Nullable<Guid> unitID { get; set; } = null;

        //[ForeignKey("co_loaderId")]
        //public virtual Carrier Co_Loader{ get; set; }

        //public Nullable<Guid> co_loaderId { get; set; } = null;

        public virtual CarrierDto Agent { get; set; }

        public Nullable<Guid> agentId { get; set; } = null;

        public virtual CommodityDto Commodity { get; set; }

        public Nullable<Guid> commodityId { get; set; } = null;

        //[ForeignKey("podId")]
        //public virtual Port POD { get; set; }

        //public Nullable<Guid> podId{ get; set; } = null;

        public virtual FreightDto Freight { get; set; }

        public Nullable<Guid> freightId { get; set; } = null;

        public string notes { get; set; }
    }
}
