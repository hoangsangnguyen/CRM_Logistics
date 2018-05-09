using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Models;
using API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("[controller]")]
    //[Authorize]
    public class AirExpsController : GenericController<AirExp, AirExpDto, AirExpForCreationDto>
    {
        private readonly DatabaseContext _context;
        private readonly IAirExpRepository _airExpRepository;

        public AirExpsController(IAirExpRepository airExpRepository, DatabaseContext context) : base(airExpRepository, context)
        {
            _airExpRepository = airExpRepository;
            _context = context;
        }

    }
}
