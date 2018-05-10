using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class ContactForCreationDto : BaseDto
    {
        [Required]
        [MaxLength(50)]
        public string contactID { get; set; }

        [Required]
        [MaxLength(50)]
        public string firstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string lastName { get; set; }

        [Required]
        [MaxLength(50)]
        public string englishName { get; set; }

        public Guid positionID { get; set; }

        public string homeAddress { get; set; }

        public string cellPhone { get; set; }

        public string homePhone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        public string company_ext { get; set; }

        public string signature { get; set; }

        public string departmentID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime birthday { get; set; }

        public bool marriageStatus { get; set; }

        public string spouseName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime spouseBirthday { get; set; }

        public string fieldInterested { get; set; }
    }
}
