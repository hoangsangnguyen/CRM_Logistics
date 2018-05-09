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
    public class FclExpsController : GenericController<FclExp, FclExpDto, FclExpForCreationDto>
    {
        private readonly DatabaseContext _context;
        private readonly IFclExpRepository _fclExpRepository;

        public FclExpsController(IFclExpRepository fclExpRepository, DatabaseContext context) : base(fclExpRepository, context)
        {
            _fclExpRepository = fclExpRepository;
            _context = context;
        }

    }
}
