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
    public class VesselsController : GenericController<Vessel, VesselDto, VesselDto>
    {
        private readonly DatabaseContext _context;
        private readonly IVesselRepository _vesselRepository;

        public VesselsController(IVesselRepository vesselRepository, DatabaseContext context) : base(vesselRepository, context)
        {
            _vesselRepository = vesselRepository;
            _context = context;
        }

    }
}
