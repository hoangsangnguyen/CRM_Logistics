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
    public class CarriersController : GenericController<Carrier, CarrierDto, CarrierForCreationDto>
    {
        private readonly DatabaseContext _context;
        private readonly ICarrierRepository _carrierExpRepository;

        public CarriersController(ICarrierRepository carrierExpRepository, DatabaseContext context) : base(carrierExpRepository, context)
        {
            _carrierExpRepository = carrierExpRepository;
            _context = context;
        }

    }
}
