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
    public class ModesController : GenericController<Mode, ModeDto, ModeDto>
    {
        private readonly DatabaseContext _context;
        private readonly IModeRepository _modeRepository;

        public ModesController(IModeRepository modeRepository, DatabaseContext context) : base(modeRepository, context)
        {
            _modeRepository = modeRepository;
            _context = context;
        }

    }
}
