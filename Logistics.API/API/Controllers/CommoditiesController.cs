using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Models;
using API.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("[controller]")]
   // [Authorize]
    public class CommoditiesController : GenericController<Commodity, CommodityDto, CommodityDto>
    {
        private readonly DatabaseContext _context;
        private readonly ICommodityRepository _commodityRepository;

        public CommoditiesController(ICommodityRepository commodityRepository, DatabaseContext context) : base(commodityRepository, context)
        {
            _commodityRepository = commodityRepository;
            _context = context;
        }
    }
}
