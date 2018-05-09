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
    public class UnitsController : GenericController<Unit, UnitDto, UnitDto>
    {
        private readonly DatabaseContext _context;
        private readonly IUnitRepository _unitRepository;

        public UnitsController(IUnitRepository unitRepository, DatabaseContext context) : base(unitRepository, context)
        {
            _unitRepository = unitRepository;
            _context = context;
        }

    }
}
