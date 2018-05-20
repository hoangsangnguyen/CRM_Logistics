using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logistics.Entities;
using Logistics.Models;

namespace Logistics.Services
{
    public interface ICommoditiesRepository : IGenericRepository<Commodity, CommodityDto, CommodityDto>
    {
    }
}
