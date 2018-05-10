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
    public class PositionsController : GenericController<Position, PositionDto, PositionDto>
    {
        private readonly DatabaseContext _context;
        private readonly IPositionRepository _positionRepository;

        public PositionsController(IPositionRepository positionRepository, DatabaseContext context) : base(positionRepository, context)
        {
            _positionRepository = positionRepository;
            _context = context;
        }

    }
}
