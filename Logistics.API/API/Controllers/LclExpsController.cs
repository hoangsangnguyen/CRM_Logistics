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
    public class LclExpsController : GenericController<LclExp, LclExpDto, LclExpForCreation>
    {
        private readonly DatabaseContext _context;
        private readonly ILclExpRepository _lclExpRepository;

        public LclExpsController(ILclExpRepository lclExpRepository, DatabaseContext context) : base(lclExpRepository, context)
        {
            _lclExpRepository = lclExpRepository;
            _context = context;
        }

    }
}
