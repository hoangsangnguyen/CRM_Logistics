using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logistics.Entities;
using Logistics.Models;

namespace Logistics.Services
{
    public class PositionsRepository : GenericRepository<Position, PositionDto, PositionDto>, IPositionsRepository
    {
        private DatabaseContext _context;

        public PositionsRepository(DatabaseContext context) : base(context)
        {
            _context = context;
        }
    }
}
