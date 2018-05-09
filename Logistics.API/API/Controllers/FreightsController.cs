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
    public class FreightsController : GenericController<Freight, FreightDto, FreightDto>
    {
        private readonly DatabaseContext _context;
        private readonly IFreightRepository _freightRepository;

        public FreightsController(IFreightRepository freightRepository, DatabaseContext context) : base(freightRepository, context)
        {
            _freightRepository = freightRepository;
            _context = context;
        }

    }
}
