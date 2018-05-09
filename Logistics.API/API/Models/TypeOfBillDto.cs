using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class TypeOfBillDto : BaseDto
    {
        public string name { get; set; }
    }
}
