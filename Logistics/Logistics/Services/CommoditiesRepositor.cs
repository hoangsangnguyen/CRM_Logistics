using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logistics.Entities;
using Logistics.Models;

namespace Logistics.Services
{
    public class CommoditiesRepositor : GenericRepository<Commodity, CommodityDto, CommodityDto>, ICommoditiesRepository
    {
        private DatabaseContext _context;

        public CommoditiesRepositor(DatabaseContext context) : base(context)
        {
            _context = context;
        }
    }
}
