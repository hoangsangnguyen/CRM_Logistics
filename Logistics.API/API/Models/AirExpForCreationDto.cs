using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class AirExpForCreationDto : BaseDto
    {
        [Required(ErrorMessage = "You should provide jobId")]
        public string JobID { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime created { get; set; }

        public string service { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime etd { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime eta { get; set; }

        public Nullable<Guid> commodityId { get; set; } = null;

        public string mawbNumber { get; set; }

        public Nullable<Guid> typeOfBillId { get; set; } = null;

        public string flightNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime flyDate { get; set; }

        public Nullable<Guid> opicID { get; set; } = null;

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

        public Nullable<Guid> unitID { get; set; } = null;

        public Nullable<Guid> paymentID { get; set; } = null;
        public bool isFinish { get; set; }

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
