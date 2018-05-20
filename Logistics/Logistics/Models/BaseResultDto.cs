using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Models
{
    public class BaseResultDto
    {
        public bool Success { get; set; }
        public string Message  { get; set; }
        public Object Object { get; set; }
    }
}
