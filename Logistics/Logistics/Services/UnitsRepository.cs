using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logistics.Entities;
using Logistics.Models;

namespace Logistics.Services
{
    public class UnitsRepository : GenericRepository<Unit, UnitDto, UnitDto>, IUnitsRepository
    {
        private DatabaseContext _context;

        public UnitsRepository(DatabaseContext context) : base(context)
        {
            _context = context;
        }
    }
}
