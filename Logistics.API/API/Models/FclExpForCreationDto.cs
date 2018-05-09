using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class FclExpForCreationDto : BaseDto
    {
        public string jobID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime created { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime etd { get; set; }

        public string bkgNumber { get; set; }
        public string mBL { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime eta { get; set; }
        public string poNumber { get; set; }

        public Nullable<Guid> mBLNumberId { get; set; } = null;

        public Nullable<Guid> vesselId { get; set; } = null;

        public Nullable<Guid> shipmentId { get; set; } = null;

        //public Nullable<Guid> pOLId{ get; set; } = null;

        public Nullable<Guid> freightId { get; set; } = null;

        public Nullable<Guid> opicID { get; set; } = null;

        public bool isFinish { get; set; }

        //[ForeignKey("sLinesId")]
        //public virtual Carrier SLines { get; set; }

       // public Nullable<Guid> sLinesId { get; set; } = null;

        public Nullable<Guid> agentId { get; set; } = null;

        public Nullable<Guid> commodityId { get; set; } = null;

        //[ForeignKey("podId")]
        //public virtual Port POD { get; set; }

        //public Nullable<Guid> podId{ get; set; } = null;

        public string Service { get; set; }
        public double GW { get; set; }
        public double CBM { get; set; }
        public string notes { get; set; }
    }
}
