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
    public class PortsController : GenericController<Port, PortDto, PortForCreationDto>
    {
        private readonly DatabaseContext _context;
        private readonly IPortRepository _portExpRepository;

        public PortsController(IPortRepository portExpRepository, DatabaseContext context) : base(portExpRepository, context)
        {
            _portExpRepository = portExpRepository;
            _context = context;
        }

    }
}
