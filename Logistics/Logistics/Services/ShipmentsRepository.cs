using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logistics.Entities;
using Logistics.Models;

namespace Logistics.Services
{
    public class ShipmentsRepository : GenericRepository<Shipment, ShipmentDto, ShipmentDto>, IShipmentsRepository
    {
        private DatabaseContext _context;

        public ShipmentsRepository(DatabaseContext context) : base(context)
        {
            _context = context;
        }
    }
}
