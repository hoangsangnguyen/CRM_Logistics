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
    public class ExpressController : GenericController<Express, ExpressDto, ExpressForCreationDto>
    {
        private readonly DatabaseContext _context;
        private readonly IExpressRepository _expressRepository;

        public ExpressController(IExpressRepository expressRepository, DatabaseContext context) : base(expressRepository, context)
        {
            _expressRepository = expressRepository;
            _context = context;
        }

    }
}
