using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logistics.Entities;
using Logistics.Models;
using Microsoft.AspNetCore.Identity;

namespace Logistics.Services
{
    public class AirexpsRepository : GenericRepository<AirExp, AirExpDto, AirExpForCreationDto>, IAirexpsRepository
    {
        private DatabaseContext _context;

        public AirexpsRepository(DatabaseContext context) : base(context)
        {
            _context = context;
        }
    }
}
