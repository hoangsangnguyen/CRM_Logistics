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

        [Required]
        public string homeAddress { get; set; }

        [Required]
        public string cellPhone { get; set; }

        [Required]
        public string homePhone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required]
        public string company_ext { get; set; }

        [Required]
        public string signature { get; set; }

        public string departmentID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime birthday { get; set; }

        [Required]
        public bool marriageStatus { get; set; }

        [Required]
        public string spouseName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime spouseBirthday { get; set; }

        [Required]
        public string fieldInterested { get; set; }
    }
}
